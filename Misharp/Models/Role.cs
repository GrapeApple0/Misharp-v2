using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Runtime.Serialization;
using Misharp.Converters;

namespace Misharp.Models;

public interface IRoleModel : IRoleLiteModel
{
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public RoleTargetEnum Target { get; set; }
    public JsonNode CondFormula { get; set; }
    public bool IsPublic { get; set; }
    public bool IsExplorable { get; set; }
    public bool AsBadge { get; set; }
    public bool CanEditMembersByModerator { get; set; }
    public Dictionary<string, object> Policies { get; set; }
    public int UsersCount { get; set; }
}

public class RoleModel : IRoleModel
{
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public RoleTargetEnum Target { get; set; }
    public JsonNode CondFormula { get; set; }
    public bool IsPublic { get; set; }
    public bool IsExplorable { get; set; }
    public bool AsBadge { get; set; }
    public bool CanEditMembersByModerator { get; set; }
    public Dictionary<string, object> Policies { get; set; }
    public int UsersCount { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public string? Color { get; set; }
    public string? IconUrl { get; set; }
    public string Description { get; set; }
    public bool IsModerator { get; set; }
    public bool IsAdministrator { get; set; }
    public int DisplayOrder { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this, Config.JsonSerializerOptions);
    }

    public static implicit operator RoleLiteModel(RoleModel role)
    {
        return new RoleLiteModel()
        {
            Id = role.Id,
            Name = role.Name,
            Color = role.Color,
            IconUrl = role.IconUrl,
            Description = role.Description,
            IsModerator = role.IsModerator,
            IsAdministrator = role.IsAdministrator,
            DisplayOrder = role.DisplayOrder
        };
    }
}

public enum RoleTargetEnum
{
    [EnumMember(Value = "manual")] Manual,
    [EnumMember(Value = "conditional")] Conditional
}