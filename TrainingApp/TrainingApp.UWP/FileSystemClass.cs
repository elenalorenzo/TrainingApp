using System;
using System.Threading.Tasks;
using Windows.Storage;
using TrainingApp.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(TrainingApp.UWP.FileSystemClass))]

namespace TrainingApp.UWP
{
    public class FileSystemClass : IFileSystem
    {
        public async Task WriteTextAsync(string fileName, string text)
        {
            var localFolder = ApplicationData.Current.LocalFolder;
            var storageFile = await localFolder.CreateFileAsync(fileName);

            await FileIO.WriteTextAsync(storageFile, text);
        }
    }
}
