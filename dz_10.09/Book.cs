using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_10._09
{
    class Book
    {
        public string name;
        private string autor;
        private int year;

        public Book() { }
        public Book(string n, string a, int y)
        {
            name = n;
            autor = a;
            year = y;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {name};\nAutor: {autor};\nYear: {year}.");
        }
        public override string ToString()
        {
            return $"Name: {name};\nAutor: {autor};\nYear: {year}.";
        }
    }
}
