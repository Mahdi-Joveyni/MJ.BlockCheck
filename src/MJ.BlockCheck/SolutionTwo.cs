namespace MJ.BlockCheck;

public class SolutionTwo
{
   public static int[] Solution(string[] A, string[] B)
   {
      HashSet<string> suffixSet = new(B);
      List<int> result = [];

      for (int i = 0; i < A.Length; i++)
      {
         if (!IsBlocked(A[i], suffixSet))
            result.Add(i);
      }

      return [.. result];
   }

   private static bool IsBlocked(string host, HashSet<string> blockedDomains)
   {
      var parts = host.Split('.');

      string current = "";
      for (int j = parts.Length - 1; j >= 0; j--)
      {
         current = j == parts.Length - 1 ? parts[j] : parts[j] + "." + current;
         if (blockedDomains.Contains(current))
         {
            return true;
         }
      }

      return false;
   }
}