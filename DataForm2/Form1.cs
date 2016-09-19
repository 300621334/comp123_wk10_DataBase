using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //"BindingSource" makes the connection b/w this Form1 & foreign database.
        //"DataSet" is a copy of original data from foreign DB, stored in this Form1 project, but editing it doesn't auto edit original DB.
        //"TableAdapter" fills this Form1 with date from DataSet. Also passes data back & forth b/w DataSet & this form.

        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'database1DataSet1.Table1' table. You can move, or remove it, as needed.
            //this.table1TableAdapter.Fill(this.database1DataSet.Table1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //even if I delete this GridView, still other functionality will work.
            //fill gridview with (this table)
            this.table1TableAdapter.Fill(this.database1DataSet.Table1);
        }


        //display GPA for a given name
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string name = textBox2.Text.ToUpper();


            //LINQ:
            //criteria is implicitly typed collection of 's' i.e. rows/records.
            //from ALL the rows 's' in table Table1//LINQ cmd is different from SQL cmd="FROM table1"=from whole table. In LINQ we select from rows/records. To use SQL cmd u need more code to connect to DB & pull data from there.

            var criteria =
            from s in this.database1DataSet.Table1  //like foreach() it goes thru ea record one by one & assigns row to 'criteria' if 'where' condition is met.
            where s.sname.ToUpper() == name//that fulfil this restriction, select those //"ORDERBY s.gpa descending" instead of 'where' will order em. "orderby s.LastName, s.FirstName"
            select s; //'s' is a record/row   //SELECT columnName would have selected ALL rows in a particular col.



            ////To see following LINQ work, have to click "show date in gridView" then "show these only"
            //var criteria =
            //    from s in this.database1DataSet.Table1
            //    orderby s.sname
            //    where Convert.ToDouble(s.gpa) > 2.7
            //    select s;


            foreach (var s in criteria)
                listBox1.Items.Add(s.sname + " has a GPA of " + s.gpa);
        }




        //clear items in listBox1
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }


        //when GPA text changes.
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            if (textBox3.Text == "")
            {
                textBox3.Text = "0"; //eout this get error as soon as textBox3(GPA) is empty. Prolly convertToDouble for empty string gives format err.!!
            }
            double gpa = Convert.ToDouble(textBox3.Text);



            var criteria = //criteria is implicitly typed collection of rows/records.
                from s in this.database1DataSet.Table1//from ALL the rows 's' in table Table1
                where Convert.ToDouble(s.gpa) == gpa //that fulfil this restriction, select those
                select s; //'s' is a record/row

            foreach (var s in criteria)
                listBox1.Items.Add(s.sname + " has a GPA of " + s.gpa);



            //listBox1.Items.Clear();

            //string gpa = textBox3.Text;
            //string name = textBox2.Text.ToUpper();

            //var criteria = //criteria is implicitly typed collection of rows/records.
            //    from s in this.database1DataSet.Table1//from ALL the rows 's' in table Table1
            //    where s.gpa == gpa //that fulfil this restriction, select those
            //    select s; //'s' is a record/row

            //foreach (var s in criteria)
            //    listBox1.Items.Add(s.sname + " has a GPA of " + s.gpa);
        }


        //when mouse leaves after coming over the GPA field
        private void textBox3_MouseLeave(object sender, EventArgs e)
        {

        }

        //"Group by" btn clicked.
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //'stus' is a collection of collections. i.e. ea item in 'stus' in itself contains many rows.
            //group-by basically assigns a 'key' to ea row. In this case keys are 2, 3, 4. and then rows are grouped by that assigned key.


            var stus = from s in this.database1DataSet.Table1
                           group s by ((int)Convert.ToDouble(s.gpa)); //"2" converts to Int32 fine but "2.5" gives err. So go thru ToDouble
                       
            //convert.ToInt32() gives err "input string not in correct format" but ToDouble works. So I used (int) casting AFTER converting toDouble. int.Parse(s.gpa) also gives same err "incorrect format"
            //group s by s.gpa;//will group the rows 's' by a 'key' w in this case is "int" part of GPA



            foreach (var group in stus) //there r 2 rows under the KEY=2. 2 rows under key=3. 1 row under key=4.
            {
                listBox1.Items.Add("GPA: " + group.Key); //group is row,& key is value of column used for grouping(GPA).
                foreach (var x in group)
                {
                    listBox1.Items.Add(" " + x.gpa + " " + x.sname);
                    //label4.Text = x.gpa;//just testing if s.gpa is a string, which it is.
                }
            }
        }


        //p-738: "group 'e' by e.Department " will gp by depts. while "group e by e.Department == 1" will make 2 gps True-gp & false-gp
        //A LINQ query body must end with a  select clause or a  group clause. Therefore, if you combine  'orderby' and  'group' ,  orderby must come  first and group must come last. e.g:
        /*var stus = from s in cartmanCollegeDataSet.tblStudents
        orderby s.LastName
        group s by (int)s.GradePointAverage;*/
        //


    }
}
