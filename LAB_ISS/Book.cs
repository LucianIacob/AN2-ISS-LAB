//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LAB_ISS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public string titlu { get; set; }
        public string autor { get; set; }
        public string cod_carte { get; set; }

        public override string ToString()
        {
            return titlu + ";" + autor + ";" + cod_carte;
        }
    }
}
