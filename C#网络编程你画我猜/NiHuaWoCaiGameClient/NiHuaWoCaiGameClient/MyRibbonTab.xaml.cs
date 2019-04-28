﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NiHuaWoCaiGameClient.UserControls
{
    /// <summary>
    /// MyRibbonTab.xaml 的交互逻辑
    /// </summary>
    public partial class MyRibbonTab : RibbonTab
    {
        public MyRibbonTab()
        {
            InitializeComponent();
            this.Loaded += MyRibbonTab_Loaded;
        }

        private void MyRibbonTab_Loaded(object sender, RoutedEventArgs e)
        {
            rrbRadius.IsChecked = true;
            rrbRed.IsChecked = true;
        }
    }
}
