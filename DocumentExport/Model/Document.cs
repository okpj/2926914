namespace DocumentExport.Model
{
  /// <summary>
  /// Документ, у которого нет дочерних документов.
  /// </summary>
  internal class Document : ComponentBase
  {
    #region Базовый класс

    public override string GetDescription(int level)
    {
      return $"{CreateMargin(level)}{Name}";
    }

    #endregion
  }
}
