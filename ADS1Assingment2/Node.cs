using System;
using System.Collections.Generic;
using System.Text;

namespace ADS1Assingment2
{
    class Node
    {
        int value;
        Node left;
        Node right;

        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public Node Left
        {
            get { return this.left; }
            set { this.left = value; }
        }

        public Node Right
        {
            get { return this.right; }
            set { this.right = value; }
        }

    }
}
