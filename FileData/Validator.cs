using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FileData
{
    public class Validator
    {
        ErrorHandling err = new ErrorHandling();

        #region Validator class members
        private string[] _args;
        private bool _version;
        private bool _size;
        private string _functionDeterminer;
        private string _filePath;
        #endregion

        #region Validator class Property
        public bool Version {
            get { return _version; }
            set { _version = value; }
        }

        public bool Size{
            get { return _size; }
            set { _size = value; }
        }


        public string[] Args{
            get { return _args; }
            set { _args = value; }
        }

        public string FunctionDeterminer
        {
            get { return _functionDeterminer; }
            set { _functionDeterminer = value; }
        }

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
        #endregion

        #region validates if the number of arguments passed is correct
        public bool validNumberOfArguments()
        {
            if (Args.Length == 2)
            {
                FunctionDeterminer = Args[0];
                FilePath = Args[1];
                return true;
            }
            else
            {
                err.LogMessage("E01: Argument size should be 2. Try --v c:/test.txt");
                return false;
            }
        }
        #endregion

        #region Validate if request is a valid version reqiest
        private bool validVersionFunction()
        {
            //switch (Args[0].ToLower())
            switch (FunctionDeterminer)
            {
                case "–v":
                    Version = true;
                    break;
                case "-v":
                    Version = true;
                    break;
                case "--v":
                    Version = true;
                    break;
                case "/v":
                    Version = true;
                    break;
                case "--version":
                    Version = true;
                    break;
                default:
                    Version = false;
                    break;
            }

            if (Version)
                return true;
            else
                return false;

        }
        #endregion

        #region Validate if request is a valid size request
        private bool validSizeFunction()
        {
            switch (FunctionDeterminer)
            {
                case "–s":
                    Size = true;
                    break;
                case "-s":
                    Size = true;
                    break;
                case "--s":
                    Size = true;
                    break;
                case "/s":
                    Size = true;
                    break;
                case "--size":
                    Size = true;
                    break;
                default:
                    Size = false;
                    break;
            }

            if (Size)
                return true;
            else
                return false;
        }
        #endregion

        #region Returns True if requested function is valid
        public bool validFunction()
        {
            if (validVersionFunction() || validSizeFunction())
                return true;
            else
            {
                err.LogMessage("E02: Unrecognised function request. Try -v c:/test.txt");
                return false;
            }
                
        }
        #endregion

        #region ToString method
        public override string ToString()
        {
            if (Version) return "Function Type : Version";
            if (Size) return "Function Type: Size";
            else
                return err.ToString();
        }
        #endregion
    }
}
