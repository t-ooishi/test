using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAppForKurabo
{
    public interface IMainTopView
    {
       void SetEventHandler(IMainTopController controller);
    }
}
