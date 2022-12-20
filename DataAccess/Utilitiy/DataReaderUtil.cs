using DataAccess.Entities;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.Utilitiy
{
    internal static class DataReaderUtil
    {
        public static List<CovidData> ReadDummyCovidDataset()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            
            List<CovidData> dataset = new List<CovidData>();

            using (var package = new ExcelPackage(new FileInfo(Path.Combine(Environment.CurrentDirectory, @"Assets\covid_dataset.xlsx"))))
            {
                var sheet = package.Workbook.Worksheets[0];
                int xx = sheet.Rows.EndRow;
                for (int i = 2; i < sheet.Rows.EndRow; i++)
                {                    
                    if (sheet.Cells["A" + i] == null || sheet.Cells["A" + i].Value == null)
                    {
                        break;
                    }                    

                    dataset.Add(new CovidData
                    { 
                        Id = Convert.ToInt32(sheet.Cells["A" + i].Value.ToString()),
                        patientId = sheet.Cells["B" + i].Value.ToString(),
                        DateOfBirth = Convert.ToDateTime(sheet.Cells["C" + i].Value.ToString()),
                        Sex = sheet.Cells["D" + i].Value.ToString(),
                        Location = sheet.Cells["E" + i].Value.ToString(),
                        CovidDateTested = Convert.ToDateTime(sheet.Cells["F" + i].Value.ToString()),
                        CovidResult = sheet.Cells["G" + i].Value.ToString()
                    });
                }
            }

            return dataset;
        }
    }
}
