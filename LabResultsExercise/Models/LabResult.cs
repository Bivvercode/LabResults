using System.ComponentModel.DataAnnotations;

namespace LabResultsExercise.Models
{
    public class LabResult
    {
        [Required]
        public int ClinicNumber { get; set; }
        
        [Key]
        [Required]
        public long Barcode { get; set; }
        
        [Required]
        public int PatientId { get; set; }
        
        [Required]
        public string PatientName { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }
        
        [Required]
        public string Gender { get; set; }
        
        [Required]
        public DateTime CollectionDate { get; set; }
        
        [Required]
        public string CollectionTime { get; set; }
        
        [Required]
        public string TestCode { get; set; }
        
        [Required]
        public string TestName { get; set; }
        
        [Required]
        public string Result { get; set; }

        public string? Unit { get; set; }
        public string? ReferenceRangeLow { get; set; }
        public string? ReferenceRangeHigh { get; set; }
        public string? Note { get; set; }
        public string? NonSpecificReferences { get; set; }
    }
}