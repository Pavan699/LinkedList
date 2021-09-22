using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProgram
{
    class Choice
    {
        public void Input()
        {
            LinkedList<int> llist = new LinkedList<int>();//declaration of linked list

            int count = 0, defCount = 1;
            while (defCount == 1)
            {
                Console.Write("Enter The Input : \n 1.Add First \t2.Add Last  \t 3.Insert \n 4.Delete First\t5.Delete Last\t 6.Search Element \n 7.Display \t 8.Sort \t 9.Exit \n");
                Console.Write("Input Plz : ");               
                int check = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                switch (check)
                {
                    case 1:
                        Console.Write("Enter How Many Elements To add :");
                        int numfirstadd = Convert.ToInt32(Console.ReadLine());
                        for(int i = 0; i< numfirstadd; i++)
                        {
                            Console.Write("Enter Element To add at first:");
                            int element1 = Convert.ToInt32(Console.ReadLine());
                            llist.Addfirst(element1);
                        }
                        count++;
                        break;
                    case 2:
                        Console.Write("Enter How Many Elements To add :");
                        int numlastadd = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < numlastadd; i++)
                        {
                            Console.Write("Enter Element To add at last:");
                            int element2 = Convert.ToInt32(Console.ReadLine());
                            llist.Append(element2);
                        }
                        count++;
                        break;
                    case 3:
                        llist.Print();
                        Console.Write("Enter the Index : ");
                        int Index = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Element To add :");
                        int value = Convert.ToInt32(Console.ReadLine());
                        llist.Insert(Index+1, value);
                        count++;
                        break;
                    case 4:
                        llist.DeleteFirst();
                        count++;
                        break;
                    case 5:
                        llist.DeleteLast();
                        count++;
                        break;
                    case 6:
                        Console.Write("Enter Element To check it is Present or Absent : ");
                        int element3 = Convert.ToInt32(Console.ReadLine());
                        bool Present = llist.Search(element3);
                        if (Present == true)
                        { Console.WriteLine("Element {0} is Present", element3); }
                        else
                        { Console.WriteLine("Element {0} is Absent", element3); }
                        count++;
                        break;
                    case 7:
                        llist.Print();
                        count++;
                        break;
                    case 8:
                        Console.Write("Enter How Many Elements To Sort :");
                        int numsortadd = Convert.ToInt32(Console.ReadLine());
                        for (int j = 0; j < numsortadd; j++)
                        {
                            Console.Write("Enter Element to Sort : ");
                            int element4 = Convert.ToInt32(Console.ReadLine());
                            llist.Sort(element4);
                        }                       
                        llist.PrintSort();
                        count++;
                        break;
                    default:
                        Console.WriteLine("Thank You.....!");
                        defCount++;
                        break;
                }
            }
            Console.WriteLine("Counter of the Operations Done is : " + count);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }
    }
}
