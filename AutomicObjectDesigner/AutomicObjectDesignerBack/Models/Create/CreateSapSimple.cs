using System.ComponentModel.DataAnnotations;
using AutomicObjectDesigner.Models.Objects;
using Microsoft.Build.Framework;



namespace AutomicObjectDesignerBack.Models.Create
{
    public class CreateSapSimple : SapSimple
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
        [System.ComponentModel.DataAnnotations.Required]
        [MaxLength(30)]

        public string? SapReport { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string? SapVariant { get; set; }
        public bool RoutineJob { get; set; }
        public string? PorcessName { get; set; }
        public string? SapJobName { get; set; }
        public bool DeleteSapJob { get; set; }




    }
}
