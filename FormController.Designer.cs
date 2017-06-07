namespace IsoMetall
{
    partial class FormController
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
            this.labelFree7 = new System.Windows.Forms.Label();
            this.labelOrderLength = new System.Windows.Forms.Label();
            this.timerProduction = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonOpenSaw = new System.Windows.Forms.Button();
            this.buttonOpenGlueTop = new System.Windows.Forms.Button();
            this.buttonOpenStack = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.dataGridViewDyn = new System.Windows.Forms.DataGridView();
            this.timerInfo = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDeTôlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viderLaCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betaOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSheet = new System.Windows.Forms.Panel();
            this.panelCurrentSheet = new System.Windows.Forms.Panel();
            this.buttonInnerCoil = new System.Windows.Forms.Button();
            this.buttonUpperCoil = new System.Windows.Forms.Button();
            this.buttonInnibition = new System.Windows.Forms.Button();
            this.buttonOpenGlueBottom = new System.Windows.Forms.Button();
            this.ToolStripMenuItemSettingsOrder = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDyn)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelSheet.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFree7
            // 
            this.labelFree7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFree7.AutoSize = true;
            this.labelFree7.Location = new System.Drawing.Point(460, 42);
            this.labelFree7.Name = "labelFree7";
            this.labelFree7.Size = new System.Drawing.Size(63, 13);
            this.labelFree7.TabIndex = 16;
            this.labelFree7.Text = "Commande:";
            // 
            // labelOrderLength
            // 
            this.labelOrderLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOrderLength.AutoSize = true;
            this.labelOrderLength.Location = new System.Drawing.Point(528, 42);
            this.labelOrderLength.Name = "labelOrderLength";
            this.labelOrderLength.Size = new System.Drawing.Size(10, 13);
            this.labelOrderLength.TabIndex = 15;
            this.labelOrderLength.Text = "-";
            // 
            // timerProduction
            // 
            this.timerProduction.Tick += new System.EventHandler(this.timerProduction_Tick);
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSpeed.Location = new System.Drawing.Point(767, 104);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownSpeed.TabIndex = 18;
            this.numericUpDownSpeed.ValueChanged += new System.EventHandler(this.numericUpDownSpeed_ValueChanged);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(767, 130);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 51);
            this.buttonStop.TabIndex = 19;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(767, 42);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 51);
            this.buttonStart.TabIndex = 20;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonOpenSaw
            // 
            this.buttonOpenSaw.Location = new System.Drawing.Point(617, 343);
            this.buttonOpenSaw.Name = "buttonOpenSaw";
            this.buttonOpenSaw.Size = new System.Drawing.Size(75, 60);
            this.buttonOpenSaw.TabIndex = 21;
            this.buttonOpenSaw.Text = "Scie";
            this.buttonOpenSaw.UseVisualStyleBackColor = true;
            this.buttonOpenSaw.Click += new System.EventHandler(this.buttonOpenSaw_Click);
            // 
            // buttonOpenGlueTop
            // 
            this.buttonOpenGlueTop.Location = new System.Drawing.Point(367, 343);
            this.buttonOpenGlueTop.Name = "buttonOpenGlueTop";
            this.buttonOpenGlueTop.Size = new System.Drawing.Size(125, 60);
            this.buttonOpenGlueTop.TabIndex = 22;
            this.buttonOpenGlueTop.Text = "Colle Supérieur";
            this.buttonOpenGlueTop.UseVisualStyleBackColor = true;
            this.buttonOpenGlueTop.Click += new System.EventHandler(this.buttonOpenGlue_Click);
            // 
            // buttonOpenStack
            // 
            this.buttonOpenStack.Location = new System.Drawing.Point(767, 405);
            this.buttonOpenStack.Name = "buttonOpenStack";
            this.buttonOpenStack.Size = new System.Drawing.Size(75, 60);
            this.buttonOpenStack.TabIndex = 24;
            this.buttonOpenStack.Text = "Empillage";
            this.buttonOpenStack.UseVisualStyleBackColor = true;
            this.buttonOpenStack.Click += new System.EventHandler(this.buttonOpenStack_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 552);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(857, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // dataGridViewDyn
            // 
            this.dataGridViewDyn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewDyn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDyn.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewDyn.Name = "dataGridViewDyn";
            this.dataGridViewDyn.Size = new System.Drawing.Size(405, 272);
            this.dataGridViewDyn.TabIndex = 30;
            // 
            // timerInfo
            // 
            this.timerInfo.Tick += new System.EventHandler(this.timerInfo_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDeTôlesToolStripMenuItem,
            this.viderLaCommandeToolStripMenuItem,
            this.betaOrderToolStripMenuItem,
            this.ToolStripMenuItemSettingsOrder});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // ajoutDeTôlesToolStripMenuItem
            // 
            this.ajoutDeTôlesToolStripMenuItem.Name = "ajoutDeTôlesToolStripMenuItem";
            this.ajoutDeTôlesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.ajoutDeTôlesToolStripMenuItem.Text = "Ajout de tôles";
            this.ajoutDeTôlesToolStripMenuItem.Click += new System.EventHandler(this.buttonAddSheet_Click);
            // 
            // viderLaCommandeToolStripMenuItem
            // 
            this.viderLaCommandeToolStripMenuItem.Name = "viderLaCommandeToolStripMenuItem";
            this.viderLaCommandeToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.viderLaCommandeToolStripMenuItem.Text = "Vider la commande";
            this.viderLaCommandeToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemEmptyOrder_Click);
            // 
            // betaOrderToolStripMenuItem
            // 
            this.betaOrderToolStripMenuItem.Name = "betaOrderToolStripMenuItem";
            this.betaOrderToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.betaOrderToolStripMenuItem.Text = "Commande Bêta";
            this.betaOrderToolStripMenuItem.Click += new System.EventHandler(this.betaOrderToolStripMenuItem_Click);
            // 
            // panelSheet
            // 
            this.panelSheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSheet.Controls.Add(this.panelCurrentSheet);
            this.panelSheet.Location = new System.Drawing.Point(15, 418);
            this.panelSheet.Name = "panelSheet";
            this.panelSheet.Size = new System.Drawing.Size(716, 38);
            this.panelSheet.TabIndex = 34;
            // 
            // panelCurrentSheet
            // 
            this.panelCurrentSheet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelCurrentSheet.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelCurrentSheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCurrentSheet.Location = new System.Drawing.Point(-36, 3);
            this.panelCurrentSheet.Name = "panelCurrentSheet";
            this.panelCurrentSheet.Size = new System.Drawing.Size(130, 30);
            this.panelCurrentSheet.TabIndex = 0;
            // 
            // buttonInnerCoil
            // 
            this.buttonInnerCoil.Location = new System.Drawing.Point(15, 343);
            this.buttonInnerCoil.Name = "buttonInnerCoil";
            this.buttonInnerCoil.Size = new System.Drawing.Size(75, 60);
            this.buttonInnerCoil.TabIndex = 41;
            this.buttonInnerCoil.Text = "Inner";
            this.buttonInnerCoil.UseVisualStyleBackColor = true;
            this.buttonInnerCoil.Click += new System.EventHandler(this.buttonInnerCoil_Click);
            // 
            // buttonUpperCoil
            // 
            this.buttonUpperCoil.Location = new System.Drawing.Point(82, 462);
            this.buttonUpperCoil.Name = "buttonUpperCoil";
            this.buttonUpperCoil.Size = new System.Drawing.Size(75, 60);
            this.buttonUpperCoil.TabIndex = 42;
            this.buttonUpperCoil.Text = "Upper";
            this.buttonUpperCoil.UseVisualStyleBackColor = true;
            this.buttonUpperCoil.Click += new System.EventHandler(this.buttonUpperCoil_Click);
            // 
            // buttonInnibition
            // 
            this.buttonInnibition.Location = new System.Drawing.Point(179, 343);
            this.buttonInnibition.Name = "buttonInnibition";
            this.buttonInnibition.Size = new System.Drawing.Size(75, 60);
            this.buttonInnibition.TabIndex = 43;
            this.buttonInnibition.Text = "Innibition";
            this.buttonInnibition.UseVisualStyleBackColor = true;
            this.buttonInnibition.Click += new System.EventHandler(this.buttonInnibition_Click);
            // 
            // buttonOpenGlueBottom
            // 
            this.buttonOpenGlueBottom.Location = new System.Drawing.Point(367, 471);
            this.buttonOpenGlueBottom.Name = "buttonOpenGlueBottom";
            this.buttonOpenGlueBottom.Size = new System.Drawing.Size(125, 60);
            this.buttonOpenGlueBottom.TabIndex = 58;
            this.buttonOpenGlueBottom.Text = "Colle Inférieur";
            this.buttonOpenGlueBottom.UseVisualStyleBackColor = true;
            this.buttonOpenGlueBottom.Click += new System.EventHandler(this.buttonOpenGlueBottom_Click);
            // 
            // ToolStripMenuItemSettingsOrder
            // 
            this.ToolStripMenuItemSettingsOrder.Name = "ToolStripMenuItemSettingsOrder";
            this.ToolStripMenuItemSettingsOrder.Size = new System.Drawing.Size(208, 22);
            this.ToolStripMenuItemSettingsOrder.Text = "Paramêtre de commande";
            this.ToolStripMenuItemSettingsOrder.Click += new System.EventHandler(this.ToolStripMenuItemSettingsOrder_Click);
            // 
            // FormController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 574);
            this.Controls.Add(this.buttonOpenGlueBottom);
            this.Controls.Add(this.buttonInnibition);
            this.Controls.Add(this.buttonUpperCoil);
            this.Controls.Add(this.buttonInnerCoil);
            this.Controls.Add(this.panelSheet);
            this.Controls.Add(this.buttonOpenStack);
            this.Controls.Add(this.dataGridViewDyn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonOpenGlueTop);
            this.Controls.Add(this.buttonOpenSaw);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.numericUpDownSpeed);
            this.Controls.Add(this.labelFree7);
            this.Controls.Add(this.labelOrderLength);
            this.Name = "FormController";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormController_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormController_FormClosed);
            this.Load += new System.EventHandler(this.FormController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDyn)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSheet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFree7;
        private System.Windows.Forms.Label labelOrderLength;
        private System.Windows.Forms.Timer timerProduction;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonOpenSaw;
        private System.Windows.Forms.Button buttonOpenGlueTop;
        private System.Windows.Forms.Button buttonOpenStack;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dataGridViewDyn;
        private System.Windows.Forms.Timer timerInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDeTôlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viderLaCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Panel panelSheet;
        private System.Windows.Forms.Panel panelCurrentSheet;
        private System.Windows.Forms.Button buttonInnerCoil;
        private System.Windows.Forms.Button buttonUpperCoil;
        private System.Windows.Forms.Button buttonInnibition;
        private System.Windows.Forms.ToolStripMenuItem betaOrderToolStripMenuItem;
        private System.Windows.Forms.Button buttonOpenGlueBottom;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettingsOrder;
    }
}

