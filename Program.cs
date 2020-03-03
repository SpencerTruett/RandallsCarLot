using System;
using System.Collections.Generic;

namespace CarLot {
    class Program {
        static void Main (string[] args) {

            List<Dictionary<string, Dictionary<string, string>>> vehicles = new List<Dictionary<string, Dictionary<string, string>>> ();

            Dictionary<string, Dictionary<string, string>> singleVehicle1 = new Dictionary<string, Dictionary<string, string>> ();

            Dictionary<string, string> vehicle1 = new Dictionary<string, string> ();
            Dictionary<string, string> sales_agent1 = new Dictionary<string, string> ();
            Dictionary<string, string> credit1 = new Dictionary<string, string> ();

            vehicle1.Add ("year", "2008");
            vehicle1.Add ("model", "Damfresh");
            vehicle1.Add ("make", "Biotraxquote");
            vehicle1.Add ("color", "sky magenta");
            singleVehicle1.Add ("vehicle", vehicle1);

            sales_agent1.Add ("mobile", "(896) 478-6975)");
            sales_agent1.Add ("last_name", "Botsford");
            sales_agent1.Add ("first_name", "Shaina");
            singleVehicle1.Add ("sale agent", sales_agent1);

            credit1.Add ("credit_provider", "J.P. Morgan Chase & Co");
            credit1.Add ("account", "601109582720302");
            singleVehicle1.Add ("credit", credit1);

            vehicles.Add (singleVehicle1);

            Dictionary<string, Dictionary<string, string>> singleVehicle2 = new Dictionary<string, Dictionary<string, string>> ();

            Dictionary<string, string> vehicle2 = new Dictionary<string, string> ();
            Dictionary<string, string> sales_agent2 = new Dictionary<string, string> ();
            Dictionary<string, string> credit2 = new Dictionary<string, string> ();

            vehicle2.Add ("year", "2010");
            vehicle2.Add ("model", "Hotquadtrax");
            vehicle2.Add ("make", "Transtintechno");
            vehicle2.Add ("color", "robin egg blue");
            singleVehicle2.Add ("vehicle", vehicle2);

            sales_agent2.Add ("mobile", "562.300.2912");
            sales_agent2.Add ("last_name", "Davis");
            sales_agent2.Add ("first_name", "Gerardo");
            singleVehicle2.Add ("sale agent", sales_agent2);

            credit2.Add ("credit_provider", "PNC Financial Services");
            credit2.Add ("account", "34578280562836");
            singleVehicle2.Add ("credit", credit2);

            vehicles.Add (singleVehicle2);

            foreach (Dictionary<string, Dictionary<string, string>> vehicleSale in vehicles) {
                foreach (KeyValuePair<string, Dictionary<string, string>> salesData in vehicleSale) {
                    Console.WriteLine (salesData.Key);
                    Console.WriteLine ("........................................");

                    foreach (KeyValuePair<string, string> dataPoint in salesData.Value) {
                        Console.WriteLine ($"{dataPoint.Key}: {dataPoint.Value}");
                        Console.WriteLine ("-------------------------");
                    }
                }
            }
        }
    }
}