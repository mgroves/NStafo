using HtmlAgilityPack;

namespace NStafo;

public class NStafo
{
    private readonly HttpClient _client;

    public NStafo()
    {
        _client = new HttpClient();
        _client.DefaultRequestHeaders.Add("User-Agent", "NStafo");
    }

   
    public async Task<int> NumStarsAsync(string repoName)
    {
        var content = await _client.GetStringAsync($"https://github.com/{repoName}");
        
        var html = new HtmlDocument();
        html.LoadHtml(content);

        var link = html.DocumentNode.Descendants("span")
            .FirstOrDefault(node => node.GetAttributeValue("id", "") == "repo-stars-counter-star");

        return Convert.ToInt32(decimal.Parse(link.GetAttributeValue("title", "")));
    }
    
    public async Task<int> NumForksAsync(string repoName)
    {
        var content = await _client.GetStringAsync($"https://github.com/{repoName}");
        
        var html = new HtmlDocument();
        html.LoadHtml(content);

        var link = html.DocumentNode.Descendants("span")
            .FirstOrDefault(node => node.GetAttributeValue("id", "") == "repo-network-counter");

        return Convert.ToInt32(decimal.Parse(link.GetAttributeValue("title", "")));
    }
}
