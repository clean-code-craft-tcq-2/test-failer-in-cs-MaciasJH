using System;
using System.Diagnostics;

namespace MisalignedSpace {
    class Misaligned {

        static string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
        static string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
        static int printColorMap() {            
            int i = 0, j = 0;
            for(i = 0; i < 5; i++) {
                for(j = 0; j < 5; j++) {
                    Console.WriteLine(printColorPair(i, j));                    
                }
            }
            return i * j;
        }

        static string printColorPair(int i, int j)
        {
            return i * 5 + j + " | " + majorColors[i] + " | " + minorColors[i];
        }
        static void Main(string[] args) {
            int result = printColorMap();
            Debug.Assert(result == 25);
            Debug.Assert(printColorPair(0, 0) == "0 | White | Blue");
            Debug.Assert(printColorPair(2, 3) == "13 | Black | Brown");
            Debug.Assert(printColorPair(4, 1) == "0 | Violet | Orange");
            Console.WriteLine("All is well (maybe!)");
        }        
    }
}