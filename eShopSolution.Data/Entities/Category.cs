using aShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace aShopSolution.Data.Entitis
{
    public class Category
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }

        // thuộc tính liên kết giữa bản product và catrgory
        public List<ProductInCategory> productInCategories { get; set; }

        public List<CategoryTranslation> CategoryTranslations { get; set; }

    }
}
