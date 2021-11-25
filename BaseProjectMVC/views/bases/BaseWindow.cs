using BaseProjectMVC.controllers;
using BaseProjectMVC.controllers.bases;
using BaseProjectMVC.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BaseProjectMVC.views.bases
{
    public abstract class BaseWindow<T> : Window where T : BaseController
    {
        protected T _controller;

        protected BaseWindow()
        {
            _controller = InitController();
            InitView();
            InitData();
            InitAction();
        }

        internal abstract protected T InitController();

        internal abstract protected void InitView();
        internal abstract protected void InitData();
        internal abstract protected void InitAction();
    }
}
