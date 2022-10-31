namespace ConsoleApp1
{
    /// <summary>
    /// Следователь
    /// </summary>
    public class Investigator : IEquatable<Investigator>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Investigator"/>.
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="firstName">Имя</param>
        /// <exception cref="ArgumentOutOfRangeException">В случае если <paramref name="lastName"/> или <paramref name="firstName"/> 
        /// <see langword="null"/>, пустая строка или строка, содержащая только пробельные символы.
        /// </exception>
        public Investigator(int id, string lastName, string firstName, string middleName = null)
        {
            this.Id = id;
            MiddleName = middleName;
            this.LastName = lastName.TrimOrNull() ?? throw new ArgumentOutOfRangeException(nameof(lastName));
            this.FirstName = firstName.TrimOrNull() ?? throw new ArgumentOutOfRangeException(nameof(firstName)); ;
        }   
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public virtual int Id { get; protected set; }
        public string MiddleName { get; }

        /// <summary>
        /// Имя
        /// </summary>
        public virtual string LastName { get; protected set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public virtual string FirstName { get; protected set; }

       //public virtual string FullName == $"{this.Last.Name} {this.FirstName}.".Trim();

        public bool Equals(Investigator? other)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj) => Equals(obj as Investigator);

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }


}
