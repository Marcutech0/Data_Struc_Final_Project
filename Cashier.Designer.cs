namespace POS_FO
{
    partial class Cashier
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ucPanel = new Panel();
            selectedItemsGridView = new DataGridView();
            productName = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            panel10 = new Panel();
            label8 = new Label();
            button14 = new Button();
            comboBox1 = new ComboBox();
            button13 = new Button();
            label2 = new Label();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            stocksButton = new Button();
            discountButton = new Button();
            salesLogButton = new Button();
            helpButton = new Button();
            exitButton = new Button();
            addItemButton = new Button();
            panel3 = new Panel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label7 = new Label();
            button12 = new Button();
            ucPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectedItemsGridView).BeginInit();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // ucPanel
            // 
            ucPanel.BackColor = Color.FromArgb(169, 175, 126);
            ucPanel.Controls.Add(selectedItemsGridView);
            ucPanel.Location = new Point(12, 79);
            ucPanel.Name = "ucPanel";
            ucPanel.Size = new Size(569, 628);
            ucPanel.TabIndex = 1;
            // 
            // selectedItemsGridView
            // 
            selectedItemsGridView.BackgroundColor = Color.White;
            selectedItemsGridView.BorderStyle = BorderStyle.None;
            selectedItemsGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(169, 175, 126);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            selectedItemsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            selectedItemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectedItemsGridView.Columns.AddRange(new DataGridViewColumn[] { productName, quantity, price });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            selectedItemsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            selectedItemsGridView.EnableHeadersVisualStyles = false;
            selectedItemsGridView.Location = new Point(0, 0);
            selectedItemsGridView.Name = "selectedItemsGridView";
            selectedItemsGridView.RowTemplate.Height = 25;
            selectedItemsGridView.Size = new Size(569, 628);
            selectedItemsGridView.TabIndex = 13;
            // 
            // productName
            // 
            productName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productName.HeaderText = "Product Name";
            productName.Name = "productName";
            // 
            // quantity
            // 
            quantity.HeaderText = "Quantity";
            quantity.Name = "quantity";
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.Name = "price";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(169, 175, 126);
            panel10.Controls.Add(label8);
            panel10.Controls.Add(button14);
            panel10.Controls.Add(comboBox1);
            panel10.Controls.Add(button13);
            panel10.Controls.Add(label2);
            panel10.Controls.Add(button11);
            panel10.Controls.Add(button10);
            panel10.Controls.Add(button9);
            panel10.Controls.Add(button8);
            panel10.Controls.Add(button7);
            panel10.Controls.Add(button6);
            panel10.Controls.Add(button5);
            panel10.Controls.Add(button4);
            panel10.Controls.Add(button3);
            panel10.Controls.Add(button2);
            panel10.Controls.Add(button1);
            panel10.Location = new Point(702, 12);
            panel10.Name = "panel10";
            panel10.Size = new Size(376, 408);
            panel10.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(10, 358);
            label8.Name = "label8";
            label8.Size = new Size(103, 15);
            label8.TabIndex = 15;
            label8.Text = "Payment Method";
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(125, 143, 105);
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button14.ForeColor = Color.White;
            button14.Location = new Point(257, 259);
            button14.Name = "button14";
            button14.Size = new Size(98, 66);
            button14.TabIndex = 13;
            button14.Text = "C";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Credit/Debit Card", "Cash", "Mobile Wallet" });
            comboBox1.Location = new Point(130, 356);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(112, 23);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(125, 143, 105);
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button13.ForeColor = Color.White;
            button13.Location = new Point(26, 259);
            button13.Name = "button13";
            button13.Size = new Size(98, 66);
            button13.TabIndex = 12;
            button13.Text = ".";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 11;
            label2.Click += label2_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(125, 143, 105);
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = Color.White;
            button11.Location = new Point(257, 344);
            button11.Name = "button11";
            button11.Size = new Size(98, 38);
            button11.TabIndex = 9;
            button11.Text = "Pay";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click_1;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(125, 143, 105);
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.White;
            button10.Location = new Point(143, 259);
            button10.Name = "button10";
            button10.Size = new Size(98, 66);
            button10.TabIndex = 5;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(125, 143, 105);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(257, 43);
            button9.Name = "button9";
            button9.Size = new Size(98, 66);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(125, 143, 105);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(143, 43);
            button8.Name = "button8";
            button8.Size = new Size(98, 66);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(125, 143, 105);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(26, 43);
            button7.Name = "button7";
            button7.Size = new Size(98, 66);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(125, 143, 105);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(257, 115);
            button6.Name = "button6";
            button6.Size = new Size(98, 66);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(125, 143, 105);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(143, 115);
            button5.Name = "button5";
            button5.Size = new Size(98, 66);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(125, 143, 105);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(26, 115);
            button4.Name = "button4";
            button4.Size = new Size(98, 66);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(125, 143, 105);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(257, 187);
            button3.Name = "button3";
            button3.Size = new Size(98, 66);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(125, 143, 105);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(143, 187);
            button2.Name = "button2";
            button2.Size = new Size(98, 66);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(125, 143, 105);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(26, 187);
            button1.Name = "button1";
            button1.Size = new Size(98, 66);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // stocksButton
            // 
            stocksButton.BackColor = Color.FromArgb(169, 175, 126);
            stocksButton.FlatAppearance.BorderSize = 0;
            stocksButton.FlatStyle = FlatStyle.Flat;
            stocksButton.Font = new Font("Nirmala UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            stocksButton.ForeColor = Color.White;
            stocksButton.Location = new Point(587, 12);
            stocksButton.Name = "stocksButton";
            stocksButton.Size = new Size(109, 91);
            stocksButton.TabIndex = 0;
            stocksButton.Text = "Stocks";
            stocksButton.UseVisualStyleBackColor = false;
            stocksButton.Click += categoriesButton_Click_1;
            // 
            // discountButton
            // 
            discountButton.BackColor = Color.FromArgb(169, 175, 126);
            discountButton.FlatAppearance.BorderSize = 0;
            discountButton.FlatStyle = FlatStyle.Flat;
            discountButton.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            discountButton.ForeColor = Color.White;
            discountButton.Location = new Point(587, 305);
            discountButton.Name = "discountButton";
            discountButton.Size = new Size(109, 96);
            discountButton.TabIndex = 5;
            discountButton.Text = "Apply Discount";
            discountButton.UseVisualStyleBackColor = false;
            discountButton.Click += discountButton_Click_1;
            // 
            // salesLogButton
            // 
            salesLogButton.BackColor = Color.FromArgb(169, 175, 126);
            salesLogButton.FlatAppearance.BorderSize = 0;
            salesLogButton.FlatStyle = FlatStyle.Flat;
            salesLogButton.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            salesLogButton.ForeColor = Color.White;
            salesLogButton.Location = new Point(587, 109);
            salesLogButton.Name = "salesLogButton";
            salesLogButton.Size = new Size(109, 88);
            salesLogButton.TabIndex = 6;
            salesLogButton.Text = "Sales log";
            salesLogButton.UseVisualStyleBackColor = false;
            salesLogButton.Click += salesLogButton2_Click;
            // 
            // helpButton
            // 
            helpButton.BackColor = Color.FromArgb(169, 175, 126);
            helpButton.FlatAppearance.BorderSize = 0;
            helpButton.FlatStyle = FlatStyle.Flat;
            helpButton.Font = new Font("Nirmala UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            helpButton.ForeColor = Color.White;
            helpButton.Location = new Point(587, 611);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(109, 96);
            helpButton.TabIndex = 7;
            helpButton.Text = "Help";
            helpButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(169, 175, 126);
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Nirmala UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(587, 509);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(109, 96);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            // 
            // addItemButton
            // 
            addItemButton.BackColor = Color.FromArgb(169, 175, 126);
            addItemButton.FlatAppearance.BorderSize = 0;
            addItemButton.FlatStyle = FlatStyle.Flat;
            addItemButton.Font = new Font("Nirmala UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            addItemButton.ForeColor = Color.White;
            addItemButton.Location = new Point(587, 203);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(109, 96);
            addItemButton.TabIndex = 9;
            addItemButton.Text = "Add Item";
            addItemButton.UseVisualStyleBackColor = false;
            addItemButton.Click += addItemButton_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(169, 175, 126);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(702, 426);
            panel3.Name = "panel3";
            panel3.Size = new Size(376, 281);
            panel3.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(311, 235);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 9;
            label13.Text = "label13";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(311, 176);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 8;
            label12.Text = "label12";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(311, 109);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 7;
            label11.Text = "label11";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(311, 75);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 6;
            label10.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(311, 35);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 5;
            label9.Text = "label9";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(26, 230);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 4;
            label6.Text = "Change";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(26, 171);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 3;
            label5.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(26, 105);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 2;
            label4.Text = "Tax";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(26, 70);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 1;
            label3.Text = "Transaction Discount";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 30);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Sub Total";
            label1.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 28);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 11;
            label7.Text = "store name";
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(169, 175, 126);
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button12.ForeColor = Color.White;
            button12.Location = new Point(587, 407);
            button12.Name = "button12";
            button12.Size = new Size(109, 96);
            button12.TabIndex = 12;
            button12.Text = "Order";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(125, 143, 105);
            ClientSize = new Size(1090, 729);
            Controls.Add(button12);
            Controls.Add(label7);
            Controls.Add(panel3);
            Controls.Add(helpButton);
            Controls.Add(addItemButton);
            Controls.Add(exitButton);
            Controls.Add(panel10);
            Controls.Add(ucPanel);
            Controls.Add(discountButton);
            Controls.Add(stocksButton);
            Controls.Add(salesLogButton);
            Name = "Cashier";
            Text = "Cashier";
            Load += Cashier_Load_1;
            ucPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)selectedItemsGridView).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel ucPanel;
        private Panel panel10;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button11;
        private Button stocksButton;
        private Button discountButton;
        private Button salesLogButton;
        private Button helpButton;
        private Button exitButton;
        private Button addItemButton;
        private UserControls.Stocks categories1;
        private UserControls.Coupon coupon1;
        private UserControls.SalesLog salesLog1;
        private UserControls.AddItems addItems1;
        private UserControls.HelpPage helpPage1;
        private Label label2;
        private Button button13;
        private Button button14;
        private Panel panel3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label13;
        private Label label12;
        private Button button12;
        private DataGridView selectedItemsGridView;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
    }
}