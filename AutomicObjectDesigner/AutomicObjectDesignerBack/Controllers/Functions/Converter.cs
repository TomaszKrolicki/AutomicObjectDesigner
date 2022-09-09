using System.Text.RegularExpressions;

namespace AutomicObjectDesignerBack.Controllers.Functions;

public class Converter
{

    public string TextKetteConverter(string text)
    {
        Regex reg = new Regex("[!\"#$%&'()*+,./:;<=>?@^`{|}~]");
        text = reg.Replace(text, "-");

        return text;
    }
}