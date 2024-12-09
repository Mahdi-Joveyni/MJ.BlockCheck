using BenchmarkDotNet.Running;
using MJ.BlockCheck.Benchmark;

var summary = BenchmarkRunner.Run<SolutionBenchmark>();