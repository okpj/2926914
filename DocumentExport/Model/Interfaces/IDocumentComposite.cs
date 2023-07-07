namespace DocumentExport.Model.Interfaces
{
    /// <summary>
    /// Комплект документов.
    /// </summary>
    internal interface IDocumentComposite : IDocumentComponent
    {
        /// <summary>
        /// Добавить документ в комплект.
        /// </summary>
        /// <param name="documentComponent">Документ комплекта.</param>
        void AddComponent(IDocumentComponent documentComponent);
    }
}
