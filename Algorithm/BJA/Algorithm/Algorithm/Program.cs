using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 문제 
 * 조규현의 좌표 (x1, y1)와 백승환의 좌표 (x2, y2)가 주어지고, 
 * 조규현이 계산한 류재명과의 거리 r1과 
 * 백승환이 계산한 류재명과의 거리 r2가 주어졌을 때, 
 * 류재명이 있을 수 있는 좌표의 수를 출력
 * 
 * 조건
 * 첫째 줄에 x1, y1, r1, x2, y2, r2가 주어진다. 
 * x1, y1, x2, y2는 -10,000보다 크거나 같고, 
 * 10,000보다 작거나 같은 정수이고, 
 * r1, r2는 10,000보다 작거나 같은 자연수이다.
 * 
 * 입력
 * 3
   0 0 13 40 0 37
   0 0 3 0 7 4
   1 1 1 1 1 5 
 * 
 * 출력
 * 2
   1
   0
 */
namespace Algorithm
{
    class Program
    {
        public struct Point
        {
            public int x, y, r;
        }
            
        static void Main(string[] args)
        {
            int _fullCount = 0;
            string _aurgument = null;
            Point p1, p2;

            _fullCount = Convert.ToInt32(Console.ReadLine());
            _aurgument = Console.ReadLine();

            string[] arg = _aurgument.Split(' ');
            p1.x = Convert.ToInt32(arg[0]);
            p1.y = Convert.ToInt32(arg[1]);
            p1.r = Convert.ToInt32(arg[2]);

            p2.x = Convert.ToInt32(arg[3]);
            p2.y = Convert.ToInt32(arg[4]);
            p2.r = Convert.ToInt32(arg[5]);

            //ToDo 조건처리
            for (int i = 0; i < _fullCount; i++)
            {
                if (p1.x < 0 || p2.x < 0)
                {

                }
            }
            double a = Math.Sqrt(4);
        }
    }
}
