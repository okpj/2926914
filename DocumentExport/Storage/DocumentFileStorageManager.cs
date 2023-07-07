using DocumentExport.Storage.Base;

namespace DocumentExport.Storage
{
    /// <summary>
    /// Менеджер файлового хранилища.
    /// </summary>
    internal class DocumentFileStorageManager : DocumentStorageManagerBase
    {
        #region Базовый класс

        internal override IDocumentStorage CreateStorage()
        {
            return new DocumentFileStorage();
        }

        #endregion
    }
}
