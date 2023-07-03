namespace A2G.Backend.Core;

internal class Sensor
{
    public string Id { get; private set; }
    public string Timestamp { get; private set; }
    public int Value { get; private set; }
    
    public Noise Noise
    {
        get
        {
            return Value switch
            {
                >= 0 and < 60 => Noise.Low,
                >= 60 and < 120 => Noise.Medium,
                >= 120 and <= 200 => Noise.High,
                _ => throw new Exception($"Invalid value: {Value}")
            };
        }
    }

    
    public Sensor(string id, string timestamp, int value)
    {
        Id = id;
        Timestamp = timestamp;
        Value = value;
    }
}