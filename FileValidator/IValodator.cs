using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileValidatorLibrary
{
    public interface IValidator
    {
        bool DoesFileExist(string filePath);
        bool CheckFileType(string filePath, string Extention);
        bool IsFileEmpty(string filePath);
    }
}
