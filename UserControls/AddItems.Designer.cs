namespace POS_FO.UserControls
{
    partial class AddItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            description = new DataGridViewTextBoxColumn();
            category = new DataGridViewComboBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            addbtn = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(169, 175, 126);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { description, category, qty, price });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(569, 574);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // description
            // 
            description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            description.HeaderText = "Product Name";
            description.Name = "description";
            // 
            // category
            // 
            category.HeaderText = "Category";
            category.Items.AddRange(new object[] { "Dairy", "Drink", "Fruit", "Meal", "Snack", "Vegetable" });
            category.Name = "category";
            category.Resizable = DataGridViewTriState.True;
            category.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // qty
            // 
            qty.HeaderText = "Quantity";
            qty.Name = "qty";
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.Name = "price";
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.FromArgb(125, 143, 105);
            addbtn.FlatAppearance.BorderSize = 0;
            addbtn.FlatStyle = FlatStyle.Flat;
            addbtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addbtn.ForeColor = Color.White;
            addbtn.Location = new Point(12, 585);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(164, 28);
            addbtn.TabIndex = 1;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(295, 585);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 15;
            label1.Text = "Payment Method";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Credit/Debit Card", "Cash", "Mobile Wallet" });
            comboBox1.Location = new Point(429, 585);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 14;
            // 
            // AddItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(169, 175, 126);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(addbtn);
            Controls.Add(dataGridView1);
            Name = "AddItems";
            Size = new Size(569, 628);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addbtn;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn price;
        private Label label1;
        private ComboBox comboBox1;
        private DataGridViewComboBoxColumn category;
    }
}
