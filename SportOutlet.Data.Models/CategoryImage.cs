using Microsoft.EntityFrameworkCore;
using SportOutlet.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportOutlet.Data.Models
{
    public class CategoryImage
    {
        [Comment("Identification of image")]
        public Guid Id { get; set; }

        [Comment("Url of the image")]
        public string ImageUrl { get; set; } = null!;

        [Comment("Example for man or women category")]
        public Gender Gender { get; set; }

        [Comment("From where we get to which category it belongs")]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
