namespace MJ.BlockCheck.Tests;

public class SolutionTwoTests
{
   [Fact]
   public void Test_Main_Functionality()
   {
      string[] A = ["unlock.microvirus.md", "visitwar.com", "visitwar.de", "fruonline.co.uk", "australia.open.com", "credit.card.us"];
      string[] B = ["microvirus.md", "visitwar.de", "piratebay.co.uk", "list.stolen.credit.card.us"];

      int[] expected = [1, 3, 4, 5];

      var Stopwatch = new System.Diagnostics.Stopwatch();
      Stopwatch.Start();
      int[] result = SolutionOne.Solution(A, B);
      var t1 = Stopwatch.Elapsed.TotalMicroseconds;
      Stopwatch.Restart();
      int[] result2 = SolutionTwo.Solution(A, B);
      var t2 = Stopwatch.Elapsed.TotalMicroseconds;

      Assert.Equal(expected, result);
      Assert.Equal(expected, result2);
   }

   [Fact]
   public void Test_Main_Functionality_LargeData()
   {
      string[] B = GenerateBlockedDomains(200);
      string[] A = GenerateHosts(2000, B);

      int[] expected = [1, 3, 4, 5];

      var Stopwatch = new System.Diagnostics.Stopwatch();
      Stopwatch.Start();
      int[] result = SolutionOne.Solution(A, B);
      var t1 = Stopwatch.Elapsed.TotalMicroseconds;
      Stopwatch.Restart();
      int[] result2 = SolutionTwo.Solution(A, B);
      var t2 = Stopwatch.Elapsed.TotalMicroseconds;
      Stopwatch.Stop();
      //Assert.Equal(expected, result);
      //Assert.Equal(expected, result2);
   }

   private string[] GenerateBlockedDomains(int count)
   {
      var blockedDomains = new List<string>();
      for (int i = 0; i < count; i++)
      {
         blockedDomains.Add($"blocked{i}.example.com");
      }
      return blockedDomains.ToArray();
   }

   private string[] GenerateHosts(int count, string[] blockedDomains)
   {
      var hosts = new List<string>();
      var random = new Random();
      for (int i = 0; i < count; i++)
      {
         if (i % 10 == 0)
         {
            // Add some blocked hosts
            hosts.Add($"sub{i}.{blockedDomains[random.Next(blockedDomains.Length)]}");
         }
         else
         {
            // Add some non-blocked hosts
            hosts.Add($"host{i}.example.net");
         }
      }
      return hosts.ToArray();
   }

   [Fact]
   public void Test_Empty_Input()
   {
      string[] A = [];
      string[] B = [];
      int[] expected = [];
      int[] result = SolutionTwo.Solution(A, B);
      Assert.Equal(expected, result);
   }

   [Fact]
   public void Empty_BlockList_Should_Return_All()
   {
      string[] A = ["unlock.microvirus.md", "visitwar.com", "visitwar.de", "fruonline.co.uk", "australia.open.com", "credit.card.us"];
      string[] B = [];
      int[] expected = [0, 1, 2, 3, 4, 5];
      int[] result = SolutionTwo.Solution(A, B);
      Assert.Equal(expected, result);
   }
}
