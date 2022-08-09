namespace HotelListing.API.Models.Country
{
    public class CountryDto : BaseCountryDto
    {
        public List<HotelDto> Hotels { get; set; }
    }
}
