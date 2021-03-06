//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Session2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Driver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Driver()
        {
            this.Vehicle = new HashSet<Vehicle>();
            this.VehicleHistory = new HashSet<VehicleHistory>();
        }
    
        public int Identifier { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public string PostCode { get; set; }
        public string RegistrationAddress { get; set; }
        public string ResidenceAddress { get; set; }
        public string PlaceOfWork { get; set; }
        public string Position { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string PhotoString { get; set; }
        public byte[] Photo { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> LicenceId { get; set; }
    
        public virtual Licence Licence { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehicle> Vehicle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleHistory> VehicleHistory { get; set; }
    }
}
