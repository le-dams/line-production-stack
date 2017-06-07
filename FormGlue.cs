using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;

namespace IsoMetall
{
    public partial class FormGlue : Form
    {
        const Boolean outDevice = false;

        private String glueName = "";
        private FormController mainForm = null;

        CultureInfo ci = new CultureInfo("fr-be");

        // Infos

            // Conso
            private int topDistanceLength = 0;

                // Recouvrement
                private float sprayCurrent    = 0;
                private float sprayComplete   = 0;
                private int sprayGrammage   = 220;

                // Position
                private int goTo = -1;
                private int goToSpeed = 20;

        private Boolean     isPopUp = false;
        private Button      openButton = null;
        private Boolean     glueTopStart = false;
        private Boolean     glueTopAction = false;
        private Boolean     rinseTopProccess = false;

        private int rinseTopTimeI = 0;

        private int rinseTopTime = Config.GLUE_RINSE_TOP_TIME;

        private int glueTopPosition = 0;

        // Speed
        private int glueTopSpeed = 1;

        private int glueTopDirection = 1;

        private int glueTopMin = 0;
        private int glueTopMax = 0;

        private int length = 1085;

        private Device device = new Device();

        public FormGlue(String glueName = "Colle")
        {
            InitializeComponent();

            this.setGlueName(glueName);

            this.initGlue();
            this.initSpray();

            // Refresh Values
            this.refreshValues();

                this.timerInfos.Interval = 90;
                this.timerInfos.Start();

                this.setLength(1085);

            // Slide
            this.timerGlueTop.Interval = 10;
            this.timerGlueTop.Start();
        }

        public decimal getPosition_pc()
        {
            return Convert.ToInt32(this.glueTopPosition * 100 / Config.MAIN_WIDTH_MAX*1.8);
        }

        // Spray

        private void initSpray()
        {
            // Timer
            this.timerSpray.Interval = 1000;
            this.timerSpray.Start();

            // Value
            this.numericUpDownSprayGrammage.Value = this.sprayGrammage;
        }

        private void useSpray()
        {
            if(this.glueTopAction == true)
            {
                int speed = this.glueTopStart ? (this.glueTopSpeed > 0 ? this.glueTopSpeed : 1) : 1;
                float use = this.sprayGrammage / 60;

                this.sprayCurrent += use;
                this.sprayComplete += use;
            }
        }

        private void setSprayGrammage(int grammage)
        {
            this.sprayGrammage = grammage;
        }

        private void initGlue()
        {
            if (outDevice)
            {
                this.device.setLimit(Config.MAIN_WIDTH_MAX);
            }

            this.trackBarGlueTop.Maximum = Config.MAIN_WIDTH_MAX;

            this.labelLengthMax.Text = Config.MAIN_WIDTH_MAX.ToString();

            this.numericUpDownTopMin.Maximum = Config.MAIN_WIDTH_MAX;
            this.numericUpDownTopMax.Maximum = Config.MAIN_WIDTH_MAX;

            this.numericUpDownWidth.Maximum = Config.MAIN_WIDTH_MAX;
            this.numericUpDownWidth.Minimum = 2;
            this.numericUpDownWidth.Value = this.length;

            this.numericUpDownTopSpeed.Maximum = Config.GLUE_SPEED_MAX;

            this.numericUpDownTopRinse.Value = this.rinseTopTime;

            int cover = (Config.MAIN_WIDTH_MAX - this.length) / 2;

            // Top
            this.glueTopMin = cover;
            this.glueTopMax = Config.MAIN_WIDTH_MAX - cover;

            // Rinse
            this.timerRinse.Interval = 100;
        }

        public void setGlueName(String glueName)
        {
            this.glueName = glueName;
        }

        public void setPopUp(Boolean action = true)
        {
            this.isPopUp = action;
            if(action)
            {
                this.ControlBox = false;
                this.ShowIcon = false;
                this.ShowInTaskbar = false;
            }
            else
            {
                this.ControlBox = true;
                this.ShowIcon = true;
                this.ShowInTaskbar = true;
            }
        }

        public void setMainForm(FormController inMainForm)
        {
            this.mainForm = inMainForm;
        }

