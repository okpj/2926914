using DocumentExport.Model.Interfaces;
using DocumentExport.Services.Adapter;

namespace DocumentExport
{
    /// <summary>
    /// Экспорт документов.
    /// </summary>
    internal class Exporter
    {
        #region Поля и свойства

        /// <summary>
        /// Адаптер для сервиса шифрования.
        /// </summary>
        private readonly IDocumentCryptoAdapter documentCryptoAdapter;

        /// <summary>
        /// Адаптер для сервиса архивации.
        /// </summary>
        private readonly IDocumentArchiveAdapter documentArchiveAdapter;

        #endregion

        #region Методы

        /// <summary>
        /// Экспортировать комплект документов.
        /// </summary>
        /// <param name="documentComponents">Комплект документов.</param>
        /// <param name="path">Путь до папки, в которую выполнить экспорт.</param>
        /// <param name="isNeedEncrypt">Признак того, нужно ли шифрование.</param>
        /// <param name="isNeedArchive">Признак того, нужна ли архивация.</param>
        internal void Export(IEnumerable<IDocumentComponent> documentComponents, string path,
            bool isNeedEncrypt, bool isNeedArchive)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Описание экспортированного документа:");

            foreach (var item in documentComponents)
            {
                Console.WriteLine(item.GetDescription(1));
            }

            if (isNeedEncrypt)
                documentCryptoAdapter.Encrypt(path);

            if (isNeedArchive)
                documentArchiveAdapter.Archive(path);
        }

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор.
        /// </summary>
        internal Exporter()
        {
            documentCryptoAdapter = new DocumentCryptoAdapter();
            documentArchiveAdapter = new DocumentArchiveAdapter();
        }

        #endregion
    }
}
