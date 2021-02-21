using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WPF_ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> _colorList =
            new ObservableCollection<string>();
        public ObservableCollection<string> ColorList
        {
            get { return _colorList; }
        }


        public MainWindow()
        {
            InitializeComponent();

            _colorList.Add("Yellow");
            _colorList.Add("Green");
            _colorList.Add("Blue");
        }
    }
}
