namespace DocumentExport.Export
{
  /// <summary>
  /// Обработчик для экспорта.
  /// </summary>
  internal class ExportHandler
  {
    #region Поля и свойства

    /// <summary>
    /// Действие обработчика.
    /// </summary>
    private Action handler;

    #endregion

    #region Методы

    /// <summary>
    /// Вызвать действие обработчика.
    /// </summary>
    internal void Invoke()
    {
      this.handler.Invoke();
    }

    #endregion

    #region Конструктор

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="handler">Действие обработчика.</param>
    internal ExportHandler(Action handler)
    {
      this.handler = handler;
    }

    #endregion
  }
}
