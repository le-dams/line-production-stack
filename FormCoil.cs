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
    public partial class FormCoil : Form
    {
        private FormController mainForm = null;
        private String position = "-";
        private Coil coil = null;
        private List<Coil> listCoil = new List<Coil>();

        public FormCoil()
        {
            InitializeComponent();

            this.setComboBox();
            this.init();

            listCoil.Add(new Coil("R7016", 0.58, 1220, 839));
            listCoil.Add(new Coil("R7016", 0.58, 1220, 839));

            this.setListCoil();

            this.Text = listCoil.Count.ToString();
        }

        public void setMainForm(FormController inMainForm)
        {
            this.mainForm = inMainForm;
            this.ControlBox = false;
        }

        public void init()
        {
            this.labelPosition.Text = this.position;

            if(this.coil == null)
            {
                this.numericUpDownLength.Value = 0;
                this.numericUpDownWidth.Value = 0;
                this.numericUpDownLengthLeft.Value = 0;
                this.numericUpDownThickness.Value = 0;

                this.comboBoxColor.Enabled = true;
                this.numericUpDownLength.Enabled = true;
                this.numericUpDownWidth.Enabled = true;
                this.numericUpDownLengthLeft.Enabled = false;
                this.numericUpDownThickness.Enabled = true;

                this.buttonCreate.Enabled = true;
                this.buttonFree.Enabled = false;
            }
            else
            {
                this.comboBoxColor.Text = this.coil.getColor();


                this.numericUpDownLengthLeft.Maximum = this.coil.getLength() / 1000;

                this.numericUpDownLength.Value = this.coil.getLength() / 1000;
                this.numericUpDownWidth.Value = this.coil.getWidth();
                this.numericUpDownLengthLeft.Value = this.coil.getLengthLeft() / 1000;
                this.numericUpDownThickness.Value = Convert.ToDecimal(this.coil.getThickness());

                this.comboBoxColor.Enabled = false;
                this.numericUpDownLength.Enabled = false;
                this.numericUpDownWidth.Enabled = false;
                this.numericUpDownLengthLeft.Enabled = true;
                this.numericUpDownThickness.Enabled = false;

                this.buttonCreate.Enabled = false;
                this.buttonFree.Enabled = true;
            }

            if (this.mainForm != null)
            {
                this.mainForm.refreshLabel();
            }
        }

        private void setComboBox()
        {
            // Clear
            this.comboBoxColor.Text = "";
            this.comboBoxColor.Items.Clear();

            // Colors
            this.comboBoxColor.Items.Add("R9010");
            this.comboBoxColor.Items.Add("R9002");
            this.comboBoxColor.Items.Add("R8015");
            this.comboBoxColor.Items.Add("R9006");
            this.comboBoxColor.Items.Add("R7032");
            this.comboBoxColor.Items.Add("R7016");
            this.comboBoxColor.Items.Add("R8015");
            this.comboBoxColor.Items.Add("R5008");
            this.comboBoxColor.Items.Add("R7022");
            this.comboBoxColor.Items.Add("R1015");
            this.comboBoxColor.Items.Add("White");

            // Sorts
        }

        // Coils

        public void setListCoil()
        {
            dataGridView1.DataSource = typeof(List<Coil>);
            dataGridView1.DataSource = this.listCoil;
            dataGridView1.AutoResizeColumns();
            dataGridView1.Refresh();
        }

        public void setCoil(String inPosition, Coil inCoil)
        {
            Coil currentCoil;
            currentCoil = inCoil;

            this.coil = currentCoil;
            this.position = inPosition;

            this.init();
        }

        private void freeCoil()
        {
            this.coil.setLengthLeft(Convert.ToInt32(this.numericUpDownLengthLeft.Value));
            this.coil = null;

            switch (this.position)
            {
                case "inner":
                    this.mainForm.setCoilInner(null);
                    break;
                case "upper":
                    this.mainForm.setCoilUpper(null);
                    break;
            }

            this.init();
        }

        private void createCoil()
        {
            Coil newCoil = new Coil(this.comboBoxColor.Text,Convert.ToDouble(this.numericUpDownThickness.Value),Convert.ToInt32(this.numericUpDownWidth.Value),Convert.ToInt32(this.numericUpDownLength.Value));

            this.coil = null; 
            this.coil = newCoil;
            
            this.init();

            switch(this.position)
            {
                case "inner":
                    this.mainForm.setCoilInner(newCoil);
                    break;
                case "upper":
                    this.mainForm.setCoilUpper(newCoil);
                    break;
            }
        }

        // Actions

        private void button1_Click(object sender, EventArgs e)
        {

            this.createCoil();
        }

        private void buttonFree_Click(object sender, EventArgs e)
        {
            this.freeCoil();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
