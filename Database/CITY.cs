//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class CITY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CITY()
        {
            this.DISTRICTs = new HashSet<DISTRICT>();
        }

        [Required(ErrorMessage = "L�tfen sehir seciniz.")]
        public int CITY_ID { get; set; }
        [Required(ErrorMessage = "L�tfen bolge seciniz.")]
        public int AREA_ID { get; set; }
        [Required(ErrorMessage = "L�tfen sehir adi giriniz.")]
        [StringLength(100, ErrorMessage = "Sehir adi uzunlugu maksimum 100 karakter olabilir.")]
        public string CITY_NAME { get; set; }
        [Range(1, Int32.MaxValue, ErrorMessage = "Sehir kodu minimum 1 olabilir.")]
        public Nullable<int> CITY_CODE { get; set; }

        public virtual AREA AREA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DISTRICT> DISTRICTs { get; set; }
    }
}