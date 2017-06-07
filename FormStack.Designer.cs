namespace IsoMetall
{
    partial class FormStack
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
            this.components = new System.ComponentModel.Container();
            this.progressBarMaxLength = new System.Windows.Forms.ProgressBar();
            this.progressBarProccess = new System.Windows.Forms.ProgressBar();
            this.timerProccess = new System.Windows.Forms.Timer(this.components);
            this.timerInfos = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelFree1 = new System.Windows.Forms.Label();
            this.labelMaxLength = new System.Windows.Forms.Label();
            this.labelLengthProccess = new System.Windows.Forms.Label();
            this.checkBoxProccess = new System.Windows.Forms.CheckBox();
            this.labelStackNbr = new System.Windows.Forms.Label();
            this.trackBarPush = new System.Windows.Forms.TrackBar();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPush)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarMaxLength
            // 
            this.progressBarMaxLength.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBarMaxLength.Location = new System.Drawing.Point(110, 242);
            this.progressBarMaxLength.Name = "progressBarMaxLength";
            this.progressBarMaxLength.Size = new System.Drawing.Size(346, 23);
            this.progressBarMaxLength.TabIndex = 0;
            // 
            // progressBarProccess
            // 
            this.progressBarProccess.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBarProccess.Location = new System.Drawing.Point(110, 172);
            this.progressBarProccess.Name = "progressBarProccess";
            this.progressBarProccess.Size = new System.Drawing.Size(346, 23);
            this.progressBarProccess.TabIndex = 1;
            // 
            // timerProccess
            // 
            this.timerProccess.Tick += new System.EventHandler(this.timerProccess_Tick);
            // 
            // timerInfos
            // 
            this.timerInfos.Tick += new System.EventHandler(this.timerInfos_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(93, 12);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(16, 52);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownSpeed.TabIndex = 4;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSpeed.ValueChanged += new System.EventHandler(this.numericUpDownSpeed_ValueChanged);
            // 
            // labelLength
            // 
            this.labelLength.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(212, 278);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(10, 13);
            this.labelLength.TabIndex = 5;
            this.labelLength.Text = "-";
            // 
            // labelFree1
            // 
            this.labelFree1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelFree1.AutoSize = true;
            this.labelFree1.Location = new System.Drawing.Point(275, 278);
            this.labelFree1.Name = "labelFree1";
            this.labelFree1.Size = new System.Drawing.Size(12, 13);
            this.labelFree1.TabIndex = 6;
            this.labelFree1.Text = "/";
            // 
            // labelMaxLength
            // 
            this.labelMaxLength.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelMaxLength.AutoSize = true;
            this.labelMaxLength.Location = new System.Drawing.Point(293, 278);
            this.labelMaxLength.Name = "labelMaxLength";
            this.labelMaxLength.Size = new System.Drawing.Size(10, 13);
            this.labelMaxLength.TabIndex = 7;
            this.labelMaxLength.Text = "-";
            // 
            // labelLengthProccess
            // 
            this.labelLengthProccess.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelLengthProccess.AutoSize = true;
            this.labelLengthProccess.Location = new System.Drawing.Point(275, 213);
            this.labelLengthProccess.Name = "labelLengthProccess";
            this.labelLengthProccess.Size = new System.Drawing.Size(10, 13);
            this.labelLengthProccess.TabIndex = 9;
            this.labelLengthProccess.Text = "-";
            // 
            // checkBoxProccess
            // 
            this.checkBoxProccess.AutoSize = true;
            this.checkBoxProccess.Enabled = false;
            this.checkBoxProccess.Location = new System.Drawing.Point(16, 99);
            this.checkBoxProccess.Name = "checkBoxProccess";
            this.checkBoxProccess.Size = new System.Drawing.Size(68, 17);
            this.checkBoxProccess.TabIndex = 10;
            this.checkBoxProccess.Text = "En cours";
            this.checkBoxProccess.UseVisualStyleBackColor = true;
            // 
            // labelStackNbr
            // 
            this.labelStackNbr.AutoSize = true;
            this.labelStackNbr.Location = new System.Drawing.Point(17, 144);
            this.labelStackNbr.Name = "labelStackNbr";
            this.labelStackNbr.Size = new System.Drawing.Size(10, 13);
            this.labelStackNbr.TabIndex = 11;
            this.labelStackNbr.Text = "-";
            // 
            // trackBarPush
            // 
            this.trackBarPush.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBarPush.Location = new System.Drawing.Point(258, 19);
            this.trackBarPush.Maximum = 100;
            this.trackBarPush.Name = "trackBarPush";
            this.trackBarPush.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarPush.Size = new System.Drawing.Size(45, 133);
            this.trackBarPush.TabIndex = 13;
            this.trackBarPush.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(417, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 27;
            this.buttonClose.Text = "Fermer";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormStack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 317);
            this.ControlBox = false;
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.trackBarPush);
            this.Controls.Add(this.labelStackNbr);
            this.Controls.Add(this.checkBoxProccess);
            this.Controls.Add(this.labelLengthProccess);
            this.Controls.Add(this.labelMaxLength);
            this.Controls.Add(this.labelFree1);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.numericUpDownSpeed);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.progressBarProccess);
            this.Controls.Add(this.progressBarMaxLength);
            this.MaximizeBox = false;
            this.Name = "FormStack";
            this.ShowInTaskbar = false;
            this.Text = "FormStack";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStack_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPush)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarMaxLength;
        private System.Windows.Forms.ProgressBar progressBarProccess;
        private System.Windows.Forms.Timer timerProccess;
        private System.Windows.Forms.Timer timerInfos;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelFree1;
        private System.Windows.Forms.Label labelMaxLength;
        private System.Windows.Forms.Label labelLengthProccess;
        private System.Windows.Forms.CheckBox checkBoxProccess;
        private System.Windows.Forms.Label labelStackNbr;
        private System.Windows.Forms.TrackBar trackBarPush;
        private System.Windows.Forms.Button buttonClose;
    }
}