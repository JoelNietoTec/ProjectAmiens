namespace API.Models.Legal.Clients
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using API.Areas.HelpPage.ModelDescriptions;

    [ModelName("ClientCountry")]
    public partial class Country
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(10)]
        public string ShortName { get; set; }

        [StringLength(100)]
        public string SpanishName { get; set; }
    }
}
