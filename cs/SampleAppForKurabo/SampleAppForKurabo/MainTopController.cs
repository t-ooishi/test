using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAppForKurabo
{
    enum ComponentId
    {
        BtnInspectionId = 1,
        BtnStopId,
        BtnSettingId,
        DummyId
    }


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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ButtonClick(object sender, EventArgs e)
        {
            DefButton btn = (DefButton)sender;

            switch (btn.Id) { 
                case ComponentId.BtnInspectionId:
                    break;
                case ComponentId.BtnStopId:
                    break;
                case ComponentId.BtnSettingId:
                    break;
                default:
                    break;
            
            }

        }
    }
}
