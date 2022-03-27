using System.Xml;
using AdapterPattern.Interfaces;
using AdapterPattern.Model;
using Newtonsoft.Json;

namespace AdapterPattern.Adapters;


public class LumiaXMLAdapter : ILumiaXMLTarget
{
    private readonly LumiaJSON _lumiaJSONAdaptee = new LumiaJSON();

    public XmlDocument GetLumiaMobilesXMLSpecification()
    {
        LumiaJSON lumiaJsonAdaptee = new LumiaJSON();
        string jsonLumia = lumiaJsonAdaptee.GetLumiaMobilesJSONSpecification();
        Console.WriteLine("JSON------------------------------------------");
        Console.WriteLine(jsonLumia);
        var xmlResult = JsonConvert.DeserializeXmlNode(jsonLumia, "MicrosoftLumiaMobiles", true);
        return xmlResult!;
    }
}