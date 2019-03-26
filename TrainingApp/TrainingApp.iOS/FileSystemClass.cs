using System;
using System.IO;
using System.Threading.Tasks;
using TrainingApp.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(TrainingApp.iOS.FileSystemClass))]

namespace TrainingApp.iOS
{
    public class FileSystemClass : IFileSystem
    {
        public async Task WriteTextAsync(string fileName, string text)
        {
            var docsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(docsPath, fileName);
            using (var writer = File.CreateText(path))
            {
                await writer.WriteAsync(text);
            }
        }
    }
}