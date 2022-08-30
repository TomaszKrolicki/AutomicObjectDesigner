using System.ComponentModel.DataAnnotations;
using AutomicObjectDesigner.Models.Objects;

namespace AutomicObjectDesignerBack.Models.Update
{
    public class UpdateSapSimpleDto : SapSimple
    {
        //Entry sequence:
        // step 1

        public enum SapSid
        {
            number,
            number1,
            number2
        }
        public enum SapClient
        {
            number,
            number1,
            number2
        }
        [Required]
        [MaxLength(30)]

        public string? SapReport { get; set; }
        [Required]
        public string? SapVariant { get; set; }
        public bool RoutineJob { get; set; }
        public string? ProcessName { get; set; }
        public string? SapJobName { get; set; }
        public bool DeleteSapJob { get; set; }
    }
}
