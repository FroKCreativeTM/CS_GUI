using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Threading;

namespace WPF_Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        DispatcherTimer _timer;
        string _inputText;

        public string InputText
        {
            get { return _inputText; }
            set
            {
                _inputText = value;
                PropertyChanged(this, new PropertyChangedEventArgs("InputText"));
            }
        }

        string _time;
        public string Time
        {
            get { return _time; }
            set
            {
                _time = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Time"));
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            _timer = new DispatcherTimer();
            _timer.Tick += _timer_Tick;
            _timer.Interval = new TimeSpan(0, 0, 1);
            _timer.Start();
        }

        //void _timer_Tick(object sender, EventArgs e)
        //{
        //    this.lblTime.Content = DateTime.Now.ToLongDateString();
        //}
        void _timer_Tick(object sender, EventArgs e)
        {
            this.Time = DateTime.Now.ToLongTimeString();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.InputText);
        }
    }
}
