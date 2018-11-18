using System;

namespace Labb2
{
    class Program
    {
        static void Main(string[] args)
        {
            Operators();
            CombineLists();
            CircleList();
            UniqueuePositionList();
        }

        private static void Operators()
        {
            Console.WriteLine("Operators:");
            Console.WriteLine("+ Operator: {0}", new Position(2, 4) + new Position(1, 2));
            Console.WriteLine("- Operator: {0}", new Position(2, 4) - new Position(1, 2));
            Console.WriteLine("- Operator: {0}", new Position(1, 2) - new Position(3, 6));
            Console.WriteLine("% Operator: {0}", new Position(3, 5) % new Position(1, 3));
            Console.WriteLine("< Operator: {0}", new Position(5, 3) < new Position(3, 5));
            Console.WriteLine("> Operator: {0} \n", new Position(7, 2) > new Position(2, 7));
        }

        private static void CombineLists()
        {
            Console.WriteLine("CombineLists:");
            SortedPosList list1 = new SortedPosList();
            list1.Add(new Position(3, 7));
            list1.Add(new Position(1, 4));
            list1.Add(new Position(2, 6));
            list1.Add(new Position(2, 3));
            Console.WriteLine("List 1: {0}", list1);
            //list1.Remove(new Position(2, 6));

            SortedPosList list2 = new SortedPosList();
            list2.Add(new Position(3, 7));
            list2.Add(new Position(1, 2));
            list2.Add(new Position(3, 6));
            list2.Add(new Position(2, 3));
            Console.WriteLine("List 2: {0}\n", list2);

            Console.WriteLine("Combining the two lists together:");
            Console.WriteLine("{0}\n", list2 + list1);
        }

        private static void CircleList()
        {
            Console.Write("CircleList:");
            SortedPosList circleList = new SortedPosList();
            circleList.Add(new Position(1, 1));
            circleList.Add(new Position(2, 2));
            circleList.Add(new Position(3, 3));
            circleList.Add(new Position(5, 5));
            circleList.Add(new Position(3, 4));

            Console.WriteLine("");
            Console.WriteLine(circleList.CircleContent(new Position(5, 5), 4) + "\n");
        }

        private static void UniqueuePositionList()
        {
            Console.Write("UniqueuePositionList:\n");
            SortedPosList list3 = new SortedPosList();
            list3.Add(new Position(14, 2));
            list3.Add(new Position(13, 37));
            list3.Add(new Position(5, 3));
            list3.Add(new Position(9, 9));

            SortedPosList list4 = new SortedPosList();
            list4.Add(new Position(2, 3));
            list4.Add(new Position(14, 2));
            list4.Add(new Position(5, 3));
            list4.Add(new Position(9, 9));
            Console.WriteLine(list3 - list4 + "\n");
        }
    }
}
