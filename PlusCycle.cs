/*
* 0보다 크거나 같고, 99보다 작아야 한다.
* 만약 10보다 작다면 앞에 0을 붙여 두 자리를 만든다.
* 1. 각 자리의 숫자를 더한다.
* 2. 주어진 수의 가장 오른쪽 자리 수와 1의 값 오른쪽 자리 수를 이어 붙여 새로운 수를 만들어 보자
*/
Console.Write("숫자 값을 입력하세요. : ");
string input = Console.ReadLine();
string result = null;
int original = int.Parse(input);
int count = 0;
while (true)
{
  if (input.Length < 2)
  {
      string num = "0" + input;
      input = num;
  }
  int a = int.Parse(input[0].ToString()) + int.Parse(input[1].ToString());
  string b = a.ToString();
  if (b.Length < 2)
  {
      result = input[1].ToString() + b[0].ToString();
  }
  else
  {
      result = input[1].ToString() + b[1].ToString();
  }
  count++;
  input = result;
  if (int.Parse(result) == original)
  {
      Console.Write("결과는 : " + count);
      break;
  }
}
