using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Demo
{
    public class AbstractClassDemo
    {
        public static void Test()
        {
            IShape shape = new Box();
            shape.SetColor(ConsoleColor.Green);
            shape.Draw();
            shape.Erase();

            shape = new Circle();
            shape.SetColor(ConsoleColor.Magenta);
            shape.Draw();
            shape.Erase();

            shape = new Hexagon();
            shape.SetColor(ConsoleColor.Yellow);
            shape.Draw();
            shape.Erase();

            Employee employee = new Employee("C#", "SQL", "Java");
        }
    }

    public class Employee
    {
        private readonly List<string> _skillSets;

        public Employee(params string[] skillSets)
        {
            _skillSets = skillSets.ToList();
        }
    }

    public interface IShape
    {
        public void Draw();
        public void SetColor(ConsoleColor color);
        public void Erase();
    }

    public abstract class Shape : IShape
    {
        protected ConsoleColor _color;

        public abstract void Draw();

        public void Erase()
        {
            Console.WriteLine("It is erased!!");
        }

        public void SetColor(ConsoleColor color)
        {
            _color = color;
        }
    }

    public class Box : Shape
    {
        public override void Draw()
        {
            Console.BackgroundColor = _color;
            Console.WriteLine("Box here!!");
            Console.ResetColor();
        }
    }

    public sealed class Circle : Shape
    {
        public sealed override void Draw()
        {
            Console.BackgroundColor = _color;
            Console.WriteLine("Circle here!!");
            Console.ResetColor();
        }
    }

    public class Hexagon : Shape
    {
        public override void Draw()
        {
            Console.BackgroundColor = _color;
            Console.WriteLine("Hexagon here!!");
            Console.ResetColor();
        }
    }
}
