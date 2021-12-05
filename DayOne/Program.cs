// https://adventofcode.com/2021/day/1
// https://adventofcode.com/2021/day/1#part2

using HelpfulStuff;

var inputPath = @"DepthMeasurements.txt";
var partOne = Methods.CountIncreaseFromRange(inputPath, 1);

Console.WriteLine($"Day 1, Part 1 increases: {partOne}");
