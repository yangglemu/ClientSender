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
        public DateTime SelectedDate { get; set; }
        public DateSelect()
        {
            InitializeComponent();
            this.monthCalendar1.DateSelected += (obj, arg) =>
            {
                this.SelectedDate = arg.Start;
            };
        }
    }
}
