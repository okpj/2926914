using DocumentExport.Model;

namespace DocumentExport.Contracts.Store
{
    /// <summary>
    /// Хранилище документов
    /// </summary>
    public interface IDocumentStore
    {
        /// <summary>
        /// Загрузить документы
        /// </summary>
        /// <returns>Коллекция документов</returns>
        IEnumerable<Document> LoadDocuments();
    }
}
