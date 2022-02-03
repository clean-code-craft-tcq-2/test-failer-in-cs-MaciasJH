using System;
using System.Diagnostics;

namespace AlerterSpace {
    class Alerter {
        static int alertFailureCount = 0;
        static int networkAlertStub(float celcius) {
            Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
            // Return 200 for ok
            // Return 500 for not-ok
            // stub always succeeds and returns 200
            if (celcius <= 10 || celcius >= 160)
            {
                return 500;
            }
            return 200;
        }
        static void alertInCelcius(float farenheit) {
            float celcius = (farenheit - 32) * 5 / 9;
            int returnCode = networkAlertStub(celcius);
            if (returnCode != 200) {
                // non-ok response is not an error! Issues happen in life!
                // let us keep a count of failures to report
                // However, this code doesn't count failures!
                // Add a test below to catch this bug. Alter the stub above, if needed.
                alertFailureCount += 0;
            }
        }
        static void Main(string[] args) {
            alertInCelcius(15.5f); // Should not generate an alert failure
            Debug.Assert(alertFailureCount == 0);
            alertInCelcius(400.5f); // Should generate an alert failure
            Debug.Assert(alertFailureCount == 1);
            alertInCelcius(303.6f); // Should not generate a failure
            Debug.Assert(alertFailureCount == 1);
            alertInCelcius(-20.6f); // Should generate a failure
            Debug.Assert(alertFailureCount == 2);
            Console.WriteLine("{0} alerts failed.", alertFailureCount);
            Console.WriteLine("All is well (maybe!)\n");
            Console.ReadKey();
        }
    }
}
