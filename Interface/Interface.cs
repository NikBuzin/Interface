using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace Interface
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
            Printers = new List<LaserPrint>();
        }
        List<LaserPrint> Printers;
        LaserPrint laserPrint;
        private void But_Printer_Click(object sender, EventArgs e)
        {
            laserPrint = new LaserPrint(TB_Name.Text, Convert.ToInt32(TB_Power.Text), Convert.ToInt32(TB_Count.Text));
            laserPrint.SetName(TB_Name.Text);
            laserPrint.SetPower(Convert.ToInt32(TB_Power.Text));           
            Printers.Add(laserPrint);
            TB_Result.Text = laserPrint.Result(Printers);
        }

        private void But_Remove_printer_Click(object sender, EventArgs e)
        {
            Printers.Remove(Printers[0]);
            TB_Result.Text = laserPrint.Result(Printers);
        }

        private void But_Add_Queue_Click(object sender, EventArgs e)
        {
            laserPrint.AddToPrint(Convert.ToInt32(TB_Count.Text));
            TB_Result.Text = laserPrint.Result(Printers);
        }

        private void But_Cancel_Queue_Click(object sender, EventArgs e)
        {
            laserPrint.CancelToPrint(Convert.ToInt32(TB_Count.Text));
            TB_Result.Text = laserPrint.Result(Printers);
        }
    }
}
