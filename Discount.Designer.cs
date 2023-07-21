namespace POS_FO
{
    partial class Discount
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button11 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(125, 143, 105);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 59);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 1;
            label1.Text = "Discount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(74, 89);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 2;
            label2.Text = "Total Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(74, 139);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 3;
            label3.Text = "Discount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(74, 187);
            label4.Name = "label4";
            label4.Size = new Size(144, 21);
            label4.TabIndex = 4;
            label4.Text = "Discount Amount";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(277, 90);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(224, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(277, 139);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(277, 190);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(224, 23);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(125, 143, 105);
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = Color.White;
            button11.Location = new Point(277, 230);
            button11.Name = "button11";
            button11.Size = new Size(223, 30);
            button11.TabIndex = 10;
            button11.Text = "Confirm";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // Discount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(169, 175, 126);
            ClientSize = new Size(574, 282);
            Controls.Add(button11);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Discount";
            Text = "Discount";
            Load += Discount_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button11;
    }
}