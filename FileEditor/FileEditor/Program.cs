﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileEditor
{
    class Program
    {
        /// <summary>
        /// Main program entry point
        /// NOTE: DO NOT EDIT THIS FILE, except to uncomment 
        /// dataService.ConvertToXML(numbers) if doing the bonus challenge
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Instantiate the data service
            DataService dataService = new DataService();

            // Create the test file data
            dataService.CreateTestFile();

            // Read in the test data
            dataService.ReadTestData();

            // Display the original test data
            dataService.DisplayTestData();

            // Add another number to the data set
            dataService.AppendTestData(6);

            // Read the updated file data
            dataService.ReadTestData();

            // Display the updated test data
            dataService.DisplayTestData();

            // Display the total
            dataService.DisplayTotal();

            // Convert to XML format
            dataService.ConvertToXML();

            // Keep the program open until the user presses a key
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
