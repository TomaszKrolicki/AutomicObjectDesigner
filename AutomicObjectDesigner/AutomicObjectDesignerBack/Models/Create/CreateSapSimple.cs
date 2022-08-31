using System.ComponentModel.DataAnnotations;
using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesignerBack.Models.Objects;
using Microsoft.Build.Framework;



namespace AutomicObjectDesignerBack.Models.Create
{
    public class CreateSapSimple : SapSimple
    {

        //Entry sequence:
        // step 1

        //TODO: Need to fix max length
        [System.ComponentModel.DataAnnotations.Required]
        [MaxLength(42)]

        public string? SapReport { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string? SapVariant { get; set; }
        public bool RoutineJob { get; set; }
        public string? ProcessName { get; set; }
        public string? SapJobName { get; set; }
        public bool DeleteSapJob { get; set; }

    }
}
