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
    public partial class FormInnibition : Form
    {
        private Boolean isPopUp = false;
        private Button openButton = null;
        private FormController mainForm = null;

        public FormInnibition()
        {
            InitializeComponent();

            this.timer1.Interval = 100;
            this.timer1.Start();
        }

        public void setMainForm(FormController inMainForm)
        {
            this.mainForm = inMainForm;
        }

        public void setOpenButton(Button inButton)
        {
            this.openButton = inButton;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelLengthTotal.Text = this.mainForm.production.ToString();
            this.labelBeforeCutting.Text = this.mainForm.saw.getCuttingLef().ToString();

            // Material
            if (this.mainForm.coilUpper == null)
            {
                this.labelCoilUpperLeft.Text = "--";
                this.labelCoilUpperRal.Text = "-";
            }
            else
            {
                this.labelCoilUpperLeft.Text = (this.mainForm.coilUpper.getLengthLeft() / 1000).ToString();
                this.labelCoilUpperRal.Text = this.mainForm.coilUpper.getColor();
            }

            if (this.mainForm.coilInner == null)
            {
                this.labelCoilInnerLeft.Text = "-";
                this.labelCoilInnerRal.Text = "-";
            }
            else
            {
                this.labelCoilInnerLeft.Text = (this.mainForm.coilInner.getLengthLeft() / 1000).ToString();
                this.labelCoilInnerRal.Text = this.mainForm.coilInner.getColor();
            }
        }
    }
}
