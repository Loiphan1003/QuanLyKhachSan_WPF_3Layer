//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CT_SDDichVu
    {
        public int MaCTSDDV { get; set; }
        public Nullable<int> MaCTPT { get; set; }
        public Nullable<int> MaDV { get; set; }
        public int SL { get; set; }
        public decimal ThanhTien { get; set; }
    
        public virtual CT_PhieuThue CT_PhieuThue { get; set; }
        public virtual DichVu DichVu { get; set; }
    }
}
