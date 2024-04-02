using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      string pass = Console.ReadLine();
      int minlength =  6;
      string upperC = pass.ToUpper();
      string lowerC = pass.ToLower();
      string digits = "123456789";
      string specialChar = "!@#$%^&*-_=+";
      int score = 0;


      if (Tools.Contains(pass, digits)){
            score++;
      }

      if (pass.Length >= minlength) {
              score++;
      }

      if (Tools.Contains(pass, upperC)){
          score++;
      }

      if (Tools.Contains(pass, lowerC)){
          score++;
      }

      if (Tools.Contains(pass, specialChar)){
        score++;
      }

      switch(score){
          case 1:
            Console.WriteLine("pass is weak");
            break;
          case 2:
            Console.WriteLine("pass is alright");
            break;
          case 3:
            Console.WriteLine("pass is good");
            break;
        case 4:
            Console.WriteLine("pass is great");
            break;
        case 5:
            Console.WriteLine("pass is extremly good");
            break;
      }
    }
  }
}
