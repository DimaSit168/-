namespace ConsoleApp1
{
    /// <summary>
    /// Уголовные дела
    /// </summary>
    public class CourtCase
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Convicted"/>.
        /// </summary>
        /// 1, "1208", "Горбушечка", "Убийство", "1977", "1978", "105"
        /// <param name="id">Идентификатор</param>
        /// <param name="article">Номер статьи</param>
        /// <param name="nameCase">Название дела</param>
        /// <param name="content">Содержание</param>
        /// <param name="YearOfOpening">Год открытия</param>
        /// <param name="YearOfClose">Год закрытия</param>
        /// <param name="NamberCase">Номер</param>
        /// <exception cref="ArgumentOutOfRangeException">В случае если <paramref name="lastName"/> или <paramref name="firstName"/> 
        /// <see langword="null"/>, пустая строка или строка, содержащая только пробельные символы.
        /// </exception>
        public CourtCase(int id, int article, string NameCase, string Content, int YearOfOpening, int YearOfClose, int NamberCase, string middleName = null)
        {
            this.Id = id;
            this.Article = article TrimOrNull();
            this.NameCase = NameCase TrimOrNull();
            this.Content = Content TrimOrNull();
            this.YearOfOpening = YearOfOpening TrimOrNull();
            this.YearOfClose = YearOfClose TrimOrNull();
            this.NamberCase = NamberCase TrimOrNull();
        }

        private void TrimOrNull() => throw new NotImplementedException();

        public int Id { get; private set; }
        public int Article { get; private set; }
        public object NameCase { get; private set; }
        public object Content { get; private set; }
        public object YearOfOpening { get; private set; }
        public object YearOfClose { get; private set; }
        public int NamberCase { get; private set; }

        public override bool Equals(object? obj)
        {
            return obj is CourtCase @case &&
                   Id == @case.Id &&
                   Article == @case.Article &&
                   EqualityComparer<object>.Default.Equals(NameCase, @case.NameCase) &&
                   EqualityComparer<object>.Default.Equals(Content, @case.Content) &&
                   EqualityComparer<object>.Default.Equals(YearOfOpening, @case.YearOfOpening) &&
                   EqualityComparer<object>.Default.Equals(YearOfClose, @case.YearOfClose) &&
                   NamberCase == @case.NamberCase;
        }
    }

    public class StringNameCase
    {
    }
}
