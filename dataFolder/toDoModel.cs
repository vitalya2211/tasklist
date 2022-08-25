using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.dataFolder
{
    class toDoModel
    {
        public DateTime CreateOnData { get; set; } = DateTime.Now;
        private bool _isDone;
        private string _text;
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
