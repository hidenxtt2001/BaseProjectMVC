using BaseProjectMVC.controllers;
using BaseProjectMVC.interfaces;
using BaseProjectMVC.views.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BaseProjectMVC.views
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : BaseWindow<MenuController>, IMenuView
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        protected internal override MenuController InitController()
        {
            return new MenuController(this);
        }

        protected internal override void InitAction()
        {
            
        }

        protected internal override void InitData()
        {
            
        }

        protected internal override void InitView()
        {
            
        }
    }
}
