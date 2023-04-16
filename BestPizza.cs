/* 
 * 최고의 피자란? 1원당 열량이 가장 높은 피자를 말한다.
 * 
 */
Console.Write("값을 입력하세요. : ");
int input = int.Parse(Console.ReadLine());
List<int> inputList = new List<int>();

int min = 0;
int max = 0;
for (int i = 0; i < input; i++)
{
    inputList.Add(int.Parse(Console.ReadLine()));
}

min = inputList[0];
max = inputList[0];
for (int j = 1; j < inputList.Count; j++)
{
    if (max < inputList[j])
    {
        max = inputList[j];
    }

    if (min > inputList[j])
    {
        min = inputList[j];
    }
}

Console.Write("결과는 : " + max + " " + min);
