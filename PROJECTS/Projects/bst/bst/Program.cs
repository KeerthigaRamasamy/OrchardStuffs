using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Using binary search tree, sorting the employee on their ids */
namespace bst
{
    class Program       
    {
        static void Main(string[] args)
        {
            node t = new node();    //creating an object of type node
            node n=null;            //creating an object of type node
            int e, n1,i,k,s;
            do
            {
            t1: try
                {
                    Console.WriteLine("Enter the number of employees"); //getting the number of employees
                    n1 = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid entry, enter again");    //handling exceptions
                    goto t1;
                }
            } while (n1 <= 0 || n1>20);
            Console.WriteLine("Enter the employee's ages");        //getting the employee ids
            for (i = 0; i < n1; i++)
            {
            t2:try
                {
                    e = int.Parse(Console.ReadLine());
                }
                catch(Exception)
                {
                    Console.WriteLine("Invalid entry, enter again");
                    goto t2;
                }
                n=t.insert(n,e);            //inserting the ids to the binary search tree
            }
            t3:Console.WriteLine("Enter the employee age to be searched");
            try
            {
                k = int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid entry, enter again");
                goto t3;
            }
            s=t.search(n, k);         //searching
            if (s == 0)
                Console.WriteLine("The key is not found");
           /* if(s==1)
            {
                Console.WriteLine("the key is found");
            }
            else
            {
                Console.WriteLine("the key is not found");
            }*/
            Console.WriteLine("The sorted list(inorder) of emp ages are");
            t.inorder(n);           //traversing inorder
            Console.WriteLine("The preorder traversal of emp ages are");
            t.preorder(n);          //traversing preorder
            Console.WriteLine("The post order traversal of emp ages are");
            t.postorder(n);         //traversing postorder
            Console.ReadLine();

        }
    }

        class node              //defining the node
        {
            public int key;     //key value stored in the node
            public node left;   //left node
            public node right;  //right node
            public int flag=0;
           
        public node newnode(int value)  //creating new node and inserting the key value
            {
                node newnode1=new node();
                newnode1.key=value;
                newnode1.left=null;
                newnode1.right=null;
                return newnode1;
            }

            /* function to insert the nodes */
            public node insert(node n,int k)    //inserting the node in the form of binary search tree
            {

                if (n == null)
                { 
                    n = newnode(k);         //creating a new node
                    return n;
                }
                    
                if (k<(n.key))              
                   n.left= insert(n.left,k);    //inserting in the left node
                else
                    n.right=insert(n.right,k);  //inserting in the right node
                return n;
            }

            /* function to traverse the nodes (inorder)*/
            public void inorder(node root)      //inorder traversal
            {
                if (root != null)       
                {
                    inorder(root.left);         //left
                    Console.WriteLine(root.key);//root
                    inorder(root.right);        //right
                }
            }
            public void preorder(node root)      //inorder traversal
            {
                if (root != null)
                {
                    Console.WriteLine(root.key);//root
                    inorder(root.left);         //left
                    inorder(root.right);        //right
                }
            }
            public void postorder(node root)      //inorder traversal
            {
                if (root != null)
                {
                    inorder(root.left);         //left
                    inorder(root.right);        //right
                    Console.WriteLine(root.key);//root
                }
            }
            public int search(node root,int k)      //search     
            {
                if (root != null)
                {
                    if (root.key == k)
                    {
                        Console.WriteLine("The key is found");
                        flag = 1;
                        return 1;
                    }

                    if (root.key < k)
                        search(root.right, k);
                    else
                        search(root.left, k);
                    // return flag;  
                }
                //if (flag == 0)
                    //Console.WriteLine("The key is not found");
               return flag;
             
                    
            }
        }
    }

