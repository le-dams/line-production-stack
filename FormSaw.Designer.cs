namespace IsoMetall
{
    partial class FormSaw
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
            this.trackBarCutLeft = new System.Windows.Forms.TrackBar();
            this.trackBarCutRight = new System.Windows.Forms.TrackBar();
            this.labelCutLeft = new System.Windows.Forms.Label();
            this.labelCutRight = new System.Windows.Forms.Label();
            this.checkBoxCutLeft = new System.Windows.Forms.CheckBox();
            this.checkBoxCutRight = new System.Windows.Forms.CheckBox();
            this.buttonCut = new System.Windows.Forms.Button();
            this.progressBarCutting = new System.Windows.Forms.ProgressBar();
            this.timerCuttingProcess = new System.Windows.Forms.Timer(this.components);
            this.timerCuttingReset = new System.Windows.Forms.Timer(this.components);
            this.vScrollBarPressureLeft = new System.Windows.Forms.VScrollBar();
            this.vScrollBarPresureRight = new System.Windows.Forms.VScrollBar();
            this.timerPressureProccess = new System.Windows.Forms.Timer(this.components);
            this.timerPressureReset = new System.Windows.Forms.Timer(this.components);
            this.progressBarLength = new System.Windows.Forms.ProgressBar();
            this.buttonStop = new System.Windows.Forms.Button();
            this.checkBoxCutLimit = new System.Windows.Forms.CheckBox();
            this.FreeLabel1 = new System.Windows.Forms.Label();
            this.labelCutNbr = new System.Windows.Forms.Label();
            this.numericUpDownCutHeight = new System.Windows.Forms.NumericUpDown();
            this.labelLengthTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLengthCurrent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewDyn = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetcuttingnbrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBeforeCutting = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownCuttingLength = new System.Windows.Forms.NumericUpDown();
            this.checkBoxAuto = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCutLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCutRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCutHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDyn)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCuttingLength)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarCutLeft
            // 
            this.trackBarCutLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarCutLeft.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarCutLeft.LargeChange = 10;
            this.trackBarCutLeft.Location = new System.Drawing.Point(567, 219);
            this.trackBarCutLeft.Maximum = 300;
            this.trackBarCutLeft.Name = "trackBarCutLeft";
            this.trackBarCutLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarCutLeft.Size = new System.Drawing.Size(104, 45);
            this.trackBarCutLeft.TabIndex = 0;
            this.trackBarCutLeft.ValueChanged += new System.EventHandler(this.trackBarCutLeft_ValueChanged);
            // 
            // trackBarCutRight
            // 
            this.trackBarCutRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarCutRight.LargeChange = 10;
            this.trackBarCutRight.Location = new System.Drawing.Point(770, 219);
            this.trackBarCutRight.Maximum = 300;
            this.trackBarCutRight.Name = "trackBarCutRight";
            this.trackBarCutRight.Size = new System.Drawing.Size(104, 45);
            this.trackBarCutRight.SmallChange = 10;
            this.trackBarCutRight.TabIndex = 1;
            this.trackBarCutRight.ValueChanged += new System.EventHandler(this.trackBarCutRight_ValueChanged);
            // 
            // labelCutLeft
            // 
            this.labelCutLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCutLeft.AutoSize = true;
            this.labelCutLeft.Location = new System.Drawing.Point(603, 267);
            this.labelCutLeft.Name = "labelCutLeft";
            this.labelCutLeft.Size = new System.Drawing.Size(35, 13);
            this.labelCutLeft.TabIndex = 2;
            this.labelCutLeft.Text = "label1";
            // 
            // labelCutRight
            // 
            this.labelCutRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCutRight.AutoSize = true;
            this.labelCutRight.Location = new System.Drawing.Point(801, 267);
            this.labelCutRight.Name = "labelCutRight";
            this.labelCutRight.Size = new System.Drawing.Size(35, 13);
            this.labelCutRight.TabIndex = 3;
            this.labelCutRight.Text = "label2";
            // 
            // checkBoxCutLeft
            // 
            this.checkBoxCutLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCutLeft.AutoSize = true;
            this.checkBoxCutLeft.Location = new System.Drawing.Point(546, 222);
            this.checkBoxCutLeft.Name = "checkBoxCutLeft";
            this.checkBoxCutLeft.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCutLeft.TabIndex = 4;
            this.checkBoxCutLeft.UseVisualStyleBackColor = true;
            this.checkBoxCutLeft.CheckedChanged += new System.EventHandler(this.checkBoxCutLeftOrRight_CheckedChanged);
            // 
            // checkBoxCutRight
            // 
            this.checkBoxCutRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCutRight.AutoSize = true;
            this.checkBoxCutRight.Location = new System.Drawing.Point(886, 222);
            this.checkBoxCutRight.Name = "checkBoxCutRight";
            this.checkBoxCutRight.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCutRight.TabIndex = 5;
            this.checkBoxCutRight.UseVisualStyleBackColor = true;
            this.checkBoxCutRight.CheckedChanged += new System.EventHandler(this.checkBoxCutLeftOrRight_CheckedChanged);
            // 
            // buttonCut
            // 
            this.buttonCut.AllowDrop = true;
            this.buttonCut.Location = new System.Drawing.Point(864, 35);
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(75, 26);
            this.buttonCut.TabIndex = 6;
            this.buttonCut.Text = "Cut";
            this.buttonCut.UseVisualStyleBackColor = true;
            this.buttonCut.Click += new System.EventHandler(this.buttonCut_Click);
            // 
            // progressBarCutting
            // 
            this.progressBarCutting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarCutting.Location = new System.Drawing.Point(562, 330);
            this.progressBarCutting.Name = "progressBarCutting";
            this.progressBarCutting.Size = new System.Drawing.Size(307, 22);
            this.progressBarCutting.Step = 250;
            this.progressBarCutting.TabIndex = 7;
            // 
            // timerCuttingProcess
            // 
            this.timerCuttingProcess.Tick += new System.EventHandler(this.timerCutting_Tick);
            // 
            // timerCuttingReset
            // 
            this.timerCuttingReset.Tick += new System.EventHandler(this.timerCuttingReset_Tick);
            // 
            // vScrollBarPressureLeft
            // 
            this.vScrollBarPressureLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBarPressureLeft.Location = new System.Drawing.Point(478, 191);
            this.vScrollBarPressureLeft.Name = "vScrollBarPressureLeft";
            this.vScrollBarPressureLeft.Size = new System.Drawing.Size(23, 89);
            this.vScrollBarPressureLeft.TabIndex = 8;
            // 
            // vScrollBarPresureRight
            // 
            this.vScrollBarPresureRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBarPresureRight.Location = new System.Drawing.Point(918, 191);
            this.vScrollBarPresureRight.Name = "vScrollBarPresureRight";
            this.vScrollBarPresureRight.Size = new System.Drawing.Size(23, 89);
            this.vScrollBarPresureRight.TabIndex = 9;
            // 
            // timerPressureProccess
            // 
            this.timerPressureProccess.Tick += new System.EventHandler(this.timerPressure_Tick);
            // 
            // timerPressureReset
            // 
            this.timerPressureReset.Tick += new System.EventHandler(this.timerPressureReset_Tick);
            // 
            // progressBarLength
            // 
            this.progressBarLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarLength.Location = new System.Drawing.Point(562, 302);
            this.progressBarLength.Name = "progressBarLength";
            this.progressBarLength.Size = new System.Drawing.Size(307, 22);
            this.progressBarLength.Step = 250;
            this.progressBarLength.TabIndex = 10;
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(864, 67);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 11;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // checkBoxCutLimit
            // 
            this.checkBoxCutLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCutLimit.AutoSize = true;
            this.checkBoxCutLimit.Location = new System.Drawing.Point(886, 335);
            this.checkBoxCutLimit.Name = "checkBoxCutLimit";
            this.checkBoxCutLimit.Size = new System.Drawing.Size(53, 17);
            this.checkBoxCutLimit.TabIndex = 12;
            this.checkBoxCutLimit.Text = "Limite";
            this.checkBoxCutLimit.UseVisualStyleBackColor = true;
            this.checkBoxCutLimit.CheckedChanged += new System.EventHandler(this.checkBoxCutLimit_CheckedChanged);
            // 
            // FreeLabel1
            // 
            this.FreeLabel1.AutoSize = true;
            this.FreeLabel1.Location = new System.Drawing.Point(715, 112);
            this.FreeLabel1.Name = "FreeLabel1";
            this.FreeLabel1.Size = new System.Drawing.Size(41, 13);
            this.FreeLabel1.TabIndex = 13;
            this.FreeLabel1.Text = "Coupe:";
            // 
            // labelCutNbr
            // 
            this.labelCutNbr.AutoSize = true;
            this.labelCutNbr.Location = new System.Drawing.Point(753, 112);
            this.labelCutNbr.Name = "labelCutNbr";
            this.labelCutNbr.Size = new System.Drawing.Size(10, 13);
            this.labelCutNbr.TabIndex = 14;
            this.labelCutNbr.Text = "-";
            // 
            // numericUpDownCutHeight
            // 
            this.numericUpDownCutHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownCutHeight.Location = new System.Drawing.Point(698, 220);
            this.numericUpDownCutHeight.Name = "numericUpDownCutHeight";
            this.numericUpDownCutHeight.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownCutHeight.TabIndex = 16;
            // 
            // labelLengthTotal
            // 
            this.labelLengthTotal.AutoSize = true;
            this.labelLengthTotal.Location = new System.Drawing.Point(568, 87);
            this.labelLengthTotal.Name = "labelLengthTotal";
            this.labelLengthTotal.Size = new System.Drawing.Size(10, 13);
            this.labelLengthTotal.TabIndex = 28;
            this.labelLengthTotal.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Longueur total:";
            // 
            // labelLengthCurrent
            // 
            this.labelLengthCurrent.AutoSize = true;
            this.labelLengthCurrent.Location = new System.Drawing.Point(568, 109);
            this.labelLengthCurrent.Name = "labelLengthCurrent";
            this.labelLengthCurrent.Size = new System.Drawing.Size(10, 13);
            this.labelLengthCurrent.TabIndex = 30;
            this.labelLengthCurrent.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Longueur courante:";
            // 
            // timerMain
            // 
            this.timerMain.Interval = 50;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // dataGridViewDyn
            // 
            this.dataGridViewDyn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewDyn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDyn.Location = new System.Drawing.Point(12, 26);
            this.dataGridViewDyn.Name = "dataGridViewDyn";
            this.dataGridViewDyn.Size = new System.Drawing.Size(395, 326);
            this.dataGridViewDyn.TabIndex = 31;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.numbersToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadOrderToolStripMenuItem,
            this.refreshOrderToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loadOrderToolStripMenuItem
            // 
            this.loadOrderToolStripMenuItem.Name = "loadOrderToolStripMenuItem";
            this.loadOrderToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.loadOrderToolStripMenuItem.Text = "Charger commande";
            this.loadOrderToolStripMenuItem.Click += new System.EventHandler(this.loadOrderToolStripMenuItem_Click);
            // 
            // refreshOrderToolStripMenuItem
            // 
            this.refreshOrderToolStripMenuItem.Name = "refreshOrderToolStripMenuItem";
            this.refreshOrderToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.refreshOrderToolStripMenuItem.Text = "Recharcher le tableau";
            this.refreshOrderToolStripMenuItem.Click += new System.EventHandler(this.refreshOrderToolStripMenuItem_Click);
            // 
            // numbersToolStripMenuItem
            // 
            this.numbersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetcuttingnbrToolStripMenuItem});
            this.numbersToolStripMenuItem.Name = "numbersToolStripMenuItem";
            this.numbersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.numbersToolStripMenuItem.Text = "Reset";
            // 
            // resetcuttingnbrToolStripMenuItem
            // 
            this.resetcuttingnbrToolStripMenuItem.Name = "resetcuttingnbrToolStripMenuItem";
            this.resetcuttingnbrToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.resetcuttingnbrToolStripMenuItem.Text = "Mize à zéro coupe";
            this.resetcuttingnbrToolStripMenuItem.Click += new System.EventHandler(this.resetcuttingnbrToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // labelBeforeCutting
            // 
            this.labelBeforeCutting.AutoSize = true;
            this.labelBeforeCutting.Location = new System.Drawing.Point(568, 129);
            this.labelBeforeCutting.Name = "labelBeforeCutting";
            this.labelBeforeCutting.Size = new System.Drawing.Size(10, 13);
            this.labelBeforeCutting.TabIndex = 34;
            this.labelBeforeCutting.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Avant coupe:";
            // 
            // numericUpDownCuttingLength
            // 
            this.numericUpDownCuttingLength.Location = new System.Drawing.Point(679, 130);
            this.numericUpDownCuttingLength.Name = "numericUpDownCuttingLength";
            this.numericUpDownCuttingLength.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCuttingLength.TabIndex = 35;
            this.numericUpDownCuttingLength.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkBoxAuto
            // 
            this.checkBoxAuto.AutoSize = true;
            this.checkBoxAuto.Location = new System.Drawing.Point(419, 35);
            this.checkBoxAuto.Name = "checkBoxAuto";
            this.checkBoxAuto.Size = new System.Drawing.Size(85, 17);
            this.checkBoxAuto.TabIndex = 36;
            this.checkBoxAuto.Text = "Automatique";
            this.checkBoxAuto.UseVisualStyleBackColor = true;
            this.checkBoxAuto.CheckedChanged += new System.EventHandler(this.checkBoxAuto_CheckedChanged);
            // 
            // FormSaw
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 364);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxAuto);
            this.Controls.Add(this.numericUpDownCuttingLength);
            this.Controls.Add(this.labelBeforeCutting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewDyn);
            this.Controls.Add(this.labelLengthCurrent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelLengthTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownCutHeight);
            this.Controls.Add(this.labelCutNbr);
            this.Controls.Add(this.FreeLabel1);
            this.Controls.Add(this.checkBoxCutLimit);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.progressBarLength);
            this.Controls.Add(this.vScrollBarPresureRight);
            this.Controls.Add(this.vScrollBarPressureLeft);
            this.Controls.Add(this.progressBarCutting);
            this.Controls.Add(this.buttonCut);
            this.Controls.Add(this.checkBoxCutRight);
            this.Controls.Add(this.checkBoxCutLeft);
            this.Controls.Add(this.labelCutRight);
            this.Controls.Add(this.labelCutLeft);
            this.Controls.Add(this.trackBarCutRight);
            this.Controls.Add(this.trackBarCutLeft);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormSaw";
            this.ShowInTaskbar = false;
            this.Text = "Saw";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCutLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCutRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCutHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDyn)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCuttingLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarCutLeft;
        private System.Windows.Forms.TrackBar trackBarCutRight;
        private System.Windows.Forms.Label labelCutLeft;
        private System.Windows.Forms.Label labelCutRight;
        private System.Windows.Forms.CheckBox checkBoxCutLeft;
        private System.Windows.Forms.CheckBox checkBoxCutRight;
        private System.Windows.Forms.Button buttonCut;
        private System.Windows.Forms.ProgressBar progressBarCutting;
        private System.Windows.Forms.Timer timerCuttingProcess;
        private System.Windows.Forms.Timer timerCuttingReset;
        private System.Windows.Forms.VScrollBar vScrollBarPressureLeft;
        private System.Windows.Forms.VScrollBar vScrollBarPresureRight;
        private System.Windows.Forms.Timer timerPressureProccess;
        private System.Windows.Forms.Timer timerPressureReset;
        private System.Windows.Forms.ProgressBar progressBarLength;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.CheckBox checkBoxCutLimit;
        private System.Windows.Forms.Label FreeLabel1;
        private System.Windows.Forms.Label labelCutNbr;
        private System.Windows.Forms.NumericUpDown numericUpDownCutHeight;
        private System.Windows.Forms.Label labelLengthTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLengthCurrent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.DataGridView dataGridViewDyn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshOrderToolStripMenuItem;
        private System.Windows.Forms.Label labelBeforeCutting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownCuttingLength;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxAuto;
        private System.Windows.Forms.ToolStripMenuItem resetcuttingnbrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numbersToolStripMenuItem;
    }
}