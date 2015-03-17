using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VelosCalendarConverter
{
    public partial class VelosCalendarConverter : Form
    {
        public VelosCalendarConverter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofdOpenXls.Filter = "Excel Files|*.XLS;*.XLSX";
            DialogResult dr=ofdOpenXls.ShowDialog();
            string filename = dr == DialogResult.OK ? ofdOpenXls.FileName:"";
            XlsReaderAdo xlsReader = new XlsReaderAdo(filename);
            //XlsReaderOfficeInterop xlsReader = new XlsReaderOfficeInterop(filename);
            xlsReader.openXls();
            txtOuput.Text = xlsReader.printDT();
        }
    }
}
