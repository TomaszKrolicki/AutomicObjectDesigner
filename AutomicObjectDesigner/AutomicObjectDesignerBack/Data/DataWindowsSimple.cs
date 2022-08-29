using AutomicObjectDesigner.Models.Objects;

namespace AutomicObjectDesignerBack.Data
{
    public class DataWindowsSimple
    {
        public static DataWindowsSimple Current { get; } = new DataWindowsSimple();
        public List<WindowsSimple> WindowsSimpleData { get; set; }

        public DataWindowsSimple()
        {
            WindowsSimpleData = new List<WindowsSimple>()
            {
                new WindowsSimple
                {
                    Id = 1,
                    ProcessName = "",
                    NameSuffix = "",
                    ObjectName = "",
                    ProcessInfo = "",
                    Docu = "",
                    Title = "",
                    Archive1 = "",
                    Archive2 = "",
                    InternalAccount = "",
                    Floder = "",
                },
                new WindowsSimple
                {
                    Id = 2,
                    ProcessName = "",
                    NameSuffix = "",
                    ObjectName = "",
                    ProcessInfo = "",
                    Docu = "",
                    Title = "",
                    Archive1 = "",
                    Archive2 = "",
                    InternalAccount = "",
                    Floder = "",
                }
            };
        }
    }
}