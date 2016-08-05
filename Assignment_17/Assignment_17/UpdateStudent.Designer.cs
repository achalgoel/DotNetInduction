namespace Assignment_17
{
    partial class UpdateStudent
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.cmbStream = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.txtEnroll = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(543, 265);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 32);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit ->";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(17, 265);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 32);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "<- Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(287, 272);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 25;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(252, 224);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(141, 32);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Delhi",
            "UP",
            "BIhar",
            "Punjab",
            "Maharashtra",
            "West Bengal",
            "MP",
            "Rajasthan",
            "Haryana"});
            this.cmbState.Location = new System.Drawing.Point(429, 158);
            this.cmbState.Margin = new System.Windows.Forms.Padding(4);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(160, 21);
            this.cmbState.TabIndex = 23;
            // 
            // cmbStream
            // 
            this.cmbStream.FormattingEnabled = true;
            this.cmbStream.Items.AddRange(new object[] {
            "Science",
            "Commerce",
            "Humanities"});
            this.cmbStream.Location = new System.Drawing.Point(125, 158);
            this.cmbStream.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStream.Name = "cmbStream";
            this.cmbStream.Size = new System.Drawing.Size(160, 21);
            this.cmbStream.TabIndex = 22;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbClass.Location = new System.Drawing.Point(429, 72);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(160, 21);
            this.cmbClass.TabIndex = 21;
            // 
            // txtEnroll
            // 
            this.txtEnroll.Location = new System.Drawing.Point(129, 73);
            this.txtEnroll.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnroll.Name = "txtEnroll";
            this.txtEnroll.Size = new System.Drawing.Size(156, 20);
            this.txtEnroll.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Stream:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Class:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "State:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Enrollment No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Update Student";
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.cmbStream);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.txtEnroll);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Name = "UpdateStudent";
            this.Text = "UpdateStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.ComboBox cmbStream;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.TextBox txtEnroll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}