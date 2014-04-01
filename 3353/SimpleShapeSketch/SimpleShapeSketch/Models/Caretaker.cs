using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShapeSketch
{
    class Caretaker
    {
        private Stack<Memento> _redo;
        private Stack<Memento> _undo;

        public Caretaker( )
        {
            _redo = new Stack<Memento>();
            _undo = new Stack<Memento>();
        }

        internal void add(Memento memento)
        {
            _undo.Push(memento);

            if (_redo.Count > 0)
                resetRedo();
        }

        internal bool canUndo()
        {
            return _undo.Count > 0;
        }

        internal bool canRedo()
        {
            return _redo.Count > 0;
        }

        internal Memento undo( Memento currentState)
        {
            _redo.Push(currentState);

            return _undo.Pop();
        }

        internal Memento redo(Memento currentState)
        {
            _undo.Push(currentState);

            return _redo.Pop();
        }
        internal void resetRedo()
        {
            _redo = new Stack<Memento>();   
        }
    }
}
