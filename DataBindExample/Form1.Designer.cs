namespace DataBindExample
{
    partial class FormMain
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
            this.lbPersons = new System.Windows.Forms.ListBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbJob = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbPersons
            // 
            this.lbPersons.FormattingEnabled = true;
            this.lbPersons.ItemHeight = 20;
            this.lbPersons.Location = new System.Drawing.Point(31, 33);
            this.lbPersons.Name = "lbPersons";
            this.lbPersons.Size = new System.Drawing.Size(267, 344);
            this.lbPersons.TabIndex = 0;
            this.lbPersons.SelectedIndexChanged += new System.EventHandler(this.lbPersons_SelectedIndexChanged);
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(321, 56);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(403, 26);
            this.tbFName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nazwisko";
            // 
            // tbLName
            // 
            this.tbLName.Location = new System.Drawing.Point(321, 123);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(403, 26);
            this.tbLName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wiek";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(321, 198);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(403, 26);
            this.tbAge.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Zawód";
            // 
            // tbJob
            // 
            this.tbJob.Location = new System.Drawing.Point(321, 275);
            this.tbJob.Name = "tbJob";
            this.tbJob.Size = new System.Drawing.Size(403, 26);
            this.tbJob.TabIndex = 8;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbJob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFName);
            this.Controls.Add(this.lbPersons);
            this.Name = "FormMain";
            this.Text = "Lista osób";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPersons;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbJob;
    }
}

