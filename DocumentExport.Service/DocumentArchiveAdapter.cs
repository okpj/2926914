using DocumentExport.Contracts.Adapter;
using FakeLibraries;

namespace DocumentExport.Service
{
    /// <summary>
    /// Адаптер для архивации файлов
    /// </summary>
    public sealed class DocumentArchiveAdapter : IDocumentArchiveAdapter
    {
        /// <summary>
        /// Архиватор
        /// </summary>
        private readonly Archiver archiver = new Archiver();

        public void Archive(string path)
        {
            // Получаем файл из папки и архивируем
            // archiver.ArchiveByteArray();

            Console.WriteLine("\n\r--------------------");
            Console.WriteLine($"Файлы в папке {path} упакованы в архив");
        }
    }
}
