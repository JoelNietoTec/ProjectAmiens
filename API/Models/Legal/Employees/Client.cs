namespace API.Models.Legal.Employees
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using API.Areas.HelpPage.ModelDescriptions;

    [ModelName("AttorneyClient")]
    public partial class Client
    {

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string BillName { get; set; }

        public int ClientTypeId { get; set; }

        public int IndustryId { get; set; }

        public int EmployeeId { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public byte? Status { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifyDate { get; set; }

        public int CountryId { get; set; }

        public virtual ClientType ClientType { get; set; }

        public virtual Industry Industry { get; set; }

    }
}
