namespace POS_FO.UserControls
{
    partial class HelpPage
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
            Help = new Label();
            SuspendLayout();
            // 
            // Help
            // 
            Help.AutoSize = true;
            Help.Location = new Point(237, 188);
            Help.Name = "Help";
            Help.Size = new Size(63, 15);
            Help.TabIndex = 0;
            Help.Text = "heeEEeELP";
            // 
            // HelpPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Help);
            Name = "HelpPage";
            Size = new Size(559, 396);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Help;
    }
}
