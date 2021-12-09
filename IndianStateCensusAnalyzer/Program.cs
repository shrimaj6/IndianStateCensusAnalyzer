using IndianCensusAnalyzer;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace IndianStateCensusAnalyzer
{
    public class Program
    {

        public static void Main(string[] args)
        {
            ImportCSVData obj = new ImportCSVData("D:/IndianStateCensusAnalyzer/IndianStateCensusAnalyzer/IndianStateCensusData.csv");
            obj.ImportData();
        }
    }
}