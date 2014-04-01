using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShapeSketch
{
    class Memento
    {
        List<GraphicalObject> _backup;
        public Memento(List<GraphicalObject> backup)
        {
            _backup = new List<GraphicalObject>();
            foreach (GraphicalObject go in backup)
                _backup.Add(go.Clone());
        }

        public List<GraphicalObject> restore()
        {
            List<GraphicalObject> returnVal = new List<GraphicalObject>();

            foreach (GraphicalObject go in _backup)
                returnVal.Add(go.Clone());

            return returnVal;
        }
    }
}
