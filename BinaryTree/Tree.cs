using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Tree
    {

        //member variables
        public Node root;

        //constructor

        //member methods
        public void Add(int value)
        {
            if (root == null)
            {
                root.value = value;
            }
            else if (value < root.value)
            {
                //move to root.left node
                root.Traverse(root.left);
                //check the value of root.left node
                if (root.left == null)
                //if root.left == null, THEN root.left.value = value;
                {
                    root.left.value = value;
                    Node newNode = new Node();
                    newNode = root.left;
                }
                //if root.left != null, THEN check the value of root.left
                else if (value < root.left.value)
                {
                    root.left.Traverse(root.left.left);

                }
                //if value < root.left, THEN move to the left child node of root.left
                else
                {
                    root.left.Traverse(root.left.right);
                }
            }
            else if (value > root.value)
            {
                //move to root.right node
                root.Traverse(root.right);
                //check the value of root.right node
                if (root.right == null)
                //if root.right == null, THEN root.right.value = value;
                {
                    root.right.value = value;
                    Node newNode = new Node();
                    newNode = root.right;
                }
                else if (value < root.right.value)
                {
                    root.right.Traverse(root.right.left);

                }
                else
                {
                    root.right.Traverse(root.right.right);
                }
                
                //if root.right != null, THEN check the value of root.right;
                //if value > root.right, THEN move to the right child of node.right
            }

        }

        public void Search(int value)
        {

        }
    }
}
