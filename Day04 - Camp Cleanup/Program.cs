﻿var CampData = File.ReadAllText("PuzzleInput.txt");

// Test Data
/*
const string dummyData = @"2-4,6-8
2-3,4-5
5-7,7-9
2-8,3-7
6-6,4-6
2-6,4-8";
*/

var splitData = CampData.Split('\n');
int counter = 0;

foreach (var s in splitData)
{
    var segments = s.Split(',');
    var segmentLeft = segments[0].Split('-');
    var segmentRight = segments[1].Split('-');

    var segmentLeftMin = int.Parse(segmentLeft[0]);
    var segmentLeftMax = int.Parse(segmentLeft[1]);

    var segmentRightMin = int.Parse(segmentRight[0]);
    var segmentRightMax = int.Parse(segmentRight[1]);

    if ((segmentLeftMin <= segmentRightMin && segmentLeftMax >= segmentRightMax) || (segmentRightMin <= segmentLeftMin && segmentLeftMax <= segmentRightMax)) counter++;
}

Console.WriteLine($"Part 1: Solution is {counter}");

counter = 0;
foreach (var s in splitData)
{
    var segments = s.Split(',');
    var segmentLeft = segments[0].Split('-');
    var segmentRight = segments[1].Split('-');

    var segmentLeftMin = int.Parse(segmentLeft[0]);
    var segmentLeftMax = int.Parse(segmentLeft[1]);

    var segmentRightMin = int.Parse(segmentRight[0]);
    var segmentRightMax = int.Parse(segmentRight[1]);

    if (segmentRightMin < segmentLeftMin)
    {
        List<int> tmp = new List<int> { segmentRightMin, segmentRightMax, segmentLeftMin, segmentLeftMax };
        segmentLeftMin = tmp[0];
        segmentLeftMax = tmp[1];
        segmentRightMin = tmp[2];
        segmentRightMax = tmp[3];
    }

    if (segmentLeftMax >= segmentRightMin)
    {
        counter++;
    }
}

Console.WriteLine($"Part 2: Solution is {counter}");