using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Redactor_Memento.Models
{
    class TextMemento
    {
            public TextMemento(string text)
            {
                Text = text;
            }
            public string Text { get; set; }
        }
    }
