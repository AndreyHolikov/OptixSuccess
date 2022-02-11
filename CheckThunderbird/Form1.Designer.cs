namespace CheckThunderbird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCheckThunderbird = new System.Windows.Forms.Button();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.tbxProcessName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTimerInterval = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxUptime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerInterval)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckThunderbird
            // 
            this.btnCheckThunderbird.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckThunderbird.Location = new System.Drawing.Point(23, 61);
            this.btnCheckThunderbird.Name = "btnCheckThunderbird";
            this.btnCheckThunderbird.Size = new System.Drawing.Size(752, 34);
            this.btnCheckThunderbird.TabIndex = 0;
            this.btnCheckThunderbird.Text = "CheckThunderbird";
            this.btnCheckThunderbird.UseVisualStyleBackColor = true;
            this.btnCheckThunderbird.Click += new System.EventHandler(this.btnCheckThunderbird_Click);
            // 
            // rtbResult
            // 
            this.rtbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbResult.Location = new System.Drawing.Point(200, 100);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(600, 350);
            this.rtbResult.TabIndex = 1;
            this.rtbResult.Text = "";
            // 
            // tbxProcessName
            // 
            this.tbxProcessName.Location = new System.Drawing.Point(110, 22);
            this.tbxProcessName.Name = "tbxProcessName";
            this.tbxProcessName.Size = new System.Drawing.Size(301, 23);
            this.tbxProcessName.TabIndex = 2;
            this.tbxProcessName.Text = "thunderbird";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Timer.Interval: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "ProcessName:";
            // 
            // nudTimerInterval
            // 
            this.nudTimerInterval.Location = new System.Drawing.Point(562, 22);
            this.nudTimerInterval.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudTimerInterval.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTimerInterval.Name = "nudTimerInterval";
            this.nudTimerInterval.Size = new System.Drawing.Size(208, 23);
            this.nudTimerInterval.TabIndex = 5;
            this.nudTimerInterval.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nudTimerInterval);
            this.panel1.Controls.Add(this.btnCheckThunderbird);
            this.panel1.Controls.Add(this.tbxProcessName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxUptime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 350);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статистика";
            // 
            // tbxUptime
            // 
            this.tbxUptime.Enabled = false;
            this.tbxUptime.Location = new System.Drawing.Point(33, 67);
            this.tbxUptime.Name = "tbxUptime";
            this.tbxUptime.Size = new System.Drawing.Size(133, 23);
            this.tbxUptime.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Время работы Windows:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerInterval)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCheckThunderbird;
        private RichTextBox rtbResult;
        private TextBox tbxProcessName;
        private Label label1;
        private Label label2;
        private NumericUpDown nudTimerInterval;
        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox tbxUptime;
        private Label label3;
    }
}