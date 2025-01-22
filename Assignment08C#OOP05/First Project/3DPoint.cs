using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment08C_OOP05.First_Project
{
    public  class _3DPoint : IComparable , ICloneable
    {
      

        public int X {  get; set; }
        public int Y { get; set; }

        public int Z { get; set; }


        public _3DPoint() { 
        }
        public _3DPoint(int x, int y) : this (x ,y ,0)
        {
        
        }

        public _3DPoint(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }


        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }


        public int CompareTo(object? obj)
        {
            _3DPoint point3D = (_3DPoint)obj;

            if(X > point3D.X && Y> point3D.Y)
                return 1;
            else if(X < point3D.X && Y < point3D.Y)
                return -1;
            else return 0;

        }

        public object Clone()
        {
            return new _3DPoint(X, Y, Z);
        }
    }


}
