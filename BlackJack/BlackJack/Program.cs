using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        /// <summary>
        /// 1. 합이 M을 넘지 않는 한도 내에서 카드의 합이 최대한 크게 만드는 것.
        /// 2. 숫자가 보이는 N장의 카드를 제한 시간안에 3장을 선택 
        /// 3. M을 넘지 않으면서 M에 최대한 가까운 카드 3장의 합을 구해 출력
        /// ** 조건
        /// (1) 첫째 줄에 카드의 개수 N 과 M이 주어진다.
        /// (2) 둘째 줄에는 카드에 쓰여 있는 수가 주어진다. (이 값은 10만을 넘지 않는 양의정수)
        /// (3) 합이 M을 넘지 않는 카드 3장을 찾을 수 있는 경우만 입력
        /// 즉 나열된 N개 중 최적의 카드 3장의 합을 출력하면 된다.
        /// </summary>
        static void Main(string[] args)
        {
            int result = 0;

            #region (1) 조건
            Console.Write("카드의 개수와 최대 합의 한도를 적으세요 : "); //2
            string input = Console.ReadLine();
            int[] inputArray;
            List<int> inputNList = new List<int>();
            int maxSum;
            //int count = int.Parse(Console.ReadLine());
            while (true)
            {
                inputArray = new int[input.Split(' ').Length];

                if (inputArray.Length != 2)
                {
                    Console.Write("카드의 개수와 합을 다시 입력하세요: ");
                    input = Console.ReadLine();
                }
                else
                    break;
            }
            #endregion

            #region (2) 조건
            Console.Write("N개 나열된 카드의 숫자를 입력하세요. : ");
            input = Console.ReadLine();
            while (true)
            {
                if (input.Split(' ').Length != inputArray.Length)
                {
                    Console.Write("N개 나열된 카드의 숫자를 다시 입력하세요. : ");
                    input = Console.ReadLine();
                }
                else
                {
                    for (int i = 0; i < input.Split(' ').Length; i++)
                    {
                        inputNList.Add(int.Parse(input.Split(' ')[i]));
                    }

                    break;
                }
            }
            #endregion
            
            int sum = 0;
            maxSum = 0;
            int[] sumArray = new int[3];

            for (int i = 0; i < inputNList.Count; i++)
            {
                for (int j = 0; j < sumArray.Length; j++)
                {
                    sum += sumArray[j];
                }

                if (sum >= maxSum)
                    maxSum = sum;
            }

            // https://www.acmicpc.net/problem/2798
            Console.Write("결과는 : " + maxSum); //12
        }
    }
}
