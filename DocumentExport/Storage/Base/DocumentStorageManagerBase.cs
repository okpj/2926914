using DocumentExport.Model.Interfaces;

namespace DocumentExport.Storage.Base
{
    /// <summary>
    /// Менеджер хранилищ документов.
    /// </summary>
    internal abstract class DocumentStorageManagerBase
    {
        #region Методы

        /// <summary>
        /// Создать экземпляр хранилища.
        /// </summary>
        /// <returns>Хранилище документов.</returns>
        internal abstract IDocumentStorage CreateStorage();

        /// <summary>
        /// Загрузить документы.
        /// </summary>
        /// <returns>Коллекция документов.</returns>
        internal IEnumerable<IDocumentComponent> LoadDocuments()
        {
            IDocumentStorage storage = this.CreateStorage();
            return storage.Load();
        }

        #endregion
    }
}
