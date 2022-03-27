using AdapterPattern.Interfaces;
using Newtonsoft.Json;

namespace AdapterPattern.Model;


public class LumiaJSON : ILumiaJSON
{
    private readonly List<LumiaMobile> _lumiaMobileList = new List<LumiaMobile>();
    public string GetLumiaMobilesJSONSpecification()
    {
        _lumiaMobileList.Add(new LumiaMobile("lumia550", "145 mm", "72 mm", "8.3", "150 g"));
        _lumiaMobileList.Add(new LumiaMobile("lumia560", "135 mm", "50 mm", "8.1", "140 g"));
        _lumiaMobileList.Add(new LumiaMobile("lumia570", "155 mm", "68 mm", "9.0", "160 g"));
        _lumiaMobileList.Add(new LumiaMobile("lumia580", "165 mm", "95 mm", "7.5", "180 g"));
        _lumiaMobileList.Add(new LumiaMobile("lumia590", "115 mm", "47 mm", "8.0", "190 g"));
        return JsonConvert.SerializeObject(new { lumiaMobiles = _lumiaMobileList });
    }
}
