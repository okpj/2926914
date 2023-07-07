using DocumentExport.Model;
using DocumentExport.Model.Interfaces;
using DocumentExport.Storage.Base;

namespace DocumentExport.Storage
{
    /// <summary>
    /// Файловое хранилище документов.
    /// </summary>
    internal class DocumentFileStorage : IDocumentStorage
    {
        #region Поля и свойства

        /// <summary>
        /// Первый документ.
        /// </summary>
        private IDocumentComponent firstDocument = new Document() { Id = 1, Name = "Документ 1" };

        /// <summary>
        /// Второй документ.
        /// </summary>
        private IDocumentComponent secondDocument = new Document() { Id = 2, Name = "Документ 2" };

        /// <summary>
        /// Третий документ.
        /// </summary>
        private IDocumentComponent thirdDocument = new Document() { Id = 3, Name = "Документ 3" };

        /// <summary>
        /// Четвёртый документ.
        /// </summary>
        private IDocumentComponent fourthDocument = new Document() { Id = 4, Name = "Документ 4" };

        /// <summary>
        /// Пятый документ.
        /// </summary>
        private IDocumentComponent fifthDocument = new Document() { Id = 5, Name = "Документ 5" };

        #endregion

        #region IDocumentStorage

        public IEnumerable<IDocumentComponent> Load()
        {
            IDocumentComposite firstComposite = new DocumentComposite { Id = 5, Name = "Комплект 1" };
            IDocumentComposite secondComposite = new DocumentComposite { Id = 6, Name = "Комплект 2" };
            firstComposite.AddComponent(secondDocument);
            secondComposite.AddComponent(thirdDocument);
            secondComposite.AddComponent(fourthDocument);
            firstComposite.AddComponent(secondComposite);

            return new List<IDocumentComponent>()
            {
                firstDocument,
                firstComposite,
                fifthDocument
            };
        }

        #endregion
    }
}