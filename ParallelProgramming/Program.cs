using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        List<string> urls = new List<string>
        {
            "https://example.com",
            "https://google.com",
            "https://microsoft.com"
        };

        // Use Parallel.ForEach to scrape data from multiple websites concurrently
        Parallel.ForEach(urls, url =>
        {
            string content = DownloadWebsiteContent(url);
            Console.WriteLine($"Scraped content from {url}: {content.Length} characters");
        });
    }

    static string DownloadWebsiteContent(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            // Send an HTTP GET request to the URL and retrieve the content
            HttpResponseMessage response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                Console.WriteLine($"Failed to download content from {url}. Status code: {response.StatusCode}");
                return string.Empty;
            }
        }
    }
}
