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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            description = new DataGridViewTextBoxColumn();
            category = new DataGridViewComboBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            addbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(169, 175, 126);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { description, category, qty, price });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
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
            addbtn.Location = new Point(202, 580);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(164, 33);
            addbtn.TabIndex = 1;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // AddItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(169, 175, 126);
            Controls.Add(addbtn);
            Controls.Add(dataGridView1);
            Name = "AddItems";
            Size = new Size(569, 628);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addbtn;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn price;
        private DataGridViewComboBoxColumn category;
    }
}
