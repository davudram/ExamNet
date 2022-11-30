namespace ExamNet
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Character
    {
        public int ID { get; set; }

        public int Chapter_ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Sex { get; set; }

        [Required]
        [StringLength(50)]
        public string Race { get; set; }

        [Required]
        [StringLength(150)]
        public string Occupation { get; set; }

        [Required]
        [StringLength(150)]
        public string Affiliation { get; set; }

        [Required]
        [StringLength(50)]
        public string Death { get; set; }

        [Required]
        public string Image_Url { get; set; }

        public virtual Chapter Chapter { get; set; }
    }
}
