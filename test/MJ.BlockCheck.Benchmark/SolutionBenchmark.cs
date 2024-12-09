using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using System;

namespace MJ.BlockCheck.Benchmark;

public class SolutionBenchmark
{
   string[] A = ["unlock.microvirus.md", "visitwar.com", "visitwar.de", "fruonline.co.uk", "australia.open.com", "credit.card.us"];
   string[] B = ["microvirus.md", "visitwar.de", "piratebay.co.uk", "list.stolen.credit.card.us"];


   [Benchmark]
   public int[] Benchmark_OptimizedSolution()
   {
      return SolutionTwo.Solution(A, B);
   }

   [Benchmark]
   public int[] Benchmark_OldSolution()
   {
      return SolutionOne.Solution(A, B);
   }


}
