using System.Threading.Tasks;
using System.Windows.Documents;
using Newtonsoft.Json;
using Parser.Interfaces;
using Parser.Models;

namespace Parser.DAL
{
    public class MainParser : IParser
    {
        public async Task<Result> Parse(string url)
        {
            var response = await App.HttpClient.GetAsync(url);

            var resultString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Result>(resultString);
        }
    }
}