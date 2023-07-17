namespace POS_FO
{
    partial class Signup
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
            label1 = new Label();
            label2 = new Label();
            newUserTxt = new TextBox();
            newPassTxt = new TextBox();
            finish = new Button();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(125, 143, 105);
            label1.Location = new Point(285, 116);
            label1.Name = "label1";
            label1.Size = new Size(102, 19);
            label1.TabIndex = 0;
            label1.Text = "New Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(125, 143, 105);
            label2.Location = new Point(285, 199);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // newUserTxt
            // 
            newUserTxt.BorderStyle = BorderStyle.None;
            newUserTxt.Cursor = Cursors.IBeam;
            newUserTxt.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            newUserTxt.Location = new Point(285, 142);
            newUserTxt.Name = "newUserTxt";
            newUserTxt.Size = new Size(295, 18);
            newUserTxt.TabIndex = 2;
            // 
            // newPassTxt
            // 
            newPassTxt.BorderStyle = BorderStyle.None;
            newPassTxt.Cursor = Cursors.IBeam;
            newPassTxt.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            newPassTxt.Location = new Point(285, 224);
            newPassTxt.Name = "newPassTxt";
            newPassTxt.Size = new Size(295, 18);
            newPassTxt.TabIndex = 3;
            // 
            // finish
            // 
            finish.BackColor = Color.FromArgb(85, 113, 83);
            finish.Cursor = Cursors.Hand;
            finish.FlatAppearance.BorderSize = 0;
            finish.FlatStyle = FlatStyle.Flat;
            finish.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            finish.ForeColor = Color.White;
            finish.Location = new Point(285, 294);
            finish.Name = "finish";
            finish.Size = new Size(133, 40);
            finish.TabIndex = 11;
            finish.Text = "Finish";
            finish.UseVisualStyleBackColor = false;
            finish.Click += EKEnter_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(85, 113, 83);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(447, 294);
            button1.Name = "button1";
            button1.Size = new Size(133, 40);
            button1.TabIndex = 12;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(85, 113, 83);
            panel1.Location = new Point(220, 170);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 2);
            panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_user_profile_100;
            pictureBox1.Location = new Point(220, 118);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(85, 113, 83);
            panel2.Location = new Point(220, 251);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 2);
            panel2.TabIndex = 18;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_password_100;
            pictureBox2.Location = new Point(220, 200);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(125, 143, 105);
            label3.Location = new Point(293, 60);
            label3.Name = "label3";
            label3.Size = new Size(236, 21);
            label3.TabIndex = 21;
            label3.Text = "Enter New Employee Account";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(finish);
            Controls.Add(newPassTxt);
            Controls.Add(newUserTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Signup";
            Text = "Signup";
            Load += Signup_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox newUserTxt;
        private TextBox newPassTxt;
        private Button finish;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label3;
    }
}