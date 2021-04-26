using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GamesForms
{
    public partial class FormInputCompany : Form
    {
        public string Company { get; set; } = string.Empty;
        public FormInputCompany()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Company = textBox1.Text;
            Close();
        }
    }
}
