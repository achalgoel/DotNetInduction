namespace Assignment_17
{
    partial class DisplayStudent
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
            this.studentDataSet = new Assignment_17.StudentDataSet();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDetailsTableAdapter = new Assignment_17.StudentDataSetTableAdapters.StudentDetailsTableAdapter();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollmentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.cmbStream = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.enrollmentNoDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.streamDataGridViewTextBoxColumn,
            this.studentStateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(641, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "StudentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "StudentDetails";
            this.studentDetailsBindingSource.DataSource = this.studentDataSet;
            // 
            // studentDetailsTableAdapter
            // 
            this.studentDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enrollmentNoDataGridViewTextBoxColumn
            // 
            this.enrollmentNoDataGridViewTextBoxColumn.DataPropertyName = "EnrollmentNo";
            this.enrollmentNoDataGridViewTextBoxColumn.HeaderText = "EnrollmentNo";
            this.enrollmentNoDataGridViewTextBoxColumn.Name = "enrollmentNoDataGridViewTextBoxColumn";
            this.enrollmentNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streamDataGridViewTextBoxColumn
            // 
            this.streamDataGridViewTextBoxColumn.DataPropertyName = "Stream";
            this.streamDataGridViewTextBoxColumn.HeaderText = "Stream";
            this.streamDataGridViewTextBoxColumn.Name = "streamDataGridViewTextBoxColumn";
            this.streamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentStateDataGridViewTextBoxColumn
            // 
            this.studentStateDataGridViewTextBoxColumn.DataPropertyName = "StudentState";
            this.studentStateDataGridViewTextBoxColumn.HeaderText = "StudentState";
            this.studentStateDataGridViewTextBoxColumn.Name = "studentStateDataGridViewTextBoxColumn";
            this.studentStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Display Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Stream:";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(389, 53);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(103, 23);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display Details";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // cmbStream
            // 
            this.cmbStream.FormattingEnabled = true;
            this.cmbStream.Items.AddRange(new object[] {
            "Science",
            "Commerce",
            "Humanities"});
            this.cmbStream.Location = new System.Drawing.Point(199, 55);
            this.cmbStream.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStream.Name = "cmbStream";
            this.cmbStream.Size = new System.Drawing.Size(160, 21);
            this.cmbStream.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(557, 381);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 32);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit ->";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(31, 381);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 32);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "<- Back";
            this.btnBack.UseVisualStyleBackColor = true;
            
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(301, 388);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 16;
            // 
            // DisplayStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 422);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.cmbStream);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DisplayStudent";
            this.Text = "DisplayStudent";
            this.Load += new System.EventHandler(this.DisplayStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private StudentDataSetTableAdapters.StudentDetailsTableAdapter studentDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollmentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ComboBox cmbStream;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblMessage;
    }
}