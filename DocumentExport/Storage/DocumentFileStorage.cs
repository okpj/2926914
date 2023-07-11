using DocumentExport.Model;
using DocumentExport.Model.Interfaces;

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
        private static IComponent firstDocument = new Document() { Id = 1, Name = "Документ 1" };

        /// <summary>
        /// Второй документ.
        /// </summary>
        private static IComponent secondDocument = new Document() { Id = 2, Name = "Документ 2" };

        /// <summary>
        /// Третий документ.
        /// </summary>
        private static IComponent thirdDocument = new Document() { Id = 3, Name = "Документ 3" };

        /// <summary>
        /// Четвёртый документ.
        /// </summary>
        private static IComponent fourthDocument = new Document() { Id = 4, Name = "Документ 4" };

        /// <summary>
        /// Пятый документ.
        /// </summary>
        private static IComponent fifthDocument = new Document() { Id = 5, Name = "Документ 5" };

        #endregion

        #region IDocumentStorage

        public IEnumerable<IComponent> Load()
        {
            IComposite firstComposite = new DocumentComposite { Id = 5, Name = "Комплект 1" };
            IComposite secondComposite = new DocumentComposite { Id = 6, Name = "Комплект 2" };
            firstComposite.AddComponent(secondDocument);
            secondComposite.AddComponent(thirdDocument);
            secondComposite.AddComponent(fourthDocument);
            firstComposite.AddComponent(secondComposite);

            return new List<IComponent>()
            {
                firstDocument,
                firstComposite,
                fifthDocument
            };
        }

        #endregion
    }
}