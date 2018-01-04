using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_form
{
    public partial class PayementUserControl : UserControl
    {
        public PayementUserControl()
        {
            InitializeComponent();
        }

        private void Debit_Click(object sender, EventArgs e)
        {
           sidepanel.Height = Debit.Height;
            sidepanel.Top = Debit.Top;
            debitcardCustomControl1.BringToFront();
        }

        private void credit_Click(object sender, EventArgs e)
        {
            sidepanel.Height = credit.Height;
            sidepanel.Top = credit.Top;
            debitcardCustomControl1.BringToFront();
        }

        private void cash_Click(object sender, EventArgs e)
        {
            sidepanel.Height = cash.Height;
            sidepanel.Top = cash.Top;
            cashusercontrol1.BringToFront();
        }
    }
}
