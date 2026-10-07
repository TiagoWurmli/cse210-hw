using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.DisplayStartingMessege();
        breathingActivity.Run();
    }
}