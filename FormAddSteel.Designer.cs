namespace IsoMetall
{
    partial class FormAddSteel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownLength = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCutLeft = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCutRigth = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.timerInfo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCutLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCutRigth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Longueur:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Débord gauche:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Débord droit:";
            // 
            // numericUpDownLength
            // 
            this.numericUpDownLength.Location = new System.Drawing.Point(136, 93);
            this.numericUpDownLength.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.numericUpDownLength.Name = "numericUpDownLength";
            this.numericUpDownLength.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLength.TabIndex = 5;
            // 
            // numericUpDownCutLeft
            // 
            this.numericUpDownCutLeft.Location = new System.Drawing.Point(136, 140);
            this.numericUpDownCutLeft.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCutLeft.Name = "numericUpDownCutLeft";
            this.numericUpDownCutLeft.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCutLeft.TabIndex = 8;
            // 
            // numericUpDownCutRigth
            // 
            this.numericUpDownCutRigth.Location = new System.Drawing.Point(136, 183);
            this.numericUpDownCutRigth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCutRigth.Name = "numericUpDownCutRigth";
            this.numericUpDownCutRigth.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCutRigth.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(136, 39);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timerInfo
            // 
            this.timerInfo.Tick += new System.EventHandler(this.timerInfo_Tick);
            // 
            // FormAddSteel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 263);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownCutRigth);
            this.Controls.Add(this.numericUpDownCutLeft);
            this.Controls.Add(this.numericUpDownLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormAddSteel";
            this.Text = "FormAddSteel";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCutLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCutRigth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownLength;
        private System.Windows.Forms.NumericUpDown numericUpDownCutLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownCutRigth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timerInfo;
    }
}