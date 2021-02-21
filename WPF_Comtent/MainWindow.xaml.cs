using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace WPF_Comtent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _sampleText;
        public string SampleText
        {
            get { return _sampleText; }
            set
            {
                _sampleText = value;
                OnPropertyChange("SampleText");
            }
        }

        private DateTime _sampleDate;
        public DateTime SampleDate
        {
            get { return _sampleDate; }
            set
            {
                _sampleDate = value;
                OnPropertyChange("SampleDate");
            }
        }

        private UIElement _sampleControl;
        public UIElement SampleControl
        {
            get { return _sampleControl; }
            set
            {
                _sampleControl = value;
                OnPropertyChange("SampleControl");
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            //this.SampleText = "This text";
            //this.SampleDate = DateTime.Now;

            //TextBox txtBox = new TextBox();
            //txtBox.Text = "[sample]";
            //this.SampleControl = txtBox;
        }

        protected void OnPropertyChange(string name)
        {
            if(string.IsNullOrEmpty(name) == true)
            {
                return;
            }
            if (PropertyChanged != null)
            {
                PropertyChangedEventArgs arg = new PropertyChangedEventArgs(name);
                PropertyChanged(this, arg);
            }
        }
    }
}
