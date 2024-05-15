using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Design_Pattern
{
    public enum Color
    {
        Red, Green, Blue
    }
    public enum Size
    {
        Small, Medium, Large, Huge
    }

    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            if (name == null)
                throw new ArgumentNullException(paramName: nameof(name));

            Name = name;
            Color = color;
            Size = size;
        }
    }

    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size) 
        {
            foreach(var p in products)
            {
                if(p.Size == size)
                    yield return p;
            }
        }

        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
            {
                if (p.Color == color)
                    yield return p;
            }
        }
    }

    public interface ISpecification<T>
    {
        bool IsStaisfied(T t);
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }

    public class ColorSpecification : ISpecification<Product>
    {
        private Color color;

        public ColorSpecification(Color color)
        {
            this.color = color;
        }
        public bool IsStaisfied(Product t)
        {
            return t.Color == color;
        }
    }


    public class SizeSpecification : ISpecification<Product>
    {
        private Size size;
        public SizeSpecification(Size size)
        {
            this.size = size;
        }
        public bool IsStaisfied(Product t)
        {
            return t.Size == size;
        }
    }

    public class AndSpecification : ISpecification<Product>
    {
        private Size size;
        private Color color;

        public AndSpecification(Size size, Color color) 
        {
            this.size = size;
            this.color = color;
        }
         public bool IsStaisfied(Product t )
        {
            return t.Size == size && t.Color == color;
        }
    }

    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var i in items)
            {
                if (spec.IsStaisfied(i))
                    yield return i;
            }
        }
    }

    internal class Open_Closed
    {
        public Open_Closed() 
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var pf = new ProductFilter();
            Console.WriteLine("Green products (old) : ");
            foreach(var p in pf.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($" - {p.Name} is green");
            }

            var bf = new BetterFilter();
            Console.WriteLine("Green products (new) : ");
            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {p.Name} is green");
            }

            Console.WriteLine("Products size (new) : ");
            foreach (var p in bf.Filter(products, new SizeSpecification(Size.Large)))
            {
                Console.WriteLine($" - {p.Name} is Large");
            }

            Console.WriteLine("Products size (new) and Green products (new) :  ");
            foreach (var p in bf.Filter(products, new AndSpecification(Size.Large, Color.Blue)))
            {
                Console.WriteLine($" - {p.Name} is Large and Red");
            }

        }
    }
}
