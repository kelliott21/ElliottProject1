using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElliottProject1
{
    internal class LinkedList
    {
        private Link root = null; //variable for start of link 

        //Method to add a new one to list
        public void AddToList(int value)
        {
            //Two conditions - root is null or not null
            if (root == null)
            {
                //First need to create a new link
                root = new Link();
                //Second set the values
                root.value = value;
            }
            else
            {
                //Adds value to list
                addFirst(value);
            }
        }
        private void addFirst(int value)
        {
            Link newLink = new Link(); //New link
            newLink.value = value; //Assigns value to new link
            newLink.nextLink = root; //Takes current root and sets it to the next link
            root = newLink; //Changes the root to the new link
        }
        public void removeFirst()
        {   
            //Removes the original root and replaces it with the second link in the list
            root = root.nextLink;
        }
        public Link getRoot()
        {
            return root;
        }

        //Method checks if there are values in the list
        public bool CValue()
        {
            if (root == null)
            {
                return false;
            }
            else
                return true;
        }
        //Creates a string containing the values in the linked list
        public string printOut()
        {
            string listString = "";
            if (CValue())
                recPrintOut(root, ref listString);
            return listString;
        }
        //Recursively adds to a string using the next link in the list
        private void recPrintOut(Link list, ref string listString)
        {
            if (list != null)
            {
                listString += list.value.ToString() + "\r\n";
                //Go to the next link in the list and continue to add to the string
                recPrintOut(list.nextLink, ref listString);
            }
        }

    }
}
