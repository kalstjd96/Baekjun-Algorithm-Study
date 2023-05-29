#region 슬라임 합치기
/* 첫번째 줄에는 슬라임의 개수 (2 < N < 100)
 * 두번쨰 줄에는 슬라임의 크기 (100보다 작거나 같은 자연수)
 * N개의 슬라임을 합치는데 슬라임이 하나가 남으면 끝난다.
 * 합치면 x + y, 합칠 때 마다 두 사람은 x * y 점수를 얻게 된다.
 * 점수의 최댓값은??
 * 즉 슬라임 개수를 입력받고 입력된 슬라임 사이즈를 서로 곱해 모두 더해주는 것
 */

int result = 0;

Console.Write("슬라임의 개수는 ? : "); //2
int count = int.Parse(Console.ReadLine());


Console.Write("슬라임의 크기는 ? : "); //3 , 4 위 카운트만큼 개수를 쓸 수 있게 조건 처리
string input = Console.ReadLine();
while (true)
{
    if (input.Split(' ').Length != count)
    {
        Console.Write("슬라임의 개수와 입력한 수가 다릅니다 다시 입력하세요: ");
        input = Console.ReadLine();
    }
    else
    {
        break;
    }
}

List<int> inputList = new List<int>();
for (int i = 0; i < count; i++)
{
    inputList.Add(int.Parse(input.Split(' ')[i]));
}

for (int j = 0; j < inputList.Count - 1; j++)
{
    for (int z = j + 1; z < inputList.Count; z++)
    {
        result += inputList[j] * inputList[z];
    }
}

Console.Write("결과는 : " + result);

#endregion
