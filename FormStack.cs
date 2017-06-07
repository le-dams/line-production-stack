using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsoMetall
{
    public partial class FormStack : Form
    {
        private Button openButton = null;

        // CheckPoint
        private Boolean proccess = false;
        private int lengthProccess = 0;

        // Vars
        private int speed = 1;
        private int maxLength = 15000;
        private Sheet currentSheet = null;
        private int stackNbr = 0;

        // Push
        private int pushLimit = 100;
        private int pushPosition = 0;
        private int pushDirection = 1;
        private int pushSpeed = 5;
        private int pushSpeedReset = 10;
        private Boolean pushEnd = false;

        public FormStack()
        {
            InitializeComponent();

            this.timerInfos.Interval = 100;
            this.timerInfos.Start();

            //this.setCurrentSheet(new Sheet(1, 5000, 1085, 140, 80, 0));
            this.init();
        }

        public Boolean inProccess()
        {
            return this.proccess;
        }

        private void init()
        {
            this.progressBarMaxLength.Maximum = maxLength;
            this.progressBarProccess.Maximum = maxLength;
            this.trackBarPush.Maximum = this.pushLimit;

            if(currentSheet != null)
            {
                this.progressBarMaxLength.Value = this.stopLength();
            }
        }

        public void setOpenButton(Button inButton)
        {
            this.openButton = inButton;
        }

        // Setter

        private void setCurrentSheet(Sheet inSheet)
        {
            this.currentSheet = inSheet;
        }

        public void importSheet(Sheet inSheet)
        {
            this.setCurrentSheet(inSheet);
            this.startProccess();
        }

        public void setSpeed(int inSpeed)
        {
            this.speed = inSpeed;
        }

        // Do

        private void refreshValues()
        {
            this.labelLengthProccess.Text = this.lengthProccess.ToString();
            this.labelLength.Text = this.stopLength().ToString();
            this.labelMaxLength.Text = this.maxLength.ToString();
            this.checkBoxProccess.Checked = this.proccess;
            this.labelStackNbr.Text = this.stackNbr.ToString();
            this.trackBarPush.Value = this.pushPosition;

            if (lengthProccess <= progressBarProccess.Maximum)
            {
                this.progressBarProccess.Value = lengthProccess;
            }
        }

        private int stopLength()
        {
            if(currentSheet != null)
            {
                return currentSheet.getLength();
            }
            else
            {
                return maxLength;
            }
        }

        // Proccess

        private void startProccess()
        {
            // Buttons
            this.buttonStart.Enabled = false;
            this.buttonStop.Enabled = true;

            this.timerProccess.Start();
        }

        private void stopProccess()
        {
            // Buttons
            this.buttonStart.Enabled = true;
            this.buttonStop.Enabled = false;

            this.timerProccess.Stop();
        }

        private void doProccess()
        {
            int newValue = this.lengthProccess + this.speed * 100;

            if (newValue >= this.stopLength())
            {
                this.lengthProccess = this.stopLength();
                
                // Success position
                int newValuePush = 0;

                // Do
                if(this.pushDirection == 1)
                {
                    newValuePush = this.pushPosition + (this.pushSpeed * pushDirection);
                }

                // Reset
                else if (this.pushDirection == -1)
                {
                    newValuePush = this.pushPosition + (this.pushSpeedReset * pushDirection);
                }

                if(newValuePush >= this.pushLimit && pushDirection == 1)
                {
                    // Reset
                    this.proccess = false;
                    this.pushEnd = true;
                    this.pushDirection = -1;
                    this.pushPosition = this.pushLimit;
                }
                else if(newValuePush <= 0 && pushDirection == -1)
                {
                    this.pushPosition = 0;

                    // Stop
                    this.stopProccess();

                    // Clear
                    this.lengthProccess = 0;
                    ++this.stackNbr;
                    this.pushDirection = 1;
                }
                else
                {
                    this.pushPosition = newValuePush;
                }


            }
            else
            {
                this.lengthProccess = newValue;
                this.proccess = true;
            }
        }

        // Actions
        private void timerProccess_Tick(object sender, EventArgs e)
        {
            this.doProccess();
        }

        private void timerInfos_Tick(object sender, EventArgs e)
        {
            this.refreshValues();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.startProccess();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.stopProccess();
        }

        private void numericUpDownSpeed_ValueChanged(object sender, EventArgs e)
        {
            this.setSpeed(Convert.ToInt32(this.numericUpDownSpeed.Value));
        }

        private void FormStack_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            this.openButton.Enabled = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.openButton.Enabled = true;
        }
    }
}
