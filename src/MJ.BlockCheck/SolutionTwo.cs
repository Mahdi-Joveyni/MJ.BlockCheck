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

      // return A.Select((host, index) => (host, index)).Where(x => !IsBlocked(x.host, B)).Select(x => x.index).ToArray();

      return [.. result];
   }

   private static bool IsBlocked(string host, HashSet<string> blockedDomains)
   {
      return blockedDomains.Any(domain => host.EndsWith(domain));
   }
}