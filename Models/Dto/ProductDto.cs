using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAPI_VSC.Models
{
    public class ProductDto
    {
        
          [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(100)]
        public string Thumbnail { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        [StringLength(30)]
        public string Brand { get; set; }

        [Required]
        [StringLength(30)]
        public string Category { get; set; }

        [Required]
        [StringLength(20)]
        public string Color { get; set; }

        [StringLength(800)]
        public string Description { get; set; }

        public List<ProductItem> ProductItems { get; set; }

        public List<ProductImageUrl> Images { get; set; }

        public List<ThumbnailUrl> Thumbnails { get; set; }

        public List<Review> Reviews { get; set; }

        public List<CartItem> RelatedCartItem { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}