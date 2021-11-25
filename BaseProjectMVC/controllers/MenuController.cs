using BaseProjectMVC.controllers.bases;
using BaseProjectMVC.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProjectMVC.controllers
{
    public class MenuController : BaseUiController<IMenuView>
    {
        public MenuController(IMenuView view)
        {
            _view = view;
        }
    }
}
