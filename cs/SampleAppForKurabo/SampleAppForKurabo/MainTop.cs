using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleAppForKurabo
{
    public partial class MainTop : Form, IMainTopView
    {
        public MainTop()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void SetEventHandler(IMainTopController controller)
        {
            defButton1.SetEventHandler(1, controller);
            defButton2.SetEventHandler(2, controller);
            defButton3.SetEventHandler(3, controller);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

    }
}
