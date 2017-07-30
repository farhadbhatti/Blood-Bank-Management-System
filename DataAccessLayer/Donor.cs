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
    
    public partial class Donor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Donor()
        {
            this.Donated_Blood = new HashSet<Donated_Blood>();
            this.Receivers = new HashSet<Receiver>();
        }
    
        public int DonorID { get; set; }
        public string Donor_Name { get; set; }
        public string Donor_Fname { get; set; }
        public int Donor_Age { get; set; }
        public string Donor_Gender { get; set; }
        public System.DateTime Donor_DOB { get; set; }
        public string Donor_Phone { get; set; }
        public string Donor_CNIC { get; set; }
        public string Donor_Email { get; set; }
        public string Donor_City { get; set; }
        public string Donor_Address { get; set; }
        public double Donor_Height { get; set; }
        public string donatedBefore { get; set; }
        public Nullable<System.DateTime> donatedBefore_Date { get; set; }
        public string Donor_Disease { get; set; }
        public int Eye_Color_ID { get; set; }
        public int Blood_Type_ID { get; set; }
        public string Stock_ID { get; set; }
        public string isSelfDonated { get; set; }
    
        public virtual Blood_Group Blood_Group { get; set; }
        public virtual Blood_Stock Blood_Stock { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Donated_Blood> Donated_Blood { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receiver> Receivers { get; set; }
        public virtual Eye_Color Eye_Color { get; set; }
    }
}
