namespace Tech_ShopManagemant
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Price { get; set; }

        public string Brand { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ProductImagePath { get; set; }

        public int? ComputerSpecification_Id { get; set; }

        public virtual ComputerSpecification ComputerSpecification { get; set; }
    }
}
