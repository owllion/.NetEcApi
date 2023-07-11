using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAPI_VSC.Models
{
    public class SingleProduct
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [StringLength(50)]
        public required string ProductName { get; set; }

        [StringLength(100)]
        public required string  Thumbnail { get; set; }

        [Required]
        public required float Price { get; set; }

        [Required]
        [StringLength(30)]
        public required string Brand { get; set; }

        [StringLength(30)]
        public required string Category { get; set; }

        [StringLength(20)]
        public required string Color { get; set; }

        [StringLength(800)]
        public required string Description { get; set; }

        // public List<ProductItem> ProductItems { get; set; }

        // public List<ProductImageUrl> Images { get; set; }

        // public List<ThumbnailUrl> Thumbnails { get; set; }

        // public List<Review> Reviews { get; set; }

        // public List<CartItem> RelatedCartItem { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}