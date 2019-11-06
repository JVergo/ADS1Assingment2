using System;
using System.Collections.Generic;
using System.Text;

namespace ADS1Assingment2
{
    class BinaryTree
    {
        private Node root;
        public Node Root
        {
            get { return root; }
        }
        private int size;
        public int Size
        {
            get { return size; }
        }


        public Node insertNode(Node newNode, int value)
        {
            if (newNode == null)
            {
                newNode = new Node();
                newNode.Value = value;
                size++;
                if (root == null)
                {
                    root = newNode;
                }
            }
            else if (value < newNode.Value)
            {
                newNode.Left = insertNode(newNode.Left, value);
            }
            else
            {
                newNode.Right = insertNode(newNode.Right, value);
            }

            return newNode;
        }

        public bool isEmpty()
        {
            if (root == null)
            {
                return true;
            }
            return false;
        }

        public Node contains(Node target)
        {
            if (root == null)
            {
                return null;
            }

            if (root == target)
            {
                return target;
            }

            if (target.Value < root.Value)
            {
                return contains(root.Left, target);
            }
            else
            {
                return contains(root.Right, target);
            }
        }

        private Node contains(Node cur, Node target)
        {
            if (cur == target)
            {
                return target;
            }

            if (target.Value < cur.Value)
            {
                return contains(cur.Left, target);
            }
            else
            {
                return contains(cur.Right, target);
            }
        }

        public Node contains(int value)
        {
            if (root == null)
            {
                return null;
            }

            if (root.Value == value)
            {
                return root;
            }

            if (value < root.Value)
            {
                return contains(root.Left, value);
            }
            else
            {
                return contains(root.Right, value);
            }
        }

        private Node contains(Node cur, int value)
        {
            if (cur.Value == value)
            {
                return cur;
            }

            if (value < cur.Value)
            {
                return contains(cur.Left, value);
            }
            else
            {
                return contains(cur.Right, value);
            }
        }

        public void inOrder()
        {
            inOrder(Root);
        }
        private void inOrder(Node cur)
        {
            if (cur != null)
            {
                inOrder(cur.Left);
                Console.Write(cur.Value + " ");
                inOrder(cur.Right);
            }
        }

        public void preOrder()
        {
            preOrder(Root);
        }
        private void preOrder(Node cur)
        {
            if (cur != null)
            {
                Console.Write(cur.Value + " ");
                preOrder(cur.Left);
                preOrder(cur.Right);
            }
        }
       
        public void postOrder()
        {
            postOrder(Root);
        }
        private void postOrder(Node cur)
        {
            if (cur != null)
            {
                postOrder(cur.Left);
                postOrder(cur.Right);
                Console.Write(cur.Value + " ");
            }
        }

        public int height()
        {
            return height(Root);
        }
        private int height(Node cur)
        {
            if (cur == null)
            {
                return 0;
            }
            else
            {
                /* compute height of each subtree */
                int lheight = height(cur.Left);
                int rheight = height(cur.Right);

                /* use the larger one */
                if (lheight > rheight)
                {
                    return (lheight + 1);
                }
                else
                {
                    return (rheight + 1);
                }
            }
        }

        public void printLevelOrder()
        {
            int h = height(root);
            int i;
            for (i = 1; i <= h; i++)
            {
                printGivenLevel(root, i);
            }
        }

        private void printGivenLevel(Node root, int level)
        {
            if (root == null)
            {
                return;
            }
            if (level == 1)
            {
                Console.Write(root.Value + " ");
            }
            else if (level > 1)
            {
                printGivenLevel(root.Left, level - 1);
                printGivenLevel(root.Right, level - 1);
            }
        }
    }
}
