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
    public partial class FormSaw : Form
    {
        private Button openButton = null;
        private FormController mainForm = null;
        private Boolean isAuto = true;

        // List informations
        private List<Label> labelsCut = new List<Label>();

        // Sheets
        private Sheet currentSheet = null;

        // Length
        private int lengthTotal = 0;
        private int lengthCurrent = 0;
        private int cuttingLength = 0;
        private int cuttingLeft = 14000;

        // Cutting informations
        private int cutLeft = 0;
        private int cutRight = 0;
        private int cutHeight = 0;
        private int cutLength = 0;
        private int cutWidth = 0;
        private int cutNbr = 0;

        // Cutting options
        private Boolean cutLeftOn = false;
        private Boolean cutRightOn = false;
        private Boolean cutLimit = false;

        private Boolean cutOn = false;
        private Boolean pressureOn = false;

        // limit
        const int speedCuttingProcess = 100;
        const int speedCuttingReset = 500;
        const int speedPressure = 34;

        const int maxHeight = 240;
        const int maxWidth = 1400;
        const int maxLength = 14000;
        const int maxCutright = 300;
        const int maxCutLeft = 300;

        public FormSaw()
        {
            InitializeComponent();

            // Init
            this.checkBoxAuto.Checked = this.isAuto;
            this.progressBarLength.Maximum = maxLength;
            this.progressBarCutting.Maximum = maxWidth;
            this.numericUpDownCutHeight.Maximum = maxHeight;
            this.numericUpDownCuttingLength.Maximum = maxLength;

            this.timerCuttingProcess.Interval = 100;
            this.timerCuttingReset.Interval = 100;
            this.timerPressureProccess.Interval = 100;
            this.timerPressureReset.Interval = 100;

            this.addLabelCut(labelCutNbr);

            this.timerMain.Start();
        }

        public int getCuttingLef()
        {
            return this.cuttingLeft;
        }

        private void autoCutting()
        {
            if (this.mainForm.isStart() && this.lengthCurrent >= maxLength)
            {
                this.mainForm.halt();
            }
            else if (this.mainForm.isStart() && this.cuttingLeft == 0 && this.cutOn == false)
            {
                this.cutting();
            }
        }

        private List<Sheet> getMainListSheet()
        {
            return this.mainForm.getListSheet();
        }

        private void refreshDataGrid()
        {
            if (this.getMainListSheet().Count == 0)
            {
                dataGridViewDyn.DataSource = typeof(List<Sheet>);
                dataGridViewDyn.AutoResizeColumns();
                dataGridViewDyn.Refresh();
                if (this.cuttingLength == 0)
                {
                    this.setCuttingLength(maxLength);
                }
            }
            else if (getMainListSheet().Count > 0)
            {
                dataGridViewDyn.DataSource = typeof(List<Sheet>);
                dataGridViewDyn.DataSource = this.getMainListSheet();
                dataGridViewDyn.AutoResizeColumns();
                dataGridViewDyn.Refresh();

                this.importSheet();
            }
        }

        public Boolean inProccess()
        {
            return this.pressureOn;
        }

        // Load
        public void setOpenButton(Button inButton)
        {
            this.openButton = inButton;
        }

        public void setMainForm(FormController inMainForm)
        {
            this.mainForm = inMainForm;
        }

        public void importSheet()
        {
            if (this.getMainListSheet().Count > 0)
            {
                this.currentSheet = this.getMainListSheet().First();

                this.setCutLenght(this.currentSheet.getLength());
                this.setCutWidth(this.currentSheet.getWidth());
                this.setCutHeight(this.currentSheet.getHeigth());
                this.setCutRight(this.currentSheet.getCutRigth());
                this.setCutLeft(this.currentSheet.getCutLeft());
                this.setCuttingLength(this.currentSheet.getLength());
            }

            this.refreshValue();
        }

        public Sheet getCurrentSheet()
        {
            return getMainListSheet().Count > 0 ? getMainListSheet().First() : null;
        }

        public int getCutNbr()
        {
            return this.cutNbr;
        }

        public void incrementLengthTotal(int value)
        {
            this.lengthTotal = this.lengthTotal + value;
            this.lengthCurrent = this.lengthCurrent + value;
            this.cuttingLeft = (this.cuttingLeft - value) < 0 ? 0 : (this.cuttingLeft - value);
        }

        // Cutting process

        public void cutting()
        {
            // Count
            this.lengthCurrent = 0;
            this.setCuttingLength(this.cuttingLength);

            // Start
            this.timerCuttingProcess.Start();

            // Refresh
            this.refreshDataGrid();
            this.mainForm.refreshDataGrid();
        }

        // INformations
        public void addLabelCut(Label inLabel)
        {
            labelsCut.Add(inLabel);
        }

        // Main cutting process
        private void cuttingProcess(Timer useTimer)
        {
            this.cutOn = true;

            this.buttonStop.Enabled = true;

            if (this.currentSheet != null)
            {
                if (this.currentSheet.getCutLeft() > 0)
                {
                    this.switchCutLeft(true);
                }
                if (this.currentSheet.getCutRigth() > 0)
                {
                    this.switchCutRight(true);
                }
            }

            if (this.pressureOn == false)
            {
                this.timerPressureProccess.Start();
            }
            else
            {
                // Cut
                if (this.cutLimit == false)
                {
                    int newValue = this.progressBarCutting.Value + speedCuttingProcess;

                    if (progressBarCutting.Value == progressBarCutting.Maximum)
                    {
                        this.switchCutLimit(true);

                        // Send to Stack
                        if (currentSheet != null)
                        {
                            this.mainForm.injectInStack(currentSheet);
                            this.currentSheet = null;
                        }

                        // Reset
                        this.cuttingSuccess();
                        useTimer.Stop();
                        this.timerCuttingReset.Start();
                    }
                    if (newValue >= this.progressBarCutting.Maximum)
                    {
                        // Stop
                        progressBarCutting.Value = progressBarCutting.Maximum;

                    }
                    else
                    {
                        progressBarCutting.Value = newValue;
                    }
                }

                // Stop width error

                else
                {

                }
            }
        }

        private void cuttingReset(Timer useTimer)
        {
            if (this.pressureOn == true)
            {
                this.timerPressureReset.Start();
            }
            else
            {
                int newValue = this.progressBarCutting.Value - speedCuttingReset;

                if (newValue <= 0)
                {
                    progressBarCutting.Value = 0;
                    useTimer.Stop();

                    // Clear
                    this.switchCutLimit(false);
                    this.switchCutLeft(false);
                    this.switchCutRight(false);
                    this.buttonStop.Enabled = false;
                    this.cutOn = false;
                }
                else
                {
                    progressBarCutting.Value = newValue;
                }
            }
        }

        public void cuttingStop()
        {
            this.timerCuttingProcess.Stop();
            this.timerPressureProccess.Stop();

            this.timerCuttingReset.Stop();
            this.timerPressureReset.Stop();
        }

        private void cuttingSuccess()
        {
            this.setCutNbr();

            if(this.isAuto)
            {
                if (getMainListSheet().Count > 0)
                {
                    this.getMainListSheet().RemoveAt(0);
                }
                this.importSheet();
                this.refreshDataGrid();
            }
            else
            {
                //this.cuttingLength = maxLength;
            }
        }

        public void pressureProcess(Timer useTimer)
        {
            if (pressureOn == false)
            {
                int newValue = this.vScrollBarPressureLeft.Value + speedPressure;

                if (newValue >= this.vScrollBarPressureLeft.Maximum)
                {
                    this.vScrollBarPressureLeft.Value = this.vScrollBarPressureLeft.Maximum;

                    // Success
                    this.pressureOn = true;
                    useTimer.Stop();
                }
                else
                {
                    this.vScrollBarPressureLeft.Value = newValue;
                }
                this.vScrollBarPresureRight.Value = this.vScrollBarPressureLeft.Value;
            }
        }

        public void pressureReset(Timer useTimer)
        {
            if (pressureOn == true)
            {
                int newValue = this.vScrollBarPressureLeft.Value - speedPressure;

                if (newValue <= 0)
                {
                    this.vScrollBarPressureLeft.Value = 0;

                    // Success
                    this.pressureOn = false;
                    useTimer.Stop();
                }
                else
                {
                    this.vScrollBarPressureLeft.Value = newValue;
                }
                this.vScrollBarPresureRight.Value = this.vScrollBarPressureLeft.Value;
            }
        }

        // Values

        public void switchCutLimit(Boolean on)
        {
            this.cutLimit = on;
            this.refreshValue();
        }

        public void switchCutLeft(Boolean on)
        {
            this.cutLeftOn = on;
            this.refreshValue();
        }

        public void switchCutRight(Boolean on)
        {
            this.cutRightOn = on;
            this.refreshValue();
        }

        public void setCutNbr(int value = -1)
        {
            if(value == -1)
            {
                ++this.cutNbr;
            }
            else
            {
                this.cutNbr = value;
            }
            this.refreshValue();
        }

        public void setCutWidth(int value)
        {
            this.cutWidth = value;
            this.refreshValue();
        }

        public void setCutHeight(int value)
        {
            this.cutHeight = value;
            this.refreshValue();
        }

        public void setCutLenght(int value)
        {
            this.cutLength = value;
            this.refreshValue();
        }

        public void setCutLeft(int value)
        {
            this.cutLeft = value;
            this.refreshValue();
        }

        public void setCutRight(int value)
        {
            this.cutRight = value;
            this.refreshValue();
        }

        public void resetCuttingCount()
        {
            this.cutNbr = 0;
        }

        public void setCuttingLength(int inLength)
        {
            this.cuttingLength = inLength;
            this.cuttingLeft = inLength - this.lengthCurrent;
        }

        public void refreshValue()
        {
            // Label
            this.labelCutLeft.Text = this.cutLeft.ToString();
            this.labelCutRight.Text = this.cutRight.ToString();
            this.numericUpDownCutHeight.Text = this.cutHeight.ToString();
            this.numericUpDownCuttingLength.Value = this.cuttingLength;

                // Cuts
                foreach(Label iLabel in labelsCut)
                {
                    iLabel.Text = this.cutNbr.ToString();
                }

            // TrackBar
            this.trackBarCutLeft.Value = this.cutLeft;
            this.trackBarCutRight.Value = this.cutRight;

            // Switch
            this.checkBoxCutLeft.Checked = this.cutLeftOn;
            this.checkBoxCutRight.Checked = this.cutRightOn;

            // ProgressBar
            this.progressBarLength.Value = this.lengthCurrent <= this.progressBarLength.Maximum ? this.lengthCurrent : this.progressBarLength.Maximum;

            // Checkbox
            this.checkBoxCutLimit.Checked = this.cutLimit;

            // Length
            this.labelLengthCurrent.Text = this.lengthCurrent.ToString();
            this.labelLengthTotal.Text = this.lengthTotal.ToString();
            this.labelBeforeCutting.Text = this.cuttingLeft.ToString();

            // Enabled
            if(this.isAuto && this.getCurrentSheet() != null)
            {
                this.setCuttingLength(this.getCurrentSheet().getLength());
            }
            this.numericUpDownCuttingLength.Enabled = this.isAuto ? false : true;
        }

        private void trackBarCutRight_ValueChanged(object sender, EventArgs e)
        {
            TrackBar tBar = (TrackBar)sender;
            this.setCutRight(tBar.Value);
        }

        private void trackBarCutLeft_ValueChanged(object sender, EventArgs e)
        {
            TrackBar tBar = (TrackBar)sender;
            this.setCutLeft(tBar.Value);
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            this.cutting();
        }

        private void checkBoxCutLeftOrRight_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            this.switchCutLeft(checkbox.Checked);
        }

        private void timerCutting_Tick(object sender, EventArgs e)
        {
            Timer useTimer = (Timer)sender;
            this.cuttingProcess(useTimer);
        }

        private void timerCuttingReset_Tick(object sender, EventArgs e)
        {
            Timer useTimer = (Timer)sender;
            this.cuttingReset(useTimer);
        }

        private void timerPressure_Tick(object sender, EventArgs e)
        {
            Timer useTimer = (Timer)sender;
            this.pressureProcess(useTimer);
        }

        private void timerPressureReset_Tick(object sender, EventArgs e)
        {
            Timer useTimer = (Timer)sender;
            this.pressureReset(useTimer);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.cuttingStop();
            if(mainForm != null)
            {
                this.mainForm.halt();
            }
        }

        private void checkBoxCutLimit_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            this.switchCutLimit(checkbox.Checked);
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            this.autoCutting();
            this.refreshValue();
        }

        private void loadOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.refreshDataGrid();
        }

        private void refreshOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.refreshDataGrid();
            this.mainForm.refreshDataGrid();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.setCuttingLength(Convert.ToInt32(this.numericUpDownCuttingLength.Value));
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.openButton.Enabled = true;
        }

        private void checkBoxAuto_CheckedChanged(object sender, EventArgs e)
        {
            this.isAuto = this.checkBoxAuto.Checked;
        }

        private void resetcuttingnbrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.resetCuttingCount();
        }
    }
}
