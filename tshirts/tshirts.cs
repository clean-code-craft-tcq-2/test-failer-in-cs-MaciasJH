using System;
using System.Diagnostics;

namespace TshirtSpace {
    class Tshirt {
        static string Size(int cms) {
            if(cms < 38) {
                return "S";
            } else if(cms > 38 && cms < 42) {
                return "M";
            } else {
                return "L";
            }
        }
        static void Main(string[] args) {
            Debug.Assert(Size(38) != "L"); // Checks for size 38, which is missing in the conditionals and is catched by L
            Debug.Assert(Size(37) == "S");
            Debug.Assert(Size(40) == "M");
            Debug.Assert(Size(43) == "L");
            Debug.Assert(Size(1000) == "Size outside human reality"); // Should not accept unrealistic sizes            
            Console.WriteLine( "All is well (maybe!)");
        }
    }
}