        public Boolean inProccess()
        {
            if(this.glueTopStart)
            {
                return true;
            }
            return false;
        }

        public Color colorProccess()
        {
            Boolean slide = (this.glueTopStart) ? true : false;
            Boolean action = (this.glueTopAction) ? true : false;

            if(rinseTopProccess)
            {
                return Color.Red;
            }
            else if(slide && action)
            {
                return Color.Green;
            }
            else if(slide || action)
            {
                return Color.Orange;
            }
            else
            {
                return Color.Red;
            }
        }

        // Refresh

        public void setOpenButton(Button inButton)
        {
            this.openButton = inButton;
        }

        private void refreshValues()
        {
            //Use
            this.Text = this.glueName;

            this.numericUpDownTopMin.Value = this.glueTopMin;
            this.numericUpDownTopMax.Value = this.glueTopMax;

            this.trackBarGlueTop.Value = glueTopPosition;

            this.labelGlueTop.Text = this.glueTopPosition.ToString();

            this.numericUpDownTopSpeed.Value = this.glueTopSpeed;

            this.labelSprayRinse.Text = (this.sprayCurrent/1000).ToString();
            this.labelSprayChanged.Text = (this.sprayComplete/ 1000).ToString();
            
            // Action
            if(this.glueTopAction == true)
            {
                this.buttonTopActionStart.Enabled = false;
                this.buttonTopActionStop.Enabled = true;
            }
            else
            {
                this.buttonTopActionStart.Enabled = true;
                this.buttonTopActionStop.Enabled = false;
            }

            // Rinse
            this.buttonRinseTop.BackColor = this.rinseTopProccess ? Color.Orange : System.Drawing.SystemColors.Control;


            if (outDevice)
            {
                // Devices
                this.device.setValue(this.glueTopPosition);
                this.device.setPosition();

                if (this.rinseTopProccess)
                {
                    this.device.blink();
                }
                else if (this.glueTopAction)
                {
                    this.device.open();
                }
                else
                {
                    this.device.close();
                }
            }
        }

        // Setter

        public void setLength(int inLength)
        {
            this.length = inLength;
            this.initGlue();
        }

        // Proccess

        public void rinseProccess()
        {
            if (this.rinseTopProccess)
            {
                if (this.rinseTopTimeI >= this.rinseTopTime)
                {
                    this.rinseTopProccess = false;
                    this.rinseTopTimeI = 0;
                }
                ++this.rinseTopTimeI;
            }

            if(!this.rinseTopProccess)
            {
                this.timerRinse.Stop();
                this.setGoTo(1);
            }
        }

        public void rinseTop(Boolean start)
        {
            this.setGoTo(1400);

            this.rinseTopProccess = start;
            this.timerRinse.Start();

            this.sprayCurrent = 0;
        }

        public void actionTop(Boolean start)
        {
             this.glueTopAction = start;
        }

        public void startTop()
        {
            //this.resetGlue(false);

            // Buttons
            this.buttonTopStart.Enabled = false;
            this.buttonTopStop.Enabled = true;

            this.glueTopStart = true;
        }

        public void stopTop()
        {
            // Buttons
            this.buttonTopStart.Enabled = true;
            this.buttonTopStop.Enabled = false;


            this.glueTopStart = false;

        }

        private void setPositionTop(int inPosition)
        {
            this.glueTopPosition = inPosition;
        }

        private void setGoTo(int position = -1,int speed = 12)
        {
            this.goTo = position;
            if(position == -1)
            {
                this.glueTopStart = false;
            }
            else if(position >= 0 && position <= Config.MAIN_WIDTH_MAX)
            {
                this.goToSpeed = speed;
                this.glueTopStart = true;

                if (this.goTo > this.glueTopPosition)
                {
                    this.glueTopDirection = 1;
                }
                else if (this.goTo < this.glueTopPosition)
                {
                    this.glueTopDirection = -1;
                }
            }
        }

