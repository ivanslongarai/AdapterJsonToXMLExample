namespace AdapterPattern.Model;


public class LumiaMobile
{
    public LumiaMobile()
    {
    }

    public LumiaMobile(string modelId, string height, string width, string thickness, string weight)
    {
        ModelId = modelId;
        Height = height;
        Width = width;
        Thickness = thickness;
        Weight = weight;
    }

    public string? ModelId { get; set; }
    public string? Height { get; set; }
    public string? Width { get; set; }
    public string? Thickness { get; set; }
    public string? Weight { get; set; }

}