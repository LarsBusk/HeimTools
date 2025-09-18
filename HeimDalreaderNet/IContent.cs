using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeimDalreaderNet
{
    public interface IContent
    {
        string[] Headers { get; }
        object[] Data { get; }
    }
}
