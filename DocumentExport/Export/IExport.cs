using DocumentExport.Model;

namespace DocumentExport.Export
{
  /// <summary>
  /// Стратегия экспорта.
  /// </summary>
  internal interface IExport
  {
    /// <summary>
    /// Выполнить экспорт.
    /// </summary>
    /// <param name="documentComponents">Данные для экспорта.</param>
    void ExecuteExport(IEnumerable<ComponentBase> documentComponents);
  }
}
