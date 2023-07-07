using DocumentExport.Model.Interfaces;

namespace DocumentExport.Storage.Base
{
    /// <summary>
    /// Хранилище документов.
    /// </summary>
    internal interface IDocumentStorage
    {
        /// <summary>
        /// Загрузить документы.
        /// </summary>
        /// <returns>Коллекция документов.</returns>
        IEnumerable<IDocumentComponent> Load();
    }
}
