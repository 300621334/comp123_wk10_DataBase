namespace testDataBase
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.greenvilleDataSet = new testDataBase.GreenvilleDataSet();
            this.contestantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contestantsTableAdapter = new testDataBase.GreenvilleDataSetTableAdapters.ContestantsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contestantNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenvilleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contestantsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.contestantNameDataGridViewTextBoxColumn,
            this.talentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contestantsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // greenvilleDataSet
            // 
            this.greenvilleDataSet.DataSetName = "GreenvilleDataSet";
            this.greenvilleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contestantsBindingSource
            // 
            this.contestantsBindingSource.DataMember = "Contestants";
            this.contestantsBindingSource.DataSource = this.greenvilleDataSet;
            // 
            // contestantsTableAdapter
            // 
            this.contestantsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // contestantNameDataGridViewTextBoxColumn
            // 
            this.contestantNameDataGridViewTextBoxColumn.DataPropertyName = "ContestantName";
            this.contestantNameDataGridViewTextBoxColumn.HeaderText = "ContestantName";
            this.contestantNameDataGridViewTextBoxColumn.Name = "contestantNameDataGridViewTextBoxColumn";
            // 
            // talentDataGridViewTextBoxColumn
            // 
            this.talentDataGridViewTextBoxColumn.DataPropertyName = "Talent";
            this.talentDataGridViewTextBoxColumn.HeaderText = "Talent";
            this.talentDataGridViewTextBoxColumn.Name = "talentDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 303);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenvilleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contestantsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GreenvilleDataSet greenvilleDataSet;
        private System.Windows.Forms.BindingSource contestantsBindingSource;
        private GreenvilleDataSetTableAdapters.ContestantsTableAdapter contestantsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contestantNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talentDataGridViewTextBoxColumn;
    }
}

