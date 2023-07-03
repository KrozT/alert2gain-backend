// See https://aka.ms/new-console-template for more information

using System.Net.Http.Headers;
using System.Text.Json;
using A2G.Backend.Core;

/*
 * API Necessary Credentials 
 */
var api = Environment.GetEnvironmentVariable("A2G_API_URL");

var authEmail = Environment.GetEnvironmentVariable("A2G_EMAIL");
var authPassword = Environment.GetEnvironmentVariable("A2G_PASSWORD");

var sensorId = Environment.GetEnvironmentVariable("A2G_SENSOR_ID");

/*
 * Define the HTTP Client and the Sensors Collection
 */
var apiUri = new Uri(api!);
var client = new HttpClient();

var sensorsCollection = new List<Sensor>();

/*
 * Helper Methods 
 */
void SetToken(string? token)
{
    client!.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
}

async Task Login(string email, string password)
{
    var data = new { email, password };
    var json = JsonSerializer.Serialize(data);
    var content = new StringContent(json);
    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

    var response = await client!.PostAsync($"{apiUri}/auth", content);
    if (response.IsSuccessStatusCode)
    {
        var result = await response.Content.ReadAsStringAsync();
        var token = JsonSerializer.Deserialize<JsonElement>(result).GetProperty("token").GetString();
        SetToken(token);
        
        Console.WriteLine($"Logged in successfully and received token");
    }
    else
    {
        Console.WriteLine($"Error: {response.StatusCode}");
    }
}

async Task FetchRecords(string id, int pageNumber, int pageSize)
{
    var response = await client!.GetAsync($"{apiUri}/records/{id}?pageNumber={pageNumber}&pageSize={pageSize}");
    if (response.IsSuccessStatusCode)
    {
        var result = await response.Content.ReadAsStringAsync();
        var sensors = JsonSerializer.Deserialize<JsonElement>(result);
        var data = sensors.GetProperty("data");

        sensorsCollection.AddRange(data.EnumerateArray()
            .Select(record => new Sensor(id, 
                    record.GetProperty("ts").GetString()!, 
                    record.GetProperty("value").GetInt32())
            ));

        Console.WriteLine($"Fetched {sensorsCollection.Count} records successfully");
    }
    else
    {
        Console.WriteLine($"Error: {response.StatusCode}");
    }
}

Dictionary<Noise, int> CountSensorsByNoise(IEnumerable<Sensor> sensors)
{
   var countByNoise = new Dictionary<Noise, int>
   {
       { Noise.Low, 0 },
       { Noise.Medium, 0 },
       { Noise.High, 0 }
   };

   foreach (var noiseLevel in sensors.Select(sensor => sensor.Noise))
   {
       countByNoise[noiseLevel]++;
   }
    
   return countByNoise;
}

DateTime UtCtoPacificStandardTime(string timestamp)
{
    var utcTime = DateTime.Parse(timestamp);
    var localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, TimeZoneInfo.FindSystemTimeZoneById("Pacific SA Standard Time"));
    return localTime;
}

int CountByTimestamp(IEnumerable<Sensor> sensors)
{
    var start = new DateTime(2023, 4, 10, 8, 0, 0);
    var end = new DateTime(2023, 4, 11, 20, 0, 0);

    return sensors.Select(sensor => UtCtoPacificStandardTime(sensor.Timestamp)).Count(sensorTime => sensorTime >= start && sensorTime <= end);
}

async Task SendResults(int noiseHigh, int noiseMedium, int noiseLow, int rangeAmount)
{
    var data = new
    {
        noiseHigh,
        noiseMedium,
        noiseLow,
        rangeAmount,
    };
    
    Console.WriteLine($"Results: (Noise High: {noiseHigh}, Noise Medium: {noiseMedium}, Noise Low: {noiseLow}, Range Amount: {rangeAmount})");
    
    var json = JsonSerializer.Serialize(data);
    var content = new StringContent(json);
    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
    
    var response = await client!.PostAsync($"{apiUri}/result", content);
    if (response.IsSuccessStatusCode)
    {
        var result = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"Sent results successfully");
    }
    else
    {
        Console.WriteLine($"Error: {response.StatusCode}");
    }
}

/*
 * API Calls 
 */
await Login(authEmail!, authPassword!);
await FetchRecords(sensorId!, 1, 10000);

var sensorsByNoise = CountSensorsByNoise(sensorsCollection);
var betweenTimestamps = CountByTimestamp(sensorsCollection);

await SendResults(sensorsByNoise[Noise.High], sensorsByNoise[Noise.Medium], 
    sensorsByNoise[Noise.Low], betweenTimestamps);