using FakeLibraries;

namespace DocumentExport.Services.Adapter
{
    /// <summary>
    /// Адаптер для шифрования файлов.
    /// </summary>
    public class DocumentCryptoAdapter : IDocumentCryptoAdapter
    {
        #region Поля и свойства

        /// <summary>
        /// Криптопровайдер.
        /// </summary>
        private readonly CryptoService cryptoService = new CryptoService();

        #endregion

        #region IDocumentCryptoAdapter

        public void Encrypt(string path)
        {
            cryptoService.EncryptByteArray();

            Console.WriteLine("\n\r--------------------");
            Console.WriteLine($"Файлы в папке {path} зашифрованы");
        }

        #endregion
    }
}