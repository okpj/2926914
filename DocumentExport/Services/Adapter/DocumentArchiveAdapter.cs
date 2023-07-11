using FakeLibraries;

namespace DocumentExport.Services.Adapter
{
  /// <summary>
  /// Адаптер для архивации файлов.
  /// </summary>
  public sealed class DocumentArchiveAdapter : IDocumentArchiveAdapter
  {
    #region Поля и свойства

    /// <summary>
    /// Архиватор.
    /// </summary>
    private readonly Archiver archiver = new Archiver();

    #endregion

    #region IDocumentArchiveAdapter

    public void Archive(string path)
    {
      archiver.ArchiveByteArray();

      Console.WriteLine("\n\r--------------------");
      Console.WriteLine($"Файлы в папке {path} упакованы в архив");
    }

    #endregion
  }
}
