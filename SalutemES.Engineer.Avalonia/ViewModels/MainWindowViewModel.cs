﻿using SalutemES;
using SalutemES.Engineer.Domain;
using SalutemES.Engineer.Infrastructure.DataBase;
using static SalutemES.Engineer.Infrastructure.DataBase.DataBaseApi;
using System.Collections.Generic;
using System.Reflection;
using System.Data;
using System.Diagnostics;
using System;
using System.Linq;
using SalutemES.Engineer.Core;
using SalutemES.Engineer.Infrastructure;

namespace SalutemES.Engineer.Avalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public List<string> SomeCollection { get; set; } = new List<string>()
        {
            "test 1",
            "test 2",
            "test 3",
            "test 4",
            "test 5"
        };
    }
}