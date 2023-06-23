using DocumentExport.Contracts.Adapter;
using FakeLibraries;

namespace DocumentExport.Service
{
    /// <summary>
    /// Адаптер для шифрования файлов
    /// </summary>
    public class DocumentCryptoAdapter : IDocumentCryptoAdapter
    {
        /// <summary>
        /// Криптопровайдер
        /// </summary>
        private readonly CryptoService cryptoService = new CryptoService();

        public void Encrypt(string path)
        {
            // Получаем файл из папки и шифруем
            // cryptoService.EncryptByteArray();

            Console.WriteLine("\n\r--------------------");
            Console.WriteLine($"Файлы в папке {path} зашифрованы");
        }
    }
}