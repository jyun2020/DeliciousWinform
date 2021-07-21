//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace customerChatServer.Properties
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ingredient_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ingredient_Table()
        {
            this.Ingredient_Record_Table = new HashSet<Ingredient_Record_Table>();
            this.Merchandise_Picture_Table = new HashSet<Merchandise_Picture_Table>();
            this.Order_Detail_Table = new HashSet<Order_Detail_Table>();
            this.Shopping_Cart_table = new HashSet<Shopping_Cart_table>();
        }
    
        public int IngredientID { get; set; }
        public string Ingredient { get; set; }
        public int IngredientCategoryID { get; set; }
        public string IngredientUnit { get; set; }
        public decimal Price { get; set; }
        public int AmountInStore { get; set; }
        public string MerchandiseDescription { get; set; }
        public bool InStoreOrNot { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ingredient_Record_Table> Ingredient_Record_Table { get; set; }
        public virtual IngredientCategory_Table IngredientCategory_Table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Merchandise_Picture_Table> Merchandise_Picture_Table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Detail_Table> Order_Detail_Table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shopping_Cart_table> Shopping_Cart_table { get; set; }
    }
}
