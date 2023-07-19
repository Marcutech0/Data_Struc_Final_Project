namespace POS_FO
{
    partial class addItemQty
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
            textBox1 = new TextBox();
            button11 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(125, 143, 105);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 62);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(143, 21);
            label1.TabIndex = 1;
            label1.Text = "Quantity of Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(112, 106);
            label2.Name = "label2";
            label2.Size = new Size(350, 28);
            label2.TabIndex = 2;
            label2.Text = "How many would you like to order?";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 23);
            textBox1.TabIndex = 3;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(125, 143, 105);
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = Color.White;
            button11.Location = new Point(176, 193);
            button11.Name = "button11";
            button11.Size = new Size(223, 30);
            button11.TabIndex = 11;
            button11.Text = "Confirm";
            button11.UseVisualStyleBackColor = false;
            // 
            // addItemQty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(169, 175, 126);
            ClientSize = new Size(574, 282);
            Controls.Add(button11);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "addItemQty";
            Text = "addItemQty";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button11;
    }
}