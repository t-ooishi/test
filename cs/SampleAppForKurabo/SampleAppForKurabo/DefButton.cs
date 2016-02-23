using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleAppForKurabo
{
    class DefButton : Button
    {
        ushort _id;

        public ushort Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public void SetEventHandler(ushort id, IMainTopController controller)
        {
            _id = id;
            this.Click += new System.EventHandler(controller.ButtonClick);
        }
    }
}
