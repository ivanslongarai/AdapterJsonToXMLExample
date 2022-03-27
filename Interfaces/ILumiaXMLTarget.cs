using System.Xml;

namespace AdapterPattern.Interfaces;


public interface ILumiaXMLTarget
{
    XmlDocument GetLumiaMobilesXMLSpecification();
}