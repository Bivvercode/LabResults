using System;
using System.IO;
using System.Linq;
using LabResultsExercise.Data;
using LabResultsExercise.Models;

namespace LabResultsExercise.Services
{
    public class LabResultsImporterService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public void ImportResultsFromFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            
            for (var i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                var columns = line.Split('|');
                
                var labResult = new LabResult
                {
                    ClinicNumber = int.Parse(columns[0]),
                    Barcode = long.Parse(columns[1]),
                    PatientId = int.Parse(columns[2]),
                    PatientName = columns[3],
                    DateOfBirth = DateTime.Parse(columns[4]),
                    Gender = columns[5],
                    CollectionDate = DateTime.Parse(columns[6]),
                    CollectionTime = columns[7],
                    TestCode = columns[8],
                    TestName = columns[9],
                    Result = columns[10],
                    Unit = columns[11],
                    ReferenceRangeLow = columns[12],
                    ReferenceRangeHigh = columns[13],
                    Note = columns[14],
                    NonSpecificReferences = columns[15]
                };

                if (!_context.LabResults.Any(result => 
                    result.Barcode == labResult.Barcode))
                {
                    _context.LabResults.Add(labResult);
                }

                _context.SaveChanges();
            }
        }
    }
}