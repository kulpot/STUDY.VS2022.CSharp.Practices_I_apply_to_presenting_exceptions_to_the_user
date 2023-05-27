using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//a bit about inner-exceptions and how to show message boxes in a non-malicious manner. FYI the Exception handled in the vid is not suppose to be specific 

namespace Practices_I_apply_to_presenting_exceptions_to_the_user
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(@"C:\Windows\WindowsUpdate.log");
                //File.Delete(@"C:\Users\sunny\Desktop\delex.txt");
            }
            catch(IOException ex)
            {
                string message = "Could not delete file.\n\n" + ex.Message;
                MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int _ticks;

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;

            if(_ticks == 5)
            {
                button1.PerformClick();
            }
        }
    }
}
