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
    
    public partial class Author
    {
        public Author()
        {
            this.Books = new HashSet<Books>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    
        public virtual ICollection<Books> Books { get; set; }
    }
}
