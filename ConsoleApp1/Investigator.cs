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
#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public Investigator(int id, string lastName, string firstName, string? middleName = null)
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {
            this.Id = id;
#pragma warning disable CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
            MiddleName = middleName;
#pragma warning restore CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
            this.LastName = lastName ?? throw new ArgumentOutOfRangeException(nameof(lastName));
            this.FirstName = firstName ?? throw new ArgumentOutOfRangeException(nameof(firstName)); ;
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
