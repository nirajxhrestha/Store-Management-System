//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreManagementSystem.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class categorySetup
    {
        public int categoryID { get; set; }
        public string categoryName { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> createdBy { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<int> updatedBy { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
        public Nullable<int> deletedBy { get; set; }
        public Nullable<System.DateTime> deletedDate { get; set; }
        public string imageName { get; set; }
        public string imagePath { get; set; }
        public string SetCategoryID { get; set; }
    }
}
