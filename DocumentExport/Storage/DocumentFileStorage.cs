using DocumentExport.Model;

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
        private static ComponentBase firstDocument = new Document() { Id = 1, Name = "Документ 1" };

        /// <summary>
        /// Второй документ.
        /// </summary>
        private static ComponentBase secondDocument = new Document() { Id = 2, Name = "Документ 2" };

        /// <summary>
        /// Третий документ.
        /// </summary>
        private static ComponentBase thirdDocument = new Document() { Id = 3, Name = "Документ 3" };

        /// <summary>
        /// Четвёртый документ.
        /// </summary>
        private static ComponentBase fourthDocument = new Document() { Id = 4, Name = "Документ 4" };

        /// <summary>
        /// Пятый документ.
        /// </summary>
        private static ComponentBase fifthDocument = new Document() { Id = 5, Name = "Документ 5" };

        #endregion

        #region IDocumentStorage

        public IEnumerable<ComponentBase> Load()
        {
            DocumentComposite firstComposite = new DocumentComposite { Id = 5, Name = "Комплект 1" };
            DocumentComposite secondComposite = new DocumentComposite { Id = 6, Name = "Комплект 2" };
            firstComposite.AddComponent(secondDocument);
            secondComposite.AddComponent(thirdDocument);
            secondComposite.AddComponent(fourthDocument);
            firstComposite.AddComponent(secondComposite);

            return new List<ComponentBase>()
            {
                firstDocument,
                firstComposite,
                fifthDocument
            };
        }

        #endregion
    }
}