using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAppForKurabo
{
    public interface IMainTopController
    {
        IMainTopView View { set; get; }
        IMainTopModel Model { set; get; }

        void ButtonClick(object sender, EventArgs e);
    }
}