        private void glueSlideTop()
        {
            int newPosition = -1;

            if (glueTopStart == true && this.goTo == -1)
            {
                newPosition = (this.glueTopPosition + (1 * this.glueTopSpeed * this.glueTopDirection));
                if (newPosition < glueTopMax && newPosition > glueTopMin)
                {
                    this.setPositionTop(newPosition);
                }
                else if (newPosition >= glueTopMax)
                {
                    this.setPositionTop(glueTopMax);
                    this.glueTopDirection *= -1;
                }
                else if (newPosition <= glueTopMin)
                {
                    this.setPositionTop(glueTopMin);
                    this.glueTopDirection *= -1;
                }
            }
            else if(this.goTo >= 0)
            {
                int max = this.goTo;
                newPosition = (this.glueTopPosition + (1 * this.goToSpeed * this.glueTopDirection));

                if(newPosition <= 0)
                {
                    newPosition = 0;
                    this.setGoTo();
                }
                else if(newPosition >= max)
                {
                    newPosition = max;
                    this.setGoTo();
                }
                else if (this.goTo == this.glueTopPosition)
                {
                    newPosition = -1;
                    this.setGoTo();
                }
                
                if(newPosition >= 0)
                {
                    this.setPositionTop(newPosition);
                }
            }
        }

        public void setSpeedTop(int speed)
        {
            if (speed <= Config.GLUE_SPEED_MAX)
            {
                this.glueTopSpeed = speed;
            }
        }

        private void resetGlue(Boolean proccess)
        {
            this.resetTop(proccess);
        }

        private void resetTop(Boolean proccess,Boolean standalone = false)
        {
            this.setGoTo(0);
        }

        public void Off()
        {

            if (outDevice)
            {
                this.device.Stop();
            }
        }

        public void Secure()
        {
            this.rinseTop(true);
        }

        // Action

        private void timerGlueTop_Tick(object sender, EventArgs e)
        {
            this.glueSlideTop();
        }

        private void timerInfos_Tick(object sender, EventArgs e)
        {
            this.refreshValues();
        }

        private void numericUpDownTopMin_ValueChanged(object sender, EventArgs e)
        {
            this.glueTopMin = Convert.ToInt32(this.numericUpDownTopMin.Value);
        }

        private void numericUpDownTopMax_ValueChanged(object sender, EventArgs e)
        {
            this.glueTopMax = Convert.ToInt32(this.numericUpDownTopMax.Value);
        }

        private void buttonTopStart_Click(object sender, EventArgs e)
        {
            this.startTop();
        }

        private void numericUpDownTopSpeed_ValueChanged(object sender, EventArgs e)
        {
            this.setSpeedTop(Convert.ToInt32(this.numericUpDownTopSpeed.Value));
        }

        private void buttonTopStop_Click(object sender, EventArgs e)
        {
            this.stopTop();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.resetGlue(true);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (this.isPopUp == true)
            {
                this.Visible = false;
                this.openButton.Enabled = true;
            }
        }

        private void buttonTopActionStart_Click(object sender, EventArgs e)
        {
            this.actionTop(true);
        }

        private void buttonTopActionStop_Click(object sender, EventArgs e)
        {
            this.actionTop(false);
        }

        private void timerRinse_Tick(object sender, EventArgs e)
        {
            this.rinseProccess();
        }

        private void buttonRinseTop_Click(object sender, EventArgs e)
        {
            this.rinseTop(true);
        }

        private void buttonResetTop_Click(object sender, EventArgs e)
        {
            this.resetTop(true);
        }

        // Load

        // Open
        private void FormGlue_Load(object sender, EventArgs e)
        {

            if (outDevice)
            {
                this.device.Start();
            }
        }

        // Close
        private void FormGlue_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Off();
        }

        private void numericUpDownTopSpray_ValueChanged(object sender, EventArgs e)
        {
            this.rinseTopTime = Convert.ToInt32(this.numericUpDownTopRinse.Value);
        }

        private void buttonResetBoth_Click(object sender, EventArgs e)
        {
            this.resetTop(true);
        }

        private void timerSpray_Tick(object sender, EventArgs e)
        {
            this.useSpray();
        }

        private void numericUpDownSprayGrammage_ValueChanged(object sender, EventArgs e)
        {
            this.setSprayGrammage(Convert.ToInt32(this.numericUpDownSprayGrammage.Value));
        }

        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            this.setLength(Convert.ToInt32(this.numericUpDownWidth.Value));
        }
    }
}
