//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinLibrary.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public long Id { get; set; }
        public string Editor { get; set; }
        public string PublishedYear { get; set; }
        public Nullable<long> PagesNumber { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public Nullable<long> Isbn { get; set; }
    }
}
