using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace WPF_Layout
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        BitmapImage _bitmapImage;

        public BitmapImage BitmapImage
        {
            get { return _bitmapImage; }
            set
            {
                _bitmapImage = value;
                OnPropertyChanged("BitmapImage");
            }
        }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == true)
            {
                string txt = ofd.FileName;
                this.BitmapImage = new BitmapImage(new Uri(txt));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if(string.IsNullOrEmpty(name) == true)
            {
                return;
            }
            if(PropertyChanged != null)
            {
                PropertyChangedEventArgs arg = new PropertyChangedEventArgs(name);
                PropertyChanged(this, arg);
            }
        }
    }
}
