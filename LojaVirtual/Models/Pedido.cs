//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LojaVirtual.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pedido()
        {
            this.ItemPedido = new HashSet<ItemPedido>();
        }
    
        public int id { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<System.DateTime> DataPedido { get; set; }
        public Nullable<System.DateTime> DataEntrega { get; set; }
        public Nullable<System.DateTime> DataEnvio { get; set; }
        public Nullable<float> PrecoFrete { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemPedido> ItemPedido { get; set; }
    }
}