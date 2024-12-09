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
      Console.WriteLine($"Old: {t1} us, New: {t2} us");
   }



   [Fact]
   public void Test_Empty_Input()
   {
      string[] A = [];
      string[] B = [];
      int[] expected = [];
      int[] result = SolutionOne.Solution(A, B);
      int[] result2 = SolutionTwo.Solution(A, B);
      Assert.Equal(expected, result);
      Assert.Equal(expected, result2);
   }

   [Fact]
   public void Empty_BlockList_Should_Return_All()
   {
      string[] A = ["unlock.microvirus.md", "visitwar.com", "visitwar.de", "fruonline.co.uk", "australia.open.com", "credit.card.us"];
      string[] B = [];
      int[] expected = [0, 1, 2, 3, 4, 5];
      int[] result = SolutionOne.Solution(A, B);
      int[] result2 = SolutionTwo.Solution(A, B);
      Assert.Equal(expected, result);
      Assert.Equal(expected, result2);
   }
}
