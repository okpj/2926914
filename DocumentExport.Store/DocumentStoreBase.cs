using DocumentExport.Contracts.Store;
using DocumentExport.Model;

namespace DocumentExport.Store
{
    /// <summary>
    /// Базовое хранилище документов
    /// </summary>
    public abstract class DocumentStoreBase : IDocumentStore
    {
        #region IDocumentStore

        public abstract IEnumerable<Document> LoadDocuments();

        #endregion

        #region Конструкторы

        /// <summary>
        /// Конструктор
        /// </summary>
        public DocumentStoreBase() { }

        #endregion
    }
}