using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElliottProject1
{
    public class Stack
    {
        //Create a linked list
        LinkedList list = new LinkedList();

        //Adds value to the first element in the list
        public int push(int value)
        {
            list.AddToList(value);
            return value;
        }

        //Pulls value from the first element in the list (last value added to list)
        public int pop()
        {
            if (!list.CValue())
            {
                throw new InvalidOperationException("The Stack is empty"); //Throws exception is stack is empty
            }
            int value = 0;
            //If list is not empty - gets root value
            if (list.getRoot() != null)
                value = list.getRoot().value;
            //Removes root value from the linked list
            list.removeFirst();
            return value;
        }

        //Returns a string containing the values in the list
        public string getList()
        {
            return list.printOut();
        }
    }


}
