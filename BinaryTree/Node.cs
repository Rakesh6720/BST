using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node
    {
        //member variables
        public int value;
        public Node left;
        public Node right;
        

        //constructor

        //member methods
        public void Traverse(Node startingNode)
        {
            //move to the left child node
            if (startingNode.left != null)
            {
                myNode = startingNode.left;
            }

            //move to the right child node
            if (startingNode.right != null)
            {
                myNode = startingNode.right;
            }
            
        }
    }
}
