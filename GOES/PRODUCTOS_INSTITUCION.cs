//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GOES
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCTOS_INSTITUCION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCTOS_INSTITUCION()
        {
            this.DETALLE_SOLICITUD = new HashSet<DETALLE_SOLICITUD>();
        }
    
        public int PROD_INSTITUCION_ID { get; set; }
        public int INSTITUCION_ID { get; set; }
        public string PROD_INSTITUCION_NOMBRE { get; set; }
        public string PROD_INSTITUCION_DESCRIPCION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_SOLICITUD> DETALLE_SOLICITUD { get; set; }
        public virtual INSTITUCIONES INSTITUCIONES { get; set; }
    }
}
