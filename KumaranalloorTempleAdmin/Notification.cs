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
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(NotificationsMetadata))]
    public partial class Notification
    {
        public int notification_id { get; set; }
        public string notification_title { get; set; }
        public string notification_description { get; set; }
        public byte[] notification_image { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> date_from { get; set; }
        public Nullable<System.DateTime> date_to { get; set; }
        public Nullable<System.DateTime> datetime_updated { get; set; }
    }
}
