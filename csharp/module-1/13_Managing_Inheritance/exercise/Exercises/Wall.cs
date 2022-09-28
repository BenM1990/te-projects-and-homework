using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public abstract class Wall
    {
        public string Name { get; }
        public string Color { get; }
    public Wall(string name, string color)
        {
            this.Name = name;
            this.Color = color;

        }
        public abstract int GetArea();

    }
}
