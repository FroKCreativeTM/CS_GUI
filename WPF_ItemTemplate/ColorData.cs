using System;
using System.ComponentModel;
using System.Windows.Media;

namespace WPF_ItemTemplate
{
    public class ColorData : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        Brush _color;
        public Brush Color
        {
            get { return _color; }
            set
            {
                _color = value;
                OnPropertyChanged("Color");
            }
        }

        string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        protected virtual void OnPropertyChanged(string name)
        {
            if(PropertyChanged == null)
            {
                return;
            }

            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
