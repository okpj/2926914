using DocumentExport.Storage;
using DocumentExport.Export;
using DocumentExport.Services.Adapter;

namespace DocumentExport
{
  /// <summary>
  /// Класс Program.
  /// </summary>
  internal sealed class Program
  {
    #region Поля и свойства

    /// <summary>
    /// Параметр, указывающий на необходимость архивации.
    /// </summary>
    private const string ArchiveParameter = "archive";

    /// <summary>
    /// Параметр, указывающий на необходимость шифрования.
    /// </summary>
    private const string EncryptParameter = "encrypt";

    #endregion

    #region Методы

    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    /// <param name="args">Аргументы, с которыми запускается программа.</param>
    private static void Main(string[] args)
    {
      string path = @"C:\docs";

      IDocumentStorage documentStorage = new DocumentFileStorage();
      var documents = documentStorage.Load();

      var handlers = new List<ExportHandler>();
      if (args.Contains(EncryptParameter))
      {
        IDocumentCryptoAdapter documentCryptoAdapter = new DocumentCryptoAdapter();
        handlers.Add(new ExportHandler(() => documentCryptoAdapter.Encrypt(path)));
      }

      if (args.Contains(ArchiveParameter))
      {
        IDocumentArchiveAdapter documentArchiveAdapter = new DocumentArchiveAdapter();
        handlers.Add(new ExportHandler(() => documentArchiveAdapter.Archive(path)));
      }

      IExport exportStrategy = new FileSystemExport(path, handlers);

      exportStrategy.ExecuteExport(documents);
    }

    #endregion
  }
}

