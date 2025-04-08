using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3_Binary_Search_Tree
{
    class Node
    {
        public int Data; //value of node
        public Node Left, Right; //left/right child pointer

        public Node(int data)
        {
            Data = data;
            Left = null; //set to null since they will either be updated or kept pointing at null (leaf nodes)
            Right = null;

        }
    }

    class BinarySearchTree
    {
        public Node Root; //starting point

        public BinarySearchTree()
        {
            Root = null; //makes sure the new tree has a null root
        }

        public Node Search(int val)
        {
            Node temp = Root; //temp points to Root node
            while (temp != null) //while root node exists
            {
                if (temp.Data == val) //return the root
                    return temp;
                else if (val < temp.Data) //go left of root
                    temp = temp.Left;
                else if (val > temp.Data) //go right of root
                    temp = temp.Right;
            }
            return null; //return null if not found
        }


        public void InsertNode(int val) //
        {
            Node newNode = new Node(val);


            if (Root == null) //root doesn't exist
            {
                Root = newNode; //create it and leave
                return;
            }

            Node temp = Root;  //pointer starts at root, looks for insertion point...when temp == null (empty spot)...
            Node parent = null; //tracks last valid node before temp becomes null...parent holds node where new val will attach (l/r child)

            while (temp != null) //traverse until empty slot
            {
                parent = temp; //update parent before moving down

                if (val < temp.Data) //if val < parent value, go left
                    temp = temp.Left; //update temp to left side
                else if (val > temp.Data) //if val > parent val, go right
                    temp = temp.Right;
                else //val == parent
                    return; //can't add duplicates
            }

            
            if (val < parent.Data) 
                parent.Left = newNode; 
            else
                parent.Right = newNode;
        
        }

        public void InOrder(Node temproot) //left-root-right
        {
            if (temproot != null)
            {
                InOrder(temproot.Left);
                Console.Write(temproot.Data + " ");
                InOrder(temproot.Right);
            }
        }

    }
}
