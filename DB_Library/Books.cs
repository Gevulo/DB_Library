//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_Library
{
    using System;
    using System.Collections.Generic;
    
    public partial class Books
    {
        public int id { get; set; }
        public string NameBook { get; set; }
        public int Year { get; set; }
        public string Gener { get; set; }
        public int id_Author { get; set; }
        public int id_Librar { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Librar Librar { get; set; }
    }
}
