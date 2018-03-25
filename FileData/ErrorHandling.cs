using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    class ErrorHandling
    {
        private StringBuilder msg = new StringBuilder();

        #region LogMessage to log error msg
        public void LogMessage(string err)
        {
            msg.Append(err);
            msg.Append(System.Environment.NewLine);
        }
        #endregion

        #region Overide ToString method to display error msg
        public override string ToString()
        {
            if (msg.Length > 0)
                return msg.ToString();
            else
                return "";
        }
        #endregion
    }
}
