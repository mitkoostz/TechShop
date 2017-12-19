namespace Tech_ShopManagemant
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int Id { get; set; }

        [Required]
        public string clientName { get; set; }

        [Required]
        public string clientPhone { get; set; }

        [Required]
        public string Adress { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string OrderedProducts { get; set; }
    }
}
