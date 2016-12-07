namespace API.Models.Legal.Clients
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using API.Areas.HelpPage.ModelDescriptions;


    [ModelName("ClientMatter")]
    public partial class Matter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int ClientId { get; set; }

        public int AttorneyID { get; set; }

        public int MatterTypeID { get; set; }

        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(10)]
        public string Description { get; set; }

        public int PracticeAreaID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OpeningDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? AdvanceBalance { get; set; }

        public int StatusId { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifyDate { get; set; }

        public virtual Client Client { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual MatterType MatterType { get; set; }
    }
}
