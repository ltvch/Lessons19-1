using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20190525_ClassesDemo
{
    class Polyline
    {
        #region PRIVATE FIELDS

        private Point[] _points;
        private int _size = 0;

        #endregion

        public Polyline(int capacity)
        {
            _points = new Point[capacity];
        }

        public Polyline(params Point[] source)
        {
            _size = source.Length;
            _points = new Point[source.Length]; 
            //_points = (Point[])source.Clone();    // поверхностное копирование
            // полное копирование
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] != null)
                {
                    _points[i] = new Point(source[i]);    
                }                
            }
        }

        public Polyline(Polyline source)
            : this(source._points)
        {
            _size = source._size;

            //_size = source._size;
            //_points = (Point[])source._points.Clone();    // поверхностное копирование
            //// полное копирование
            //for (int i = 0; i < _size; i++)
            //{
            //    _points[i] = new Point(source._points[i]);
            //}
        }

        public int Capacity
        {
            get
            {
                return _points.Length;
            }
        }

        public int Size
        {
            get
            {
                return _size;
            }
        }

        //public Polyline Add(Point p)
        //{
        //    if (_size == _points.Length)
        //    {
        //        Array.Resize(ref _points, _points.Length * 2);
        //    }

        //    //_points[_size++] = p;    // copy reference
        //    _points[_size++] = new Point(p);    // full copy

        //    return this;
        //}

        public void Add(Point p)
        {
            if (_size == _points.Length)
            {
                Array.Resize(ref _points, _points.Length * 2);
            }

            //_points[_size++] = p;    // copy reference
            _points[_size++] = new Point(p);    // full copy
        }

        // !!! Error !!!
        // point - REFERENCE
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

        public Point GetPointByPosition(int index)
        {
            // + !!! index validation
            if (index < 0 || index >= _size)
            {
                return null;
            }

            return new Point(_points[index]);
        }

        public PointRO GetPointROByPosition(int index)
        {
            if (index < 0 || index >= _size)
            {
                return null;
            }

            return new PointRO(_points[index]);
        }

        public bool SetPointInPosition(int index, Point p)
        {
            if (index < 0 || index >= _size)
            {
                return false;
            }

            _points[index] = new Point(p);

            return true;
        }

        public Point this[int index]
        {
            get 
            {
                return GetPointByPosition(index);
            }
            set 
            {
                SetPointInPosition(index, value);
            }
        }
    }
}
