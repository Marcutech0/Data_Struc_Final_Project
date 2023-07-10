namespace POS_FO.UserControls
{
    partial class Coupon
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
            CouponPage = new Label();
            SuspendLayout();
            // 
            // CouponPage
            // 
            CouponPage.AutoSize = true;
            CouponPage.Location = new Point(218, 173);
            CouponPage.Name = "CouponPage";
            CouponPage.Size = new Size(80, 15);
            CouponPage.TabIndex = 0;
            CouponPage.Text = "apply coupon";
            // 
            // Coupon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CouponPage);
            Name = "Coupon";
            Size = new Size(559, 396);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CouponPage;
    }
}
