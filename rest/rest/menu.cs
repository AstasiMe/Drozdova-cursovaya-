//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rest
{
    using System;
    using System.Collections.Generic;
    
    public partial class menu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public menu()
        {
            this.order11 = new HashSet<order11>();
            this.dishes = new HashSet<dishes>();
        }
    
        public int id_menu { get; set; }
        public string name_item { get; set; }
        public Nullable<bool> active { get; set; }
        public string composition { get; set; }
        public Nullable<int> gm { get; set; }
        public Nullable<int> calories { get; set; }
        public string bar_kitchen { get; set; }
        public Nullable<double> price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order11> order11 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dishes> dishes { get; set; }
    }
}
