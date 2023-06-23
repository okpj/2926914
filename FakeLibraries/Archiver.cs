namespace FakeLibraries
{
    /// <summary>
    /// Библиотека архивации
    /// </summary>
    public sealed class Archiver
    {
        #region Методы

        /// <summary>
        /// Заархивировать
        /// </summary>
        /// <param name="file">Файл для упаковки в архив</param>
        /// <param name="archive">Существующий архив в который необходимо упаковать файл.
        /// Если сущевтвующий архив не передан, будет создан новый.</param>
        /// <returns>Архив</returns>
        public byte[] ArchiveByteArray(byte[] file, byte[]? archive = null)
        {
            if (archive?.Length == 0)
            {
                //Создать архив;
            }
            //Упаковать файл в архив;
            return file;
        }

        #endregion
    }
}
