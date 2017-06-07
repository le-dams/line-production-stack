namespace IsoMetall
{
    partial class FormOrder
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
            this.checkBoxIsRoof = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownOrderWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOnde = new System.Windows.Forms.ComboBox();
            this.comboBoxHeight = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrderWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxIsRoof
            // 
            this.checkBoxIsRoof.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxIsRoof.AutoSize = true;
            this.checkBoxIsRoof.Location = new System.Drawing.Point(123, 65);
            this.checkBoxIsRoof.Name = "checkBoxIsRoof";
            this.checkBoxIsRoof.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsRoof.TabIndex = 66;
            this.checkBoxIsRoof.UseVisualStyleBackColor = true;
            this.checkBoxIsRoof.CheckedChanged += new System.EventHandler(this.checkBoxIsRoof_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Toiture:";
            // 
            // numericUpDownOrderWidth
            // 
            this.numericUpDownOrderWidth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownOrderWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownOrderWidth.Location = new System.Drawing.Point(123, 131);
            this.numericUpDownOrderWidth.Maximum = new decimal(new int[] {
            1400,
            0,
            0,
            0});
            this.numericUpDownOrderWidth.Name = "numericUpDownOrderWidth";
            this.numericUpDownOrderWidth.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownOrderWidth.TabIndex = 64;
            this.numericUpDownOrderWidth.ValueChanged += new System.EventHandler(this.numericUpDownOrderWidth_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Hauteur:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Largeur:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 67;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.hidden);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Ondes:";
            // 
            // comboBoxOnde
            // 
            this.comboBoxOnde.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxOnde.FormattingEnabled = true;
            this.comboBoxOnde.Location = new System.Drawing.Point(123, 166);
            this.comboBoxOnde.Name = "comboBoxOnde";
            this.comboBoxOnde.Size = new System.Drawing.Size(66, 21);
            this.comboBoxOnde.TabIndex = 69;
            this.comboBoxOnde.SelectedIndexChanged += new System.EventHandler(this.comboBoxOnde_SelectedIndexChanged);
            // 
            // comboBoxHeight
            // 
            this.comboBoxHeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxHeight.FormattingEnabled = true;
            this.comboBoxHeight.Location = new System.Drawing.Point(123, 90);
            this.comboBoxHeight.Name = "comboBoxHeight";
            this.comboBoxHeight.Size = new System.Drawing.Size(66, 21);
            this.comboBoxHeight.TabIndex = 70;
            this.comboBoxHeight.SelectedIndexChanged += new System.EventHandler(this.comboBoxHeight_SelectedIndexChanged);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 252);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxHeight);
            this.Controls.Add(this.comboBoxOnde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxIsRoof);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownOrderWidth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrderWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxIsRoof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownOrderWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOnde;
        private System.Windows.Forms.ComboBox comboBoxHeight;
    }
}