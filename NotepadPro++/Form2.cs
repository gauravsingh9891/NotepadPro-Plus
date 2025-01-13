using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadPro__
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = "Designed & Developed by Gaurav Kumar\nVersion 1.0.0.0(OS Build 19045.5247)\n©Gaurav Kumar. All rights reserved.\n\nThe Windows 10 Pro operating system and its user interface are protected\nby trademark and other pending or existing intellectual property rights in\nthe India.\n\n\nThe product is licensed the Microsoft Software Licence Terms to:\n Mr Gaurav\n org name";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
