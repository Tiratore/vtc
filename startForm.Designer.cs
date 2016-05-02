namespace VTC
{
    partial class startForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.selectSrtLabel = new System.Windows.Forms.Label();
            this.selectMovLabel = new System.Windows.Forms.Label();
            this.selectSrtButton = new System.Windows.Forms.Button();
            this.openMovButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.startButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.selectSrtLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.selectMovLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.selectSrtButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.openMovButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.startButton, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 350);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // selectSrtLabel
            // 
            this.selectSrtLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectSrtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectSrtLabel.Location = new System.Drawing.Point(3, 46);
            this.selectSrtLabel.Name = "selectSrtLabel";
            this.selectSrtLabel.Size = new System.Drawing.Size(188, 23);
            this.selectSrtLabel.TabIndex = 0;
            this.selectSrtLabel.Text = "Выберите srt файл:";
            // 
            // selectMovLabel
            // 
            this.selectMovLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectMovLabel.AutoSize = true;
            this.selectMovLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectMovLabel.Location = new System.Drawing.Point(3, 164);
            this.selectMovLabel.Name = "selectMovLabel";
            this.selectMovLabel.Size = new System.Drawing.Size(188, 20);
            this.selectMovLabel.TabIndex = 1;
            this.selectMovLabel.Text = "Выберите видео:";
            // 
            // selectSrtButton
            // 
            this.selectSrtButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectSrtButton.Location = new System.Drawing.Point(197, 46);
            this.selectSrtButton.Name = "selectSrtButton";
            this.selectSrtButton.Size = new System.Drawing.Size(188, 23);
            this.selectSrtButton.TabIndex = 2;
            this.selectSrtButton.Text = "Открыть";
            this.selectSrtButton.UseVisualStyleBackColor = true;
            this.selectSrtButton.Click += new System.EventHandler(this.selectSrtButton_Click);
            // 
            // openMovButton
            // 
            this.openMovButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.openMovButton.Location = new System.Drawing.Point(197, 162);
            this.openMovButton.Name = "openMovButton";
            this.openMovButton.Size = new System.Drawing.Size(188, 23);
            this.openMovButton.TabIndex = 3;
            this.openMovButton.Text = "Открыть";
            this.openMovButton.UseVisualStyleBackColor = true;
            this.openMovButton.Click += new System.EventHandler(this.openMovButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.startButton, 2);
            this.startButton.Location = new System.Drawing.Point(3, 235);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(382, 112);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 374);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "startForm";
            this.Text = "Выбор файлов";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label selectSrtLabel;
        private System.Windows.Forms.Label selectMovLabel;
        private System.Windows.Forms.Button selectSrtButton;
        private System.Windows.Forms.Button openMovButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button startButton;
    }
}