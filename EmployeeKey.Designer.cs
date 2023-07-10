namespace POS_FO
{
    partial class EmployeeKey
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
            label1 = new Label();
            label2 = new Label();
            EKEnter = new Button();
            label3 = new Label();
            label4 = new Label();
            SUButton = new Button();
            userTxt = new TextBox();
            passTxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(81, 94, 99);
            label1.Location = new Point(149, 111);
            label1.Name = "label1";
            label1.Size = new Size(711, 39);
            label1.TabIndex = 0;
            label1.Text = "- Place the name of the POS here w/ logo (?) -";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(125, 143, 105);
            label2.Location = new Point(423, 209);
            label2.Name = "label2";
            label2.Size = new Size(162, 21);
            label2.TabIndex = 1;
            label2.Text = "Enter Employee PIN";
            // 
            // EKEnter
            // 
            EKEnter.BackColor = Color.FromArgb(85, 113, 83);
            EKEnter.Cursor = Cursors.Hand;
            EKEnter.FlatAppearance.BorderSize = 0;
            EKEnter.FlatStyle = FlatStyle.Flat;
            EKEnter.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EKEnter.ForeColor = Color.White;
            EKEnter.Location = new Point(343, 502);
            EKEnter.Name = "EKEnter";
            EKEnter.Size = new Size(133, 40);
            EKEnter.TabIndex = 10;
            EKEnter.Text = "Enter";
            EKEnter.UseVisualStyleBackColor = false;
            EKEnter.Click += EKEnter_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 281);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 11;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 330);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 12;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // SUButton
            // 
            SUButton.BackColor = Color.FromArgb(85, 113, 83);
            SUButton.Cursor = Cursors.Hand;
            SUButton.FlatAppearance.BorderSize = 0;
            SUButton.FlatStyle = FlatStyle.Flat;
            SUButton.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SUButton.ForeColor = Color.White;
            SUButton.Location = new Point(508, 502);
            SUButton.Name = "SUButton";
            SUButton.Size = new Size(133, 40);
            SUButton.TabIndex = 13;
            SUButton.Text = "Create New";
            SUButton.UseVisualStyleBackColor = false;
            SUButton.Click += SUButton_Click;
            // 
            // userTxt
            // 
            userTxt.Location = new Point(335, 281);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(326, 23);
            userTxt.TabIndex = 14;
            // 
            // passTxt
            // 
            passTxt.Location = new Point(335, 330);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(326, 23);
            passTxt.TabIndex = 15;
            // 
            // EmployeeKey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 729);
            Controls.Add(passTxt);
            Controls.Add(userTxt);
            Controls.Add(SUButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(EKEnter);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeeKey";
            Text = "Form1";
            Load += EmployeeKey_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button EKEnter;
        private Label label3;
        private Label label4;
        private Button SUButton;
        private TextBox userTxt;
        private TextBox passTxt;
    }
}