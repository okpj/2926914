namespace DocumentExport.Model
{
  /// <summary>
  /// Базовый компонент.
  /// </summary>
  internal abstract class ComponentBase
  {
    #region Поля и свойства

    /// <summary>
    /// Идентификатор компонента.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Название компонента.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Коэффициент для отступа.
    /// </summary>
    private const int MarginCoefficient = 2;

    #endregion

    #region Методы

    /// <summary>
    /// Получить описание компонента.
    /// </summary>
    /// <param name="level">Уровень вложенности компонента.</param>
    /// <returns>Описание компонента.</returns>
    public abstract string GetDescription(int level);

    /// <summary>
    /// Создать отступ.
    /// </summary>
    /// <param name="level">Уровень вложенности компонента.</param>
    /// <returns>Строка отступа</returns>
    protected string CreateMargin(int level)
    {
      return new string(' ', level * MarginCoefficient);
    }

    #endregion
  }
}
