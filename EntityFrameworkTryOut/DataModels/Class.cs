using EntityFrameworkTryOut.Enums;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkTryOut.DataModels
{
    public class Class
    {
        public int ClassID { get; set; }
        [MaxLength(50)]
        public string  ClassName { get; set; }
        [Required]
        public int MaxClassSize { get; set; }
        public Language ClassLanguage { get; set; }

        public string ClassRaiting { get; set; }

    }
}