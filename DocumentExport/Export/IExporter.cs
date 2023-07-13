using DocumentExport.Model;

namespace DocumentExport.Export
{
  /// <summary>
  /// Экспортёр.
  /// </summary>
  internal interface IExporter
  {
    /// <summary>
    /// Выполнить экспорт.
    /// </summary>
    /// <param name="documentComponents">Данные для экспорта.</param>
    void Export(IEnumerable<ComponentBase> documentComponents);
  }
}
