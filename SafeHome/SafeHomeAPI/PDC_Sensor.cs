//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SafeHomeAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class PDC_Sensor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PDC_Sensor()
        {
            this.PDC_SensorEvent = new HashSet<PDC_SensorEvent>();
        }
    
        public int SensorID { get; set; }
        public int SensorTypeID { get; set; }
        public int RoomID { get; set; }
    
        public virtual PDC_Room PDC_Room { get; set; }
        public virtual PDC_SensorType PDC_SensorType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PDC_SensorEvent> PDC_SensorEvent { get; set; }
    }
}