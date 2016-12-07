namespace API.Models.Legal.Clients
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using API.Areas.HelpPage.ModelDescriptions;

    [ModelName("ClientAttorney")]
    public partial class Employee
    {

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public int PositionId { get; set; }

        [Column(TypeName = "money")]
        public decimal? HourRate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifyDate { get; set; }

    }
}
