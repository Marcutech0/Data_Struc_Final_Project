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
            AddItemsPage = new Label();
            SuspendLayout();
            // 
            // AddItemsPage
            // 
            AddItemsPage.AutoSize = true;
            AddItemsPage.Location = new Point(248, 171);
            AddItemsPage.Name = "AddItemsPage";
            AddItemsPage.Size = new Size(59, 15);
            AddItemsPage.TabIndex = 0;
            AddItemsPage.Text = "add items";
            // 
            // AddItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddItemsPage);
            Name = "AddItems";
            Size = new Size(559, 396);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddItemsPage;
    }
}
