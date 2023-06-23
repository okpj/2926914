namespace DocumentExport.Contracts.Adapter
{
    /// <summary>
    /// Интерфейс адаптера для шифрования
    /// </summary>
    public interface IDocumentCryptoAdapter
    {
        /// <summary>
        /// Зашифровать содержимое папки
        /// </summary>
        /// <param name="path">Путь до папки</param>
        public void Encrypt(string path);
    }
}
