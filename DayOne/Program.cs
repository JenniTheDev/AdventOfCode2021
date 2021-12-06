// https://adventofcode.com/2021/day/1
// https://adventofcode.com/2021/day/1#part2

using HelpfulStuff;

// Part One
var inputPath = @"DepthMeasurements.txt";
var partOne = Methods.CountIncreaseFromRange(inputPath, 1);

// Part Two
var partTwo = Methods.CountIncreaseFromRange(inputPath, 3);

Console.WriteLine($"Day 1, Part 1 increases: {partOne}");
Console.WriteLine($"Dat 1, Part 1 increases: {partTwo}");
