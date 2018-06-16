using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSender
{
    public partial class DateSelect : Form
    {
        public DateTime Date { get; set; }
        public DateSelect()
        {
            InitializeComponent();
            dateTimePicker.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd 00:00:00"));
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd (dddd) HH:mm:ss";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.Date = this.dateTimePicker.Value;
        }
    }
}
