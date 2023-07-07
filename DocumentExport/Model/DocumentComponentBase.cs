using DocumentExport.Model.Interfaces;

namespace DocumentExport.Model
{
    /// <summary>
    /// Базовый компонент документа.
    /// </summary>
    internal abstract class DocumentComponentBase : IDocumentComponent
    {
        #region IDocumentComponent

        public int Id { get; set; }

        public string Name { get; set; }

        public IDocumentComponent Parent { get; set; }

        public abstract string GetDescription(int level);

        #endregion
    }
}
