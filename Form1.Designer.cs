namespace VTC
{
    partial class MainForm
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
            this.trackBarOnMainForm1 = new System.Windows.Forms.TrackBar();
            this.tableLayoutOnMainForm1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOnMainForm1)).BeginInit();
            this.tableLayoutOnMainForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarOnMainForm1
            // 
            this.trackBarOnMainForm1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarOnMainForm1.Location = new System.Drawing.Point(566, 414);
            this.trackBarOnMainForm1.Name = "trackBarOnMainForm1";
            this.trackBarOnMainForm1.Size = new System.Drawing.Size(191, 24);
            this.trackBarOnMainForm1.TabIndex = 1;
            // 
            // tableLayoutOnMainForm1
            // 
            this.tableLayoutOnMainForm1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutOnMainForm1.ColumnCount = 2;
            this.tableLayoutOnMainForm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOnMainForm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOnMainForm1.Controls.Add(this.trackBarOnMainForm1, 1, 1);
            this.tableLayoutOnMainForm1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutOnMainForm1.Location = new System.Drawing.Point(12, 58);
            this.tableLayoutOnMainForm1.Name = "tableLayoutOnMainForm1";
            this.tableLayoutOnMainForm1.RowCount = 2;
            this.tableLayoutOnMainForm1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutOnMainForm1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutOnMainForm1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutOnMainForm1.Size = new System.Drawing.Size(760, 441);
            this.tableLayoutOnMainForm1.TabIndex = 2;
            this.tableLayoutOnMainForm1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutOnMainForm1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.tableLayoutOnMainForm1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 411);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.tableLayoutOnMainForm1);
            this.Name = "MainForm";
            this.Text = "VTC";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOnMainForm1)).EndInit();
            this.tableLayoutOnMainForm1.ResumeLayout(false);
            this.tableLayoutOnMainForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarOnMainForm1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutOnMainForm1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

