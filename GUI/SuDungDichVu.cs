//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI
{
    using System;
    using System.Collections.Generic;
    
    public partial class SuDungDichVu
    {
        public int IDBangThuePhong { get; set; }
        public int IDDichVu { get; set; }
        public int SoLuong { get; set; }
    
        public virtual BangThuePhong BangThuePhong { get; set; }
        public virtual DichVu DichVu { get; set; }
    }
}
