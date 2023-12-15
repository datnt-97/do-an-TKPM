namespace ALoxe.UI
{
    partial class frmLoading
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
            loading1 = new Components.Loading();
            lbTitle = new Label();
            SuspendLayout();
            // 
            // loading1
            // 
            loading1.Location = new Point(34, 19);
            loading1.Name = "loading1";
            loading1.Size = new Size(75, 75);
            loading1.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.BackColor = Color.Silver;
            lbTitle.ForeColor = Color.Red;
            lbTitle.Location = new Point(-1, 92);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(42, 20);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "label";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            lbTitle.Visible = false;
            // 
            // frmLoading
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(142, 111);
            ControlBox = false;
            Controls.Add(lbTitle);
            Controls.Add(loading1);
            MinimumSize = new Size(120, 120);
            Name = "frmLoading";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmLoading_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Components.Loading loading1;
        private Label lbTitle;
    }
}