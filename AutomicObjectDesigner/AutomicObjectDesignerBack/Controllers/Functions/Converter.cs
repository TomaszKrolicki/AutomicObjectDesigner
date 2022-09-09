using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace AutomicObjectDesignerBack.Controllers.Functions;

public class Converter
{

    public string TextKetteConverter(string text)
    {
        Regex reg = new Regex("[!\"#$%&'()*+,./:;<=>?@^`{|}~]");
        text = reg.Replace(text, "-");

        return text;
    }

    public string ConvertText(Regex reg, string text, string replacmentSign)
    {
        text = reg.Replace(text, replacmentSign);

        return text;
    }

    public string TextReportConverter(string text)
    {
        Regex reg = new Regex("[!\"%&'()*+,./:;<=>?^`{|}~]");
        text = reg.Replace(text, "-");

        return text;
    }
    public string TextVariantConverter(string text)
    {
        Regex reg = new Regex("[!\"#$%&'()*+_,./:;<=>?@^`{|}~]");
        text = reg.Replace(text, "-");

        return text;
    }
}