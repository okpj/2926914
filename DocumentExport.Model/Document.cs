namespace DocumentExport.Model
{
    /// <summary>
    /// Документ
    /// </summary>
    public sealed class Document
    {
        #region Поля и свойства

        /// <summary>
        /// Идентификатор документа
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название документа
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Состав документа
        /// </summary>
        public IEnumerable<Document> StructureCollection { get; set; }

        #endregion

        #region Конструкторы

        /// <summary>
        /// Конструктор
        /// </summary>
        public Document() { }

        #endregion
    }
}