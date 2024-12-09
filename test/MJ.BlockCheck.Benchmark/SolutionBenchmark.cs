using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using System;

namespace MJ.BlockCheck.Benchmark;

public class SolutionBenchmark
{
   string[] A;
   string[] B;

   [GlobalSetup]
   public void Setup()
   {
      B = GenerateBlockedDomains(200);
      A = GenerateHosts(2000, B);
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
      return [.. hosts];
   }


   [Benchmark]
   public int[] Benchmark_OldSolution()
   {
      return SolutionOne.Solution(A, B);
   }

   [Benchmark]
   public int[] Benchmark_OptimizedSolution()
   {
      return SolutionTwo.Solution(A, B);
   }

}
