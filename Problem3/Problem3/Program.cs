using Problem3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
     public class Tree
    {
        public int item;
        public Tree left;
        public Tree right;
        public Tree(int val)
        {
            item = val;
            left = null;
            right = null;
        }

        public static Tree findLowestCommonAncestor(Tree root, Tree p, Tree q)
        {
            if (root == null)
                return null;

            if (root == p || root == q)
                return root;

            Tree left = findLowestCommonAncestor(root.left, p, q);
            Tree right = findLowestCommonAncestor(root.right, p, q);

            if (left != null && right != null)
                return root;

            if (left != null)
                return left;
            else
                return right;
        }
    }
  
 class Program
    {
        static void Main(string[] args)
        {
           
                Tree root = new Tree(1);
            root.left = new Tree(2);
            root.right = new Tree(3);
            root.left.left = new Tree(4);
            root.left.right = new Tree(5);
            root.right.left = new Tree(6);
            root.right.right = new Tree(7);

            root.left.left.left = new Tree(8);
            root.left.left.right = new Tree(9);
            Tree p = root.right;
            Tree q = root.right.right;

            Tree LCA = Tree.findLowestCommonAncestor(root, p, q);
            Console.WriteLine(LCA.item);
        }

    }
      
}
    
  

