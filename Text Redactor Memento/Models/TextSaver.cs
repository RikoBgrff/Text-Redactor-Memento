using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Redactor_Memento.Models
{
    class TextSaver
    {
        private Text originator;
        private Stack<TextMemento> history = new Stack<TextMemento>();
        public TextSaver(Text originator)
        {
            this.originator = originator;
        }

        public void Save()
        {
            history.Push(originator.Save());
        }

        public void Undo()
        {
            originator.Load(history.Pop());
        }
    }
}
