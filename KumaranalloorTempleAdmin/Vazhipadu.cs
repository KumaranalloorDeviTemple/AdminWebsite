//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KumaranalloorTempleAdmin
{
    using kumaranalloordevitempleadminweb;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(VazhipaduMetadata))]
    public partial class Vazhipadu
    {
        public int vazhipadu_id { get; set; }
        public int diety_id { get; set; }
        public string offering_name { get; set; }
        public string materials_reqd { get; set; }
        public Nullable<decimal> offering_amount { get; set; }
        public string remarks { get; set; }
        public Nullable<System.DateTime> datetime_updated { get; set; }
        public string user_updated { get; set; }
    
        public virtual Diety Diety { get; set; }
    }
}
