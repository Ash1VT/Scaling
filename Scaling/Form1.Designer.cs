
namespace Scaling
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nearestNeighbourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nearestNeighbourToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ktimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilinearInterpolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadButton = new System.Windows.Forms.Button();
            this.pictureActionsPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.imageInfoPanel = new System.Windows.Forms.Panel();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.fileFormatLabel = new System.Windows.Forms.Label();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inputInfoPanel = new System.Windows.Forms.Panel();
            this.interpolateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.XYScaleButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.YScaleButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.XScaleButton = new System.Windows.Forms.Button();
            this.XYScaleTextBox = new System.Windows.Forms.TextBox();
            this.YScaleTextBox = new System.Windows.Forms.TextBox();
            this.XScaleTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.algorithmInfoPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.algorithmLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pictureActionsPanel.SuspendLayout();
            this.imageInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.inputInfoPanel.SuspendLayout();
            this.algorithmInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.nearestNeighbourToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1608, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nearestNeighbourToolStripMenuItem
            // 
            this.nearestNeighbourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.nearestNeighbourToolStripMenuItem1, this.ktimeToolStripMenuItem, this.bilinearInterpolationToolStripMenuItem });
            this.nearestNeighbourToolStripMenuItem.Name = "nearestNeighbourToolStripMenuItem";
            this.nearestNeighbourToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.nearestNeighbourToolStripMenuItem.Text = "Algorithm";
            // 
            // nearestNeighbourToolStripMenuItem1
            // 
            this.nearestNeighbourToolStripMenuItem1.Name = "nearestNeighbourToolStripMenuItem1";
            this.nearestNeighbourToolStripMenuItem1.Size = new System.Drawing.Size(218, 24);
            this.nearestNeighbourToolStripMenuItem1.Text = "Nearest neighbour";
            this.nearestNeighbourToolStripMenuItem1.Click += new System.EventHandler(this.nearestNeighbourToolStripMenuItem1_Click);
            // 
            // ktimeToolStripMenuItem
            // 
            this.ktimeToolStripMenuItem.Name = "ktimeToolStripMenuItem";
            this.ktimeToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.ktimeToolStripMenuItem.Text = "K-time ";
            this.ktimeToolStripMenuItem.Click += new System.EventHandler(this.ktimeToolStripMenuItem_Click);
            // 
            // bilinearInterpolationToolStripMenuItem
            // 
            this.bilinearInterpolationToolStripMenuItem.Name = "bilinearInterpolationToolStripMenuItem";
            this.bilinearInterpolationToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.bilinearInterpolationToolStripMenuItem.Text = "Bilinear interpolation";
            this.bilinearInterpolationToolStripMenuItem.Click += new System.EventHandler(this.bilinearInterpolationToolStripMenuItem_Click);
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(64, 16);
            this.loadButton.Margin = new System.Windows.Forms.Padding(4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(339, 71);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // pictureActionsPanel
            // 
            this.pictureActionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureActionsPanel.Controls.Add(this.saveButton);
            this.pictureActionsPanel.Controls.Add(this.loadButton);
            this.pictureActionsPanel.Location = new System.Drawing.Point(16, 712);
            this.pictureActionsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pictureActionsPanel.Name = "pictureActionsPanel";
            this.pictureActionsPanel.Size = new System.Drawing.Size(942, 103);
            this.pictureActionsPanel.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(527, 16);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(339, 71);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // imageInfoPanel
            // 
            this.imageInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageInfoPanel.Controls.Add(this.resolutionLabel);
            this.imageInfoPanel.Controls.Add(this.fileFormatLabel);
            this.imageInfoPanel.Controls.Add(this.fileSizeLabel);
            this.imageInfoPanel.Controls.Add(this.label4);
            this.imageInfoPanel.Controls.Add(this.label3);
            this.imageInfoPanel.Controls.Add(this.label2);
            this.imageInfoPanel.Controls.Add(this.label1);
            this.imageInfoPanel.Location = new System.Drawing.Point(988, 47);
            this.imageInfoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.imageInfoPanel.Name = "imageInfoPanel";
            this.imageInfoPanel.Size = new System.Drawing.Size(527, 200);
            this.imageInfoPanel.TabIndex = 4;
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolutionLabel.Location = new System.Drawing.Point(261, 73);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(149, 35);
            this.resolutionLabel.TabIndex = 6;
            // 
            // fileFormatLabel
            // 
            this.fileFormatLabel.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileFormatLabel.Location = new System.Drawing.Point(261, 143);
            this.fileFormatLabel.Name = "fileFormatLabel";
            this.fileFormatLabel.Size = new System.Drawing.Size(149, 35);
            this.fileFormatLabel.TabIndex = 5;
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSizeLabel.Location = new System.Drawing.Point(261, 108);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(149, 35);
            this.fileSizeLabel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Image information";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "File format:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "File size:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resolution:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(942, 642);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // inputInfoPanel
            // 
            this.inputInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputInfoPanel.Controls.Add(this.interpolateButton);
            this.inputInfoPanel.Controls.Add(this.label6);
            this.inputInfoPanel.Controls.Add(this.XYScaleButton);
            this.inputInfoPanel.Controls.Add(this.label7);
            this.inputInfoPanel.Controls.Add(this.YScaleButton);
            this.inputInfoPanel.Controls.Add(this.label8);
            this.inputInfoPanel.Controls.Add(this.XScaleButton);
            this.inputInfoPanel.Controls.Add(this.XYScaleTextBox);
            this.inputInfoPanel.Controls.Add(this.YScaleTextBox);
            this.inputInfoPanel.Controls.Add(this.XScaleTextBox);
            this.inputInfoPanel.Controls.Add(this.label5);
            this.inputInfoPanel.Location = new System.Drawing.Point(988, 541);
            this.inputInfoPanel.Name = "inputInfoPanel";
            this.inputInfoPanel.Size = new System.Drawing.Size(527, 274);
            this.inputInfoPanel.TabIndex = 6;
            // 
            // interpolateButton
            // 
            this.interpolateButton.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interpolateButton.Location = new System.Drawing.Point(14, 206);
            this.interpolateButton.Name = "interpolateButton";
            this.interpolateButton.Size = new System.Drawing.Size(453, 52);
            this.interpolateButton.TabIndex = 14;
            this.interpolateButton.Text = "Interpolate";
            this.interpolateButton.UseVisualStyleBackColor = true;
            this.interpolateButton.Click += new System.EventHandler(this.interpolateButton_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 38);
            this.label6.TabIndex = 9;
            this.label6.Text = "XY:";
            // 
            // XYScaleButton
            // 
            this.XYScaleButton.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XYScaleButton.Location = new System.Drawing.Point(273, 161);
            this.XYScaleButton.Name = "XYScaleButton";
            this.XYScaleButton.Size = new System.Drawing.Size(194, 38);
            this.XYScaleButton.TabIndex = 13;
            this.XYScaleButton.Text = "Scale";
            this.XYScaleButton.UseVisualStyleBackColor = true;
            this.XYScaleButton.Click += new System.EventHandler(this.XYScaleButton_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 41);
            this.label7.TabIndex = 8;
            this.label7.Text = "Y:";
            // 
            // YScaleButton
            // 
            this.YScaleButton.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YScaleButton.Location = new System.Drawing.Point(273, 114);
            this.YScaleButton.Name = "YScaleButton";
            this.YScaleButton.Size = new System.Drawing.Size(194, 38);
            this.YScaleButton.TabIndex = 12;
            this.YScaleButton.Text = "Scale";
            this.YScaleButton.UseVisualStyleBackColor = true;
            this.YScaleButton.Click += new System.EventHandler(this.YScaleButton_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 41);
            this.label8.TabIndex = 7;
            this.label8.Text = "X:";
            // 
            // XScaleButton
            // 
            this.XScaleButton.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XScaleButton.Location = new System.Drawing.Point(273, 70);
            this.XScaleButton.Name = "XScaleButton";
            this.XScaleButton.Size = new System.Drawing.Size(194, 38);
            this.XScaleButton.TabIndex = 11;
            this.XScaleButton.Text = "Scale";
            this.XScaleButton.UseVisualStyleBackColor = true;
            this.XScaleButton.Click += new System.EventHandler(this.XScaleButton_Click);
            // 
            // XYScaleTextBox
            // 
            this.XYScaleTextBox.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XYScaleTextBox.Location = new System.Drawing.Point(80, 158);
            this.XYScaleTextBox.Name = "XYScaleTextBox";
            this.XYScaleTextBox.Size = new System.Drawing.Size(183, 38);
            this.XYScaleTextBox.TabIndex = 10;
            // 
            // YScaleTextBox
            // 
            this.YScaleTextBox.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YScaleTextBox.Location = new System.Drawing.Point(80, 114);
            this.YScaleTextBox.Name = "YScaleTextBox";
            this.YScaleTextBox.Size = new System.Drawing.Size(183, 38);
            this.YScaleTextBox.TabIndex = 9;
            // 
            // XScaleTextBox
            // 
            this.XScaleTextBox.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XScaleTextBox.Location = new System.Drawing.Point(80, 70);
            this.XScaleTextBox.Name = "XScaleTextBox";
            this.XScaleTextBox.Size = new System.Drawing.Size(183, 38);
            this.XScaleTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 35);
            this.label5.TabIndex = 7;
            this.label5.Text = "Input information";
            // 
            // algorithmInfoPanel
            // 
            this.algorithmInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.algorithmInfoPanel.Controls.Add(this.label9);
            this.algorithmInfoPanel.Controls.Add(this.timeLabel);
            this.algorithmInfoPanel.Controls.Add(this.algorithmLabel);
            this.algorithmInfoPanel.Controls.Add(this.label12);
            this.algorithmInfoPanel.Controls.Add(this.label13);
            this.algorithmInfoPanel.Location = new System.Drawing.Point(988, 268);
            this.algorithmInfoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.algorithmInfoPanel.Name = "algorithmInfoPanel";
            this.algorithmInfoPanel.Size = new System.Drawing.Size(527, 250);
            this.algorithmInfoPanel.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 35);
            this.label9.TabIndex = 7;
            this.label9.Text = "Time:";
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(278, 168);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(204, 35);
            this.timeLabel.TabIndex = 6;
            // 
            // algorithmLabel
            // 
            this.algorithmLabel.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithmLabel.Location = new System.Drawing.Point(282, 81);
            this.algorithmLabel.Name = "algorithmLabel";
            this.algorithmLabel.Size = new System.Drawing.Size(200, 64);
            this.algorithmLabel.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(99, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(383, 35);
            this.label12.TabIndex = 3;
            this.label12.Text = "Algorithm information";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(240, 35);
            this.label13.TabIndex = 0;
            this.label13.Text = "Algorithm name:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 828);
            this.Controls.Add(this.algorithmInfoPanel);
            this.Controls.Add(this.inputInfoPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imageInfoPanel);
            this.Controls.Add(this.pictureActionsPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Scaling";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pictureActionsPanel.ResumeLayout(false);
            this.imageInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.inputInfoPanel.ResumeLayout(false);
            this.inputInfoPanel.PerformLayout();
            this.algorithmInfoPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button interpolateButton;

        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.ToolStripMenuItem bilinearInterpolationToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem nearestNeighbourToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ktimeToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem nearestNeighbourToolStripMenuItem;

        private System.Windows.Forms.Panel algorithmInfoPanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label algorithmLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.TextBox YScaleTextBox;
        private System.Windows.Forms.TextBox XYScaleTextBox;
        private System.Windows.Forms.Button XScaleButton;
        private System.Windows.Forms.Button YScaleButton;
        private System.Windows.Forms.Button XYScaleButton;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox XScaleTextBox;

        private System.Windows.Forms.Panel inputInfoPanel;

        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.Label fileFormatLabel;
        private System.Windows.Forms.Label resolutionLabel;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Panel pictureActionsPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel imageInfoPanel;
    }
}

