namespace ALoxe.Components
{
    partial class ucStepH
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
            pnTest = new Panel();
            SuspendLayout();
            // 
            // pnTest
            // 
            pnTest.Dock = DockStyle.Fill;
            pnTest.Location = new Point(0, 0);
            pnTest.Name = "pnTest";
            pnTest.Size = new Size(140, 80);
            pnTest.TabIndex = 25;
            // 
            // ucStepH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnTest);
            Name = "ucStepH";
            Size = new Size(140, 80);
            Load += ucStepH_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lbDes;
        private Label lbName;
        private CircleImageButton btnStep;
        private Panel pnProgressRight;
        private Panel pnProgressLeft;
        private Panel panel1;
        private Panel pnTest;
    }
}
