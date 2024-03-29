﻿using DocumentExport.Model;

namespace DocumentExport.Storage
{
  /// <summary>
  /// Хранилище документов.
  /// </summary>
  internal interface IDocumentStorage
  {
    /// <summary>
    /// Загрузить документы.
    /// </summary>
    /// <returns>Коллекция документов.</returns>
    IEnumerable<ComponentBase> Load();
  }
}
