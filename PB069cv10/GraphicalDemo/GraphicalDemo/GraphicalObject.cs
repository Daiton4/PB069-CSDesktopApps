using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalDemo
{
    public enum ObjectType { LINE, RECTANGLE, ELLIPSE }
    public class GraphicalObject
    {
        public ObjectType Type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int DX { get; set; }
        public int DY { get; set; }

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4}", (int)Type, X, Y, DX, DY);
        }

        public static GraphicalObject ParseObject(string line)
        {
            GraphicalObject obj = new GraphicalObject();
            string[] parts = line.Split(';');
            if (parts.Length != 5)
            {
                throw new FormatException("Invalid file format");
            }
            obj.Type = (ObjectType)int.Parse(parts[0]);
            obj.X = int.Parse(parts[1]);
            obj.Y = int.Parse(parts[2]);
            obj.DX = int.Parse(parts[3]);
            obj.DY = int.Parse(parts[4]);
            return obj;
        }
    }
}
