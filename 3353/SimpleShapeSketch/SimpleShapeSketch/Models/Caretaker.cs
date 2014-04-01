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

        internal Memento undo()
        {
            if (_redo.Count == 0)
                _redo.Push(_undo.Pop());

            _redo.Push(_undo.Pop());
            return _redo.Peek();
        }

        internal Memento redo()
        {
            if (_undo.Count == 0)
                _undo.Push(_redo.Pop());

            _undo.Push(_redo.Pop());
            return _undo.Peek();
        }
        internal void resetRedo()
        {
            _redo = new Stack<Memento>();   
        }
    }
}
