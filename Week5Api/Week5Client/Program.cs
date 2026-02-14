using System.Net.Http;

var client = new HttpClient();

string url = "https://lab-week5api-rb-1.onrender.com/api/Hello";

Console.WriteLine("Calling API...");
string response = await client.GetStringAsync(url);

Console.WriteLine("Response:");
Console.WriteLine(response);
