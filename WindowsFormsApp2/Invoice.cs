//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            this.Item_Invoice = new HashSet<Item_Invoice>();
        }
    
        public int InvoiceID { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public Nullable<decimal> InvoiceDiscount { get; set; }
        public decimal InvoiceAmount { get; set; }
        public Nullable<decimal> InvoiceAmountRecieved { get; set; }
        public Nullable<decimal> InvoiceBalance { get; set; }
        public string InvoicePaymentMethod { get; set; }
        public string InvoiceRemarks { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item_Invoice> Item_Invoice { get; set; }
    }
}
