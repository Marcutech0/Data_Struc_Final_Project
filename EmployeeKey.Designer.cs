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
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            label2.Location = new Point(430, 235);
            label2.Name = "label2";
            label2.Size = new Size(197, 21);
            label2.TabIndex = 1;
            label2.Text = "Enter Employee Account";
            // 
            // EKEnter
            // 
            EKEnter.BackColor = Color.FromArgb(85, 113, 83);
            EKEnter.Cursor = Cursors.Hand;
            EKEnter.FlatAppearance.BorderSize = 0;
            EKEnter.FlatStyle = FlatStyle.Flat;
            EKEnter.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EKEnter.ForeColor = Color.White;
            EKEnter.Location = new Point(313, 454);
            EKEnter.Name = "EKEnter";
            EKEnter.Size = new Size(163, 40);
            EKEnter.TabIndex = 10;
            EKEnter.Text = "Enter";
            EKEnter.UseVisualStyleBackColor = false;
            EKEnter.Click += EKEnter_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(125, 143, 105);
            label3.Location = new Point(378, 278);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 11;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(125, 143, 105);
            label4.Location = new Point(378, 364);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
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
            SUButton.Location = new Point(533, 454);
            SUButton.Name = "SUButton";
            SUButton.Size = new Size(163, 40);
            SUButton.TabIndex = 13;
            SUButton.Text = "Create New";
            SUButton.UseVisualStyleBackColor = false;
            SUButton.Click += SUButton_Click;
            // 
            // userTxt
            // 
            userTxt.BorderStyle = BorderStyle.None;
            userTxt.Cursor = Cursors.IBeam;
            userTxt.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            userTxt.ForeColor = Color.FromArgb(125, 143, 105);
            userTxt.Location = new Point(378, 306);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(318, 18);
            userTxt.TabIndex = 14;
            userTxt.TextChanged += userTxt_TextChanged;
            // 
            // passTxt
            // 
            passTxt.BorderStyle = BorderStyle.None;
            passTxt.Cursor = Cursors.IBeam;
            passTxt.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            passTxt.ForeColor = Color.FromArgb(125, 143, 105);
            passTxt.Location = new Point(378, 392);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(318, 18);
            passTxt.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(85, 113, 83);
            panel1.Location = new Point(314, 328);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 2);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(85, 113, 83);
            panel2.Location = new Point(314, 415);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(382, 2);
            panel2.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_user_profile_100;
            pictureBox1.Location = new Point(313, 278);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_password_100;
            pictureBox2.Location = new Point(313, 364);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // EmployeeKey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 729);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}