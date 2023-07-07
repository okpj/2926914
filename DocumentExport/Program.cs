using DocumentExport.Storage;
using DocumentExport.Storage.Base;

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
        private const string archiveParameter = "archive";

        /// <summary>
        /// Параметр, указывющий на необходимость шифрования.
        /// </summary>
        private const string encryptParameter = "encrypt";

        #endregion

        #region Методы

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы, с которыми запускается программа.</param>
        private static void Main(string[] args)
        {
            string path = @"C:\docs";

            DocumentStorageManagerBase documentStorageManager = new DocumentFileStorageManager();
            var documents = documentStorageManager.LoadDocuments();

            var exporter = new Exporter();
            exporter.Export(documents, path, args.Contains(encryptParameter), args.Contains(archiveParameter));
        }

        #endregion
    }
}

