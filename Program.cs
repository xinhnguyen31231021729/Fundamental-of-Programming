internal class Section04()
{

    static void Main(string[] args)
    {
        int win = 0;
        int time = 0;
        int lose = time - win;
        int money = 1000;
        
        do
        {
            Random rnd = new Random();
            int com_num = rnd.Next(1, 100);
            time++;
            for (int i = 0; i < 5; i++) 
            {     
            
                Console.WriteLine("Your number is: ");
                int man_num = int.Parse("0" + Console.ReadLine());

                if (man_num == com_num)
                {
                Console.WriteLine("You win");
                    win++;money += 100;             
                break;
                }
                else
                if (man_num < com_num)
                Console.WriteLine("Your number is less than com's number");
                else
                Console.WriteLine("Your number is greater than com's number");
            }


            Console.WriteLine($"The com's number is: {com_num}");
            Console.WriteLine("Do you want to play again ?  <Y/N>");
            string res = "" + Console.ReadLine();
            if (res.ToUpper().Equals("N"))
            {
                Console.WriteLine("See u again");
                Console.WriteLine("Your money ");
                break;
            }
        }

        while (true);
      
    }  
}