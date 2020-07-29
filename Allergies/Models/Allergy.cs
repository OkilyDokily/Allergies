using System.Collections.Generic;

namespace Allergies{
    public class Allergy{
      private static Dictionary<int, string> ad = new Dictionary<int,string>(){
        {1,"eggs"},{2,"peanuts"},{4,"shellfish"},{8,"strawberries"},{16,"tomatoes"},{32,"chocolate"},{64,"pollen"},{128,"cats"}
      };

      public static int GetHighestDouble(int i){
        int d = 1;
          while(true){
          if((d * 2) >= i){
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
    }
}