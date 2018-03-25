using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    interface IThirdPartyTools
    {
        string Version(string filepath);
        int Size(string filepath);
    }
}
