class Program
  {
      static void Main(string[] args)
      {
          #region 알고리즘 ATM
          int[] timeList;
          string[] ff;
          int count;

          while (true)
          {
              Console.Write("N명 값을 쓰세요. : ");
              string tt = Console.ReadLine();
              count = Convert.ToInt32(tt);
              timeList = new int[count];

              string time = Console.ReadLine();
              ff = time.Split(' ');

              if (ff.Length != timeList.Length)
              {
                  Console.Write("입력이 잘못 되었습니다. 다시 입력해주세요.\n");
              }
              else
              {
                  for (int i = 0; i < count; i++)
                  {
                      timeList[i] = Convert.ToInt32(ff[i].Trim());
                  }
                  break;
              }
          }

          //정렬
          Array.Sort(timeList);

          int prev = 0; //이전까지의 누적 시간
          int sum = 0; //사람별 대기시간 총합

          for (int i = 0; i < count; i++)
          {
              sum += prev + timeList[i];
              prev += timeList[i];
          }
          System.Console.WriteLine(sum);
          #endregion
          }

  }
}
