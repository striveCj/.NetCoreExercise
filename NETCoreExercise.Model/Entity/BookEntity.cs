using NETCoreExercise.Core.Base;

namespace NETCoreExercise.Model.Entity
{
    public class BookEntity:BaseEntity
    {
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
    }
}
