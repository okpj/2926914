using DocumentExport.Model;

namespace FakeStore
{
    /// <summary>
    /// Хранилище документов
    /// </summary>
    public sealed class DocumentStore
    {
        #region Поля и свойства

        /// <summary>
        /// Первый документ
        /// </summary>
        private static readonly Document FirstDocument = new()
        {
            Id = 1,
            Name = "Документ 1",
        };

        /// <summary>
        /// Второй документ
        /// </summary>
        private static readonly Document SecondDocument = new()
        {
            Id = 2,
            Name = "Документ 2",
        };

        /// <summary>
        /// Первый комплект
        /// </summary>
        private static readonly Document FirstStructure = new()
        {
            Id = 3,
            Name = "Комлект 1",
            StructureCollection = new Document[]
            {
                FirstDocument,
                SecondDocument
            }
        };

        /// <summary>
        /// Второй комплект
        /// </summary>
        private static readonly Document SecondStructure = new()
        {
            Id = 4,
            Name = "Комплект 2",
            StructureCollection = new Document[]
            {
                FirstStructure
            }
        };

        /// <summary>
        /// Третий документ
        /// </summary>
        private static readonly Document ThirdDocument = new()
        {
            Id = 4,
            Name = "Документ 3"
        };

        /// <summary>
        /// Список документов
        /// </summary>
        private static readonly Document[] DocumentCollection = new Document[]
        {
            SecondStructure,
            ThirdDocument
        };
        #endregion

        #region Методы

        /// <summary>
        /// Получить список документов
        /// </summary>
        /// <returns>Список документов</returns>
        public IEnumerable<Document> GetDocumenCollection()
        {
            return DocumentCollection;
        }

        #endregion
    }
}