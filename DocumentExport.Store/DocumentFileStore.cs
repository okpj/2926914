using DocumentExport.Model;

namespace DocumentExport.Store
{
    /// <summary>
    /// Файловое хранилище документов
    /// </summary>
    public sealed class DocumentFileStore : DocumentStoreBase
    {
        #region Базовый класс

        public override IEnumerable<Document> LoadDocuments()
        {
            var fakeStore = new FakeStore.DocumentStore();
            return fakeStore.GetDocumenCollection();
        }

        #endregion

        #region Конструкторы

        /// <summary>
        /// Конструктор
        /// </summary>
        public DocumentFileStore(string path) : base() { }

        #endregion
    }
}
