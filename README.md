# Benchmarks
* Summary *

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


| Method                      | Mean     | Error   | StdDev   |
|---------------------------- |---------:|--------:|---------:|
| Benchmark_OldSolution       | 370.8 us | 8.31 us | 24.10 us |
| Benchmark_OptimizedSolution | 305.8 us | 6.11 us | 17.73 us |

 * Hints *
Outliers
  SolutionBenchmark.Benchmark_OldSolution: Default       -> 3 outliers were removed (439.20 us..446.30 us)
  SolutionBenchmark.Benchmark_OptimizedSolution: Default -> 1 outlier  was  removed (376.58 us)

 * Legends *
  Mean   : Arithmetic mean of all measurements
  Error  : Half of 99.9% confidence interval
  StdDev : Standard deviation of all measurements
  1 us   : 1 Microsecond (0.000001 sec)

 ***** BenchmarkRunner: End *****
Run time: 00:02:32 (152.61 sec), executed benchmarks: 2

Global total time: 00:02:43 (163.49 sec), executed benchmarks: 2

To Run the benchmarks, run the following command in the terminal:	dotnet run -c Release --project test/MJ.BlockCheck.Benchmark

# MJ.BlockCheck
 
A router has an in-memory collection B of M external domains which cannot be visited by local network user. There is a rule that if a domain is blocked, any its subdomains are blocked too. For example, if domain adult.hb is blocked, the following hosts are blocked too: images.adult.hb, ringo.adult.hb, video.ringo.adult.hb Write a function (in C#): 

`class Solution { public static int[] solution(string[] A, string[] B); }` 

that, given a non-empty array A of N hosts, and B of M blocked domains, returns a sequence consisting of L integers where each integer represents an index of a host in input A array that can be visited by user. For example, given: 

| A[0] = unlock.microvirus.md | B[0] = microvirus.md					 |

| A[1] = visitwar.com   		       |   B[1] = visitwar.de						 |

| A[2] = visitwar.de 		           |    B[2] = piratebay.co.uk				 |

| A[3] = fruonline.co.uk		       |    B[3] = list.stolen.credit.card.us |

| A[4] = australia.open.com     |													

| A[5] = credit.card.us	           |
 the function should return the array [1, 3, 4, 5], as explained above. 

 **Assume that:** 

 - N and M are integers within the range [1..20,000];
 - L is integer within the range [0..20,000];
 - each element of array A is a string with length [2.. 256];
 - each element of collection B is a string with length [2..256].

   **Complexity:**

 - expected worst-case time complexity is O(N);

 - expected worst-case space complexity is O(M)

beyond input storage (not counting the storage required for input arguments). Looping over the list B for each item in the list A to find a match is not an option. If we check 1000 hosts in the list of 100 blocked domains, we would do this way 100000 string comparisons. It would be simply too slow. The list of blocked domains B can be considered as rare changed. Elements of input arrays cannot be modified