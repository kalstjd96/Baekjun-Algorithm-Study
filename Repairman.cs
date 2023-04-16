/* 
 * L인 테이프를 무한개 가지고 있다.
 * 첫 번째 줄에는 물이 새는 곳 N, 테이프 길이 L이 주어진다.
 * 둘쩨 줄에는 물이 새는 곳의 위치가 주어진다.
 * N과 L은 1,000보다 작거나 같은 자연수
 */

Console.Write("물이 새는 곳의 갯수와 테이프의 길이는? : ");
string[] inputValue = Console.ReadLine().Split(' ');
int leaksLoCount = Convert.ToInt32(inputValue[0]);
int tapeLenth = Convert.ToInt32(inputValue[1]);
int count = 0;

Console.Write("물이 새는 곳 위치를 쓰시오. : ");
string[] location = Console.ReadLine().Split(' ');
int[] aa = new int[location.Length];
for (int j = 0; j < aa.Length; j++)
{
    aa[j] = int.Parse(location[j]);
}

//물이 세는 위치 오름차순
Array.Sort(location);
int startPoint = aa[0];

//물이 새는 곳이 자연수라 칭했으니 최소 1군데는 존재한다.
count++;

for (int i = 1; i < location.Length; i++)
{
    if (aa[i] - startPoint > tapeLenth -1)
    {
        count++;
        startPoint = aa[i];
    }
}
//string[] inputValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(count);
            
