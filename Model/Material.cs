//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Control7.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Material
    {
        public Material()
        {
            this.Accounting = new HashSet<Accounting>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdManufacturer { get; set; }
    
        public virtual ICollection<Accounting> Accounting { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
