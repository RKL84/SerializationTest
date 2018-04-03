using eTakeoff.Bridge.Core.Model;
using eTakeoff.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SerializerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var eTkoString = File.ReadAllText(@"eTakeoffSerializerInput.txt");
            var result = new List<BridgeAssignmentSummary>();
            eTkoString = eTkoString.Replace("\r\n", "").ToString();

            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int iCount = 0; iCount < 3000; iCount++)
            {
                var data = new BridgeAssignmentSummary();
                var stringReader = new RStringReader(ref eTkoString);
                data.StreamIn(stringReader);
                result.Add(data);
            }

            watch.Stop();
            var elapsTime = watch.ElapsedMilliseconds;
            Console.WriteLine($"Serialization using eTakeoff serializer took {elapsTime} milliseconds");

            //prepare the sample data for JSON parser
            //using the first object in the collection
            var testData = result.First();
            JSONStringWriter writer1 = new JSONStringWriter();
            testData.StreamOut(writer1);
            var value1 = writer1.GetText();

            watch.Restart();
            result = new List<BridgeAssignmentSummary>();
            for (int iCount = 0; iCount < 3000; iCount++)
            {
                var reader1 = new JSONStringReader(value1);
                testData = new BridgeAssignmentSummary();
                testData.StreamIn(reader1);
                result.Add(testData);
            }

            watch.Stop();
            elapsTime = watch.ElapsedMilliseconds;
            Console.WriteLine($"Serialization using Newtonsoft JSON.NET serializer took {elapsTime} milliseconds");
            Console.Read();
        }
    }
}

