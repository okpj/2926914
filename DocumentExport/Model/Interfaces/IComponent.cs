namespace DocumentExport.Model.Interfaces
{
    /// <summary>
    /// Компонент.
    /// </summary>
    internal interface IComponent
    {
        /// <summary>
        /// Идентификатор документа.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Название документа.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Получить описание документа.
        /// </summary>
        /// <param name="level">Уровень вложенности компонента.</param>
        /// <returns>Описание документа.</returns>
        string GetDescription(int level);
    }
}
