using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod8_Binary_Search_Tree_Demo_Dave
{
    class Node
    {
        public int data;
        //two pointers:
        public Node right; //holds right child
        public Node left; //holds left child

        //Constructor--help initialize the data (right and left pointers)
        //whenever creating a new node, you will pass the value (null) because it will be your new node
        public Node(int data, Node right, Node left)
        {
            this.data = data; //data is the value (number) held in the node
            this.right = right; //points to this node's right child
            this.left = left; //points to this node's left child
        }
    }

    class BinarySearchTree
    {
        ////create a private node (root node) with a public property that is read only
        ////Hides that node from it being manipulated
        //private Node root;
        //public Node Root
        //{
        //    get { return this.root; }
        //}


        //Keeping it public right now for simplicity
        public Node root; //"head", starting point
        public BinarySearchTree()
        {
            root = null;
        }

        public bool Search(int val) //public Node Search(int val) ---then in first if block, return temp for 7.3 assignment
        {
            Node temp = root; //starting point, temp points to root node
            while (temp != null) //while root node exists...
            {
                if (temp.data == val) //if root node == searched value
                    return true;
                else if (val < temp.data) //if searched value is < root node (temp.data), moves to left side of the tree if true
                    temp = temp.left; //
                else if (val > temp.data) //if searched value is > root node (temp.data) moves to right side of root
                    temp = temp.right;
            }
            return false;
        }

        public void InsertNode(Node temproot, int val) //temproot is just a reference to the root itself
        {
            Node newNode = new Node(val, null, null); //new node to be created, holding value (number or letter on node), null and null for left/right childres

            //Is rootnode null? does it exist?
            Node temp = null;

            if (root != null) //there are nodes and we have to decide where to enter the newnode (left or right side)
            {
                while (temproot != null)
                {
                    temp = temproot; //temp will remain on the last leaf node when temproot == null
                    if (temproot.data == val) //checks if tmeproot.data == value you're trying to add and returns, stops, cannot add duplicates
                        return;
                    else if (val < temproot.data) //if val is < the temproot value, go left
                        temproot = temproot.left;
                    else if (val > temproot.data) //if val is > the temproot value, go right
                        temproot = temproot.right;
                }
                //If come out of while loop, you can reached the leaf node and temp points to that leaf node
                if (val < temp.data)
                    temp.left = newNode; //left node will equal value of the data of the newNode
                if (val > temp.data)
                    temp.right = newNode;
            }
            else //if tree is empty, assign the newnode to be the root
            {
                root = newNode;
            }
        }

        public void InOrderTraversal(Node temproot) //left-root-right
        {
            if (temproot != null) //terminating condition
            {
                InOrderTraversal(temproot.left); //once you have reached the temproot, print it. Go all the way to the left, reach the end, start printing
                Console.Write(temproot.data + " "); //at the root
                InOrderTraversal(temproot.right); // Go all the way to the right
            }
        }

        public void PreOrderTraversal(Node temproot) //root-left-right
        {
            if (temproot != null)
            {
                Console.Write(temproot.data + " "); //at the root
                PreOrderTraversal(temproot.left);
                PreOrderTraversal(temproot.right);
            }
        }

        public void PostOrderTraversal(Node temproot) //left-right-root
        {
            if(temproot != null)
            {
                PostOrderTraversal(temproot.left);
                PostOrderTraversal(temproot.right);
                Console.Write(temproot.data + " "); //when you get to the root
            }
        }
    }
}
