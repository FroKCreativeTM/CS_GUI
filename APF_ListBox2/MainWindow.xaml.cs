using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace APF_ListBox2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> _sampleColors = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            AddElement("Yellow");
            AddElement("Green");
            AddElement("Blue");

            foreach (PropertyInfo propInfo in typeof(Colors).GetProperties(
                BindingFlags.Static | BindingFlags.Public))
            {
                _sampleColors.Add(propInfo.Name);
            }
        }

        ObservableCollection<UIElement> _colorList =
            new ObservableCollection<UIElement>();
        public ObservableCollection<UIElement> ColorList
        {
            get { return _colorList; }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            // 임의의 요소를 추기
            Random rand = new Random((int)DateTime.Now.Ticks);
            int colorIndex = rand.Next(_sampleColors.Count);

            AddElement(_sampleColors[colorIndex]);
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            _colorList.RemoveAt(_colorList.Count - 1);
        }

        private void AddElement(string colorName)
        {
            WrapPanel panel = new WrapPanel();

            CheckBox box = new CheckBox();
            box.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            Label lbl = new Label();
            lbl.Content = colorName;

            panel.Children.Add(box);
            panel.Children.Add(lbl);

            _colorList.Add(panel);
        }
    }
}
