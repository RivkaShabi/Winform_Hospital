using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class rashi : Form
    {
        public rashi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           mashgichim mashgichimf =new  mashgichim();
            mashgichimf.Show();
        }
    }
}
