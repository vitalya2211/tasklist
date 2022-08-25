using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.dataFolder
{
    class toDoModel:INotifyPropertyChanged
    {
        public DateTime CreateOnData { get; set; } = DateTime.Now;
        private bool _isDone;
        private string _text;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void onPropertyChanged(string propertyName="")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public bool isDone
        {
            get { return _isDone; }
            set { _isDone = value; }
        }
        
        public string Text
        {
            get { return _text; }
            set { _text = value; }

        }
    }
}
