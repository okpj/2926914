using DocumentExport.Model.Interfaces;

namespace DocumentExport.Model
{
    /// <summary>
    /// Базовый компонент.
    /// </summary>
    internal abstract class ComponentBase : IComponent
    {
        #region IComponent

        public int Id { get; set; }

        public string Name { get; set; }

        public abstract string GetDescription(int level);

        #endregion
    }
}
