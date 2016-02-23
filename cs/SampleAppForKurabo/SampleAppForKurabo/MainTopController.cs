using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAppForKurabo
{
    class MainTopController : IMainTopController
    {
        private IMainTopView _view;
        private IMainTopModel _model;

        public IMainTopView View
        {
            get { return _view; }
            set { _view = value; }
        }

        public IMainTopModel Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public void ButtonClick(object sender, EventArgs e)
        {
            DefButton btn = (DefButton)sender;

            switch (btn.Id) { 
                case 1:
                    break;
                default:
                    break;
            
            }

        }
    }
}
