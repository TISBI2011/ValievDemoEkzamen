//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kontrolnaaya2Valiev.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employees()
        {
            this.DevelopmentProcess = new HashSet<DevelopmentProcess>();
        }
    
        public int id { get; set; }
        public int idRole { get; set; }
        public int idDepartament { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public int Phone { get; set; }
        public int PassportNumber { get; set; }
        public string Language { get; set; }
        public string Sallary { get; set; }
        public string login { get; set; }
        public string parol { get; set; }
    
        public virtual Departament Departament { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevelopmentProcess> DevelopmentProcess { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
