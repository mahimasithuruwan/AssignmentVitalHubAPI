using System.ComponentModel.DataAnnotations;

namespace AssignmentVitalHubAPI.Entity.BaseEntity
{
    public class Entity<TKey> : IEntity
    {
        public int Id { get; set; }

        public DateTimeOffset CreatedDateTime { get; set; } = DateTime.Now;

        public DateTimeOffset? UpdatedDateTime { get; set; }


        public bool? IsDeleted { get; set; } = false;


    }
}
