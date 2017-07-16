using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using kumaranalloordevitempleadminweb;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace kumaranalloordevitempleadminweb
{
    //[MetadataType(typeof(VazhipaduMetadata))]
    public class VazhipaduMetadata
        {
            public int vazhipadu_id;
            public int diety_id;
            [Display(Name = "Offering")]
            [Required(ErrorMessage = "Please enter a valid Offering.")]
            public string offering_name;
            [Display(Name = "Materials")]
            public string materials_reqd;
            [Display(Name = "Amount")]
            [Required(ErrorMessage = "Please enter a valid Amount.")]
            public Nullable<decimal> offering_amount { get; set; }
            [Display(Name = "Remarks")]
            public string remarks { get; set; }
        }
   // [MetadataType(typeof(DietyMetadata))]
    public class DietyMetadata
        {
            public int diety_id { get; set; }
            [Display(Name = "Diety")]
            public string diety_name { get; set; }
        }
    //[MetadataType(typeof(NotificationsMetadata))]
    public class NotificationsMetadata
        {
        [HiddenInput(DisplayValue = false)]
        [Key]
        public int notification_id { get; set; }
        [Display(Name = "Title")]
        [Required(ErrorMessage = "Please enter a valid Title.")]
        public string notification_title { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please enter a valid Description.")]
        public string notification_description { get; set; }
        //[Display(Name = "Image")]
        //[Required(ErrorMessage = "Please enter a valid Image.")]
        //public byte[] notification_image { get; set; }
        [Display(Name = "From : Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Please enter a valid Date From.")]
        public Nullable<System.DateTime> date_from { get; set; }
        [Display(Name = "To : Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Please enter a valid Date To.")]
        public Nullable<System.DateTime> date_to { get; set; }
        //public Nullable<System.DateTime> datetime_updated { get; set; }
    }
}