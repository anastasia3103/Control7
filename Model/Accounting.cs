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
    
    public partial class Accounting
    {
        public int Id { get; set; }
        public System.DateTime DateDelivery { get; set; }
        public int IdEmployee { get; set; }
        public int IdMaterial { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public Nullable<decimal> Amount { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Material Material { get; set; }
    }
}