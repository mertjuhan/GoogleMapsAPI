using System.Formats.Asn1;
using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;

namespace GoogleMapsAPI.Models
{
    public partial class modelJSON
    {
        [JsonProperty("dizi")]
        public Dizi[] dizi { get; set; }
    }

    public partial class Dizi
    {
        [JsonProperty("business_status")]
        public string BusinessStatus { get; set; }

        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("icon_background_color")]
        public string IconBackgroundColor { get; set; }

        [JsonProperty("icon_mask_base_uri")]
        public Uri IconMaskBaseUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("permanently_closed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PermanentlyClosed { get; set; }

        [JsonProperty("place_id")]
        public string PlaceId { get; set; }

        [JsonProperty("plus_code")]
        public PlusCode PlusCode { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("types")]
        public string[] Types { get; set; }

        [JsonProperty("user_ratings_total")]
        public long UserRatingsTotal { get; set; }

        [JsonProperty("html_attributions")]
        public object[] HtmlAttributions { get; set; }

        [JsonProperty("opening_hours", NullValueHandling = NullValueHandling.Ignore)]
        public OpeningHours OpeningHours { get; set; }

        [JsonProperty("photos", NullValueHandling = NullValueHandling.Ignore)]
        public Photo[] Photos { get; set; }

        [JsonProperty("price_level", NullValueHandling = NullValueHandling.Ignore)]
        public long? PriceLevel { get; set; }
    }

    public partial class Geometry
    {
        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("viewport")]
        public Viewport Viewport { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lng")]
        public string Lng { get; set; }
    }

    public partial class Viewport
    {
        [JsonProperty("south")]
        public double South { get; set; }

        [JsonProperty("west")]
        public double West { get; set; }

        [JsonProperty("north")]
        public double North { get; set; }

        [JsonProperty("east")]
        public double East { get; set; }
    }

    public partial class OpeningHours
    {
        [JsonProperty("open_now")]
        public bool OpenNow { get; set; }
    }

    public partial class Photo
    {
        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("html_attributions")]
        public string[] HtmlAttributions { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }
    }

    public partial class PlusCode
    {
        [JsonProperty("compound_code")]
        public string CompoundCode { get; set; }

        [JsonProperty("global_code")]
        public string GlobalCode { get; set; }
    }

}
