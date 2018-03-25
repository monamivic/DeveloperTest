using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //
            Validator newValidator = new Validator();
            newValidator.Args = args;

            if (newValidator.validNumberOfArguments() && newValidator.validFunction())
            {
                ThirdParty newThirdParty = new ThirdParty();
                Debug.WriteLine(newValidator.ToString());
                if (newValidator.Version)
                {
                    Debug.WriteLine(newThirdParty.Version(newValidator.FilePath));
                }
                if(newValidator.Size)
                {
                    Debug.WriteLine(newThirdParty.Size(newValidator.FilePath));
                }
            }
            else
            {
                Debug.WriteLine(newValidator.ToString());
            }
                
        }
    }
}
