using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Redactor_Memento.Models
{
    class Text
    {
        public string Textt { get; set; }
        
        public TextMemento Save()
        {
            return new TextMemento(Textt.Clone() as string);
        }
        public void Load(TextMemento memento)
        {
            Textt = memento.Text;
        }
    }
}
