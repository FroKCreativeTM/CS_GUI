using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF_ItemTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> _sampleColors = new List<string>();

        private ObservableCollection<ColorData> _colorList =
            new ObservableCollection<ColorData>();

        public ObservableCollection<ColorData> ColorList
        {
            get { return _colorList; }
        }

        public MainWindow()
        {
            InitializeComponent();

            AddColor("Yellow");
            AddColor("Green");
            AddColor("Blue");

            foreach (PropertyInfo propInfo in typeof(Colors).GetProperties(
                BindingFlags.Static | BindingFlags.Public))
            {
                _sampleColors.Add(propInfo.Name);
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            int colorIndex = rand.Next(_sampleColors.Count);

            AddColor(_sampleColors[colorIndex]);
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            _colorList.RemoveAt(_colorList.Count - 1);
        }
        private void AddColor(string colorName)
        {
            ColorData item = new ColorData();
            item.Name = colorName;
            Color color = (Color)ColorConverter.ConvertFromString(colorName);
            item.Color = new SolidColorBrush(color);

            _colorList.Add(item);
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in _colorList)
            {
                item.Color = new SolidColorBrush(Colors.Red);
                item.Name = "Red";
            }
        }
    }
}
