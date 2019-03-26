using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp.Interfaces
{
    public interface IFileSystem
    {
        Task WriteTextAsync(string fileName, string text);
    }
}
