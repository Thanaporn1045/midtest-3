using System;

namespace สอบมิดข้อ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int box1, box2, box3, numA, xA, numB, xB,all;
            Console.Write("Boxes in the bucket no.1 ? : ");
            box1 = int.Parse(Console.ReadLine());
            Console.Write("Boxes in the bucket no.2 ? : ");
            box2 = int.Parse(Console.ReadLine());
            Console.Write("Boxes in the bucket no.3 ? : ");
            box3 = int.Parse(Console.ReadLine());
            all = box1 + box2 + box3;
            while (all >= 0)
            {
                Console.Write("Player A No. of the bucket : ");
                numA = int.Parse(Console.ReadLine());
                Console.Write("Player A Number of boxes to be picked out 1 or 2 ? : ");
                xA = int.Parse(Console.ReadLine());
                if (numA == 1) { box1 = box1 - xA; } 
                if (numA == 2) { box2 = box2 - xA; }
                if (numA == 3) { box3 = box3 - xA; }
                Console.WriteLine("Remaining boxes in the bucket no.1,no.2,no.3 :{0},{1},{2} ", box1, box2, box3);
                all = all - xA;
                if (all == 0)
                {
                    Console.WriteLine("The winner is Player B");
                    break;
                }
                Console.Write("Player B No. of the bucket : ");
                numB = int.Parse(Console.ReadLine());
                Console.Write("Player B Number of boxes to be picked out 1 or 2 ? : ");
                xB = int.Parse(Console.ReadLine());
                if (numB == 1) { box1 = box1 - xB; }
                if (numB == 2) { box2 = box2 - xB; }
                if (numB == 3) { box3 = box3 - xB; }
                Console.WriteLine("Remaining boxes in the bucket no.1,no.2,no.3 :{0},{1},{2} ", box1, box2, box3);
                all = all - xB;
                if (all == 0)
                {
                    Console.WriteLine("The winner is Player A");
                    break;
                }

            }

        }
    }
}
