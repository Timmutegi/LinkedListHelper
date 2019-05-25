using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListHelpers
{
    public static class LinkedListHelpers
    {
        
        public static void Main()
        {
            string[] input = { "E", "B", "E", "E", "B", "A", "B" };
            LinkedList<String> my_list = new LinkedList<String>(input);
            Console.WriteLine(my_list);
            DeleteRepeated(my_list);
            Console.WriteLine(my_list);
        }
        private static void DeleteRepeated(LinkedList<string> my_list)
        {
            var head = my_list.First;
            var current = head.Next;
            while (head != null)
            {
                    if ((head == current))
                    {
                        current = current.Next;
                    }
                        current = current.Next;              
            }
        }
        
    }
}
