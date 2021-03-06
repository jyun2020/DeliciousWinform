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
    
    public partial class Recipe_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recipe_Table()
        {
            this.Collection_Table = new HashSet<Collection_Table>();
            this.CommentSection_Table = new HashSet<CommentSection_Table>();
            this.Hashtag_Record_Table = new HashSet<Hashtag_Record_Table>();
            this.Ingredient_Record_Table = new HashSet<Ingredient_Record_Table>();
            this.LikeRecipe_Table = new HashSet<LikeRecipe_Table>();
            this.Steps_Table = new HashSet<Steps_Table>();
            this.Wish_List_Table = new HashSet<Wish_List_Table>();
        }
    
        public int RecipeID { get; set; }
        public System.DateTime PostTime { get; set; }
        public int RecipeCategoryID { get; set; }
        public int MemberID { get; set; }
        public string RecipeName { get; set; }
        public string RecipeDescription { get; set; }
        public int ForHowMany { get; set; }
        public int TimeNeed { get; set; }
        public string ShareLink { get; set; }
        public int Views { get; set; }
        public byte[] Picture { get; set; }
        public string Video { get; set; }
        public Nullable<bool> DisVisible { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Collection_Table> Collection_Table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommentSection_Table> CommentSection_Table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hashtag_Record_Table> Hashtag_Record_Table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ingredient_Record_Table> Ingredient_Record_Table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LikeRecipe_Table> LikeRecipe_Table { get; set; }
        public virtual Member_Table Member_Table { get; set; }
        public virtual RecipeCategory_Table RecipeCategory_Table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Steps_Table> Steps_Table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wish_List_Table> Wish_List_Table { get; set; }
    }
}
