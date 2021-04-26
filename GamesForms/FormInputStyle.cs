using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GamesForms
{
    public partial class FormInputStyle : Form
    {
        public string Style { get; set; } = string.Empty;
        public FormInputStyle()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Style = textBox1.Text;
            Close();
        }
    }
}
