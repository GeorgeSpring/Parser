using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Documents;
using Parser.Models;

namespace Parser.Interfaces
{
    public interface IParser
    {
         Task<Result> Parse(string url);
    }
}