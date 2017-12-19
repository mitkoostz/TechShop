namespace Tech_ShopManagemant
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ComputerSpecification
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ComputerSpecification()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public string ProcessorBrand { get; set; }

        public string ProcessorType { get; set; }

        public string ProcessorModel { get; set; }

        public string ProcessorCoreNumber { get; set; }

        public string ProcessorGHz { get; set; }

        public string IntegratedGraphicProcessor { get; set; }

        public string MatherBoardSocket { get; set; }

        public string RamType { get; set; }

        public string RamMemory { get; set; }

        public string RamSlots { get; set; }

        public string RamSlotsUsed { get; set; }

        public string HardDiscType { get; set; }

        public string HardDiscMemory { get; set; }

        public string HardDiscCirclingSpeed { get; set; }

        public string VideoCardType { get; set; }

        public string VideoCardBrand { get; set; }

        public string VideoCardSerie { get; set; }

        public string VideoCardModel { get; set; }

        public string VideoCardMemory { get; set; }

        public string PowerSupply { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
