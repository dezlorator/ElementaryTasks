using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileValidatorLibrary
{
    public class FileValidator : IValidator
    {

        public bool DoesFileExist(string filePath)
        {
            return File.Exists(filePath);
        }

        public bool CheckFileType(string filePath, string Extention)
        {
            return Path.GetExtension(filePath) == Extention;
        }

        public bool IsFileEmpty(string filePath)
        {
            return new FileInfo(filePath).Length == 0;
        }
    }
}
