//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetAspNet.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExpanseTypes
    {
        public ExpanseTypes()
        {
            this.Expanses = new HashSet<Expanses>();
        }
    
        public System.Guid ExpenseType_ID { get; set; }
        public string Name { get; set; }
        public Nullable<double> Ceiling { get; set; }
        public bool Fixed { get; set; }
        public bool OnlyManagers { get; set; }
        public System.Guid Tva_ID { get; set; }
    
        public virtual ICollection<Expanses> Expanses { get; set; }
        public virtual Tvas Tvas { get; set; }
    }
}
