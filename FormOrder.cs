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
    public partial class FormOrder : Form
    {
        private FormController mainForm = null;

        public FormOrder()
        {
            InitializeComponent();
            this.Text = "Paramètres de commande";
        }

        // Init
        public void setMainForm(FormController inMainForm)
        {
            this.mainForm = inMainForm;

            this.comboBoxHeight.Text = this.mainForm.getOrder().getHeight().ToString();
            this.numericUpDownOrderWidth.Value = this.mainForm.getOrder().getWidth();
            this.checkBoxIsRoof.Checked = this.mainForm.getOrder().isRoof();
            this.comboBoxOnde.Text = this.mainForm.getOrder().getOndes().ToString();

            // Ondes
            this.comboBoxOnde.Items.Add("3");
            this.comboBoxOnde.Items.Add("5");

            // Height
            this.comboBoxHeight.Items.Add("40");
            this.comboBoxHeight.Items.Add("50");
            this.comboBoxHeight.Items.Add("60");
            this.comboBoxHeight.Items.Add("80");
            this.comboBoxHeight.Items.Add("100");
            this.comboBoxHeight.Items.Add("120");
            this.comboBoxHeight.Items.Add("140");
            this.comboBoxHeight.Items.Add("160");
            this.comboBoxHeight.Items.Add("180");
            this.comboBoxHeight.Items.Add("200");
            this.comboBoxHeight.Items.Add("240");
        }

        public void hidden(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void numericUpDownOrderWidth_ValueChanged(object sender, EventArgs e)
        {
            this.mainForm.getOrder().setWidth(Convert.ToInt32(this.numericUpDownOrderWidth.Value));
        }

        private void checkBoxIsRoof_CheckedChanged(object sender, EventArgs e)
        {
            this.mainForm.getOrder().enabledRoof(this.checkBoxIsRoof.Checked);
        }

        private void hidden()
        {

        }

        private void comboBoxOnde_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mainForm.getOrder().setOndes(Convert.ToInt32(this.comboBoxOnde.Text));
        }

        private void comboBoxHeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mainForm.getOrder().setHeight(Convert.ToInt32(this.comboBoxHeight.Text));
        }
    }
}
