using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsoMetall
{
    public partial class FormController : Form
    {
        // Length production: 100M
        const int lengthProduction = 100;

        const int LENGTH_MAX = 14000;
        const int WIDTH_MAX = 1250;

        // Init
        private int speed = 0;
        private int incrementSheet = 1;
        public int production = 0;
        private Boolean productionStart = false;

        // Order
        private List<Sheet> listSheet = new List<Sheet>();
        private Sheet selectSheet = null;
        private Order order = new Order(50, 1010);

            // Material
            public Coil coilUpper = new Coil("R8012",0.58,1220,1234);
            public Coil coilInner = new Coil("R9002", 0.48, 1089, 890);

            // Stock
            private List<Coil> listCoil = new List<Coil>();

        // Other forms
        public FormSaw saw = new FormSaw();
        private FormGlue glueTop = new FormGlue("Colle supérieur");
        private FormGlue glueBottom = new FormGlue("Colle inférieur");
        private FormStack stack = new FormStack();
        private FormCoil coil = new FormCoil();
        private FormInnibition innibition = new FormInnibition();
        private FormOrder formOrder = new FormOrder();

        private SerialPort arduino = null;

        public FormController()
        {
            InitializeComponent();

            this.initMain();
        }

        private void initMain()
        {
            // Position
            this.initPosition();

            // Timer info
            this.setProgressParts();
            this.timerInfo.Start();

            // Data GRid
            this.refreshDataGrid();

            // Coil
            this.coil.Visible = false;
            this.coil.setMainForm(this);

            // Innibition
            this.innibition.setMainForm(this);
            this.innibition.setOpenButton(this.buttonOpenSaw);

            // Order
            this.formOrder.setMainForm(this);

            // Saw
            this.saw.setMainForm(this);
            this.saw.setOpenButton(this.buttonOpenSaw);

            // Glue
            this.glueTop.setMainForm(this);
            this.glueTop.setPopUp();
            this.glueTop.setLength(order.getWidth());
            this.glueTop.setOpenButton(this.buttonOpenGlueTop);

            this.glueBottom.setMainForm(this);
            this.glueBottom.setPopUp();
            this.glueBottom.setLength(order.getWidth());
            this.glueBottom.setOpenButton(this.buttonOpenGlueBottom);

            // Stack
            this.stack.setOpenButton(this.buttonOpenStack);

            // Refresh
            this.refreshDataGrid();
            this.refreshLabel();
        }

        
        // Wall
        private void setWall()
        {
            
        }

        // Roof
        private void setRoof()
        {

        }

        public void callArduino(String message)
        {
            if (this.arduino != null)
            {
                this.arduino.Write(message);
            }
        }

        private void setListCoil()
        {
            this.listCoil.Add(new Coil("R9010", 0.48, 1089, 1400));
            this.listCoil.Add(new Coil("R8012", 0.58, 1220, 1298));
            this.listCoil.Add(new Coil("R8015", 0.58, 1220, 1450));
            this.listCoil.Add(new Coil("R1015", 0.58, 1220, 1900));
            this.listCoil.Add(new Coil("R9010", 0.48, 1089, 2012));
            this.listCoil.Add(new Coil("R5008", 0.55, 1220, 1100));
            this.listCoil.Add(new Coil("R7016", 0.68, 1400, 1400));
            this.listCoil.Add(new Coil("R9010", 0.48, 1089, 400));
            this.listCoil.Add(new Coil("R9010", 0.48, 1089, 732));
        }

        // Get limits

        public int getMaxLength()
        {
            return Config.MAIN_LENGTH_MAX;
        }

        public int getMaxWidth()
        {
            return Config.MAIN_WIDTH_MAX;
        }

        public int getMaxHeight()
        {
            return Config.MAIN_HEIGHT_MAX;
        }

        public int getMinHeight()
        {
            return Config.MAIN_HEIGHT_MIN;
        }

        // Display sheet

        public int getRationMToPx()
        {
            return this.panelSheet.Width / lengthProduction;
        }

        private void initPosition()
        {
            this.buttonUpperCoil.Location = new Point(this.buttonInnerCoil.Left + (15 * this.getRationMToPx()), this.buttonUpperCoil.Top);
            this.buttonInnibition.Location = new Point(this.buttonUpperCoil.Left + (15 * this.getRationMToPx()), this.buttonInnibition.Top);
            this.buttonOpenGlueTop.Location = new Point(this.buttonInnibition.Left + (25 * this.getRationMToPx()), this.buttonOpenGlueTop.Top);
            this.buttonOpenSaw.Location = new Point(this.buttonOpenGlueTop.Left + (25 * this.getRationMToPx()), this.buttonOpenSaw.Top);
            this.buttonOpenStack.Location = new Point(this.buttonOpenSaw.Left + (25 * this.getRationMToPx()), this.buttonOpenStack.Top);

            if(this.selectSheet != null)
            {
                this.initPanelSheet();
            }
        }

        private void initPanelSheet()
        {
            // Init Panel Sheet
            this.panelCurrentSheet.Width = this.selectSheet.getLength() / 1000 * this.getRationMToPx();
            this.panelCurrentSheet.Location = new Point((this.buttonInnibition.Left - this.buttonInnerCoil.Left) - this.panelCurrentSheet.Width, this.panelCurrentSheet.Top);
        }

        public List<Sheet> getListSheet()
        {
            return listSheet;
        }

        // Production

        public Boolean isStart()
        {
            return this.productionStart;
        }

        // Halt
        public void halt()
        {
            this.stop();
            this.glueTop.Secure();
            this.glueBottom.Secure();
        }

        public void stop()
        {

            this.productionStart = false;
            this.timerProduction.Stop();

            // Buttons
            this.buttonStart.Enabled = true;
            this.buttonStop.Enabled = false;

            //this.setSpeed(0, true);
            this.glueTop.Secure();
            this.glueBottom.Secure();
        }

        private void prepare()
        {
            foreach (Sheet iSheet in listSheet)
            {
                this.selectedSheet(iSheet);
                break;
            }
        }

        private void begin()
        {

            this.timerProduction.Interval = 100;
            this.timerProduction.Start();

            // Buttons
            this.buttonStart.Enabled = false;
            this.buttonStop.Enabled = true;
        }

        private void Production()
        {
            if(this.speed == 0)
            {
                setSpeed(1);
            }
            // Length
            double lengthDouble = 17 * this.getRationMToPx() * speed / 10;

            int length = Convert.ToInt32(lengthDouble);

            this.productionStart = true;

            // Use
            this.production += length;
            this.saw.incrementLengthTotal(length);

            // Coils
            if(this.coilInner != null)
            {
                this.coilInner.use(length);
            }

            if(this.coilUpper != null)
            {
                this.coilUpper.use(length);
            }

            // Panel Use
            int newX = this.panelCurrentSheet.Left + (1 * speed);
            this.panelCurrentSheet.Location = new Point(newX,this.panelCurrentSheet.Top);

            // Stop
            if(listSheet.Count == 0)
            {
                this.stop();
            }

            // Refresh
            this.refreshLabel();

            //this.Text = ((selectSheet.getLength() - beforeCutting) * 100 / (selectSheet.getLength())).ToString();
        }

        private void setSpeed(int inSpeed, Boolean stop = false)
        {
            if (inSpeed == 0 && stop == false)
            {
                this.numericUpDownSpeed.Value = 0;
                this.stop();
            }
            else if (inSpeed == 0 && stop == true)
            {
                this.numericUpDownSpeed.Value = 0;
            }
            else
            {

            }
            this.speed = inSpeed;
        }

        // Refresh
        public void refreshLabel()
        {
            CultureInfo ci = new CultureInfo("fr-be");

            this.numericUpDownSpeed.Value = this.speed;

           // this.labelOrderLength.Text = (Convert.ToDecimal(this.order.getLength(listSheet)/1000)).ToString("N01", ci);
            this.labelOrderLength.Text = (Convert.ToDecimal(this.order.getLength(listSheet))/1000).ToString("F", ci);

            if (this.productionStart)
            {
                this.buttonStart.BackColor = Color.Green;
                this.buttonStop.BackColor = Color.Gray;
            }
            else
            {
                this.buttonStart.BackColor = Color.Gray;
                this.buttonStop.BackColor = Color.Red;
            }


            this.callArduino(this.glueTop.getPosition_pc().ToString());

            if (this.arduino != null)
            {
                this.Text = this.arduino.ToString() + " - " + this.glueTop.getPosition_pc().ToString();
            }
        }


        // Refresh Grid
        public void refreshDataGrid()
        {
            if(listSheet.Count == 0)
            {
                dataGridViewDyn.DataSource = typeof(List<Sheet>);
                dataGridViewDyn.AutoResizeColumns();
                dataGridViewDyn.Refresh();
            }
            else if(listSheet.Count>0)
            {
                dataGridViewDyn.DataSource = typeof(List<Sheet>);
                dataGridViewDyn.DataSource = listSheet;
                dataGridViewDyn.AutoResizeColumns();
                dataGridViewDyn.Refresh();
            }
        }

        // Add sheet
        public void selectedSheet(Sheet inSheet)
        {
            this.glueTop.setLength(inSheet.getWidth());
            this.glueBottom.setLength(inSheet.getWidth());
            this.selectSheet = inSheet;

            this.refreshLabel();
        }

        public void addSheet(Sheet inSheet)
        {
            this.listSheet.Add(inSheet);

            // Prepare
            this.prepare();
            this.refreshDataGrid();
            this.refreshLabel();
            this.incrementSheetAdd();
        }

        public void delSheet(Sheet inSheet)
        {
            if (inSheet != null)
            {
                this.listSheet.Remove(inSheet);

                this.prepare();
            }
            this.refreshDataGrid();
        }

        public int incrementSheetGet()
        {
            return this.incrementSheet;
        }

        private void incrementSheetAdd()
        {
            this.incrementSheet++;
        }

        public void injectInStack(Sheet inSheet)
        {
            this.stack.importSheet(inSheet);
        }

        // Progress
        private void setProgressParts()
        {
            this.buttonOpenGlueTop.BackColor = this.glueTop.colorProccess();
            this.buttonOpenGlueBottom.BackColor = this.glueBottom.colorProccess();
            this.buttonOpenSaw.BackColor = this.saw.inProccess() ? Color.Green : Color.Red;
            this.buttonOpenStack.BackColor = this.stack.inProccess() ? Color.Green : Color.Red;

            if (this.coilInner == null)
            {
                this.buttonInnerCoil.BackColor = Color.Red;
            }
            else if(this.coilInner.getLengthLeft() == 0)
            {
                this.buttonInnerCoil.BackColor = Color.Orange;
            }
            else
            {
                this.buttonInnerCoil.BackColor = Color.Green;
            }


            if (this.coilUpper == null)
            {
                this.buttonUpperCoil.BackColor = Color.Red;
            }
            else if (this.coilUpper.getLengthLeft() == 0)
            {
                this.buttonUpperCoil.BackColor = Color.Orange;
            }
            else
            {
                this.buttonUpperCoil.BackColor = Color.Green;
            }
        }

        // Getter
        public Order getOrder()
        {
            return this.order;
        }

        // Setter
        private void setCoil(String position = null)
        {
            switch(position)
            {
                case "inner":
                    this.coil.setCoil("inner",this.coilInner);
                    break;
                case "upper":
                    this.coil.setCoil("upper",this.coilUpper);
                    break;
            }
            this.coil.Visible = true;
        }

        public void setCoilUpper(Coil inUpper)
        {
            this.coilUpper = inUpper;
            this.refreshLabel();
        }

        public void setCoilInner(Coil inInner)
        {
            this.coilInner = inInner;
            this.refreshLabel();
        }

        public void closeAll()
        {
            if(this.arduino != null)
            {
                this.arduino.Close();
            }
            this.glueTop.Off();
            this.glueBottom.Off();
        }

        // Actions
        private void buttonCutting_Click(object sender, EventArgs e)
        {
            this.saw.cutting();
        }

        private void buttonAddSheet_Click(object sender, EventArgs e)
        {
            FormAddSteel formAddSteel = new FormAddSteel();

            formAddSteel.setMainForm(this);
            formAddSteel.ShowDialog();
        }

        private void timerProduction_Tick(object sender, EventArgs e)
        {
            this.Production();
        }

        private void numericUpDownSpeed_ValueChanged(object sender, EventArgs e)
        {
            this.setSpeed(Convert.ToInt32(this.numericUpDownSpeed.Value));

            // Glue
            this.glueTop.setSpeedTop(this.speed * 2);
            this.glueBottom.setSpeedTop(this.speed * 2);
            
            // Stack)
            this.stack.setSpeed(speed);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.begin();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.stop();
        }

        private void buttonInnibition_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;

            if (this.innibition.Visible != true)
            {
                this.innibition.Visible = true;
            }
        }

        private void buttonOpenGlue_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;

            if (this.glueTop.Visible != true)
            {
                this.glueTop.Visible = true;
            }
        }

        private void buttonOpenGlueBottom_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;

            if (this.glueBottom.Visible != true)
            {
                this.glueBottom.Visible = true;
            }
        }

        private void buttonOpenSaw_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;

            if (this.saw.Visible != true)
            {
                this.saw.Visible = true;
            }
        }

        private void buttonOpenStack_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;

            if (this.stack.Visible != true)
            {
                this.stack.Visible = true;
            }
        }

        private void ToolStripMenuItemEmptyOrder_Click(object sender, EventArgs e)
        {
            this.listSheet.Clear();
            this.incrementSheet = 1;
            this.production = 0;

            this.refreshLabel();
            this.refreshDataGrid();
        }

        private void timerInfo_Tick(object sender, EventArgs e)
        {
            this.setProgressParts();
            this.refreshLabel();
        }

        private void buttonInnerCoil_Click(object sender, EventArgs e)
        {
            this.setCoil("inner");
        }

        private void buttonUpperCoil_Click(object sender, EventArgs e)
        {
            this.setCoil("upper");
        }

        private void betaOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {
                this.addSheet(new Sheet(this.incrementSheetGet(), 13500,this.order.getWidth(),this.order.getHeight(), 0,0));
            }
            this.refreshLabel();
        }

        private void FormController_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxSerial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.arduino != null)
            {
                this.arduino.Close();
                this.arduino = null;
            }
        }

        private void FormController_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.closeAll();
        }

        private void FormController_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.closeAll();
        }

        private void ToolStripMenuItemSettingsOrder_Click(object sender, EventArgs e)
        {
            this.formOrder.Visible = true;
        }
    }
}
