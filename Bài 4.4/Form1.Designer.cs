namespace Bai4._4
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
            groupBox1 = new GroupBox();
            lstMenu = new ListBox();
            groupBox2 = new GroupBox();
            lstSelected = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thực đơn";
            // 
            // lstMenu
            // 
            lstMenu.FormattingEnabled = true;
            lstMenu.Location = new Point(12, 143);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(150, 104);
            lstMenu.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(286, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Món đã chọn";
            // 
            // lstSelected
            // 
            lstSelected.FormattingEnabled = true;
            lstSelected.Location = new Point(179, 143);
            lstSelected.Name = "lstSelected";
            lstSelected.Size = new Size(150, 104);
            lstSelected.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 262);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = ">";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(112, 262);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.IndianRed;
            lblTotal.Location = new Point(12, 303);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(118, 20);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Tổng tiền: 0VNĐ";

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lstSelected);
            Controls.Add(groupBox2);
            Controls.Add(lstMenu);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstMenu;
        private GroupBox groupBox2;
        private ListBox lstSelected;
        private Button btnAdd;
        private Button btnRemove;
        private Label lblTotal;
    }
}
