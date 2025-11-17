using ICanHelp.Core.Entities;
using ICanHelp.Core.Entities.Negotiations;
using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Application.DTO
{
    public class AnnouncementDto
    {
        public Guid Id { get; set; }
        public CategoryDto Category { get; set; }
        public SubcategoryDto Subcategory { get; set; }
        public DifficultLevelDto DifficultLevel { get; set; }
        public Guid OwnerId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public LocationDto Location { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsFinished { get; set; }


        public ClientOfferDto ClientOffer { get; set; }
        public IEnumerable<HelperOfferDto> HelperOffers { get; set; }
        public IEnumerable<ImageDto> Images { get; set; }
    }
}
