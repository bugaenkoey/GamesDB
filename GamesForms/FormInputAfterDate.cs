using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GamesForms
{
    public partial class FormInputAfterDate : Form
    {
        public DateTime AfterDate { get; set; }
        public FormInputAfterDate()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            AfterDate = dateTimePicker1.Value;
            Close();
        }
    }
}
