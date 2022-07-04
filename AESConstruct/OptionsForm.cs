using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AESConstruct
{
    public partial class OptionsForm : Form
    {
        private MainForm form;

        public OptionsForm(MainForm form)
        {
            InitializeComponent();
            SaltBox.Text = form.GetSalt();
            IVBox.Text = form.GetIV();
            this.form = form;
        }

        private void SaltBox_TextChanged(object sender, EventArgs e)
        {
            if (form != null)
            {
                form.SetSalt(SaltBox.Text);
            }
        }

        private void IVBox_TextChanged(object sender, EventArgs e)
        {
            if (form != null)
            {
                form.SetIV(IVBox.Text);
            }
        }
    }
}
