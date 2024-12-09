namespace MJ.BlockCheck;

public class SolutionOne
{
   public static int[] Solution(string[] A, string[] B)
   {
      HashSet<string> blockedDomains = [];
      foreach (string domain in B)
      {
         var parts = domain.Split('.');
         Array.Reverse(parts);
         blockedDomains.Add(string.Join(".", parts));
      }

      List<int> result = [];

      for (int i = 0; i < A.Length; i++)
      {
         if (!IsBlocked(A[i], blockedDomains))
            result.Add(i);
      }

      return [.. result];
   }

   private static bool IsBlocked(string host, HashSet<string> blockedDomains)
   {
      var parts = host.Split('.');
      Array.Reverse(parts);

      string current = "";
      for (int j = 0; j < parts.Length; j++)
      {
         current = j == 0 ? parts[j] : current + "." + parts[j];
         if (blockedDomains.Contains(current))
         {
            return true;
         }
      }

      return false;
   }
}