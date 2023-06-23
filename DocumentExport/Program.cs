using DocumentExport.Contracts.Store;
using DocumentExport.Model.Extension;
using DocumentExport.Service;
using DocumentExport.Store;

namespace DocumentExport
{
    /// <summary>
    /// Класс Program
    /// </summary>
    internal sealed class Program
    {
        #region Поля и свойства

        /// <summary>
        /// Параметр, указывющий на необходимость архивации
        /// </summary>
        private static string archiveParameter = "archive";

        /// <summary>
        /// Параметр, указывющий на необходимость шифрования
        /// </summary>
        private static string encryptParameter = "encrypt";

        #endregion

        #region Методы

        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Аргументы, с которыми запускается программа</param>
        private static void Main(string[] args)
        {
            string path = "C:/docs";

            IDocumentStore documentStore = new DocumentFileStore(path);
            var documents = documentStore.LoadDocuments();

            Console.WriteLine("--------------------");
            Console.WriteLine(documents.CreateStringBuilderDescription());

            if (args.Contains(encryptParameter))
            {
                var cryptoService = new DocumentCryptoAdapter();
                cryptoService.Encrypt(path);
            }

            if (args.Contains(archiveParameter))
            {
                var archiveService = new DocumentArchiveAdapter();
                archiveService.Archive(path);
            }
        }

        #endregion
    }
}

