using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grytet.Test
{
    public class Testapi
    {
        public class Rootobject
        {
            public string listingId { get; set; }
            public string sourceLocale { get; set; }
            public string sourceLocaleName { get; set; }
            public Adcontent adContent { get; set; }
            public Feature[] features { get; set; }
            public Location location { get; set; }
            public Photos photos { get; set; }
            public Unit[] units { get; set; }
        }

        public class Adcontent
        {
            public string accommodationsSummary { get; set; }
            public string description { get; set; }
            public string headline { get; set; }
        }

        public class Location
        {
            public float lat { get; set; }
            public float lng { get; set; }
        }

        public class Photos
        {
            public Photo[] photos { get; set; }
            public Thumbnail[] thumbnails { get; set; }
        }

        public class Photo
        {
            public Small small { get; set; }
            public Medium medium { get; set; }
            public Large large { get; set; }
            public Originaldimension originalDimension { get; set; }
        }

        public class Small
        {
            public Dimension dimension { get; set; }
            public string uri { get; set; }
        }

        public class Dimension
        {
            public int height { get; set; }
            public int width { get; set; }
        }

        public class Medium
        {
            public Dimension1 dimension { get; set; }
            public string uri { get; set; }
        }

        public class Dimension1
        {
            public int height { get; set; }
            public int width { get; set; }
        }

        public class Large
        {
            public Dimension2 dimension { get; set; }
            public string uri { get; set; }
        }

        public class Dimension2
        {
            public int height { get; set; }
            public int width { get; set; }
        }

        public class Originaldimension
        {
            public int height { get; set; }
            public int width { get; set; }
        }

        public class Thumbnail
        {
            public Photo1 photo { get; set; }
            public int unitNumber { get; set; }
        }

        public class Photo1
        {
            public Small1 small { get; set; }
            public Medium1 medium { get; set; }
            public Large1 large { get; set; }
            public Originaldimension1 originalDimension { get; set; }
        }

        public class Small1
        {
            public Dimension3 dimension { get; set; }
            public string uri { get; set; }
        }

        public class Dimension3
        {
            public int height { get; set; }
            public int width { get; set; }
        }

        public class Medium1
        {
            public Dimension4 dimension { get; set; }
            public string uri { get; set; }
        }

        public class Dimension4
        {
            public int height { get; set; }
            public int width { get; set; }
        }

        public class Large1
        {
            public Dimension5 dimension { get; set; }
            public string uri { get; set; }
        }

        public class Dimension5
        {
            public int height { get; set; }
            public int width { get; set; }
        }

        public class Originaldimension1
        {
            public int height { get; set; }
            public int width { get; set; }
        }

        public class Feature
        {
            public int count { get; set; }
            public string category { get; set; }
            public string description { get; set; }
            public string localizedName { get; set; }
        }

        public class Unit
        {
            public int unitNumber { get; set; }
            public Unitcontent unitContent { get; set; }
            public Reviewsummary reviewSummary { get; set; }
            public Unitreviewcontent unitReviewContent { get; set; }
            public Rateperiod[] ratePeriods { get; set; }
            public Unitavailability unitAvailability { get; set; }
        }

        public class Unitcontent
        {
            public int area { get; set; }
            public string areaUnit { get; set; }
            public string bathroomDetails { get; set; }
            public Bathroom[] bathrooms { get; set; }
            public string bedroomDetails { get; set; }
            public Bedroom[] bedrooms { get; set; }
            public int diningSeating { get; set; }
            public int maxSleep { get; set; }
            public int maxSleepInBeds { get; set; }
            public int numberOfBathrooms { get; set; }
            public int numberOfBedrooms { get; set; }
            public string propertyType { get; set; }
            public Feature1[] features { get; set; }
        }

        public class Bathroom
        {
            public Amenity[] amenities { get; set; }
            public string name { get; set; }
            public string roomSubType { get; set; }
        }

        public class Amenity
        {
            public int count { get; set; }
            public string category { get; set; }
            public string description { get; set; }
            public string localizedName { get; set; }
        }

        public class Bedroom
        {
            public Amenity1[] amenities { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string roomSubType { get; set; }
        }

        public class Amenity1
        {
            public int count { get; set; }
            public string category { get; set; }
            public string description { get; set; }
            public string localizedName { get; set; }
        }

        public class Feature1
        {
            public int count { get; set; }
            public string category { get; set; }
            public string description { get; set; }
            public string localizedName { get; set; }
        }

        public class Reviewsummary
        {
            public int reviewCount { get; set; }
            public float averageRating { get; set; }
            public int oneStarReviewCount { get; set; }
            public int twoStarReviewCount { get; set; }
            public int threeStarReviewCount { get; set; }
            public int fourStarReviewCount { get; set; }
            public int fiveStarReviewCount { get; set; }
            public int guestbookReviewCount { get; set; }
        }

        public class Unitreviewcontent
        {
            public string nextPage { get; set; }
            public int size { get; set; }
            public int page { get; set; }
            public Entry[] entries { get; set; }
        }

        public class Entry
        {
            public DateTime arrivalDate { get; set; }
            public string reviewerName { get; set; }
            public string body { get; set; }
            public string headline { get; set; }
            public int helpfulCount { get; set; }
            public int unhelpfulCount { get; set; }
            public string reviewLocale { get; set; }
        }

        public class Unitavailability
        {
            public string availabilityDefault { get; set; }
            public string changeOverDefault { get; set; }
            public Daterange dateRange { get; set; }
            public int maxStayDefault { get; set; }
            public int minPriorNotifyDefault { get; set; }
            public int minStayDefault { get; set; }
            public string stayIncrementDefault { get; set; }
            public Unitavailabilityconfiguration unitAvailabilityConfiguration { get; set; }
        }

        public class Daterange
        {
            public string beginDate { get; set; }
            public string endDate { get; set; }
        }

        public class Unitavailabilityconfiguration
        {
            public string availability { get; set; }
            public object availableUnitCount { get; set; }
            public string changeOver { get; set; }
            public string maxStay { get; set; }
            public string minPriorNotify { get; set; }
            public string minStay { get; set; }
            public string stayIncrement { get; set; }
        }

        public class Rateperiod
        {
            public Daterange1 dateRange { get; set; }
            public int minimumStay { get; set; }
            public string name { get; set; }
            public Rates rates { get; set; }
        }

        public class Daterange1
        {
            public string beginDate { get; set; }
            public string endDate { get; set; }
        }

        public class Rates
        {
            public Weekly weekly { get; set; }
            public Season season { get; set; }
        }

        public class Weekly
        {
            public string currency { get; set; }
            public int amount { get; set; }
        }

        public class Season
        {
            public string currency { get; set; }
            public int amount { get; set; }
        }

    }
}
