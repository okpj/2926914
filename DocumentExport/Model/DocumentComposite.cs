using System.Text;

namespace DocumentExport.Model
{
  /// <summary>
  /// Составной документ.
  /// </summary>
  internal class DocumentComposite : ComponentBase
  {
    #region Поля и свойства

    /// <summary>
    /// Состав комплекта документа.
    /// </summary>
    private List<ComponentBase> documentComponentsCollection = new List<ComponentBase>();

    #endregion

    #region Методы

    /// <summary>
    /// Добавить компонент в комплект.
    /// </summary>
    /// <param name="documentComponent">Компонент комплекта.</param>
    public void AddComponent(ComponentBase documentComponent)
    {
      this.documentComponentsCollection.Add(documentComponent);
    }

    #endregion

    #region Базовый класс

    public override string GetDescription(int level)
    {
      StringBuilder description = new StringBuilder();
      description.AppendFormat("{0}{1}", CreateMargin(level), Name);
      level++;

      foreach (var item in this.documentComponentsCollection)
      {
        description.AppendLine();
        description.AppendFormat("{0}", item.GetDescription(level));
      }

      return description.ToString();
    }

    #endregion
  }
}
