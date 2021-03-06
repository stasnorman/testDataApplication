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
    
    public partial class Vehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicle()
        {
            this.VehicleHistory = new HashSet<VehicleHistory>();
            this.VehicleImage = new HashSet<VehicleImage>();
        }
    
        public int Id { get; set; }
        public string VIN { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string VehicleType { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public int Weight { get; set; }
        public int Color { get; set; }
        public Nullable<int> EngineTypeId { get; set; }
        public string TypeDrive { get; set; }
        public string VehicleCategory { get; set; }
        public string EngineNumber { get; set; }
        public string EngineModel { get; set; }
        public Nullable<int> EngineYear { get; set; }
        public string EnginePower { get; set; }
        public string Horsepower { get; set; }
        public Nullable<double> MaximumLoad { get; set; }
        public string Comments { get; set; }
        public Nullable<int> DriverId { get; set; }
        public double WeightInKg { get; set; }
        public string LicencePlate { get; set; }
    
        public virtual CustomColor CustomColor { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual EngineType EngineType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleHistory> VehicleHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleImage> VehicleImage { get; set; }
    }
}
