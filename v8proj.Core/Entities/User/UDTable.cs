using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace v8proj.Core.Entities.User
{
    public class UDTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "User Name")]
        [StringLength(30, MinimumLength = 3)]
            public string UserName { get; set; }
        
        [Required]
        [Display(Name = "Password")]
        [StringLength(50, MinimumLength = 6)]
        public string Password { get; set; }
        
        [Required]
        [Display(Name = "Email")]
        [StringLength(50)]
        public string Email { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime LastLogin { get; set; }
        
        [StringLength(30)]
        public string LoginIp { get; set; }
        
        
    }
}