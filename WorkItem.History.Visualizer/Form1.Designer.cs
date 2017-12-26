namespace WorkItem.History.Visualizer
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbWorkItemId = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgWiHistory = new System.Windows.Forms.DataGridView();
            this.lstVisualizer = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWiHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbWorkItemId);
            this.splitContainer1.Panel1.Controls.Add(this.btnAnalyze);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(684, 461);
            this.splitContainer1.SplitterDistance = 47;
            this.splitContainer1.TabIndex = 1;
            // 
            // tbWorkItemId
            // 
            this.tbWorkItemId.Location = new System.Drawing.Point(22, 13);
            this.tbWorkItemId.Name = "tbWorkItemId";
            this.tbWorkItemId.Size = new System.Drawing.Size(370, 20);
            this.tbWorkItemId.TabIndex = 1;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(424, 12);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(238, 23);
            this.btnAnalyze.TabIndex = 0;
            this.btnAnalyze.Text = "Visualize";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgWiHistory);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lstVisualizer);
            this.splitContainer2.Size = new System.Drawing.Size(684, 410);
            this.splitContainer2.SplitterDistance = 205;
            this.splitContainer2.TabIndex = 3;
            // 
            // dgWiHistory
            // 
            this.dgWiHistory.AllowUserToAddRows = false;
            this.dgWiHistory.AllowUserToDeleteRows = false;
            this.dgWiHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgWiHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWiHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgWiHistory.Location = new System.Drawing.Point(0, 0);
            this.dgWiHistory.Name = "dgWiHistory";
            this.dgWiHistory.Size = new System.Drawing.Size(684, 205);
            this.dgWiHistory.TabIndex = 3;
            // 
            // lstVisualizer
            // 
            this.lstVisualizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVisualizer.Location = new System.Drawing.Point(0, 0);
            this.lstVisualizer.Name = "lstVisualizer";
            this.lstVisualizer.Size = new System.Drawing.Size(684, 201);
            this.lstVisualizer.TabIndex = 0;
            this.lstVisualizer.UseCompatibleStateImageBehavior = false;
            this.lstVisualizer.SelectedIndexChanged += new System.EventHandler(this.lstVisualizer_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Work Item History Visualizer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgWiHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbWorkItemId;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgWiHistory;
        private System.Windows.Forms.ListView lstVisualizer;

    }
}

