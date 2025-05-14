using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWHDHacker
{
    public partial class SeparateForm: Form
    {
        public SeparateForm()
        {
            InitializeComponent();
            FormClosing += SeparateForm_FormClosing;
        }

        private void SeparateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
