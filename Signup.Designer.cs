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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 136);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "New Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 194);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // newUserTxt
            // 
            newUserTxt.Location = new Point(267, 133);
            newUserTxt.Name = "newUserTxt";
            newUserTxt.Size = new Size(295, 23);
            newUserTxt.TabIndex = 2;
            // 
            // newPassTxt
            // 
            newPassTxt.Location = new Point(267, 191);
            newPassTxt.Name = "newPassTxt";
            newPassTxt.Size = new Size(295, 23);
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
            finish.Location = new Point(206, 272);
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
            button1.Location = new Point(398, 272);
            button1.Name = "button1";
            button1.Size = new Size(133, 40);
            button1.TabIndex = 12;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(finish);
            Controls.Add(newPassTxt);
            Controls.Add(newUserTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Signup";
            Text = "Signup";
            Load += Signup_Load;
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
    }
}