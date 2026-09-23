namespace Bai4._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            radMale = new RadioButton();
            radFemale = new RadioButton();
            mtxrPhone = new MaskedTextBox();
            dtpBirthDate = new DateTimePicker();
            cboCourse = new ComboBox();
            chkAgree = new CheckBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(72, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 27);
            txtName.TabIndex = 0;
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Location = new Point(343, 41);
            radMale.Name = "radMale";
            radMale.Size = new Size(62, 24);
            radMale.TabIndex = 1;
            radMale.TabStop = true;
            radMale.Text = "Nam";
            radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.Location = new Point(411, 41);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(50, 24);
            radFemale.TabIndex = 2;
            radFemale.TabStop = true;
            radFemale.Text = "Nữ";
            radFemale.UseVisualStyleBackColor = true;
            // 
            // mtxrPhone
            // 
            mtxrPhone.Location = new Point(72, 80);
            mtxrPhone.Mask = "(000) 000-0000";
            mtxrPhone.Name = "mtxrPhone";
            mtxrPhone.Size = new Size(211, 27);
            mtxrPhone.TabIndex = 3;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(72, 126);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(250, 27);
            dtpBirthDate.TabIndex = 4;
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(72, 171);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(151, 28);
            cboCourse.TabIndex = 5;
            // 
            // chkAgree
            // 
            chkAgree.AutoSize = true;
            chkAgree.Location = new Point(236, 175);
            chkAgree.Name = "chkAgree";
            chkAgree.Size = new Size(178, 24);
            chkAgree.TabIndex = 6;
            chkAgree.Text = "Tôi đồng ý với nội quy";
            chkAgree.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(72, 216);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(chkAgree);
            Controls.Add(cboCourse);
            Controls.Add(dtpBirthDate);
            Controls.Add(mtxrPhone);
            Controls.Add(radFemale);
            Controls.Add(radMale);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private RadioButton radMale;
        private RadioButton radFemale;
        private MaskedTextBox mtxrPhone;
        private DateTimePicker dtpBirthDate;
        private ComboBox cboCourse;
        private CheckBox chkAgree;
        private Button btnRegister;
    }
}
