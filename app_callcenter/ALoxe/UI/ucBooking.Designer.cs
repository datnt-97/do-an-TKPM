namespace ALoxe.UI
{
    partial class ucBooking
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
            splitContainer1 = new SplitContainer();
            advancedDataGridView1 = new Components.Datagrid.AdvancedDataGridView();
            advancedDataGridViewSearchToolBar1 = new Components.AdvancedDataGridViewSearchToolBar();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(advancedDataGridViewSearchToolBar1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(advancedDataGridView1);
            splitContainer1.Size = new Size(906, 461);
            splitContainer1.SplitterDistance = 95;
            splitContainer1.TabIndex = 0;
            // 
            // advancedDataGridView1
            // 
            advancedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advancedDataGridView1.FilterAndSortEnabled = true;
            advancedDataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.Location = new Point(0, 3);
            advancedDataGridView1.Name = "advancedDataGridView1";
            advancedDataGridView1.RightToLeft = RightToLeft.No;
            advancedDataGridView1.RowHeadersWidth = 51;
            advancedDataGridView1.Size = new Size(903, 359);
            advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.TabIndex = 0;
            // 
            // advancedDataGridViewSearchToolBar1
            // 
            advancedDataGridViewSearchToolBar1.AllowMerge = false;
            advancedDataGridViewSearchToolBar1.GripStyle = ToolStripGripStyle.Hidden;
            advancedDataGridViewSearchToolBar1.ImageScalingSize = new Size(20, 20);
            advancedDataGridViewSearchToolBar1.Location = new Point(0, 0);
            advancedDataGridViewSearchToolBar1.MaximumSize = new Size(0, 27);
            advancedDataGridViewSearchToolBar1.MinimumSize = new Size(0, 27);
            advancedDataGridViewSearchToolBar1.Name = "advancedDataGridViewSearchToolBar1";
            advancedDataGridViewSearchToolBar1.RenderMode = ToolStripRenderMode.Professional;
            advancedDataGridViewSearchToolBar1.Size = new Size(906, 27);
            advancedDataGridViewSearchToolBar1.TabIndex = 0;
            advancedDataGridViewSearchToolBar1.Text = "advancedDataGridViewSearchToolBar1";
            // 
            // ucBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ucBooking";
            Size = new Size(906, 461);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Components.AdvancedDataGridViewSearchToolBar advancedDataGridViewSearchToolBar1;
        private Components.Datagrid.AdvancedDataGridView advancedDataGridView1;
    }
}
