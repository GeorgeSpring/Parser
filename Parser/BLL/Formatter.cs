using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parser.DAL;
using Parser.Interfaces;
using Parser.Models;

namespace Parser.BLL
{
    public class Formatter
    {
        private readonly IParser _parser = new MainParser();

        private Result _cache = null;

        public async Task WarmUpCache(string url)
        {
            var result = await _parser.Parse(url);
            _cache = result;
        }

        public async Task<List<string>> GetImagesFromUrl(string url)
        {
            Result result;

            if (_cache == null)
            {
                result = await _parser.Parse(url);
            }
            else
                result = _cache;

            return result.response.hotels.Select(x => x.image.path).ToList();
        }
        
        public async Task<List<string>> GetAddressesFromUrl(string url)
        {
            var result = await _parser.Parse(url);

            return result.response.hotels.Select(x => x.address).ToList();
        }
    }
}