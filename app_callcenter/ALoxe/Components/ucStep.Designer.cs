namespace ALoxe.Components
{
    partial class ucStep
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
            pnProgress = new Panel();
            btnStep = new CircleImageButton();
            lbName = new Label();
            lbDes = new Label();
            SuspendLayout();
            // 
            // pnProgress
            // 
            pnProgress.BackColor = Color.LightGray;
            pnProgress.Location = new Point(13, 30);
            pnProgress.Name = "pnProgress";
            pnProgress.Size = new Size(4, 40);
            pnProgress.TabIndex = 17;
            // 
            // btnStep
            // 
            btnStep.BackColor = Color.Transparent;
            btnStep.BackgroundImageLayout = ImageLayout.Zoom;
            btnStep.FlatAppearance.BorderSize = 0;
            btnStep.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnStep.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnStep.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnStep.FlatStyle = FlatStyle.Flat;
            btnStep.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStep.Image = null;
            btnStep.Location = new Point(0, 0);
            btnStep.Margin = new Padding(0);
            btnStep.Name = "btnStep";
            btnStep.Size = new Size(29, 28);
            btnStep.TabIndex = 16;
            btnStep.Text = "1";
            btnStep.UseVisualStyleBackColor = false;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbName.Location = new Point(38, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(55, 20);
            lbName.TabIndex = 18;
            lbName.Text = "Đã đặt";
            // 
            // lbDes
            // 
            lbDes.AutoSize = true;
            lbDes.Font = new Font("Segoe UI", 7F);
            lbDes.Location = new Point(39, 20);
            lbDes.Name = "lbDes";
            lbDes.Size = new Size(56, 15);
            lbDes.TabIndex = 19;
            lbDes.Text = "Đã đặt xe";
            // 
            // ucStep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(lbDes);
            Controls.Add(lbName);
            Controls.Add(btnStep);
            Controls.Add(pnProgress);
            Name = "ucStep";
            Size = new Size(213, 72);
            Load += ucStep_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnProgress;
        private CircleImageButton btnStep;
        private Label lbName;
        private Label lbDes;
    }
}
