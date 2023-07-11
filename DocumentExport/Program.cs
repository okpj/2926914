using DocumentExport.Services.Adapter;
using DocumentExport.Storage;

namespace DocumentExport
{
    /// <summary>
    /// Класс Program.
    /// </summary>
    internal sealed class Program
    {
        #region Поля и свойства

        /// <summary>
        /// Параметр, указывющий на необходимость архивации.
        /// </summary>
        private const string ArchiveParameter = "archive";

        /// <summary>
        /// Параметр, указывющий на необходимость шифрования.
        /// </summary>
        private const string EncryptParameter = "encrypt";

        #endregion

        #region Методы

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы, с которыми запускается программа.</param>
        private static void Main(string[] args)
        {
            string path = @"C:\docs";

            IDocumentStorage documentStorage = new DocumentFileStorage();
            var documents = documentStorage.Load();

            var exporter = new Exporter(new DocumentCryptoAdapter(), new DocumentArchiveAdapter());
            exporter.Export(documents, path, args.Contains(EncryptParameter), args.Contains(ArchiveParameter));
        }

        #endregion
    }
}

