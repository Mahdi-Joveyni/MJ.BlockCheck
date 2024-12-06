﻿namespace MJ.BlockCheck.Tests;

public class SolutionTests
{
   [Fact]
   public void Test_Main_Functionality()
   {
      string[] A = ["unlock.microvirus.md", "visitwar.com", "visitwar.de", "fruonline.co.uk", "australia.open.com", "credit.card.us"];
      string[] B = ["microvirus.md", "visitwar.de", "piratebay.co.uk", "list.stolen.credit.card.us"];

      int[] expected = [1, 3, 4, 5];

      int[] result = Solution.solution(A, B);

      Assert.Equal(expected, result);
   }

   [Fact]
   public void Test_Empty_Input()
   {
      string[] A = [];
      string[] B = [];
      int[] expected = [];
      int[] result = Solution.solution(A, B);
      Assert.Equal(expected, result);
   }

   [Fact]
   public void Empty_BlockList_Should_Return_All()
   {
      string[] A = ["unlock.microvirus.md", "visitwar.com", "visitwar.de", "fruonline.co.uk", "australia.open.com", "credit.card.us"];
      string[] B = [];
      int[] expected = [0, 1, 2, 3, 4, 5];
      int[] result = Solution.solution(A, B);
      Assert.Equal(expected, result);
   }
}