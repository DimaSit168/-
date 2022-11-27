using System;

namespace ConsoleApp
{
    /// <summary>
    /// Осужденный
    /// </summary>
    public class Convicted : IEquatable<Convicted>
    {

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Convicted"/>.
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="firstName">Имя</param>
        /// <exception cref="ArgumentOutOfRangeException">В случае если <paramref name="lastName"/> или <paramref name="firstName"/> 
        /// <see langword="null"/>, пустая строка или строка, содержащая только пробельные символы.
        /// </exception>
        public Convicted(int id, string lastName, string firstName, string? middleName = null)
        {
            this.Id = id;
            this.MiddleName = middleName;
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
        bool IEquatable<Convicted>.Equals(Convicted? other)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj) => ((IEquatable<Convicted>)this).Equals(obj as Convicted);

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
