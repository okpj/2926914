namespace DocumentExport.Model.Interfaces
{
    /// <summary>
    /// Комплект.
    /// </summary>
    internal interface IComposite : IComponent
    {
        /// <summary>
        /// Добавить документ в комплект.
        /// </summary>
        /// <param name="documentComponent">Документ комплекта.</param>
        void AddComponent(IComponent documentComponent);
    }
}
