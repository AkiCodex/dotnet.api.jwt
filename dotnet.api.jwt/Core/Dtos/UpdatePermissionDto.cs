using System.ComponentModel.DataAnnotations;

namespace dotnet.api.jwt.Core.Dtos
{
    public class UpdatePermissionDto
    {
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }
    }
}
