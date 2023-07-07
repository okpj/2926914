namespace DocumentExport.Services.Adapter
{
    /// <summary>
    /// Интерфейс адаптера для архивации.
    /// </summary>
    public interface IDocumentArchiveAdapter
    {
        /// <summary>
        /// Заархивировать содержимое папки.
        /// </summary>
        /// <param name="path">Путь до папки.</param>
        public void Archive(string path);
    }
}
