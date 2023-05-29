class Program
{
    static void Main(string[] args)
    {

        #region 거스름 돈 
        int a = 0;
        int aa = 0;
        int ori = 1000;
        Console.WriteLine("가격은 ??: ");

        int price = Convert.ToInt32(Console.ReadLine());

        while (price > 1000 || price < 1)
        {
            Console.WriteLine("1이상 1000이하로 입력을 해주세요. : ");
            price = Convert.ToInt32(Console.ReadLine());
            if (price < 1000 && price > 1)
            {
                break;
            }
        }

        int resultPrice = ori - price;

        int[] changeList = { 500, 100, 50, 10, 5, 1 };

        for (int i = 0; i < changeList.Length; i++)
        {
            aa = resultPrice / changeList[i];
            a += aa;

            resultPrice = resultPrice % changeList[i];
        }

        System.Console.WriteLine(a);
        #endregion

    }

}


}
