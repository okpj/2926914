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
        private readonly IDocumentCryptoAdapter documentCryptoAdapter = new DocumentCryptoAdapter();

        /// <summary>
        /// Адаптер для сервиса архивации.
        /// </summary>
        private readonly IDocumentArchiveAdapter documentArchiveAdapter = new DocumentArchiveAdapter();

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
                this.documentCryptoAdapter.Encrypt(path);

            if (isNeedArchive)
                this.documentArchiveAdapter.Archive(path);
        }

        #endregion
    }
}
