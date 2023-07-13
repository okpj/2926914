using DocumentExport.Model;

namespace DocumentExport.Export
{
  /// <summary>
  /// Стратегия для экспорта в файловую систему.
  /// </summary>
  internal class FileSystemExport : IExporter
  {
    #region Поля и свойства

    /// <summary>
    /// Папка, в которую необходимо выполнить экспорт.
    /// </summary>
    private readonly string path;

    /// <summary>
    /// Вспомогательные обработчики.
    /// </summary>
    private readonly IEnumerable<ExportHandler> handlers;

    #endregion

    #region IExporter

    public void Export(IEnumerable<ComponentBase> documentComponents)
    {
      Console.WriteLine($"Выполнен экспорт в папку {path}");
      Console.WriteLine("--------------------");
      Console.WriteLine("Описание экспортированного документа:");

      foreach (var item in documentComponents)
      {
        Console.WriteLine(item.GetDescription(1));
      }

      foreach (var handler in this.handlers)
      {
        handler.Invoke();
      }
    }

    #endregion

    #region Конструктор

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="path">Папка, в которую необходимо выполнить экспорт.</param>
    /// <param name="handlersCollection">Обработчики для экспорта.</param>
    internal FileSystemExport(string path, IEnumerable<ExportHandler> handlersCollection)
    {
      this.path = path;
      this.handlers = handlersCollection;
    }

    #endregion
  }
}
