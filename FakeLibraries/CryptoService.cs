namespace FakeLibraries
{
    /// <summary>
    /// Библиотека шифрования
    /// </summary>
    public sealed class CryptoService
    {
        #region Методы

        /// <summary>
        /// Зашифровать
        /// </summary>
        /// <param name="plainObject">Открытый массив байт</param>
        /// <returns>Зашифрованный массив байт</returns>
        public byte[] EncryptByteArray(byte[] plainObject)
        {
            return plainObject;
        }

        #endregion
    }
}