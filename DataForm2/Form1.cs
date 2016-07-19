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
        //"TableAdapter" fills this Form1 with date from DataSet. Also passes data back & forth b/w DataSet & BindingSource.

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Table1' table. You can move, or remove it, as needed.
            //this.table1TableAdapter.Fill(this.database1DataSet.Table1);



            //// TODO: This line of code loads data into the 'linqdbDataSet.student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.linqdbDataSet.student);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.table1TableAdapter.Fill(this.database1DataSet.Table1);
 //even if I delete this GridView, still other functionality will work.
        }


        //display GPA for a given name
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string name = textBox2.Text.ToUpper();

            var criteria = //criteria is implicitly typed collection of rows/records.
                from s in this.database1DataSet.Table1//from ALL the rows 's' in table Table1
                where s.sname.ToUpper() == name//that fulfil this restriction, select those
                select s; //'s' is a record/row

            foreach (var s in criteria)
                listBox1.Items.Add(s.sname+" has a GPA of "+s.gpa);
        }


        //clear items in listBox1
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }


        //when GPA text changes.
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
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
            listBox1.Items.Clear();

            double gpa = Convert.ToDouble(textBox3.Text);
            

            var criteria = //criteria is implicitly typed collection of rows/records.
                from s in this.database1DataSet.Table1//from ALL the rows 's' in table Table1
                where s.gpa == gpa //that fulfil this restriction, select those
                select s; //'s' is a record/row

            foreach (var s in criteria)
                listBox1.Items.Add(s.sname + " has a GPA of " + s.gpa);
        }
    }
}
