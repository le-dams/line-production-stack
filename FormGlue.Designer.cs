namespace IsoMetall
{
    partial class FormGlue
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
            this.timerGlueTop = new System.Windows.Forms.Timer(this.components);
            this.labelFree1 = new System.Windows.Forms.Label();
            this.numericUpDownTopMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTopMax = new System.Windows.Forms.NumericUpDown();
            this.labelLengthMax = new System.Windows.Forms.Label();
            this.timerInfos = new System.Windows.Forms.Timer(this.components);
            this.labelGlueTop = new System.Windows.Forms.Label();
            this.numericUpDownTopSpeed = new System.Windows.Forms.NumericUpDown();
            this.buttonTopStart = new System.Windows.Forms.Button();
            this.buttonTopStop = new System.Windows.Forms.Button();
            this.trackBarGlueTop = new System.Windows.Forms.TrackBar();
            this.labelFreeSlide = new System.Windows.Forms.Label();
            this.labelFreeGlue = new System.Windows.Forms.Label();
            this.buttonTopActionStop = new System.Windows.Forms.Button();
            this.buttonTopActionStart = new System.Windows.Forms.Button();
            this.buttonRinseTop = new System.Windows.Forms.Button();
            this.timerRinse = new System.Windows.Forms.Timer(this.components);
            this.buttonResetBoth = new System.Windows.Forms.Button();
            this.numericUpDownTopRinse = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerSpray = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSprayRinse = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSprayChanged = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownSprayGrammage = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGlueTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopRinse)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSprayGrammage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGlueTop
            // 
            this.timerGlueTop.Tick += new System.EventHandler(this.timerGlueTop_Tick);
            // 
            // labelFree1
            // 
            this.labelFree1.AutoSize = true;
            this.labelFree1.Location = new System.Drawing.Point(454, 89);
            this.labelFree1.Name = "labelFree1";
            this.labelFree1.Size = new System.Drawing.Size(38, 13);
            this.labelFree1.TabIndex = 2;
            this.labelFree1.Text = "Butée:";
            // 
            // numericUpDownTopMin
            // 
            this.numericUpDownTopMin.Location = new System.Drawing.Point(12, 385);
            this.numericUpDownTopMin.Name = "numericUpDownTopMin";
            this.numericUpDownTopMin.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownTopMin.TabIndex = 4;
            this.numericUpDownTopMin.ValueChanged += new System.EventHandler(this.numericUpDownTopMin_ValueChanged);
            // 
            // numericUpDownTopMax
            // 
            this.numericUpDownTopMax.Location = new System.Drawing.Point(569, 385);
            this.numericUpDownTopMax.Name = "numericUpDownTopMax";
            this.numericUpDownTopMax.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownTopMax.TabIndex = 7;
            this.numericUpDownTopMax.ValueChanged += new System.EventHandler(this.numericUpDownTopMax_ValueChanged);
            // 
            // labelLengthMax
            // 
            this.labelLengthMax.AutoSize = true;
            this.labelLengthMax.Location = new System.Drawing.Point(516, 89);
            this.labelLengthMax.Name = "labelLengthMax";
            this.labelLengthMax.Size = new System.Drawing.Size(10, 13);
            this.labelLengthMax.TabIndex = 8;
            this.labelLengthMax.Text = "-";
            // 
            // timerInfos
            // 
            this.timerInfos.Tick += new System.EventHandler(this.timerInfos_Tick);
            // 
            // labelGlueTop
            // 
            this.labelGlueTop.AutoSize = true;
            this.labelGlueTop.Location = new System.Drawing.Point(516, 55);
            this.labelGlueTop.Name = "labelGlueTop";
            this.labelGlueTop.Size = new System.Drawing.Size(10, 13);
            this.labelGlueTop.TabIndex = 10;
            this.labelGlueTop.Text = "-";
            // 
            // numericUpDownTopSpeed
            // 
            this.numericUpDownTopSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownTopSpeed.Location = new System.Drawing.Point(473, 307);
            this.numericUpDownTopSpeed.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownTopSpeed.Name = "numericUpDownTopSpeed";
            this.numericUpDownTopSpeed.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownTopSpeed.TabIndex = 12;
            this.numericUpDownTopSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTopSpeed.ValueChanged += new System.EventHandler(this.numericUpDownTopSpeed_ValueChanged);
            // 
            // buttonTopStart
            // 
            this.buttonTopStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonTopStart.Location = new System.Drawing.Point(473, 278);
            this.buttonTopStart.Name = "buttonTopStart";
            this.buttonTopStart.Size = new System.Drawing.Size(55, 23);
            this.buttonTopStart.TabIndex = 14;
            this.buttonTopStart.Text = "Start";
            this.buttonTopStart.UseVisualStyleBackColor = true;
            this.buttonTopStart.Click += new System.EventHandler(this.buttonTopStart_Click);
            // 
            // buttonTopStop
            // 
            this.buttonTopStop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonTopStop.Enabled = false;
            this.buttonTopStop.Location = new System.Drawing.Point(473, 333);
            this.buttonTopStop.Name = "buttonTopStop";
            this.buttonTopStop.Size = new System.Drawing.Size(55, 23);
            this.buttonTopStop.TabIndex = 18;
            this.buttonTopStop.Text = "Stop";
            this.buttonTopStop.UseVisualStyleBackColor = true;
            this.buttonTopStop.Click += new System.EventHandler(this.buttonTopStop_Click);
            // 
            // trackBarGlueTop
            // 
            this.trackBarGlueTop.Enabled = false;
            this.trackBarGlueTop.Location = new System.Drawing.Point(76, 372);
            this.trackBarGlueTop.Name = "trackBarGlueTop";
            this.trackBarGlueTop.Size = new System.Drawing.Size(475, 45);
            this.trackBarGlueTop.TabIndex = 26;
            this.trackBarGlueTop.TickFrequency = 0;
            this.trackBarGlueTop.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // labelFreeSlide
            // 
            this.labelFreeSlide.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFreeSlide.AutoSize = true;
            this.labelFreeSlide.Location = new System.Drawing.Point(470, 242);
            this.labelFreeSlide.Name = "labelFreeSlide";
            this.labelFreeSlide.Size = new System.Drawing.Size(63, 13);
            this.labelFreeSlide.TabIndex = 30;
            this.labelFreeSlide.Text = "Mouvement";
            // 
            // labelFreeGlue
            // 
            this.labelFreeGlue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFreeGlue.AutoSize = true;
            this.labelFreeGlue.Location = new System.Drawing.Point(104, 239);
            this.labelFreeGlue.Name = "labelFreeGlue";
            this.labelFreeGlue.Size = new System.Drawing.Size(30, 13);
            this.labelFreeGlue.TabIndex = 31;
            this.labelFreeGlue.Text = "Colle";
            // 
            // buttonTopActionStop
            // 
            this.buttonTopActionStop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonTopActionStop.Enabled = false;
            this.buttonTopActionStop.Location = new System.Drawing.Point(91, 333);
            this.buttonTopActionStop.Name = "buttonTopActionStop";
            this.buttonTopActionStop.Size = new System.Drawing.Size(55, 23);
            this.buttonTopActionStop.TabIndex = 33;
            this.buttonTopActionStop.Text = "Stop";
            this.buttonTopActionStop.UseVisualStyleBackColor = true;
            this.buttonTopActionStop.Click += new System.EventHandler(this.buttonTopActionStop_Click);
            // 
            // buttonTopActionStart
            // 
            this.buttonTopActionStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonTopActionStart.Location = new System.Drawing.Point(91, 278);
            this.buttonTopActionStart.Name = "buttonTopActionStart";
            this.buttonTopActionStart.Size = new System.Drawing.Size(55, 23);
            this.buttonTopActionStart.TabIndex = 32;
            this.buttonTopActionStart.Text = "Start";
            this.buttonTopActionStart.UseVisualStyleBackColor = true;
            this.buttonTopActionStart.Click += new System.EventHandler(this.buttonTopActionStart_Click);
            // 
            // buttonRinseTop
            // 
            this.buttonRinseTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRinseTop.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRinseTop.Location = new System.Drawing.Point(278, 281);
            this.buttonRinseTop.Name = "buttonRinseTop";
            this.buttonRinseTop.Size = new System.Drawing.Size(55, 23);
            this.buttonRinseTop.TabIndex = 36;
            this.buttonRinseTop.Text = "Rincage";
            this.buttonRinseTop.UseVisualStyleBackColor = false;
            this.buttonRinseTop.Click += new System.EventHandler(this.buttonRinseTop_Click);
            // 
            // timerRinse
            // 
            this.timerRinse.Tick += new System.EventHandler(this.timerRinse_Tick);
            // 
            // buttonResetBoth
            // 
            this.buttonResetBoth.BackColor = System.Drawing.Color.LightBlue;
            this.buttonResetBoth.Location = new System.Drawing.Point(278, 234);
            this.buttonResetBoth.Name = "buttonResetBoth";
            this.buttonResetBoth.Size = new System.Drawing.Size(55, 23);
            this.buttonResetBoth.TabIndex = 39;
            this.buttonResetBoth.Text = "Reset";
            this.buttonResetBoth.UseVisualStyleBackColor = false;
            this.buttonResetBoth.Click += new System.EventHandler(this.buttonResetBoth_Click);
            // 
            // numericUpDownTopRinse
            // 
            this.numericUpDownTopRinse.Location = new System.Drawing.Point(278, 333);
            this.numericUpDownTopRinse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTopRinse.Name = "numericUpDownTopRinse";
            this.numericUpDownTopRinse.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownTopRinse.TabIndex = 42;
            this.numericUpDownTopRinse.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTopRinse.ValueChanged += new System.EventHandler(this.numericUpDownTopSpray_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // timerSpray
            // 
            this.timerSpray.Tick += new System.EventHandler(this.timerSpray_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Largeur:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Depuis rinçage:";
            // 
            // labelSprayRinse
            // 
            this.labelSprayRinse.AutoSize = true;
            this.labelSprayRinse.Location = new System.Drawing.Point(131, 55);
            this.labelSprayRinse.Name = "labelSprayRinse";
            this.labelSprayRinse.Size = new System.Drawing.Size(10, 13);
            this.labelSprayRinse.TabIndex = 48;
            this.labelSprayRinse.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Depuis changement:";
            // 
            // labelSprayChanged
            // 
            this.labelSprayChanged.AutoSize = true;
            this.labelSprayChanged.Location = new System.Drawing.Point(131, 89);
            this.labelSprayChanged.Name = "labelSprayChanged";
            this.labelSprayChanged.Size = new System.Drawing.Size(10, 13);
            this.labelSprayChanged.TabIndex = 50;
            this.labelSprayChanged.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Grammage:";
            // 
            // numericUpDownSprayGrammage
            // 
            this.numericUpDownSprayGrammage.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSprayGrammage.Location = new System.Drawing.Point(128, 124);
            this.numericUpDownSprayGrammage.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownSprayGrammage.Name = "numericUpDownSprayGrammage";
            this.numericUpDownSprayGrammage.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownSprayGrammage.TabIndex = 53;
            this.numericUpDownSprayGrammage.ValueChanged += new System.EventHandler(this.numericUpDownSprayGrammage_ValueChanged);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownWidth.Location = new System.Drawing.Point(519, 122);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownWidth.TabIndex = 54;
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.numericUpDownWidth_ValueChanged);
            // 
            // FormGlue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 429);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.numericUpDownSprayGrammage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelSprayChanged);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSprayRinse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownTopRinse);
            this.Controls.Add(this.buttonResetBoth);
            this.Controls.Add(this.buttonRinseTop);
            this.Controls.Add(this.buttonTopActionStop);
            this.Controls.Add(this.buttonTopActionStart);
            this.Controls.Add(this.labelFreeGlue);
            this.Controls.Add(this.labelFreeSlide);
            this.Controls.Add(this.trackBarGlueTop);
            this.Controls.Add(this.buttonTopStop);
            this.Controls.Add(this.buttonTopStart);
            this.Controls.Add(this.numericUpDownTopSpeed);
            this.Controls.Add(this.labelGlueTop);
            this.Controls.Add(this.labelLengthMax);
            this.Controls.Add(this.numericUpDownTopMax);
            this.Controls.Add(this.numericUpDownTopMin);
            this.Controls.Add(this.labelFree1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormGlue";
            this.Text = "Glue";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGlue_FormClosed);
            this.Load += new System.EventHandler(this.FormGlue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGlueTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopRinse)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSprayGrammage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerGlueTop;
        private System.Windows.Forms.Label labelFree1;
        private System.Windows.Forms.NumericUpDown numericUpDownTopMin;
        private System.Windows.Forms.NumericUpDown numericUpDownTopMax;
        private System.Windows.Forms.Label labelLengthMax;
        private System.Windows.Forms.Timer timerInfos;
        private System.Windows.Forms.Label labelGlueTop;
        private System.Windows.Forms.NumericUpDown numericUpDownTopSpeed;
        private System.Windows.Forms.Button buttonTopStart;
        private System.Windows.Forms.Button buttonTopStop;
        private System.Windows.Forms.TrackBar trackBarGlueTop;
        private System.Windows.Forms.Label labelFreeSlide;
        private System.Windows.Forms.Label labelFreeGlue;
        private System.Windows.Forms.Button buttonTopActionStop;
        private System.Windows.Forms.Button buttonTopActionStart;
        private System.Windows.Forms.Button buttonRinseTop;
        private System.Windows.Forms.Timer timerRinse;
        private System.Windows.Forms.Button buttonResetBoth;
        private System.Windows.Forms.NumericUpDown numericUpDownTopRinse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Timer timerSpray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSprayRinse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSprayChanged;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownSprayGrammage;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
    }
}