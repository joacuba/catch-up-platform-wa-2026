namespace Catch_Up_Platform.net.Shared.Domain.Model;

public interface IAuditableEntity
{
   DateTimeOffset? CreatedAt { get; set; } 
   DateTimeOffset? UpdatedAt { get; set; }
}