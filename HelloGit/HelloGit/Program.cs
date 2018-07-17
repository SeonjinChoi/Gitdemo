using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//How to debugging
namespace HelloGit
{
    class Porgram
    {
        static void Main(string[] args)
        {
            int d = 0;

            for (int i = 0; i < 10000; i++)
            {
                d = d + 1; // F9로 중단점 설정 -> 오른쪽 버튼 눌러 조건 설정 가능

                if (i == 5001)
                    d = d / 0;
            }

            Console.WriteLine(d);
        }
    }
 }      