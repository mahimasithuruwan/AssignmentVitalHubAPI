using System.ComponentModel.DataAnnotations;

namespace AssignmentVitalHubAPI.Entity.BaseEntity
{
	public interface IEntity
    {
        int Id { get; }
        DateTimeOffset CreatedDateTime { get; set; }

        DateTimeOffset? UpdatedDateTime { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
