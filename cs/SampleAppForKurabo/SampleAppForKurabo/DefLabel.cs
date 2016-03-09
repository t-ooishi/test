using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleAppForKurabo
{
    class DefLabel : Label
    {
        ComponentId _id;

        public ComponentId Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public void SetEventHandler(ComponentId id, IMainTopController controller)
        {
            _id = id;
        }
    }
}
