﻿using ESAPIX.Common;
using Prism.Mvvm;
using System.Linq;
using VMS.TPS.Common.Model.API;

namespace Napiwocki.PlanChecker.ViewModels
{
    public class MainViewModel : BindableBase
    {
        AppComThread VMS = AppComThread.Instance;

        public MainViewModel()
        {

        }
    }
}

      
