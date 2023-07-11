using DocumentExport.Model.Interfaces;
using System.Text;

namespace DocumentExport.Model
{
    /// <summary>
    /// Составной документ.
    /// </summary>
    internal class DocumentComposite : DocumentComponentBase, IDocumentComposite
    {
        #region Поля и свойства

        /// <summary>
        /// Состав комплекта документа.
        /// </summary>
        private List<IDocumentComponent> documentComponentsCollection;

        #endregion

        #region Базовый класс

        public override string GetDescription(int level)
        {
            StringBuilder description = new StringBuilder();
            description.AppendFormat("{0}{1}", new string(' ', level * 2), this.Name);
            level++;

            foreach (var item in this.documentComponentsCollection)
            {
                description.AppendLine();
                description.AppendFormat("{0}", item.GetDescription(level));
            }

            return description.ToString();
        }

        #endregion

        #region IDocumentComposite

        public void AddComponent(IDocumentComponent documentComponent)
        {
            this.documentComponentsCollection.Add(documentComponent);
        }

        #endregion

        #region Конструкторы

        /// <summary>
        /// Конструктор.
        /// </summary>
        public DocumentComposite()
        {
            this.documentComponentsCollection = new List<IDocumentComponent>();
        }

        #endregion
    }
}
