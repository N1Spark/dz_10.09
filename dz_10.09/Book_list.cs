using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dz_10._09;

namespace dz_10._09
{
    class Book_list
    {
        static private int count = 0;
        private Book[] list = new Book[count];

        public Book_list() { }
        public Book_list(Book[] books)
        {
            this.list = books;
        }

        public void Add(Book a)
        {
            count++;
            Book_list buf = new Book_list();
            for (int i = 0; i < count - 1; i++)
                buf.list[i] = this.list[i];
            buf.list[count - 1] = a;
            this.list = buf.list;
        }
        public void Delete(Book a)
        {
            int index = -1;
            for (int i = 0; i < count - 1; i++)
                if (list[i].name == a.name)
                    index = i;
            if (index == -1)
            {
                Console.WriteLine("Такой книги нет");
                return;
            }
            count--;
            Book_list buf = new Book_list();
            for (int i = 0, j = 0; i <= count; i++)
            {
                if (i != index)
                {
                    buf.list[j] = list[i];
                    j++;
                }
            }
            this.list = buf.list;
        }
        public override string ToString()
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine($"{i + 1}. {list[i]}");
            return "";
        }

        public static Book_list operator +(Book_list a, Book b)
        {
            count++;
            Book_list buf = new Book_list();
            for (int i = 0; i < count - 1; i++)
                buf.list[i] = a.list[i];
            buf.list[count - 1] = b;
            return buf;
        }
        public static Book_list operator -(Book_list a, Book b)
        {
            int index = -1;
            for (int i = 0; i < count - 1; i++)
                if (a.list[i].name == b.name)
                    index = i;
            if (index == -1)
            {
                Console.WriteLine("Такой книги нет");
                return a;
            }
            count--;
            Book_list buf = new Book_list();
            for (int i = 0, j = 0; i < count; i++)
            {
                if (i != index)
                {
                    buf.list[j] = a.list[i];
                    j++;
                }
            }
            return buf;
        }
        public static bool operator ==(Book_list a, Book b)
        {
            int index = -1;
            for (int i = 0; i < count - 1; i++)
                if (a.list[i].name == b.name)
                    index = i;
            if (index == -1)
                return false;
            else
                return true;
        }
        public static bool operator !=(Book_list a, Book b)
        {
            return !(a == b);
        }

        public void Search(string a)
        {
            int index = -1;
            for (int i = 0; i < count - 1; i++)
                if (list[i].name == a)
                    index = i;
            if (index == -1)
                Console.WriteLine("Такой книги нет");
            else
                Console.WriteLine($"Книга в списке есть под номером: {index + 1}");
        }


        public string this[int index]
        {
            get
            {
                if (index >= list.Length || index < 0)
                    throw new Exception("Некорректный индекс");
                else
                    return list[index].name;
            }
            set
            {
                if (index >= list.Length || index < 0)
                    throw new Exception("Некорректный индекс");
                else
                    list[index].name = value;
            }
        }

    }
}
