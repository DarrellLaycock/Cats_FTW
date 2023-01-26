using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cats_FTW.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            UID = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8);
        }

        [Key, Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.None), MaxLength(8)]
        public string UID { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; } = true;
        public int? InsertUserId { get; set; }
        public DateTime? InsertedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}