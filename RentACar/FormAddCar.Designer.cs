namespace RentACar
{
    partial class FormAddCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCar));
            this.cbBrands = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbModels = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbRegistration = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudEngine = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cbFuel = new System.Windows.Forms.ComboBox();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.btnDeletePic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEngine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBrands
            // 
            this.cbBrands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrands.FormattingEnabled = true;
            this.cbBrands.Location = new System.Drawing.Point(127, 35);
            this.cbBrands.Margin = new System.Windows.Forms.Padding(2);
            this.cbBrands.Name = "cbBrands";
            this.cbBrands.Size = new System.Drawing.Size(133, 21);
            this.cbBrands.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model";
            // 
            // cbModels
            // 
            this.cbModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModels.FormattingEnabled = true;
            this.cbModels.Location = new System.Drawing.Point(127, 66);
            this.cbModels.Margin = new System.Windows.Forms.Padding(2);
            this.cbModels.Name = "cbModels";
            this.cbModels.Size = new System.Drawing.Size(133, 21);
            this.cbModels.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Typ własności";
            // 
            // cbTypes
            // 
            this.cbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Location = new System.Drawing.Point(127, 98);
            this.cbTypes.Margin = new System.Windows.Forms.Padding(2);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(133, 21);
            this.cbTypes.TabIndex = 5;
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(127, 132);
            this.nudYear.Margin = new System.Windows.Forms.Padding(2);
            this.nudYear.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(132, 20);
            this.nudYear.TabIndex = 7;
            this.nudYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rok produkcji";
            // 
            // mtbRegistration
            // 
            this.mtbRegistration.AsciiOnly = true;
            this.mtbRegistration.Location = new System.Drawing.Point(127, 162);
            this.mtbRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.mtbRegistration.Mask = "aaaaaaa";
            this.mtbRegistration.Name = "mtbRegistration";
            this.mtbRegistration.Size = new System.Drawing.Size(133, 20);
            this.mtbRegistration.TabIndex = 9;
            this.mtbRegistration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbRegistration_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nr rejestracyjny";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pojemność silnika";
            // 
            // nudEngine
            // 
            this.nudEngine.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudEngine.Location = new System.Drawing.Point(127, 194);
            this.nudEngine.Margin = new System.Windows.Forms.Padding(2);
            this.nudEngine.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudEngine.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudEngine.Name = "nudEngine";
            this.nudEngine.Size = new System.Drawing.Size(132, 20);
            this.nudEngine.TabIndex = 11;
            this.nudEngine.Value = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.nudEngine.ValueChanged += new System.EventHandler(this.nudEngine_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 227);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Paliwo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbFuel
            // 
            this.cbFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuel.FormattingEnabled = true;
            this.cbFuel.Items.AddRange(new object[] {
            "PB",
            "ON",
            "LPG"});
            this.cbFuel.Location = new System.Drawing.Point(127, 225);
            this.cbFuel.Margin = new System.Windows.Forms.Padding(2);
            this.cbFuel.Name = "cbFuel";
            this.cbFuel.Size = new System.Drawing.Size(133, 21);
            this.cbFuel.TabIndex = 13;
            this.cbFuel.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // picCar
            // 
            this.picCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picCar.ErrorImage")));
            this.picCar.Location = new System.Drawing.Point(275, 35);
            this.picCar.Margin = new System.Windows.Forms.Padding(2);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(210, 210);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar.TabIndex = 15;
            this.picCar.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(127, 255);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(413, 255);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddPic
            // 
            this.btnAddPic.Location = new System.Drawing.Point(505, 35);
            this.btnAddPic.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(84, 29);
            this.btnAddPic.TabIndex = 18;
            this.btnAddPic.Text = "Wybierz obraz";
            this.btnAddPic.UseVisualStyleBackColor = true;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // btnDeletePic
            // 
            this.btnDeletePic.Location = new System.Drawing.Point(505, 78);
            this.btnDeletePic.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletePic.Name = "btnDeletePic";
            this.btnDeletePic.Size = new System.Drawing.Size(84, 29);
            this.btnDeletePic.TabIndex = 19;
            this.btnDeletePic.Text = "Usuń obraz";
            this.btnDeletePic.UseVisualStyleBackColor = true;
            this.btnDeletePic.Click += new System.EventHandler(this.btnDeletePic_Click);
            // 
            // FormAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(606, 315);
            this.Controls.Add(this.btnDeletePic);
            this.Controls.Add(this.btnAddPic);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picCar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbFuel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudEngine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtbRegistration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTypes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbModels);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBrands);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj samochód";
            this.Load += new System.EventHandler(this.FormAddCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEngine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBrands;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbModels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbRegistration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudEngine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbFuel;
        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.Button btnDeletePic;
    }
}