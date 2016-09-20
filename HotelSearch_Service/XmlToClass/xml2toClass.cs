using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlToClass
{


    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class HotelListResponse
    {

        private string customerSessionIdField;

        private byte numberOfRoomsRequestedField;

        private bool moreResultsAvailableField;

        private string cacheKeyField;

        private string cacheLocationField;

        private HotelListResponseCachedSupplierResponse cachedSupplierResponseField;

        private HotelListResponseHotelList hotelListField;

        /// <remarks/>
        public string customerSessionId
        {
            get
            {
                return this.customerSessionIdField;
            }
            set
            {
                this.customerSessionIdField = value;
            }
        }

        /// <remarks/>
        public byte numberOfRoomsRequested
        {
            get
            {
                return this.numberOfRoomsRequestedField;
            }
            set
            {
                this.numberOfRoomsRequestedField = value;
            }
        }

        /// <remarks/>
        public bool moreResultsAvailable
        {
            get
            {
                return this.moreResultsAvailableField;
            }
            set
            {
                this.moreResultsAvailableField = value;
            }
        }

        /// <remarks/>
        public string cacheKey
        {
            get
            {
                return this.cacheKeyField;
            }
            set
            {
                this.cacheKeyField = value;
            }
        }

        /// <remarks/>
        public string cacheLocation
        {
            get
            {
                return this.cacheLocationField;
            }
            set
            {
                this.cacheLocationField = value;
            }
        }

        /// <remarks/>
        public HotelListResponseCachedSupplierResponse cachedSupplierResponse
        {
            get
            {
                return this.cachedSupplierResponseField;
            }
            set
            {
                this.cachedSupplierResponseField = value;
            }
        }

        /// <remarks/>
        public HotelListResponseHotelList HotelList
        {
            get
            {
                return this.hotelListField;
            }
            set
            {
                this.hotelListField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseCachedSupplierResponse
    {

        private string supplierCacheToleranceField;

        private byte cachedTimeField;

        private byte supplierRequestNumField;

        private byte supplierResponseNumField;

        private ushort supplierResponseTimeField;

        private byte candidatePreptimeField;

        private byte otherOverheadTimeField;

        private ushort tpidUsedField;

        private bool matchedCurrencyField;

        private bool matchedLocaleField;

        /// <remarks/>
        public string supplierCacheTolerance
        {
            get
            {
                return this.supplierCacheToleranceField;
            }
            set
            {
                this.supplierCacheToleranceField = value;
            }
        }

        /// <remarks/>
        public byte cachedTime
        {
            get
            {
                return this.cachedTimeField;
            }
            set
            {
                this.cachedTimeField = value;
            }
        }

        /// <remarks/>
        public byte supplierRequestNum
        {
            get
            {
                return this.supplierRequestNumField;
            }
            set
            {
                this.supplierRequestNumField = value;
            }
        }

        /// <remarks/>
        public byte supplierResponseNum
        {
            get
            {
                return this.supplierResponseNumField;
            }
            set
            {
                this.supplierResponseNumField = value;
            }
        }

        /// <remarks/>
        public ushort supplierResponseTime
        {
            get
            {
                return this.supplierResponseTimeField;
            }
            set
            {
                this.supplierResponseTimeField = value;
            }
        }

        /// <remarks/>
        public byte candidatePreptime
        {
            get
            {
                return this.candidatePreptimeField;
            }
            set
            {
                this.candidatePreptimeField = value;
            }
        }

        /// <remarks/>
        public byte otherOverheadTime
        {
            get
            {
                return this.otherOverheadTimeField;
            }
            set
            {
                this.otherOverheadTimeField = value;
            }
        }

        /// <remarks/>
        public ushort tpidUsed
        {
            get
            {
                return this.tpidUsedField;
            }
            set
            {
                this.tpidUsedField = value;
            }
        }

        /// <remarks/>
        public bool matchedCurrency
        {
            get
            {
                return this.matchedCurrencyField;
            }
            set
            {
                this.matchedCurrencyField = value;
            }
        }

        /// <remarks/>
        public bool matchedLocale
        {
            get
            {
                return this.matchedLocaleField;
            }
            set
            {
                this.matchedLocaleField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelList
    {

        private byte sizeField;

        private byte activePropertyCountField;

        private HotelListResponseHotelListHotelSummary[] hotelSummaryField;

        /// <remarks/>
        public byte size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        public byte activePropertyCount
        {
            get
            {
                return this.activePropertyCountField;
            }
            set
            {
                this.activePropertyCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HotelSummary")]
        public HotelListResponseHotelListHotelSummary[] HotelSummary
        {
            get
            {
                return this.hotelSummaryField;
            }
            set
            {
                this.hotelSummaryField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummary
    {

        private byte orderField;

        private int ubsScoreField;

        private uint hotelIdField;

        private string nameField;

        private string address1Field;

        private string address2Field;

        private string cityField;

        private uint postalCodeField;

        private bool postalCodeFieldSpecified;

        private string countryCodeField;

        private string airportCodeField;

        private string supplierTypeField;

        private byte propertyCategoryField;

        private byte hotelRatingField;

        private string hotelRatingDisplayField;

        private byte confidenceRatingField;

        private uint amenityMaskField;

        private decimal tripAdvisorRatingField;

        private ushort tripAdvisorReviewCountField;

        private bool tripAdvisorReviewCountFieldSpecified;

        private string tripAdvisorRatingUrlField;

        private string locationDescriptionField;

        private string shortDescriptionField;

        private decimal highRateField;

        private decimal lowRateField;

        private string rateCurrencyCodeField;

        private decimal latitudeField;

        private decimal longitudeField;

        private sbyte proximityDistanceField;

        private string proximityUnitField;

        private bool hotelInDestinationField;

        private string thumbNailUrlField;

        private string deepLinkField;

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsList roomRateDetailsListField;

        /// <remarks/>
        public byte order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }

        /// <remarks/>
        public int ubsScore
        {
            get
            {
                return this.ubsScoreField;
            }
            set
            {
                this.ubsScoreField = value;
            }
        }

        /// <remarks/>
        public uint hotelId
        {
            get
            {
                return this.hotelIdField;
            }
            set
            {
                this.hotelIdField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string address1
        {
            get
            {
                return this.address1Field;
            }
            set
            {
                this.address1Field = value;
            }
        }

        /// <remarks/>
        public string address2
        {
            get
            {
                return this.address2Field;
            }
            set
            {
                this.address2Field = value;
            }
        }

        /// <remarks/>
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public uint postalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool postalCodeSpecified
        {
            get
            {
                return this.postalCodeFieldSpecified;
            }
            set
            {
                this.postalCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string countryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }

        /// <remarks/>
        public string airportCode
        {
            get
            {
                return this.airportCodeField;
            }
            set
            {
                this.airportCodeField = value;
            }
        }

        /// <remarks/>
        public string supplierType
        {
            get
            {
                return this.supplierTypeField;
            }
            set
            {
                this.supplierTypeField = value;
            }
        }

        /// <remarks/>
        public byte propertyCategory
        {
            get
            {
                return this.propertyCategoryField;
            }
            set
            {
                this.propertyCategoryField = value;
            }
        }

        /// <remarks/>
        public byte hotelRating
        {
            get
            {
                return this.hotelRatingField;
            }
            set
            {
                this.hotelRatingField = value;
            }
        }

        /// <remarks/>
        public string hotelRatingDisplay
        {
            get
            {
                return this.hotelRatingDisplayField;
            }
            set
            {
                this.hotelRatingDisplayField = value;
            }
        }

        /// <remarks/>
        public byte confidenceRating
        {
            get
            {
                return this.confidenceRatingField;
            }
            set
            {
                this.confidenceRatingField = value;
            }
        }

        /// <remarks/>
        public uint amenityMask
        {
            get
            {
                return this.amenityMaskField;
            }
            set
            {
                this.amenityMaskField = value;
            }
        }

        /// <remarks/>
        public decimal tripAdvisorRating
        {
            get
            {
                return this.tripAdvisorRatingField;
            }
            set
            {
                this.tripAdvisorRatingField = value;
            }
        }

        /// <remarks/>
        public ushort tripAdvisorReviewCount
        {
            get
            {
                return this.tripAdvisorReviewCountField;
            }
            set
            {
                this.tripAdvisorReviewCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tripAdvisorReviewCountSpecified
        {
            get
            {
                return this.tripAdvisorReviewCountFieldSpecified;
            }
            set
            {
                this.tripAdvisorReviewCountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string tripAdvisorRatingUrl
        {
            get
            {
                return this.tripAdvisorRatingUrlField;
            }
            set
            {
                this.tripAdvisorRatingUrlField = value;
            }
        }

        /// <remarks/>
        public string locationDescription
        {
            get
            {
                return this.locationDescriptionField;
            }
            set
            {
                this.locationDescriptionField = value;
            }
        }

        /// <remarks/>
        public string shortDescription
        {
            get
            {
                return this.shortDescriptionField;
            }
            set
            {
                this.shortDescriptionField = value;
            }
        }

        /// <remarks/>
        public decimal highRate
        {
            get
            {
                return this.highRateField;
            }
            set
            {
                this.highRateField = value;
            }
        }

        /// <remarks/>
        public decimal lowRate
        {
            get
            {
                return this.lowRateField;
            }
            set
            {
                this.lowRateField = value;
            }
        }

        /// <remarks/>
        public string rateCurrencyCode
        {
            get
            {
                return this.rateCurrencyCodeField;
            }
            set
            {
                this.rateCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        public decimal latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        public decimal longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        public sbyte proximityDistance
        {
            get
            {
                return this.proximityDistanceField;
            }
            set
            {
                this.proximityDistanceField = value;
            }
        }

        /// <remarks/>
        public string proximityUnit
        {
            get
            {
                return this.proximityUnitField;
            }
            set
            {
                this.proximityUnitField = value;
            }
        }

        /// <remarks/>
        public bool hotelInDestination
        {
            get
            {
                return this.hotelInDestinationField;
            }
            set
            {
                this.hotelInDestinationField = value;
            }
        }

        /// <remarks/>
        public string thumbNailUrl
        {
            get
            {
                return this.thumbNailUrlField;
            }
            set
            {
                this.thumbNailUrlField = value;
            }
        }

        /// <remarks/>
        public string deepLink
        {
            get
            {
                return this.deepLinkField;
            }
            set
            {
                this.deepLinkField = value;
            }
        }

        /// <remarks/>
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsList RoomRateDetailsList
        {
            get
            {
                return this.roomRateDetailsListField;
            }
            set
            {
                this.roomRateDetailsListField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsList
    {

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetails roomRateDetailsField;

        /// <remarks/>
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetails RoomRateDetails
        {
            get
            {
                return this.roomRateDetailsField;
            }
            set
            {
                this.roomRateDetailsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetails
    {

        private uint roomTypeCodeField;

        private uint rateCodeField;

        private byte maxRoomOccupancyField;

        private byte quotedRoomOccupancyField;

        private byte minGuestAgeField;

        private string roomDescriptionField;

        private bool propertyAvailableField;

        private bool propertyRestrictedField;

        private uint expediaPropertyIdField;

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfos rateInfosField;

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsValueAdds valueAddsField;

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsBedTypes bedTypesField;

        private string smokingPreferencesField;

        /// <remarks/>
        public uint roomTypeCode
        {
            get
            {
                return this.roomTypeCodeField;
            }
            set
            {
                this.roomTypeCodeField = value;
            }
        }

        /// <remarks/>
        public uint rateCode
        {
            get
            {
                return this.rateCodeField;
            }
            set
            {
                this.rateCodeField = value;
            }
        }

        /// <remarks/>
        public byte maxRoomOccupancy
        {
            get
            {
                return this.maxRoomOccupancyField;
            }
            set
            {
                this.maxRoomOccupancyField = value;
            }
        }

        /// <remarks/>
        public byte quotedRoomOccupancy
        {
            get
            {
                return this.quotedRoomOccupancyField;
            }
            set
            {
                this.quotedRoomOccupancyField = value;
            }
        }

        /// <remarks/>
        public byte minGuestAge
        {
            get
            {
                return this.minGuestAgeField;
            }
            set
            {
                this.minGuestAgeField = value;
            }
        }

        /// <remarks/>
        public string roomDescription
        {
            get
            {
                return this.roomDescriptionField;
            }
            set
            {
                this.roomDescriptionField = value;
            }
        }

        /// <remarks/>
        public bool propertyAvailable
        {
            get
            {
                return this.propertyAvailableField;
            }
            set
            {
                this.propertyAvailableField = value;
            }
        }

        /// <remarks/>
        public bool propertyRestricted
        {
            get
            {
                return this.propertyRestrictedField;
            }
            set
            {
                this.propertyRestrictedField = value;
            }
        }

        /// <remarks/>
        public uint expediaPropertyId
        {
            get
            {
                return this.expediaPropertyIdField;
            }
            set
            {
                this.expediaPropertyIdField = value;
            }
        }

        /// <remarks/>
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfos RateInfos
        {
            get
            {
                return this.rateInfosField;
            }
            set
            {
                this.rateInfosField = value;
            }
        }

        /// <remarks/>
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsValueAdds ValueAdds
        {
            get
            {
                return this.valueAddsField;
            }
            set
            {
                this.valueAddsField = value;
            }
        }

        /// <remarks/>
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsBedTypes BedTypes
        {
            get
            {
                return this.bedTypesField;
            }
            set
            {
                this.bedTypesField = value;
            }
        }

        /// <remarks/>
        public string smokingPreferences
        {
            get
            {
                return this.smokingPreferencesField;
            }
            set
            {
                this.smokingPreferencesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfos
    {

        private byte sizeField;

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfo rateInfoField;

        /// <remarks/>
        public byte size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfo RateInfo
        {
            get
            {
                return this.rateInfoField;
            }
            set
            {
                this.rateInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfo
    {

        private bool priceBreakdownField;

        private bool promoField;

        private bool rateChangeField;

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoRoomGroup roomGroupField;

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoChargeableRateInfo chargeableRateInfoField;

        private string cancellationPolicyField;

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoCancelPolicyInfo[] cancelPolicyInfoListField;

        private bool nonRefundableField;

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoHotelFees hotelFeesField;

        private string rateTypeField;

        private uint promoIdField;

        private bool promoIdFieldSpecified;

        private string promoDescriptionField;

        private string promoTypeField;

        private byte currentAllotmentField;

        /// <remarks/>
        public bool priceBreakdown
        {
            get
            {
                return this.priceBreakdownField;
            }
            set
            {
                this.priceBreakdownField = value;
            }
        }

        /// <remarks/>
        public bool promo
        {
            get
            {
                return this.promoField;
            }
            set
            {
                this.promoField = value;
            }
        }

        /// <remarks/>
        public bool rateChange
        {
            get
            {
                return this.rateChangeField;
            }
            set
            {
                this.rateChangeField = value;
            }
        }

        /// <remarks/>
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoRoomGroup RoomGroup
        {
            get
            {
                return this.roomGroupField;
            }
            set
            {
                this.roomGroupField = value;
            }
        }

        /// <remarks/>
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoChargeableRateInfo ChargeableRateInfo
        {
            get
            {
                return this.chargeableRateInfoField;
            }
            set
            {
                this.chargeableRateInfoField = value;
            }
        }

        /// <remarks/>
        public string cancellationPolicy
        {
            get
            {
                return this.cancellationPolicyField;
            }
            set
            {
                this.cancellationPolicyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CancelPolicyInfo", IsNullable = false)]
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoCancelPolicyInfo[] CancelPolicyInfoList
        {
            get
            {
                return this.cancelPolicyInfoListField;
            }
            set
            {
                this.cancelPolicyInfoListField = value;
            }
        }

        /// <remarks/>
        public bool nonRefundable
        {
            get
            {
                return this.nonRefundableField;
            }
            set
            {
                this.nonRefundableField = value;
            }
        }

        /// <remarks/>
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoHotelFees HotelFees
        {
            get
            {
                return this.hotelFeesField;
            }
            set
            {
                this.hotelFeesField = value;
            }
        }

        /// <remarks/>
        public string rateType
        {
            get
            {
                return this.rateTypeField;
            }
            set
            {
                this.rateTypeField = value;
            }
        }

        /// <remarks/>
        public uint promoId
        {
            get
            {
                return this.promoIdField;
            }
            set
            {
                this.promoIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool promoIdSpecified
        {
            get
            {
                return this.promoIdFieldSpecified;
            }
            set
            {
                this.promoIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string promoDescription
        {
            get
            {
                return this.promoDescriptionField;
            }
            set
            {
                this.promoDescriptionField = value;
            }
        }

        /// <remarks/>
        public string promoType
        {
            get
            {
                return this.promoTypeField;
            }
            set
            {
                this.promoTypeField = value;
            }
        }

        /// <remarks/>
        public byte currentAllotment
        {
            get
            {
                return this.currentAllotmentField;
            }
            set
            {
                this.currentAllotmentField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoRoomGroup
    {

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoRoomGroupRoom roomField;

        /// <remarks/>
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoRoomGroupRoom Room
        {
            get
            {
                return this.roomField;
            }
            set
            {
                this.roomField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoRoomGroupRoom
    {

        private byte numberOfAdultsField;

        private byte numberOfChildrenField;

        private string rateKeyField;

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoRoomGroupRoomChargeableNightlyRates[] chargeableNightlyRatesField;

        /// <remarks/>
        public byte numberOfAdults
        {
            get
            {
                return this.numberOfAdultsField;
            }
            set
            {
                this.numberOfAdultsField = value;
            }
        }

        /// <remarks/>
        public byte numberOfChildren
        {
            get
            {
                return this.numberOfChildrenField;
            }
            set
            {
                this.numberOfChildrenField = value;
            }
        }

        /// <remarks/>
        public string rateKey
        {
            get
            {
                return this.rateKeyField;
            }
            set
            {
                this.rateKeyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ChargeableNightlyRates")]
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoRoomGroupRoomChargeableNightlyRates[] ChargeableNightlyRates
        {
            get
            {
                return this.chargeableNightlyRatesField;
            }
            set
            {
                this.chargeableNightlyRatesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoRoomGroupRoomChargeableNightlyRates
    {

        private decimal baseRateField;

        private decimal rateField;

        private bool promoField;

        /// <remarks/>
        public decimal baseRate
        {
            get
            {
                return this.baseRateField;
            }
            set
            {
                this.baseRateField = value;
            }
        }

        /// <remarks/>
        public decimal rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        /// <remarks/>
        public bool promo
        {
            get
            {
                return this.promoField;
            }
            set
            {
                this.promoField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoChargeableRateInfo
    {

        private decimal averageBaseRateField;

        private decimal averageRateField;

        private decimal commissionableUsdTotalField;

        private string currencyCodeField;

        private decimal maxNightlyRateField;

        private decimal nightlyRateTotalField;

        private decimal surchargeTotalField;

        private decimal totalField;

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoChargeableRateInfoNightlyRatesPerRoom nightlyRatesPerRoomField;

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoChargeableRateInfoSurcharges surchargesField;

        /// <remarks/>
        public decimal averageBaseRate
        {
            get
            {
                return this.averageBaseRateField;
            }
            set
            {
                this.averageBaseRateField = value;
            }
        }

        /// <remarks/>
        public decimal averageRate
        {
            get
            {
                return this.averageRateField;
            }
            set
            {
                this.averageRateField = value;
            }
        }

        /// <remarks/>
        public decimal commissionableUsdTotal
        {
            get
            {
                return this.commissionableUsdTotalField;
            }
            set
            {
                this.commissionableUsdTotalField = value;
            }
        }

        /// <remarks/>
        public string currencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        public decimal maxNightlyRate
        {
            get
            {
                return this.maxNightlyRateField;
            }
            set
            {
                this.maxNightlyRateField = value;
            }
        }

        /// <remarks/>
        public decimal nightlyRateTotal
        {
            get
            {
                return this.nightlyRateTotalField;
            }
            set
            {
                this.nightlyRateTotalField = value;
            }
        }

        /// <remarks/>
        public decimal surchargeTotal
        {
            get
            {
                return this.surchargeTotalField;
            }
            set
            {
                this.surchargeTotalField = value;
            }
        }

        /// <remarks/>
        public decimal total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoChargeableRateInfoNightlyRatesPerRoom NightlyRatesPerRoom
        {
            get
            {
                return this.nightlyRatesPerRoomField;
            }
            set
            {
                this.nightlyRatesPerRoomField = value;
            }
        }

        /// <remarks/>
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoChargeableRateInfoSurcharges Surcharges
        {
            get
            {
                return this.surchargesField;
            }
            set
            {
                this.surchargesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoChargeableRateInfoNightlyRatesPerRoom
    {

        private byte sizeField;

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoChargeableRateInfoNightlyRatesPerRoomNightlyRate[] nightlyRateField;

        /// <remarks/>
        public byte size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NightlyRate")]
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoChargeableRateInfoNightlyRatesPerRoomNightlyRate[] NightlyRate
        {
            get
            {
                return this.nightlyRateField;
            }
            set
            {
                this.nightlyRateField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoChargeableRateInfoNightlyRatesPerRoomNightlyRate
    {

        private decimal baseRateField;

        private decimal rateField;

        private bool promoField;

        /// <remarks/>
        public decimal baseRate
        {
            get
            {
                return this.baseRateField;
            }
            set
            {
                this.baseRateField = value;
            }
        }

        /// <remarks/>
        public decimal rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        /// <remarks/>
        public bool promo
        {
            get
            {
                return this.promoField;
            }
            set
            {
                this.promoField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoChargeableRateInfoSurcharges
    {

        private byte sizeField;

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoChargeableRateInfoSurchargesSurcharge surchargeField;

        /// <remarks/>
        public byte size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoChargeableRateInfoSurchargesSurcharge Surcharge
        {
            get
            {
                return this.surchargeField;
            }
            set
            {
                this.surchargeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoChargeableRateInfoSurchargesSurcharge
    {

        private string typeField;

        private decimal amountField;

        /// <remarks/>
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public decimal amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoCancelPolicyInfo
    {

        private uint versionIdField;

        private System.DateTime cancelTimeField;

        private ushort startWindowHoursField;

        private byte nightCountField;

        private byte percentField;

        private bool percentFieldSpecified;

        private string currencyCodeField;

        private string timeZoneDescriptionField;

        /// <remarks/>
        public uint versionId
        {
            get
            {
                return this.versionIdField;
            }
            set
            {
                this.versionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime cancelTime
        {
            get
            {
                return this.cancelTimeField;
            }
            set
            {
                this.cancelTimeField = value;
            }
        }

        /// <remarks/>
        public ushort startWindowHours
        {
            get
            {
                return this.startWindowHoursField;
            }
            set
            {
                this.startWindowHoursField = value;
            }
        }

        /// <remarks/>
        public byte nightCount
        {
            get
            {
                return this.nightCountField;
            }
            set
            {
                this.nightCountField = value;
            }
        }

        /// <remarks/>
        public byte percent
        {
            get
            {
                return this.percentField;
            }
            set
            {
                this.percentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentSpecified
        {
            get
            {
                return this.percentFieldSpecified;
            }
            set
            {
                this.percentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string currencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        public string timeZoneDescription
        {
            get
            {
                return this.timeZoneDescriptionField;
            }
            set
            {
                this.timeZoneDescriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoHotelFees
    {

        private byte sizeField;

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoHotelFeesHotelFee[] hotelFeeField;

        /// <remarks/>
        public byte size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HotelFee")]
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoHotelFeesHotelFee[] HotelFee
        {
            get
            {
                return this.hotelFeeField;
            }
            set
            {
                this.hotelFeeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoHotelFeesHotelFee
    {

        private string descriptionField;

        private decimal amountField;

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoHotelFeesHotelFeeHotelFeeBreakdown hotelFeeBreakdownField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public decimal amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoHotelFeesHotelFeeHotelFeeBreakdown HotelFeeBreakdown
        {
            get
            {
                return this.hotelFeeBreakdownField;
            }
            set
            {
                this.hotelFeeBreakdownField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsRateInfosRateInfoHotelFeesHotelFeeHotelFeeBreakdown
    {

        private string unitField;

        private string frequencyField;

        /// <remarks/>
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        public string frequency
        {
            get
            {
                return this.frequencyField;
            }
            set
            {
                this.frequencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsValueAdds
    {

        private byte sizeField;

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsValueAddsValueAdd[] valueAddField;

        /// <remarks/>
        public byte size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ValueAdd")]
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsValueAddsValueAdd[] ValueAdd
        {
            get
            {
                return this.valueAddField;
            }
            set
            {
                this.valueAddField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsValueAddsValueAdd
    {

        private uint idField;

        private string descriptionField;

        /// <remarks/>
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsBedTypes
    {

        private byte sizeField;

        private HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsBedTypesBedType[] bedTypeField;

        /// <remarks/>
        public byte size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BedType")]
        public HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsBedTypesBedType[] BedType
        {
            get
            {
                return this.bedTypeField;
            }
            set
            {
                this.bedTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HotelListResponseHotelListHotelSummaryRoomRateDetailsListRoomRateDetailsBedTypesBedType
    {

        private byte idField;

        private string descriptionField;

        /// <remarks/>
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }




}
