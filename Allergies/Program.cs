using System;
namespace Allergies{
  public class Program{
    public static void Main(){
      Console.WriteLine("What is your allergies score?");
      int i = int.Parse(Console.ReadLine());
      string[] s = Allergy.GetAllergyStringArray(i);
      Console.WriteLine("You have these allergies:");
      foreach(string str in s){
        Console.WriteLine(str);
      }
    }
  }
}