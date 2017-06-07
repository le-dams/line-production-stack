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
    public partial class FormAddSteel : Form
    {
        private FormController mainForm = null;

        public FormAddSteel()
        {
            InitializeComponent();

            this.timerInfo.Interval = 1000;
            this.timerInfo.Start();
        }

        public void setMainForm(FormController inForm1)
        {
            this.mainForm = inForm1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quant = Convert.ToInt32(this.numericUpDown1.Value);

            if(quant == 0)
            {
                quant = 1;
            }

            for (int i = 1; i <= quant; i++)
            {
                this.mainForm.addSheet(new Sheet(this.mainForm.incrementSheetGet(), Convert.ToInt32(this.numericUpDownLength.Value), this.mainForm.getOrder().getWidth(), this.mainForm.getOrder().getHeight(), Convert.ToInt32(this.numericUpDownCutLeft.Value), Convert.ToInt32(this.numericUpDownCutRigth.Value)));
                this.mainForm.refreshLabel();
            }
            this.Close();
        }

        private void timerInfo_Tick(object sender, EventArgs e)
        {
            // Roof
            if(this.mainForm.getOrder().isRoof())
            {
                this.numericUpDownCutLeft.Enabled = true;
                this.numericUpDownCutRigth.Enabled = true;
            }
            // Wall
            else
            {
                this.numericUpDownCutLeft.Enabled = false;
                this.numericUpDownCutRigth.Enabled = false;
            }
        }

    }
}
