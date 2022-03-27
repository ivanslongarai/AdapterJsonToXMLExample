
using System.Xml;
using AdapterPattern.Adapters;
using AdapterPattern.Interfaces;

ILumiaXMLTarget lumiaXMLTarget = new LumiaXMLAdapter();
var xmlLumiaMobile = lumiaXMLTarget.GetLumiaMobilesXMLSpecification();

using (var stringWriter = new StringWriter())
using (var xmlTextWriter = XmlWriter.Create(stringWriter))
{
    xmlLumiaMobile.WriteTo(xmlTextWriter);
    xmlTextWriter.Flush();
    Console.WriteLine("XML-------------------------------------------");
    Console.WriteLine(stringWriter.GetStringBuilder().ToString());

}
