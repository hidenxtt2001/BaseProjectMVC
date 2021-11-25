using BaseProjectMVC.interfaces;
using BaseProjectMVC.interfaces.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProjectMVC.controllers.bases
{
    public class BaseUiController<T> : BaseController where T : IBaseView
    {
        protected T _view;
    }
}
