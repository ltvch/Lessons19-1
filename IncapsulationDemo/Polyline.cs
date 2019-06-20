using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190518_IncapulationDemo
{
    struct Polyline
    {
        private Point[] _points;

        public Polyline(params Point[] source)
        {
            _points = (Point[])source.Clone();
        }

        public Polyline(Polyline source)
        {
            _points = (Point[])source._points.Clone();
        }

        // !!! Error !!!
        public Point[] Points
        {
            get 
            {
                return (Point[])_points.Clone(); 
            }
            set 
            {
                _points = (Point[])value.Clone(); 
            }
        }
        
    }
}
