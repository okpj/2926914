using System.Text;

namespace DocumentExport.Model.Extension
{
    /// <summary>
    /// Расширение для Document
    /// </summary>
    public static class DocumentExtension
    {
        #region Методы

        /// <summary>
        /// Сформировать описание документа
        /// </summary>
        /// <param name="document">Документ для которого формируется описание</param>
        /// <param name="level">Уровень вложенности документа</param>
        /// <param name="builder">
        /// StringBuilder для записи описания. Создаётся новый, если не передано значение.
        /// </param>
        /// <returns>Описание документа</returns>
        private static StringBuilder CreateStringBuilderDescription(this Document document, int level = 1,
            StringBuilder? builder = null)
        {
            builder ??= new StringBuilder();
            builder.AppendLine();
            builder.AppendFormat("{0}{1}", new string(' ', level * 2), document.Name);
            level++;

            if (document.StructureCollection?.Count() > 0)
            {
                foreach (var innerDocument in document.StructureCollection)
                {
                    innerDocument.CreateStringBuilderDescription(level, builder);
                }
            }

            return builder;
        }

        /// <summary>
        /// Сформировать описание набора документов
        /// </summary>
        /// <param name="documents">Набор документов для которого формируется описание</param>
        /// <returns>Описание набора документов</returns>
        public static StringBuilder CreateStringBuilderDescription(this IEnumerable<Document> documents)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Описание экспортированного документа:");
            foreach (var document in documents)
            {
                document.CreateStringBuilderDescription(builder: builder);
            }
            return builder;
        }

        #endregion
    }
}