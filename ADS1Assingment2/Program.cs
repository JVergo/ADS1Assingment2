using System;
using System.Diagnostics;

namespace ADS1Assingment2
{
    class Program
    {

        static void Main(string[] args)
        {
            Node root = null;
            BinaryTree tree = new BinaryTree();
            const int SIZE = 11;//20000000;
            int[] a = new int[SIZE];

            Console.WriteLine("Generating random array with {0} values...", SIZE);

            Random random = new Random();

            Stopwatch watch = Stopwatch.StartNew();

            for (int i = 0; i < SIZE; i++)
            {
                a[i] = random.Next(10000);
            }
            /*a[0] = 30;
            a[1] = 35;
            a[2] = 57;
            a[3] = 15;
            a[4] = 63;
            a[5] = 49;
            a[6] = 89;
            a[7] = 77;
            a[8] = 67;
            a[9] = 98;
            a[10] = 91;*/

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();

            Console.WriteLine("Filling the tree with {0} nodes...", SIZE);

            watch = Stopwatch.StartNew();

            for (int i = 0; i < SIZE; i++)
            {
                root = tree.insertNode(root, a[i]);
            }

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();

            Console.WriteLine("Finding target node with value {0}", root.Value);

            watch = Stopwatch.StartNew();

            Node temp = tree.contains(root);

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine("current node value is: {0}", temp.Value);
            Console.WriteLine();

            int v = a[random.Next(a.Length)];
            Console.WriteLine("Finding target value {0}", v);

            watch = Stopwatch.StartNew();

            temp = tree.contains(v);

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine("current node value is: {0}", temp.Value);
            Console.WriteLine();

            Console.WriteLine("Inorder: ");

            watch = Stopwatch.StartNew();

            tree.inOrder();

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();

            Console.WriteLine("Preorder: ");

            watch = Stopwatch.StartNew();

            tree.preOrder();

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();

            Console.WriteLine("Postorder: ");

            watch = Stopwatch.StartNew();

            tree.postOrder();

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();

            Console.WriteLine("Caluate the height of the tree");

            watch = Stopwatch.StartNew();

            int num = tree.height();

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine("The height of the tree: {0}", num);
            Console.WriteLine();

            Console.WriteLine("Printing level");

            watch = Stopwatch.StartNew();

            tree.printLevelOrder();

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
