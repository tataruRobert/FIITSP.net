//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proiect2_1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Locations
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhotosId { get; set; }
    
        public virtual Photos Photo { get; set; }
    }
}
