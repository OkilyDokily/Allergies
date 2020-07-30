using System.Collections.Generic;
using System;
namespace Allergies{
    public class Allergy{
      private static Dictionary<int, string> ad = new Dictionary<int,string>(){
        {1,"eggs"},{2,"peanuts"},{4,"shellfish"},{8,"strawberries"},{16,"tomatoes"},{32,"chocolate"},{64,"pollen"},{128,"cats"}
      };

      public static int GetHighestDouble(int i){
        int d = 1;
          while(true){
            if (d == i){
              return d;
            }
            else if((d * 2) > i){
              return d;
            }
            else{
              d *= 2;
            }
        }
      }

      public static int GetDifference(int i){
        int n = GetHighestDouble(i);
        return i - n;
      }

      public static int GetHighestDoubleOnDifference(int i){
        int n = GetDifference(i);
        return GetHighestDouble(n);
      }

      public static string GetStringFromHighestDouble(int i){
        return ad[GetHighestDouble(i)];
      } 

      public static string[] GetStringArrayFromHighestDoubleAndDifference(int i){
        int d = GetDifference(i);
        string s = GetStringFromHighestDouble(d);
        string f = GetStringFromHighestDouble(i);

        return new string[] {f,s};
      }

      public static string[] GetAllergyStringArray(int i){
        int c = i;
        List<string> l = new List<string>();
        while (c > 0){ 
          l.Add(GetStringFromHighestDouble(c));
          c  = GetDifference(c);
          Console.WriteLine(c);
        }
        foreach(string str in l){
          Console.WriteLine(str);
        }
        return l.ToArray();
      }
    }
}