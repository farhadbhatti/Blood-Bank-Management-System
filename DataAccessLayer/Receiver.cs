//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Receiver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Receiver()
        {
            this.Donated_Blood = new HashSet<Donated_Blood>();
        }
    
        public int Receiver_ID { get; set; }
        public string Receiver_Name { get; set; }
        public string Receiver_Fname { get; set; }
        public string Receiver_Phone { get; set; }
        public string Receiver_CNIC { get; set; }
        public int Blood_Amount { get; set; }
        public System.DateTime Donation_Date { get; set; }
        public string Disease { get; set; }
        public int Donor_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Donated_Blood> Donated_Blood { get; set; }
        public virtual Donor Donor { get; set; }
    }
}