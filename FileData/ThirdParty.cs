using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    class ThirdParty: IThirdPartyTools
    {
        FileDetails newFileDetails = new FileDetails(); 

        public string Version(string filepath)
        {
            return newFileDetails.Version(filepath);
        }

        public int Size(string filepath)
        {
            return newFileDetails.Size(filepath);
        }
    }
}
