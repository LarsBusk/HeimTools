using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeimdalReader
{
    public interface IContent
    {
        string[] Headers { get; }
        object[] Data { get; }
    }
}
