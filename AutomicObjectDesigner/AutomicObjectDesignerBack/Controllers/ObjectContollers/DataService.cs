using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutomicObjectDesigner.Models.Objects;

namespace AutomicObjectDesignerBack.Controllers.ObjectContollers
{
    public class DataService
    {
        public static DataService Current { get; } = new DataService();
        public List<SapSimple> SapSimple { get; set; }

        public DataService()
        {
            SapSimple = new List<SapSimple>()
            {
                new SapSimple
                {
                    Agent = "Tadzio",
                    Active = true,
                    DeleteSapJob = false,
                    Folder = "Document",
                    Id = 5,
                    Login = "Tadzio",
                    MaxParallelTasks = 5,
                    OwnerId = 4,
                    PorcessName = "process",
                    PostProcess = "postprocess",

                },
                new SapSimple
                {
                Agent = "Adzio",
                Active = true,
                DeleteSapJob = false,
                Folder = "Document",
                Id = 6,
                Login = "Adzio",
                MaxParallelTasks = 6,
                OwnerId = 5,
                PorcessName = "process",
                PostProcess = "postprocess",

                }
            };
        }
    }
}
