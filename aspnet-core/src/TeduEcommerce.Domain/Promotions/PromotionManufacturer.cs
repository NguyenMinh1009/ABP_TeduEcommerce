using System;
using System.Collections.Generic;
using System.Text;

namespace TeduEcommerce.Promotions
{
    public class PromotionManufacturer : Entity<Guid>
    {
        public Guid ManufactureId { get; set; }
        public Guid PromotionId { get; set; }

    }
}
