//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zakaz
    {
        public int id { get; set; }
        public Nullable<int> Zakazchik { get; set; }
        public Nullable<int> Tovar { get; set; }
        public Nullable<int> Kolichestvo { get; set; }
    
        public virtual Tovar Tovar1 { get; set; }
        public virtual Zakazchik Zakazchik1 { get; set; }
    }
}