// Copyright 2011, Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Author: api.anash@gmail.com (Anash P. Oommen)

#pragma warning disable 1591

namespace Google.Api.Ads.AdWords.v201109 {
  using Google.Api.Ads.AdWords.Headers;
  using Google.Api.Ads.AdWords.Lib;

  using System.Web.Services.Protocols;
  using System;
  using System.ComponentModel;
  using System.Diagnostics;
  using System.Web.Services;
  using System.Xml.Serialization;

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "CampaignCriterionServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class CampaignCriterionService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public CampaignCriterionService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201109/CampaignCriterionService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignCriterionPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] {serviceSelector});
      return ((CampaignCriterionPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignCriterionReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
CampaignCriterionOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((CampaignCriterionReturnValue) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ApiException : ApplicationException {
    private ApiError[] errorsField;

    [System.Xml.Serialization.XmlElementAttribute("errors")]
    public ApiError[] errors {
      get { return this.errorsField; }
      set { this.errorsField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(StringLengthError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SizeLimitError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SelectorError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequiredError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RegionCodeError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReadOnlyError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RateExceededError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RangeError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuotaCheckError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PagingError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperatorError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationAccessDenied))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NullError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NotWhitelistedError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NotEmptyError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NewEntityCreationError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(InternalApiError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityNotFound))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityCountLimitExceeded))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignCriterionLimitExceeded))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistinctError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DatabaseError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ClientTermsError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignCriterionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AuthorizationError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AuthenticationError))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TargetError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsQueryError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SettingError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RejectedError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuotaError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DateError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BudgetError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BiddingTransitionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BiddingError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionTrackingError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateAccountError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CustomerSyncError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExperimentServiceError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeoLocationError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdExtensionOverrideError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApiUsageError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocationCriterionServiceError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(VideoError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MediaError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AudioError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolicyViolationError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionPolicyError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(JobError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionLimitExceeded))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdCountLimitExceeded))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityAccessDenied))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignAdExtensionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BulkMutateJobError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupServiceError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdExtensionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReportDefinitionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CollectionSizeError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServicedAccountError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TrafficEstimatorError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TargetingIdeaError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MatchesRegexError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurrencyCodeError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserListError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdParamPolicyError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdParamError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AlertError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(OpportunityError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BulkOpportunityServiceError))]
  public abstract partial class ApiError {
    private string fieldPathField;

    private string triggerField;

    private string errorStringField;

    private string apiErrorTypeField;

    public string fieldPath {
      get { return this.fieldPathField; }
      set { this.fieldPathField = value; }
    }

    public string trigger {
      get { return this.triggerField; }
      set { this.triggerField = value; }
    }

    public string errorString {
      get { return this.errorStringField; }
      set { this.errorStringField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ApiError.Type")]
    public string ApiErrorType {
      get { return this.apiErrorTypeField; }
      set { this.apiErrorTypeField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignCriterionReturnValue))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignTargetReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionTrackerReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExperimentReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdExtensionOverrideReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignAdExtensionReturnValue))]
  public abstract partial class ListReturnValue {
    private string listReturnValueTypeField;

    [System.Xml.Serialization.XmlElementAttribute("ListReturnValue.Type")]
    public string ListReturnValueType {
      get { return this.listReturnValueTypeField; }
      set { this.listReturnValueTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignCriterionReturnValue : ListReturnValue {
    private CampaignCriterion[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public CampaignCriterion[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NegativeCampaignCriterion))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignCriterion {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private Criterion criterionField;

    private string campaignCriterionTypeField;

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    public Criterion criterion {
      get { return this.criterionField; }
      set { this.criterionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("CampaignCriterion.Type")]
    public string CampaignCriterionType {
      get { return this.campaignCriterionTypeField; }
      set { this.campaignCriterionTypeField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Vertical))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionUserList))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionUserInterest))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Proximity))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Product))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Polygon))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Platform))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Placement))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperatingSystemVersion))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Location))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Language))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Keyword))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Gender))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContentLabel))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Carrier))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AgeRange))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Criterion {
    private long idField;

    private bool idFieldSpecified;

    private CriterionType typeField;

    private bool typeFieldSpecified;

    private string criterionTypeField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public CriterionType type {
      get { return this.typeField; }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get { return this.typeFieldSpecified; }
      set { this.typeFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("Criterion.Type")]
    public string CriterionType {
      get { return this.criterionTypeField; }
      set { this.criterionTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Criterion.Type", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum CriterionType {
    CONTENT_LABEL,
    KEYWORD,
    PLACEMENT,
    VERTICAL,
    USER_LIST,
    USER_INTEREST,
    PRODUCT,
    LANGUAGE,
    LOCATION,
    AGE_RANGE,
    CARRIER,
    OPERATING_SYSTEM_VERSION,
    GENDER,
    POLYGON,
    PROXIMITY,
    PLATFORM,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Vertical : Criterion {
    private string[] pathField;

    [System.Xml.Serialization.XmlElementAttribute("path")]
    public string[] path {
      get { return this.pathField; }
      set { this.pathField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CriterionUserList : Criterion {
    private long userListIdField;

    private bool userListIdFieldSpecified;

    private string userListNameField;

    private CriterionUserListMembershipStatus userListMembershipStatusField;

    private bool userListMembershipStatusFieldSpecified;

    public long userListId {
      get { return this.userListIdField; }
      set {
        this.userListIdField = value;
        this.userListIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool userListIdSpecified {
      get { return this.userListIdFieldSpecified; }
      set { this.userListIdFieldSpecified = value; }
    }

    public string userListName {
      get { return this.userListNameField; }
      set { this.userListNameField = value; }
    }

    public CriterionUserListMembershipStatus userListMembershipStatus {
      get { return this.userListMembershipStatusField; }
      set {
        this.userListMembershipStatusField = value;
        this.userListMembershipStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool userListMembershipStatusSpecified {
      get { return this.userListMembershipStatusFieldSpecified; }
      set { this.userListMembershipStatusFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CriterionUserList.MembershipStatus", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum CriterionUserListMembershipStatus {
    OPEN,
    CLOSED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CriterionUserInterest : Criterion {
    private long userInterestIdField;

    private bool userInterestIdFieldSpecified;

    private string userInterestNameField;

    public long userInterestId {
      get { return this.userInterestIdField; }
      set {
        this.userInterestIdField = value;
        this.userInterestIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool userInterestIdSpecified {
      get { return this.userInterestIdFieldSpecified; }
      set { this.userInterestIdFieldSpecified = value; }
    }

    public string userInterestName {
      get { return this.userInterestNameField; }
      set { this.userInterestNameField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Proximity : Criterion {
    private GeoPoint geoPointField;

    private ProximityDistanceUnits radiusDistanceUnitsField;

    private bool radiusDistanceUnitsFieldSpecified;

    private double radiusInUnitsField;

    private bool radiusInUnitsFieldSpecified;

    private Address addressField;

    public GeoPoint geoPoint {
      get { return this.geoPointField; }
      set { this.geoPointField = value; }
    }

    public ProximityDistanceUnits radiusDistanceUnits {
      get { return this.radiusDistanceUnitsField; }
      set {
        this.radiusDistanceUnitsField = value;
        this.radiusDistanceUnitsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool radiusDistanceUnitsSpecified {
      get { return this.radiusDistanceUnitsFieldSpecified; }
      set { this.radiusDistanceUnitsFieldSpecified = value; }
    }

    public double radiusInUnits {
      get { return this.radiusInUnitsField; }
      set {
        this.radiusInUnitsField = value;
        this.radiusInUnitsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool radiusInUnitsSpecified {
      get { return this.radiusInUnitsFieldSpecified; }
      set { this.radiusInUnitsFieldSpecified = value; }
    }

    public Address address {
      get { return this.addressField; }
      set { this.addressField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class GeoPoint {
    private int latitudeInMicroDegreesField;

    private bool latitudeInMicroDegreesFieldSpecified;

    private int longitudeInMicroDegreesField;

    private bool longitudeInMicroDegreesFieldSpecified;

    public int latitudeInMicroDegrees {
      get { return this.latitudeInMicroDegreesField; }
      set {
        this.latitudeInMicroDegreesField = value;
        this.latitudeInMicroDegreesSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool latitudeInMicroDegreesSpecified {
      get { return this.latitudeInMicroDegreesFieldSpecified; }
      set { this.latitudeInMicroDegreesFieldSpecified = value; }
    }

    public int longitudeInMicroDegrees {
      get { return this.longitudeInMicroDegreesField; }
      set {
        this.longitudeInMicroDegreesField = value;
        this.longitudeInMicroDegreesSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool longitudeInMicroDegreesSpecified {
      get { return this.longitudeInMicroDegreesFieldSpecified; }
      set { this.longitudeInMicroDegreesFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Proximity.DistanceUnits", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ProximityDistanceUnits {
    KILOMETERS,
    MILES
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Address {
    private string streetAddressField;

    private string streetAddress2Field;

    private string cityNameField;

    private string provinceCodeField;

    private string provinceNameField;

    private string postalCodeField;

    private string countryCodeField;

    public string streetAddress {
      get { return this.streetAddressField; }
      set { this.streetAddressField = value; }
    }

    public string streetAddress2 {
      get { return this.streetAddress2Field; }
      set { this.streetAddress2Field = value; }
    }

    public string cityName {
      get { return this.cityNameField; }
      set { this.cityNameField = value; }
    }

    public string provinceCode {
      get { return this.provinceCodeField; }
      set { this.provinceCodeField = value; }
    }

    public string provinceName {
      get { return this.provinceNameField; }
      set { this.provinceNameField = value; }
    }

    public string postalCode {
      get { return this.postalCodeField; }
      set { this.postalCodeField = value; }
    }

    public string countryCode {
      get { return this.countryCodeField; }
      set { this.countryCodeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Product : Criterion {
    private ProductCondition[] conditionsField;

    private string textField;

    [System.Xml.Serialization.XmlElementAttribute("conditions")]
    public ProductCondition[] conditions {
      get { return this.conditionsField; }
      set { this.conditionsField = value; }
    }

    public string text {
      get { return this.textField; }
      set { this.textField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ProductCondition {
    private string argumentField;

    private ProductConditionOperand operandField;

    public string argument {
      get { return this.argumentField; }
      set { this.argumentField = value; }
    }

    public ProductConditionOperand operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ProductConditionOperand {
    private string operandField;

    public string operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Polygon : Criterion {
    private GeoPoint[] verticesField;

    [System.Xml.Serialization.XmlElementAttribute("vertices")]
    public GeoPoint[] vertices {
      get { return this.verticesField; }
      set { this.verticesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Platform : Criterion {
    private string platformNameField;

    public string platformName {
      get { return this.platformNameField; }
      set { this.platformNameField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Placement : Criterion {
    private string urlField;

    public string url {
      get { return this.urlField; }
      set { this.urlField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class OperatingSystemVersion : Criterion {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Location : Criterion {
    private string locationNameField;

    private string displayTypeField;

    private bool isObsoleteField;

    private bool isObsoleteFieldSpecified;

    private Location[] parentLocationsField;

    public string locationName {
      get { return this.locationNameField; }
      set { this.locationNameField = value; }
    }

    public string displayType {
      get { return this.displayTypeField; }
      set { this.displayTypeField = value; }
    }

    public bool isObsolete {
      get { return this.isObsoleteField; }
      set {
        this.isObsoleteField = value;
        this.isObsoleteSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isObsoleteSpecified {
      get { return this.isObsoleteFieldSpecified; }
      set { this.isObsoleteFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("parentLocations")]
    public Location[] parentLocations {
      get { return this.parentLocationsField; }
      set { this.parentLocationsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Language : Criterion {
    private string codeField;

    private string nameField;

    public string code {
      get { return this.codeField; }
      set { this.codeField = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Keyword : Criterion {
    private string textField;

    private KeywordMatchType matchTypeField;

    private bool matchTypeFieldSpecified;

    public string text {
      get { return this.textField; }
      set { this.textField = value; }
    }

    public KeywordMatchType matchType {
      get { return this.matchTypeField; }
      set {
        this.matchTypeField = value;
        this.matchTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool matchTypeSpecified {
      get { return this.matchTypeFieldSpecified; }
      set { this.matchTypeFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum KeywordMatchType {
    EXACT,
    PHRASE,
    BROAD
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Gender : Criterion {
    private GenderGenderType genderTypeField;

    private bool genderTypeFieldSpecified;

    public GenderGenderType genderType {
      get { return this.genderTypeField; }
      set {
        this.genderTypeField = value;
        this.genderTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool genderTypeSpecified {
      get { return this.genderTypeFieldSpecified; }
      set { this.genderTypeFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Gender.GenderType", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum GenderGenderType {
    GENDER_MALE,
    GENDER_FEMALE,
    GENDER_UNDETERMINED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ContentLabel : Criterion {
    private ContentLabelType contentLabelTypeField;

    private bool contentLabelTypeFieldSpecified;

    public ContentLabelType contentLabelType {
      get { return this.contentLabelTypeField; }
      set {
        this.contentLabelTypeField = value;
        this.contentLabelTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool contentLabelTypeSpecified {
      get { return this.contentLabelTypeFieldSpecified; }
      set { this.contentLabelTypeFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ContentLabelType {
    ADULTISH,
    AFE,
    BELOW_THE_FOLD,
    CONFLICT,
    DP,
    EMBEDDED_VIDEO,
    GAMES,
    JACKASS,
    PROFANITY,
    UGC_FORUMS,
    UGC_IMAGES,
    UGC_SOCIAL,
    UGC_VIDEOS,
    SIRENS,
    TRAGEDY,
    VIDEO
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Carrier : Criterion {
    private string nameField;

    private string countryCodeField;

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public string countryCode {
      get { return this.countryCodeField; }
      set { this.countryCodeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AgeRange : Criterion {
    private AgeRangeAgeRangeType ageRangeTypeField;

    private bool ageRangeTypeFieldSpecified;

    public AgeRangeAgeRangeType ageRangeType {
      get { return this.ageRangeTypeField; }
      set {
        this.ageRangeTypeField = value;
        this.ageRangeTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ageRangeTypeSpecified {
      get { return this.ageRangeTypeFieldSpecified; }
      set { this.ageRangeTypeFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AgeRange.AgeRangeType", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AgeRangeAgeRangeType {
    AGE_RANGE_18_24,
    AGE_RANGE_25_34,
    AGE_RANGE_35_44,
    AGE_RANGE_45_54,
    AGE_RANGE_55_64,
    AGE_RANGE_65_UP,
    AGE_RANGE_UNDETERMINED,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class NegativeCampaignCriterion : CampaignCriterion {
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignCriterionOperation))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignTargetOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionTrackerOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateAccountOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExperimentOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdExtensionOverrideOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignAdExtensionOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserListOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdParamOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(JobOperation))]
  public abstract partial class Operation {
    private Operator operatorField;

    private bool operatorFieldSpecified;

    private string operationTypeField;

    public Operator @operator {
      get { return this.operatorField; }
      set {
        this.operatorField = value;
        this.operatorSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool operatorSpecified {
      get { return this.operatorFieldSpecified; }
      set { this.operatorFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("Operation.Type")]
    public string OperationType {
      get { return this.operationTypeField; }
      set { this.operationTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum Operator {
    ADD,
    REMOVE,
    SET
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignCriterionOperation : Operation {
    private CampaignCriterion operandField;

    public CampaignCriterion operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignCriterionPage))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignTargetPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NoStatsPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionTrackerPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionBidLandscapePage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupBidLandscapePage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExperimentPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdExtensionOverridePage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserListPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AlertPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignAdExtensionPage))]
  public abstract partial class Page {
    private int totalNumEntriesField;

    private bool totalNumEntriesFieldSpecified;

    private string pageTypeField;

    public int totalNumEntries {
      get { return this.totalNumEntriesField; }
      set {
        this.totalNumEntriesField = value;
        this.totalNumEntriesSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool totalNumEntriesSpecified {
      get { return this.totalNumEntriesFieldSpecified; }
      set { this.totalNumEntriesFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("Page.Type")]
    public string PageType {
      get { return this.pageTypeField; }
      set { this.pageTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignCriterionPage : Page {
    private CampaignCriterion[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public CampaignCriterion[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Paging {
    private int startIndexField;

    private bool startIndexFieldSpecified;

    private int numberResultsField;

    private bool numberResultsFieldSpecified;

    public int startIndex {
      get { return this.startIndexField; }
      set {
        this.startIndexField = value;
        this.startIndexSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool startIndexSpecified {
      get { return this.startIndexFieldSpecified; }
      set { this.startIndexFieldSpecified = value; }
    }

    public int numberResults {
      get { return this.numberResultsField; }
      set {
        this.numberResultsField = value;
        this.numberResultsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numberResultsSpecified {
      get { return this.numberResultsFieldSpecified; }
      set { this.numberResultsFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class OrderBy {
    private string fieldField;

    private SortOrder sortOrderField;

    private bool sortOrderFieldSpecified;

    public string field {
      get { return this.fieldField; }
      set { this.fieldField = value; }
    }

    public SortOrder sortOrder {
      get { return this.sortOrderField; }
      set {
        this.sortOrderField = value;
        this.sortOrderSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool sortOrderSpecified {
      get { return this.sortOrderFieldSpecified; }
      set { this.sortOrderFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum SortOrder {
    ASCENDING,
    DESCENDING
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class DateRange {
    private string minField;

    private string maxField;

    public string min {
      get { return this.minField; }
      set { this.minField = value; }
    }

    public string max {
      get { return this.maxField; }
      set { this.maxField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Predicate {
    private string fieldField;

    private PredicateOperator operatorField;

    private bool operatorFieldSpecified;

    private string[] valuesField;

    public string field {
      get { return this.fieldField; }
      set { this.fieldField = value; }
    }

    public PredicateOperator @operator {
      get { return this.operatorField; }
      set {
        this.operatorField = value;
        this.operatorSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool operatorSpecified {
      get { return this.operatorFieldSpecified; }
      set { this.operatorFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("values")]
    public string[] values {
      get { return this.valuesField; }
      set { this.valuesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Predicate.Operator", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum PredicateOperator {
    EQUALS,
    NOT_EQUALS,
    IN,
    NOT_IN,
    GREATER_THAN,
    GREATER_THAN_EQUALS,
    LESS_THAN,
    LESS_THAN_EQUALS,
    STARTS_WITH,
    STARTS_WITH_IGNORE_CASE,
    CONTAINS,
    CONTAINS_IGNORE_CASE,
    DOES_NOT_CONTAIN,
    DOES_NOT_CONTAIN_IGNORE_CASE,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Selector {
    private string[] fieldsField;

    private Predicate[] predicatesField;

    private DateRange dateRangeField;

    private OrderBy[] orderingField;

    private Paging pagingField;

    [System.Xml.Serialization.XmlElementAttribute("fields")]
    public string[] fields {
      get { return this.fieldsField; }
      set { this.fieldsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("predicates")]
    public Predicate[] predicates {
      get { return this.predicatesField; }
      set { this.predicatesField = value; }
    }

    public DateRange dateRange {
      get { return this.dateRangeField; }
      set { this.dateRangeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ordering")]
    public OrderBy[] ordering {
      get { return this.orderingField; }
      set { this.orderingField = value; }
    }

    public Paging paging {
      get { return this.pagingField; }
      set { this.pagingField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApiException))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ApplicationException {
    private string messageField;

    private string applicationExceptionTypeField;

    public string message {
      get { return this.messageField; }
      set { this.messageField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ApplicationException.Type")]
    public string ApplicationExceptionType {
      get { return this.applicationExceptionTypeField; }
      set { this.applicationExceptionTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class StringLengthError : ApiError {
    private StringLengthErrorReason reasonField;

    private bool reasonFieldSpecified;

    public StringLengthErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "StringLengthError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum StringLengthErrorReason {
    TOO_SHORT,
    TOO_LONG
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class SizeLimitError : ApiError {
    private SizeLimitErrorReason reasonField;

    private bool reasonFieldSpecified;

    public SizeLimitErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SizeLimitError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum SizeLimitErrorReason {
    REQUEST_SIZE_LIMIT_EXCEEDED,
    RESPONSE_SIZE_LIMIT_EXCEEDED,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class SelectorError : ApiError {
    private SelectorErrorReason reasonField;

    private bool reasonFieldSpecified;

    public SelectorErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SelectorError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum SelectorErrorReason {
    INVALID_FIELD_NAME,
    MISSING_FIELDS,
    MISSING_PREDICATES,
    OPERATOR_DOES_NOT_SUPPORT_MULTIPLE_VALUES,
    INVALID_PREDICATE_ENUM_VALUE,
    MISSING_PREDICATE_OPERATOR,
    MISSING_PREDICATE_VALUES,
    INVALID_PREDICATE_FIELD_NAME,
    INVALID_PREDICATE_OPERATOR,
    INVALID_FIELD_SELECTION,
    INVALID_PREDICATE_VALUE,
    INVALID_SORT_FIELD_NAME,
    SELECTOR_ERROR,
    UNKNOWN_ERROR
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class RequiredError : ApiError {
    private RequiredErrorReason reasonField;

    private bool reasonFieldSpecified;

    public RequiredErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RequiredError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum RequiredErrorReason {
    REQUIRED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class RequestError : ApiError {
    private RequestErrorReason reasonField;

    private bool reasonFieldSpecified;

    public RequestErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RequestError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum RequestErrorReason {
    UNKNOWN,
    INVALID_INPUT
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class RegionCodeError : ApiError {
    private RegionCodeErrorReason reasonField;

    private bool reasonFieldSpecified;

    public RegionCodeErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RegionCodeError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum RegionCodeErrorReason {
    INVALID_REGION_CODE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ReadOnlyError : ApiError {
    private ReadOnlyErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ReadOnlyErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ReadOnlyError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ReadOnlyErrorReason {
    READ_ONLY
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class RateExceededError : ApiError {
    private RateExceededErrorReason reasonField;

    private bool reasonFieldSpecified;

    private string rateNameField;

    private string rateScopeField;

    private int retryAfterSecondsField;

    private bool retryAfterSecondsFieldSpecified;

    public RateExceededErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }

    public string rateName {
      get { return this.rateNameField; }
      set { this.rateNameField = value; }
    }

    public string rateScope {
      get { return this.rateScopeField; }
      set { this.rateScopeField = value; }
    }

    public int retryAfterSeconds {
      get { return this.retryAfterSecondsField; }
      set {
        this.retryAfterSecondsField = value;
        this.retryAfterSecondsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool retryAfterSecondsSpecified {
      get { return this.retryAfterSecondsFieldSpecified; }
      set { this.retryAfterSecondsFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RateExceededError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum RateExceededErrorReason {
    RATE_EXCEEDED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class RangeError : ApiError {
    private RangeErrorReason reasonField;

    private bool reasonFieldSpecified;

    public RangeErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RangeError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum RangeErrorReason {
    TOO_LOW,
    TOO_HIGH
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class QuotaCheckError : ApiError {
    private QuotaCheckErrorReason reasonField;

    private bool reasonFieldSpecified;

    public QuotaCheckErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "QuotaCheckError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum QuotaCheckErrorReason {
    INVALID_TOKEN_HEADER,
    ACCOUNT_DELINQUENT,
    ACCOUNT_INACCESSIBLE,
    ACCOUNT_INACTIVE,
    INCOMPLETE_SIGNUP,
    INCOMPLETE_SIGNUP_LATEST_ADWORDS_API_TNC_NOT_AGREED,
    INCOMPLETE_SIGNUP_NO_BILLING_INFO,
    INCOMPLETE_SIGNUP_USER_INFO_MISSING,
    INCOMPLETE_SIGNUP_USER_INFO_PENDING,
    INCOMPLETE_SIGNUP_USER_INFO_REJECTED,
    MONTHLY_BUDGET_REACHED,
    QUOTA_EXCEEDED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class PagingError : ApiError {
    private PagingErrorReason reasonField;

    private bool reasonFieldSpecified;

    public PagingErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PagingError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum PagingErrorReason {
    START_INDEX_CANNOT_BE_NEGATIVE,
    NUMBER_OF_RESULTS_CANNOT_BE_NEGATIVE,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class OperatorError : ApiError {
    private OperatorErrorReason reasonField;

    private bool reasonFieldSpecified;

    public OperatorErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "OperatorError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum OperatorErrorReason {
    OPERATOR_NOT_SUPPORTED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class OperationAccessDenied : ApiError {
    private OperationAccessDeniedReason reasonField;

    private bool reasonFieldSpecified;

    public OperationAccessDeniedReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "OperationAccessDenied.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum OperationAccessDeniedReason {
    ACTION_NOT_PERMITTED,
    ADD_OPERATION_NOT_PERMITTED,
    REMOVE_OPERATION_NOT_PERMITTED,
    SET_OPERATION_NOT_PERMITTED,
    MUTATE_ACTION_NOT_PERMITTED_FOR_CLIENT,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class NullError : ApiError {
    private NullErrorReason reasonField;

    private bool reasonFieldSpecified;

    public NullErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "NullError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum NullErrorReason {
    NULL_CONTENT
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class NotWhitelistedError : ApiError {
    private NotWhitelistedErrorReason reasonField;

    private bool reasonFieldSpecified;

    public NotWhitelistedErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "NotWhitelistedError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum NotWhitelistedErrorReason {
    CUSTOMER_NOT_WHITELISTED_FOR_API
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class NotEmptyError : ApiError {
    private NotEmptyErrorReason reasonField;

    private bool reasonFieldSpecified;

    public NotEmptyErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "NotEmptyError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum NotEmptyErrorReason {
    EMPTY_LIST
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class NewEntityCreationError : ApiError {
    private NewEntityCreationErrorReason reasonField;

    private bool reasonFieldSpecified;

    public NewEntityCreationErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "NewEntityCreationError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum NewEntityCreationErrorReason {
    CANNOT_SET_ID_FOR_ADD
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class InternalApiError : ApiError {
    private InternalApiErrorReason reasonField;

    private bool reasonFieldSpecified;

    public InternalApiErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "InternalApiError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum InternalApiErrorReason {
    UNEXPECTED_INTERNAL_API_ERROR,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class EntityNotFound : ApiError {
    private EntityNotFoundReason reasonField;

    private bool reasonFieldSpecified;

    public EntityNotFoundReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EntityNotFound.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum EntityNotFoundReason {
    INVALID_ID
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignCriterionLimitExceeded))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionLimitExceeded))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdCountLimitExceeded))]
  public partial class EntityCountLimitExceeded : ApiError {
    private EntityCountLimitExceededReason reasonField;

    private bool reasonFieldSpecified;

    private string enclosingIdField;

    private int limitField;

    private bool limitFieldSpecified;

    public EntityCountLimitExceededReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }

    public string enclosingId {
      get { return this.enclosingIdField; }
      set { this.enclosingIdField = value; }
    }

    public int limit {
      get { return this.limitField; }
      set {
        this.limitField = value;
        this.limitSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool limitSpecified {
      get { return this.limitFieldSpecified; }
      set { this.limitFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EntityCountLimitExceeded.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum EntityCountLimitExceededReason {
    ACCOUNT_LIMIT,
    CAMPAIGN_LIMIT,
    ADGROUP_LIMIT,
    ADGROUP_TEXT_AD_LIMIT,
    ADGROUP_DISPLAY_AD_LIMIT,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignCriterionLimitExceeded : EntityCountLimitExceeded {
    private CampaignCriterionLimitExceededCriteriaLimitType limitTypeField;

    private bool limitTypeFieldSpecified;

    public CampaignCriterionLimitExceededCriteriaLimitType limitType {
      get { return this.limitTypeField; }
      set {
        this.limitTypeField = value;
        this.limitTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool limitTypeSpecified {
      get { return this.limitTypeFieldSpecified; }
      set { this.limitTypeFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignCriterionLimitExceeded.CriteriaLimitType", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum CampaignCriterionLimitExceededCriteriaLimitType {
    CAMPAIGN_CRITERIA,
    CAMPAIGN_NEGATIVE_KEYWORD,
    CAMPAIGN_NEGATIVE_WEBSITE,
    CAMPAIGN_LOCATION_CRITERIA,
    CAMPAIGN_PROXIMITY_CRITERIA
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class DistinctError : ApiError {
    private DistinctErrorReason reasonField;

    private bool reasonFieldSpecified;

    public DistinctErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DistinctError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum DistinctErrorReason {
    DUPLICATE_ELEMENT,
    DUPLICATE_TYPE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class DatabaseError : ApiError {
    private DatabaseErrorReason reasonField;

    private bool reasonFieldSpecified;

    public DatabaseErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DatabaseError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum DatabaseErrorReason {
    CONCURRENT_MODIFICATION,
    PERMISSION_DENIED,
    CAMPAIGN_PRODUCT_NOT_SUPPORTED,
    DUPLICATE_KEY,
    DATABASE_ERROR,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CriterionError : ApiError {
    private CriterionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CriterionErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CriterionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum CriterionErrorReason {
    CONCRETE_TYPE_REQUIRED,
    INVALID_EXCLUDED_CATEGORY,
    INVALID_KEYWORD_TEXT,
    KEYWORD_TEXT_TOO_LONG,
    KEYWORD_HAS_TOO_MANY_WORDS,
    KEYWORD_HAS_INVALID_CHARS,
    INVALID_PLACEMENT_URL,
    INVALID_USER_LIST,
    INVALID_USER_INTEREST,
    INVALID_FORMAT_FOR_PLACEMENT_URL,
    PLACEMENT_URL_IS_TOO_LONG,
    PLACEMENT_URL_HAS_ILLEGAL_CHAR,
    PLACEMENT_URL_HAS_MULTIPLE_SITES_IN_LINE,
    PLACEMENT_IS_NOT_AVAILABLE_FOR_TARGETING_OR_EXCLUSION,
    INVALID_VERTICAL_PATH,
    CANNOT_EXCLUDE_CRITERIA_TYPE,
    CANNOT_ADD_CRITERIA_TYPE,
    INVALID_PRODUCT_FILTER,
    PRODUCT_FILTER_TOO_LONG,
    INVALID_CRITERION_ID,
    CANNOT_TARGET_CRITERION,
    CRITERION_ID_AND_TYPE_MISMATCH,
    INVALID_PROXIMITY_RADIUS,
    INVALID_PROXIMITY_RADIUS_UNITS,
    INVALID_STREETADDRESS_LENGTH,
    INVALID_CITYNAME_LENGTH,
    INVALID_REGIONCODE_LENGTH,
    INVALID_REGIONNAME_LENGTH,
    INVALID_POSTALCODE_LENGTH,
    INVALID_COUNTRY_CODE,
    INVALID_LATITUDE,
    INVALID_LONGITUDE,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ClientTermsError : ApiError {
    private ClientTermsErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ClientTermsErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ClientTermsError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ClientTermsErrorReason {
    INCOMPLETE_SIGNUP_CURRENT_ADWORDS_TNC_NOT_AGREED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignCriterionError : ApiError {
    private CampaignCriterionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CampaignCriterionErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignCriterionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum CampaignCriterionErrorReason {
    CRITERIA_QUOTA_EXCEEDED,
    CONCRETE_TYPE_REQUIRED,
    ID_FILTERS_HAVE_DIFF_FIELDS_SET,
    INVALID_EXCLUDED_CATEGORY,
    INVALID_KEYWORD_TEXT,
    INVALID_PLACEMENT_URL,
    INVALID_VERTICAL_PATH,
    CANNOT_EXCLUDE_ALL_PLATFORMS,
    CANNOT_EXCLUDE_CRITERIA_TYPE,
    CANNOT_EXCLUDE_PLATFORM_CRITERION,
    TOO_MANY_OPERTAIONS,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AuthorizationError : ApiError {
    private AuthorizationErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AuthorizationErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AuthorizationError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AuthorizationErrorReason {
    UNABLE_TO_AUTHORIZE,
    NO_ADWORDS_ACCOUNT_FOR_CUSTOMER,
    USER_PERMISSION_DENIED,
    EFFECTIVE_USER_PERMISSION_DENIED,
    USER_HAS_READONLY_PERMISSION,
    NO_CUSTOMER_FOUND
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AuthenticationError : ApiError {
    private AuthenticationErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AuthenticationErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AuthenticationError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AuthenticationErrorReason {
    AUTHENTICATION_FAILED,
    CLIENT_CUSTOMER_ID_IS_REQUIRED,
    CLIENT_EMAIL_REQUIRED,
    CLIENT_CUSTOMER_ID_INVALID,
    CLIENT_EMAIL_INVALID,
    CLIENT_EMAIL_FAILED_TO_AUTHENTICATE,
    CUSTOMER_NOT_FOUND,
    GOOGLE_ACCOUNT_DELETED,
    GOOGLE_ACCOUNT_COOKIE_INVALID,
    FAILED_TO_AUTHENTICATE_GOOGLE_ACCOUNT,
    GOOGLE_ACCOUNT_USER_AND_ADS_USER_MISMATCH,
    LOGIN_COOKIE_REQUIRED,
    NOT_ADS_USER,
    OAUTH_TOKEN_INVALID,
    OAUTH_TOKEN_EXPIRED,
    OAUTH_TOKEN_DISABLED,
    OAUTH_TOKEN_REVOKED,
    OAUTH_TOKEN_HEADER_INVALID,
    LOGIN_COOKIE_INVALID,
    FAILED_TO_RETRIEVE_LOGIN_COOKIE,
    USER_ID_INVALID
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "CampaignServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Stats))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class CampaignService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public CampaignService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201109/CampaignService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] {serviceSelector});
      return ((CampaignPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
CampaignOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((CampaignReturnValue) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignReturnValue : ListReturnValue {
    private Campaign[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public Campaign[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Campaign {
    private long idField;

    private bool idFieldSpecified;

    private string nameField;

    private CampaignStatus statusField;

    private bool statusFieldSpecified;

    private ServingStatus servingStatusField;

    private bool servingStatusFieldSpecified;

    private string startDateField;

    private string endDateField;

    private Budget budgetField;

    private BiddingStrategy biddingStrategyField;

    private ConversionOptimizerEligibility conversionOptimizerEligibilityField;

    private CampaignStats campaignStatsField;

    private AdServingOptimizationStatus adServingOptimizationStatusField;

    private bool adServingOptimizationStatusFieldSpecified;

    private FrequencyCap frequencyCapField;

    private Setting[] settingsField;

    private NetworkSetting networkSettingField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public CampaignStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    public ServingStatus servingStatus {
      get { return this.servingStatusField; }
      set {
        this.servingStatusField = value;
        this.servingStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool servingStatusSpecified {
      get { return this.servingStatusFieldSpecified; }
      set { this.servingStatusFieldSpecified = value; }
    }

    public string startDate {
      get { return this.startDateField; }
      set { this.startDateField = value; }
    }

    public string endDate {
      get { return this.endDateField; }
      set { this.endDateField = value; }
    }

    public Budget budget {
      get { return this.budgetField; }
      set { this.budgetField = value; }
    }

    public BiddingStrategy biddingStrategy {
      get { return this.biddingStrategyField; }
      set { this.biddingStrategyField = value; }
    }

    public ConversionOptimizerEligibility conversionOptimizerEligibility {
      get { return this.conversionOptimizerEligibilityField; }
      set { this.conversionOptimizerEligibilityField = value; }
    }

    public CampaignStats campaignStats {
      get { return this.campaignStatsField; }
      set { this.campaignStatsField = value; }
    }

    public AdServingOptimizationStatus adServingOptimizationStatus {
      get { return this.adServingOptimizationStatusField; }
      set {
        this.adServingOptimizationStatusField = value;
        this.adServingOptimizationStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adServingOptimizationStatusSpecified {
      get { return this.adServingOptimizationStatusFieldSpecified; }
      set { this.adServingOptimizationStatusFieldSpecified = value; }
    }

    public FrequencyCap frequencyCap {
      get { return this.frequencyCapField; }
      set { this.frequencyCapField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("settings")]
    public Setting[] settings {
      get { return this.settingsField; }
      set { this.settingsField = value; }
    }

    public NetworkSetting networkSetting {
      get { return this.networkSettingField; }
      set { this.networkSettingField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum CampaignStatus {
    ACTIVE,
    DELETED,
    PAUSED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ServingStatus {
    SERVING,
    NONE,
    ENDED,
    PENDING,
    SUSPENDED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Budget {
    private BudgetBudgetPeriod periodField;

    private bool periodFieldSpecified;

    private Money amountField;

    private BudgetBudgetDeliveryMethod deliveryMethodField;

    private bool deliveryMethodFieldSpecified;

    public BudgetBudgetPeriod period {
      get { return this.periodField; }
      set {
        this.periodField = value;
        this.periodSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool periodSpecified {
      get { return this.periodFieldSpecified; }
      set { this.periodFieldSpecified = value; }
    }

    public Money amount {
      get { return this.amountField; }
      set { this.amountField = value; }
    }

    public BudgetBudgetDeliveryMethod deliveryMethod {
      get { return this.deliveryMethodField; }
      set {
        this.deliveryMethodField = value;
        this.deliveryMethodSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool deliveryMethodSpecified {
      get { return this.deliveryMethodFieldSpecified; }
      set { this.deliveryMethodFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Budget.BudgetPeriod", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum BudgetBudgetPeriod {
    DAILY,
    MONTHLY
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Money : ComparableValue {
    private long microAmountField;

    private bool microAmountFieldSpecified;

    public long microAmount {
      get { return this.microAmountField; }
      set {
        this.microAmountField = value;
        this.microAmountSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool microAmountSpecified {
      get { return this.microAmountFieldSpecified; }
      set { this.microAmountFieldSpecified = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NumberValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LongValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Money))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public abstract partial class ComparableValue {
    private string comparableValueTypeField;

    [System.Xml.Serialization.XmlElementAttribute("ComparableValue.Type")]
    public string ComparableValueType {
      get { return this.comparableValueTypeField; }
      set { this.comparableValueTypeField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LongValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleValue))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public abstract partial class NumberValue : ComparableValue {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class LongValue : NumberValue {
    private long numberField;

    private bool numberFieldSpecified;

    public long number {
      get { return this.numberField; }
      set {
        this.numberField = value;
        this.numberSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numberSpecified {
      get { return this.numberFieldSpecified; }
      set { this.numberFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class DoubleValue : NumberValue {
    private double numberField;

    private bool numberFieldSpecified;

    public double number {
      get { return this.numberField; }
      set {
        this.numberField = value;
        this.numberSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numberSpecified {
      get { return this.numberFieldSpecified; }
      set { this.numberFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Budget.BudgetDeliveryMethod", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum BudgetBudgetDeliveryMethod {
    STANDARD,
    ACCELERATED
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BudgetOptimizer))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PercentCPA))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPM))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPC))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionOptimizer))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public abstract partial class BiddingStrategy {
    private string biddingStrategyTypeField;

    [System.Xml.Serialization.XmlElementAttribute("BiddingStrategy.Type")]
    public string BiddingStrategyType {
      get { return this.biddingStrategyTypeField; }
      set { this.biddingStrategyTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BudgetOptimizer : BiddingStrategy {
    private bool enhancedCpcEnabledField;

    private bool enhancedCpcEnabledFieldSpecified;

    private Money bidCeilingField;

    public bool enhancedCpcEnabled {
      get { return this.enhancedCpcEnabledField; }
      set {
        this.enhancedCpcEnabledField = value;
        this.enhancedCpcEnabledSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool enhancedCpcEnabledSpecified {
      get { return this.enhancedCpcEnabledFieldSpecified; }
      set { this.enhancedCpcEnabledFieldSpecified = value; }
    }

    public Money bidCeiling {
      get { return this.bidCeilingField; }
      set { this.bidCeilingField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class PercentCPA : BiddingStrategy {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ManualCPM : BiddingStrategy {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ManualCPC : BiddingStrategy {
    private bool enhancedCpcEnabledField;

    private bool enhancedCpcEnabledFieldSpecified;

    public bool enhancedCpcEnabled {
      get { return this.enhancedCpcEnabledField; }
      set {
        this.enhancedCpcEnabledField = value;
        this.enhancedCpcEnabledSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool enhancedCpcEnabledSpecified {
      get { return this.enhancedCpcEnabledFieldSpecified; }
      set { this.enhancedCpcEnabledFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ConversionOptimizer : BiddingStrategy {
    private PricingModel pricingModelField;

    private bool pricingModelFieldSpecified;

    private ConversionOptimizerBidType conversionOptimizerBidTypeField;

    private bool conversionOptimizerBidTypeFieldSpecified;

    private ConversionDeduplicationMode deduplicationModeField;

    private bool deduplicationModeFieldSpecified;

    public PricingModel pricingModel {
      get { return this.pricingModelField; }
      set {
        this.pricingModelField = value;
        this.pricingModelSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool pricingModelSpecified {
      get { return this.pricingModelFieldSpecified; }
      set { this.pricingModelFieldSpecified = value; }
    }

    public ConversionOptimizerBidType conversionOptimizerBidType {
      get { return this.conversionOptimizerBidTypeField; }
      set {
        this.conversionOptimizerBidTypeField = value;
        this.conversionOptimizerBidTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool conversionOptimizerBidTypeSpecified {
      get { return this.conversionOptimizerBidTypeFieldSpecified; }
      set { this.conversionOptimizerBidTypeFieldSpecified = value; }
    }

    public ConversionDeduplicationMode deduplicationMode {
      get { return this.deduplicationModeField; }
      set {
        this.deduplicationModeField = value;
        this.deduplicationModeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool deduplicationModeSpecified {
      get { return this.deduplicationModeFieldSpecified; }
      set { this.deduplicationModeFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum PricingModel {
    CLICKS,
    IMPRESSIONS,
    CONVERSIONS
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ConversionOptimizerBidType {
    TARGET_CPA,
    MAX_CPA
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ConversionDeduplicationMode {
    ONE_PER_CLICK,
    MANY_PER_CLICK
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ConversionOptimizerEligibility {
    private bool eligibleField;

    private bool eligibleFieldSpecified;

    private ConversionOptimizerEligibilityRejectionReason[] rejectionReasonsField;

    public bool eligible {
      get { return this.eligibleField; }
      set {
        this.eligibleField = value;
        this.eligibleSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool eligibleSpecified {
      get { return this.eligibleFieldSpecified; }
      set { this.eligibleFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("rejectionReasons")]
    public ConversionOptimizerEligibilityRejectionReason[] rejectionReasons {
      get { return this.rejectionReasonsField; }
      set { this.rejectionReasonsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ConversionOptimizerEligibility.RejectionReason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ConversionOptimizerEligibilityRejectionReason {
    CAMPAIGN_IS_NOT_ACTIVE,
    NOT_CPC_CAMPAIGN,
    CONVERSION_TRACKING_NOT_ENABLED,
    NOT_ENOUGH_CONVERSIONS,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignStats : Stats {
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignStats))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdExtensionOverrideStats))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignAdExtensionStats))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdStats))]
  public partial class Stats {
    private string startDateField;

    private string endDateField;

    private StatsNetwork networkField;

    private bool networkFieldSpecified;

    private long clicksField;

    private bool clicksFieldSpecified;

    private long impressionsField;

    private bool impressionsFieldSpecified;

    private Money costField;

    private double averagePositionField;

    private bool averagePositionFieldSpecified;

    private Money averageCpcField;

    private Money averageCpmField;

    private double ctrField;

    private bool ctrFieldSpecified;

    private long conversionsField;

    private bool conversionsFieldSpecified;

    private double conversionRateField;

    private bool conversionRateFieldSpecified;

    private Money costPerConversionField;

    private long conversionsManyPerClickField;

    private bool conversionsManyPerClickFieldSpecified;

    private double conversionRateManyPerClickField;

    private bool conversionRateManyPerClickFieldSpecified;

    private Money costPerConversionManyPerClickField;

    private long viewThroughConversionsField;

    private bool viewThroughConversionsFieldSpecified;

    private long totalConvValueField;

    private bool totalConvValueFieldSpecified;

    private double valuePerConvField;

    private bool valuePerConvFieldSpecified;

    private double valuePerConvManyPerClickField;

    private bool valuePerConvManyPerClickFieldSpecified;

    private long invalidClicksField;

    private bool invalidClicksFieldSpecified;

    private double invalidClickRateField;

    private bool invalidClickRateFieldSpecified;

    private long numCallsField;

    private bool numCallsFieldSpecified;

    private long numMissedCallsField;

    private bool numMissedCallsFieldSpecified;

    private long numReceivedCallsField;

    private bool numReceivedCallsFieldSpecified;

    private long callDurationSecsField;

    private bool callDurationSecsFieldSpecified;

    private double avgCallDurationSecsField;

    private bool avgCallDurationSecsFieldSpecified;

    private string statsTypeField;

    public string startDate {
      get { return this.startDateField; }
      set { this.startDateField = value; }
    }

    public string endDate {
      get { return this.endDateField; }
      set { this.endDateField = value; }
    }

    public StatsNetwork network {
      get { return this.networkField; }
      set {
        this.networkField = value;
        this.networkSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool networkSpecified {
      get { return this.networkFieldSpecified; }
      set { this.networkFieldSpecified = value; }
    }

    public long clicks {
      get { return this.clicksField; }
      set {
        this.clicksField = value;
        this.clicksSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool clicksSpecified {
      get { return this.clicksFieldSpecified; }
      set { this.clicksFieldSpecified = value; }
    }

    public long impressions {
      get { return this.impressionsField; }
      set {
        this.impressionsField = value;
        this.impressionsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool impressionsSpecified {
      get { return this.impressionsFieldSpecified; }
      set { this.impressionsFieldSpecified = value; }
    }

    public Money cost {
      get { return this.costField; }
      set { this.costField = value; }
    }

    public double averagePosition {
      get { return this.averagePositionField; }
      set {
        this.averagePositionField = value;
        this.averagePositionSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool averagePositionSpecified {
      get { return this.averagePositionFieldSpecified; }
      set { this.averagePositionFieldSpecified = value; }
    }

    public Money averageCpc {
      get { return this.averageCpcField; }
      set { this.averageCpcField = value; }
    }

    public Money averageCpm {
      get { return this.averageCpmField; }
      set { this.averageCpmField = value; }
    }

    public double ctr {
      get { return this.ctrField; }
      set {
        this.ctrField = value;
        this.ctrSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ctrSpecified {
      get { return this.ctrFieldSpecified; }
      set { this.ctrFieldSpecified = value; }
    }

    public long conversions {
      get { return this.conversionsField; }
      set {
        this.conversionsField = value;
        this.conversionsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool conversionsSpecified {
      get { return this.conversionsFieldSpecified; }
      set { this.conversionsFieldSpecified = value; }
    }

    public double conversionRate {
      get { return this.conversionRateField; }
      set {
        this.conversionRateField = value;
        this.conversionRateSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool conversionRateSpecified {
      get { return this.conversionRateFieldSpecified; }
      set { this.conversionRateFieldSpecified = value; }
    }

    public Money costPerConversion {
      get { return this.costPerConversionField; }
      set { this.costPerConversionField = value; }
    }

    public long conversionsManyPerClick {
      get { return this.conversionsManyPerClickField; }
      set {
        this.conversionsManyPerClickField = value;
        this.conversionsManyPerClickSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool conversionsManyPerClickSpecified {
      get { return this.conversionsManyPerClickFieldSpecified; }
      set { this.conversionsManyPerClickFieldSpecified = value; }
    }

    public double conversionRateManyPerClick {
      get { return this.conversionRateManyPerClickField; }
      set {
        this.conversionRateManyPerClickField = value;
        this.conversionRateManyPerClickSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool conversionRateManyPerClickSpecified {
      get { return this.conversionRateManyPerClickFieldSpecified; }
      set { this.conversionRateManyPerClickFieldSpecified = value; }
    }

    public Money costPerConversionManyPerClick {
      get { return this.costPerConversionManyPerClickField; }
      set { this.costPerConversionManyPerClickField = value; }
    }

    public long viewThroughConversions {
      get { return this.viewThroughConversionsField; }
      set {
        this.viewThroughConversionsField = value;
        this.viewThroughConversionsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool viewThroughConversionsSpecified {
      get { return this.viewThroughConversionsFieldSpecified; }
      set { this.viewThroughConversionsFieldSpecified = value; }
    }

    public long totalConvValue {
      get { return this.totalConvValueField; }
      set {
        this.totalConvValueField = value;
        this.totalConvValueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool totalConvValueSpecified {
      get { return this.totalConvValueFieldSpecified; }
      set { this.totalConvValueFieldSpecified = value; }
    }

    public double valuePerConv {
      get { return this.valuePerConvField; }
      set {
        this.valuePerConvField = value;
        this.valuePerConvSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valuePerConvSpecified {
      get { return this.valuePerConvFieldSpecified; }
      set { this.valuePerConvFieldSpecified = value; }
    }

    public double valuePerConvManyPerClick {
      get { return this.valuePerConvManyPerClickField; }
      set {
        this.valuePerConvManyPerClickField = value;
        this.valuePerConvManyPerClickSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valuePerConvManyPerClickSpecified {
      get { return this.valuePerConvManyPerClickFieldSpecified; }
      set { this.valuePerConvManyPerClickFieldSpecified = value; }
    }

    public long invalidClicks {
      get { return this.invalidClicksField; }
      set {
        this.invalidClicksField = value;
        this.invalidClicksSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool invalidClicksSpecified {
      get { return this.invalidClicksFieldSpecified; }
      set { this.invalidClicksFieldSpecified = value; }
    }

    public double invalidClickRate {
      get { return this.invalidClickRateField; }
      set {
        this.invalidClickRateField = value;
        this.invalidClickRateSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool invalidClickRateSpecified {
      get { return this.invalidClickRateFieldSpecified; }
      set { this.invalidClickRateFieldSpecified = value; }
    }

    public long numCalls {
      get { return this.numCallsField; }
      set {
        this.numCallsField = value;
        this.numCallsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numCallsSpecified {
      get { return this.numCallsFieldSpecified; }
      set { this.numCallsFieldSpecified = value; }
    }

    public long numMissedCalls {
      get { return this.numMissedCallsField; }
      set {
        this.numMissedCallsField = value;
        this.numMissedCallsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numMissedCallsSpecified {
      get { return this.numMissedCallsFieldSpecified; }
      set { this.numMissedCallsFieldSpecified = value; }
    }

    public long numReceivedCalls {
      get { return this.numReceivedCallsField; }
      set {
        this.numReceivedCallsField = value;
        this.numReceivedCallsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numReceivedCallsSpecified {
      get { return this.numReceivedCallsFieldSpecified; }
      set { this.numReceivedCallsFieldSpecified = value; }
    }

    public long callDurationSecs {
      get { return this.callDurationSecsField; }
      set {
        this.callDurationSecsField = value;
        this.callDurationSecsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool callDurationSecsSpecified {
      get { return this.callDurationSecsFieldSpecified; }
      set { this.callDurationSecsFieldSpecified = value; }
    }

    public double avgCallDurationSecs {
      get { return this.avgCallDurationSecsField; }
      set {
        this.avgCallDurationSecsField = value;
        this.avgCallDurationSecsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool avgCallDurationSecsSpecified {
      get { return this.avgCallDurationSecsFieldSpecified; }
      set { this.avgCallDurationSecsFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("Stats.Type")]
    public string StatsType {
      get { return this.statsTypeField; }
      set { this.statsTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Stats.Network", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum StatsNetwork {
    SEARCH,
    GOOGLE_SEARCH,
    SEARCH_NETWORK,
    CONTENT,
    CONTENT_KEYWORD_BID,
    CONTENT_PLACEMENT_BID,
    ALL,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AdServingOptimizationStatus {
    OPTIMIZE,
    ROTATE,
    UNAVAILABLE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class FrequencyCap {
    private long impressionsField;

    private bool impressionsFieldSpecified;

    private TimeUnit timeUnitField;

    private bool timeUnitFieldSpecified;

    private Level levelField;

    private bool levelFieldSpecified;

    public long impressions {
      get { return this.impressionsField; }
      set {
        this.impressionsField = value;
        this.impressionsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool impressionsSpecified {
      get { return this.impressionsFieldSpecified; }
      set { this.impressionsFieldSpecified = value; }
    }

    public TimeUnit timeUnit {
      get { return this.timeUnitField; }
      set {
        this.timeUnitField = value;
        this.timeUnitSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool timeUnitSpecified {
      get { return this.timeUnitFieldSpecified; }
      set { this.timeUnitFieldSpecified = value; }
    }

    public Level level {
      get { return this.levelField; }
      set {
        this.levelField = value;
        this.levelSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool levelSpecified {
      get { return this.levelFieldSpecified; }
      set { this.levelFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum TimeUnit {
    MINUTE,
    HOUR,
    DAY,
    WEEK,
    MONTH,
    LIFETIME
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum Level {
    CREATIVE,
    ADGROUP,
    CAMPAIGN,
    UNKNOWN
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RealTimeBiddingSetting))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeoTargetTypeSetting))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public abstract partial class Setting {
    private string settingTypeField;

    [System.Xml.Serialization.XmlElementAttribute("Setting.Type")]
    public string SettingType {
      get { return this.settingTypeField; }
      set { this.settingTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class RealTimeBiddingSetting : Setting {
    private bool optInField;

    private bool optInFieldSpecified;

    public bool optIn {
      get { return this.optInField; }
      set {
        this.optInField = value;
        this.optInSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool optInSpecified {
      get { return this.optInFieldSpecified; }
      set { this.optInFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class GeoTargetTypeSetting : Setting {
    private GeoTargetTypeSettingPositiveGeoTargetType positiveGeoTargetTypeField;

    private bool positiveGeoTargetTypeFieldSpecified;

    private GeoTargetTypeSettingNegativeGeoTargetType negativeGeoTargetTypeField;

    private bool negativeGeoTargetTypeFieldSpecified;

    public GeoTargetTypeSettingPositiveGeoTargetType positiveGeoTargetType {
      get { return this.positiveGeoTargetTypeField; }
      set {
        this.positiveGeoTargetTypeField = value;
        this.positiveGeoTargetTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool positiveGeoTargetTypeSpecified {
      get { return this.positiveGeoTargetTypeFieldSpecified; }
      set { this.positiveGeoTargetTypeFieldSpecified = value; }
    }

    public GeoTargetTypeSettingNegativeGeoTargetType negativeGeoTargetType {
      get { return this.negativeGeoTargetTypeField; }
      set {
        this.negativeGeoTargetTypeField = value;
        this.negativeGeoTargetTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool negativeGeoTargetTypeSpecified {
      get { return this.negativeGeoTargetTypeFieldSpecified; }
      set { this.negativeGeoTargetTypeFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GeoTargetTypeSetting.PositiveGeoTargetType", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum GeoTargetTypeSettingPositiveGeoTargetType {
    DONT_CARE,
    AREA_OF_INTEREST,
    LOCATION_OF_PRESENCE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GeoTargetTypeSetting.NegativeGeoTargetType", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum GeoTargetTypeSettingNegativeGeoTargetType {
    DONT_CARE,
    LOCATION_OF_PRESENCE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class NetworkSetting {
    private bool targetGoogleSearchField;

    private bool targetGoogleSearchFieldSpecified;

    private bool targetSearchNetworkField;

    private bool targetSearchNetworkFieldSpecified;

    private bool targetContentNetworkField;

    private bool targetContentNetworkFieldSpecified;

    private bool targetContentContextualField;

    private bool targetContentContextualFieldSpecified;

    private bool targetPartnerSearchNetworkField;

    private bool targetPartnerSearchNetworkFieldSpecified;

    public bool targetGoogleSearch {
      get { return this.targetGoogleSearchField; }
      set {
        this.targetGoogleSearchField = value;
        this.targetGoogleSearchSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool targetGoogleSearchSpecified {
      get { return this.targetGoogleSearchFieldSpecified; }
      set { this.targetGoogleSearchFieldSpecified = value; }
    }

    public bool targetSearchNetwork {
      get { return this.targetSearchNetworkField; }
      set {
        this.targetSearchNetworkField = value;
        this.targetSearchNetworkSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool targetSearchNetworkSpecified {
      get { return this.targetSearchNetworkFieldSpecified; }
      set { this.targetSearchNetworkFieldSpecified = value; }
    }

    public bool targetContentNetwork {
      get { return this.targetContentNetworkField; }
      set {
        this.targetContentNetworkField = value;
        this.targetContentNetworkSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool targetContentNetworkSpecified {
      get { return this.targetContentNetworkFieldSpecified; }
      set { this.targetContentNetworkFieldSpecified = value; }
    }

    public bool targetContentContextual {
      get { return this.targetContentContextualField; }
      set {
        this.targetContentContextualField = value;
        this.targetContentContextualSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool targetContentContextualSpecified {
      get { return this.targetContentContextualFieldSpecified; }
      set { this.targetContentContextualFieldSpecified = value; }
    }

    public bool targetPartnerSearchNetwork {
      get { return this.targetPartnerSearchNetworkField; }
      set {
        this.targetPartnerSearchNetworkField = value;
        this.targetPartnerSearchNetworkSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool targetPartnerSearchNetworkSpecified {
      get { return this.targetPartnerSearchNetworkFieldSpecified; }
      set { this.targetPartnerSearchNetworkFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Bid {
    private Money amountField;

    public Money amount {
      get { return this.amountField; }
      set { this.amountField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPMAdGroupBids))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPCAdGroupBids))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionOptimizerAdGroupBids))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BudgetOptimizerAdGroupBids))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PercentCPAAdGroupBids))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public abstract partial class AdGroupBids {
    private string adGroupBidsTypeField;

    [System.Xml.Serialization.XmlElementAttribute("AdGroupBids.Type")]
    public string AdGroupBidsType {
      get { return this.adGroupBidsTypeField; }
      set { this.adGroupBidsTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ManualCPMAdGroupBids : AdGroupBids {
    private Bid maxCpmField;

    public Bid maxCpm {
      get { return this.maxCpmField; }
      set { this.maxCpmField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ManualCPCAdGroupBids : AdGroupBids {
    private Bid keywordMaxCpcField;

    private Bid keywordContentMaxCpcField;

    private Bid siteMaxCpcField;

    private bool enhancedCpcEnabledField;

    private bool enhancedCpcEnabledFieldSpecified;

    public Bid keywordMaxCpc {
      get { return this.keywordMaxCpcField; }
      set { this.keywordMaxCpcField = value; }
    }

    public Bid keywordContentMaxCpc {
      get { return this.keywordContentMaxCpcField; }
      set { this.keywordContentMaxCpcField = value; }
    }

    public Bid siteMaxCpc {
      get { return this.siteMaxCpcField; }
      set { this.siteMaxCpcField = value; }
    }

    public bool enhancedCpcEnabled {
      get { return this.enhancedCpcEnabledField; }
      set {
        this.enhancedCpcEnabledField = value;
        this.enhancedCpcEnabledSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool enhancedCpcEnabledSpecified {
      get { return this.enhancedCpcEnabledFieldSpecified; }
      set { this.enhancedCpcEnabledFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ConversionOptimizerAdGroupBids : AdGroupBids {
    private Bid targetCpaField;

    private ConversionOptimizerBidType conversionOptimizerBidTypeField;

    private bool conversionOptimizerBidTypeFieldSpecified;

    private ConversionDeduplicationMode deduplicationModeField;

    private bool deduplicationModeFieldSpecified;

    public Bid targetCpa {
      get { return this.targetCpaField; }
      set { this.targetCpaField = value; }
    }

    public ConversionOptimizerBidType conversionOptimizerBidType {
      get { return this.conversionOptimizerBidTypeField; }
      set {
        this.conversionOptimizerBidTypeField = value;
        this.conversionOptimizerBidTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool conversionOptimizerBidTypeSpecified {
      get { return this.conversionOptimizerBidTypeFieldSpecified; }
      set { this.conversionOptimizerBidTypeFieldSpecified = value; }
    }

    public ConversionDeduplicationMode deduplicationMode {
      get { return this.deduplicationModeField; }
      set {
        this.deduplicationModeField = value;
        this.deduplicationModeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool deduplicationModeSpecified {
      get { return this.deduplicationModeFieldSpecified; }
      set { this.deduplicationModeFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BudgetOptimizerAdGroupBids : AdGroupBids {
    private Bid proxyKeywordMaxCpcField;

    private Bid proxySiteMaxCpcField;

    private bool enhancedCpcEnabledField;

    private bool enhancedCpcEnabledFieldSpecified;

    public Bid proxyKeywordMaxCpc {
      get { return this.proxyKeywordMaxCpcField; }
      set { this.proxyKeywordMaxCpcField = value; }
    }

    public Bid proxySiteMaxCpc {
      get { return this.proxySiteMaxCpcField; }
      set { this.proxySiteMaxCpcField = value; }
    }

    public bool enhancedCpcEnabled {
      get { return this.enhancedCpcEnabledField; }
      set {
        this.enhancedCpcEnabledField = value;
        this.enhancedCpcEnabledSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool enhancedCpcEnabledSpecified {
      get { return this.enhancedCpcEnabledFieldSpecified; }
      set { this.enhancedCpcEnabledFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class PercentCPAAdGroupBids : AdGroupBids {
    private int percentCpaField;

    private bool percentCpaFieldSpecified;

    public int percentCpa {
      get { return this.percentCpaField; }
      set {
        this.percentCpaField = value;
        this.percentCpaSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool percentCpaSpecified {
      get { return this.percentCpaFieldSpecified; }
      set { this.percentCpaFieldSpecified = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionOptimizerBiddingTransition))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BiddingTransition {
    private BiddingStrategy targetBiddingStrategyField;

    private AdGroupBids explicitAdGroupBidsField;

    private string biddingTransitionTypeField;

    public BiddingStrategy targetBiddingStrategy {
      get { return this.targetBiddingStrategyField; }
      set { this.targetBiddingStrategyField = value; }
    }

    public AdGroupBids explicitAdGroupBids {
      get { return this.explicitAdGroupBidsField; }
      set { this.explicitAdGroupBidsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("BiddingTransition.Type")]
    public string BiddingTransitionType {
      get { return this.biddingTransitionTypeField; }
      set { this.biddingTransitionTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ConversionOptimizerBiddingTransition : BiddingTransition {
    private bool useSavedBidsField;

    private bool useSavedBidsFieldSpecified;

    public bool useSavedBids {
      get { return this.useSavedBidsField; }
      set {
        this.useSavedBidsField = value;
        this.useSavedBidsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool useSavedBidsSpecified {
      get { return this.useSavedBidsFieldSpecified; }
      set { this.useSavedBidsFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignOperation : Operation {
    private BiddingTransition biddingTransitionField;

    private Campaign operandField;

    public BiddingTransition biddingTransition {
      get { return this.biddingTransitionField; }
      set { this.biddingTransitionField = value; }
    }

    public Campaign operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignPage : Page {
    private Budget totalBudgetField;

    private Campaign[] entriesField;

    public Budget totalBudget {
      get { return this.totalBudgetField; }
      set { this.totalBudgetField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public Campaign[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class TargetError : ApiError {
    private TargetErrorReason reasonField;

    private bool reasonFieldSpecified;

    public TargetErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TargetError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum TargetErrorReason {
    AD_SCHEDULE_ADVANCED_INCOMPATIBLE_WITH_CONVERSION_OPTIMIZER,
    AD_SCHEDULE_BID_MULTIPLIER_MALFORMED,
    AD_SCHEDULE_BID_MULTIPLIER_TOO_BIG,
    AD_SCHEDULE_BID_MULTIPLIER_TOO_SMALL,
    AD_SCHEDULE_BID_MULTIPLIER_TOO_MANY_FRACTION_DIGITS,
    AD_SCHEDULE_EXCEEDED_INTERVALS_PER_DAY_LIMIT,
    AD_SCHEDULE_EXCEEDS_PAST_END_OF_WEEK,
    AD_SCHEDULE_INCOMPATIBILITY,
    AD_SCHEDULE_INCOMPATIBLE_WITH_BUDGET_OPTIMIZER,
    AD_SCHEDULE_INTERVAL_CANNOT_SPAN_MULTIPLE_DAYS,
    AD_SCHEDULE_INVALID_DAY_OF_THE_WEEK,
    AD_SCHEDULE_INVALID_TIME_INTERVAL,
    AD_SCHEDULE_NO_INTERVALS_WHILE_ENABLED,
    AD_SCHEDULE_NOT_MULTIPLE_OF_15_MINUTES,
    AD_SCHEDULE_TIME_INTERVALS_OVERLAP,
    CANNOT_EXCLUDE_CITY,
    CANNOT_EXCLUDE_IF_NOT_TARGETED,
    CANNOT_EXCLUDE_METRO,
    CANNOT_EXCLUDE_PROVINCE,
    CANNOT_OPT_OUT_GOOGLE_SEARCH_WHILE_BID_TO_POSITION_ENABLE,
    CANNOT_TARGET_AGE_WITHOUT_GENDER,
    CANNOT_TARGET_CITY,
    CANNOT_TARGET_CONTENT_CONTEXTUAL_WITHOUT_CONTENT_NETWORK,
    CANNOT_TARGET_COUNTRY,
    CANNOT_TARGET_COVERAGE,
    CANNOT_TARGET_GENDER_WITHOUT_AGE,
    CANNOT_TARGET_GOOGLE_SEARCH_FOR_CPM_CAMPAIGN,
    CANNOT_TARGET_LANGUAGE,
    CANNOT_TARGET_METRO,
    CANNOT_TARGET_MOBILE_CARRIER,
    CANNOT_TARGET_PROVINCE,
    CANNOT_TARGET_SEARCH_SYNDICATION_WITHOUT_GOOGLE_SEARCH,
    CANNOT_TARGET_SYNDICATABLE_TYPES,
    CANNOT_TARGET_THE_SAME_TARGET_LIST_TYPE_MULTIPLE_TIMES,
    DEMOGRAPHIC_BID_MODIFIER_SHOULD_BE_IN_BETWEEN_0_AND_500,
    INVALID_CITY_CODE,
    INVALID_CITYNAME_LENGTH,
    INVALID_EXCLUDED_POLYGON_TARGET,
    INVALID_EXCLUDED_PROXIMITY_TARGET,
    INVALID_LANGUAGE_CODE,
    INVALID_LATITUDE,
    INVALID_LONGITUDE,
    INVALID_METRO_CODE,
    INVALID_MOBILE_CARRIER,
    INVALID_MOBILE_PLATFORM,
    INVALID_POSTALCODE_LENGTH,
    INVALID_PROVINCE_CODE,
    INVALID_PROXIMITY_RADIUS,
    INVALID_REGIONCODE_LENGTH,
    INVALID_REGIONNAME_LENGTH,
    INVALID_STREETADDRESS_LENGTH,
    MULTIPLE_OCCURRENCES_OF_SAME_TARGET,
    POLYGON_DUPLICATE_VERTICES,
    POLYGON_EDGES_INTERSECT,
    POLYGON_TOO_FEW_VERTICES,
    POLYGON_TOO_MANY_VERTICES,
    POLYGON_TOO_LARGE,
    TARGET_IS_ENCLOSED_BY_ANOTHER_TARGET,
    TARGET_IS_EXCLUDED_BY_ANOTHER_TARGET,
    TARGETING_VALIDATION_FAILED,
    TARGETING_CROSS_COUNTRY_REGIONAL,
    TARGETING_EXCLUSION_NOT_SUPPORTED,
    TARGETING_INCOMPATIBLE_LOCATION_TYPES,
    TARGETING_NOT_SUPPORTED,
    TARGETING_TOO_MANY_REGIONS,
    TOO_MANY_EXCLUDED_LOCATIONS,
    TOO_MANY_TARGETED_LOCATIONS,
    WARNING_MAY_NOW_REQUIRE_CHINESE_APPROVAL,
    WARNING_NOW_REQUIRES_CHINESE_APPROVAL,
    WARNING_NOW_TARGETS_CHINA,
    WARNING_NOW_TARGETS_CHINESE,
    TARGET_ERROR
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class StatsQueryError : ApiError {
    private StatsQueryErrorReason reasonField;

    private bool reasonFieldSpecified;

    public StatsQueryErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "StatsQueryError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum StatsQueryErrorReason {
    DATE_NOT_IN_VALID_RANGE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class SettingError : ApiError {
    private SettingErrorReason reasonField;

    private bool reasonFieldSpecified;

    public SettingErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SettingError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum SettingErrorReason {
    DUPLICATE_SETTING_TYPE,
    SETTING_TYPE_IS_NOT_AVAILABLE,
    SETTING_TYPE_IS_NOT_COMPATIBLE_WITH_CAMPAIGN,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class RejectedError : ApiError {
    private RejectedErrorReason reasonField;

    private bool reasonFieldSpecified;

    public RejectedErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RejectedError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum RejectedErrorReason {
    UNKNOWN_VALUE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class QuotaError : ApiError {
    private QuotaErrorReason reasonField;

    private bool reasonFieldSpecified;

    private int limitField;

    private bool limitFieldSpecified;

    public QuotaErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }

    public int limit {
      get { return this.limitField; }
      set {
        this.limitField = value;
        this.limitSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool limitSpecified {
      get { return this.limitFieldSpecified; }
      set { this.limitFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "QuotaError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum QuotaErrorReason {
    TOO_MANY_ADGROUPS_PER_CAMPAIGN,
    TOO_MANY_CAMPAIGNS_PER_ACCOUNT,
    TOO_MANY_CONVERSION_TYPES_PER_ACCOUNT,
    TOO_MANY_KEYWORDS_PER_ADGROUP,
    TOO_MANY_KEYWORDS_PER_CAMPAIGN,
    TOO_MANY_KEYWORDS_PER_CUSTOMER,
    TOO_MANY_SITES_PER_ADGROUP,
    TOO_MANY_SITES_PER_CAMPAIGN,
    TOO_MANY_CRITERIA_PER_ACCOUNT,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class DateError : ApiError {
    private DateErrorReason reasonField;

    private bool reasonFieldSpecified;

    public DateErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DateError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum DateErrorReason {
    INVALID_FIELD_VALUES_IN_DATE,
    INVALID_STRING_DATE,
    INVALID_STRING_DATE_RANGE,
    INVALID_STRING_DATE_TIME,
    EARLIER_THAN_MINIMUM_DATE,
    LATER_THAN_MAXIMUM_DATE,
    DATE_RANGE_MINIMUM_DATE_LATER_THAN_MAXIMUM_DATE,
    DATE_RANGE_MINIMUM_AND_MAXIMUM_DATES_BOTH_NULL
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignError : ApiError {
    private CampaignErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CampaignErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum CampaignErrorReason {
    AFTER_MAXIMUM_ALLOWABLE_DATE,
    CANNOT_GO_BACK_TO_INCOMPLETE,
    CANNOT_MODIFY_START_DATE_IF_ALREADY_STARTED,
    CANNOT_SET_ACCELERATED_DELIVERY_FOR_BUDGET_OPTIMIZER_CAMPAIGN,
    CANNOT_SET_END_DATE_BEFORE_EXPERIMENT_END_DATE,
    CANNOT_SET_DATE_TO_PAST,
    CANNOT_SET_POSITION_PREFERENCE_IF_NOT_SEARCH_TARGETED,
    CURRENCY_NOT_VALID_FOR_ACCOUNT,
    DUPLICATE_CAMPAIGN_NAME,
    INCOMPATIBLE_CAMPAIGN_FIELD,
    INVALID_CAMPAIGN_NAME,
    INVALID_AD_SERVING_OPTIMIZATION_STATUS,
    KEYWORD_QUOTA_EXCEEDED,
    MAX_IMPRESSIONS_NOT_IN_RANGE,
    START_DATE_AFTER_END_DATE,
    TIME_UNIT_NOT_SUPPORTED,
    USE_BIDDING_TRANSITION_FIELD_INSTEAD_TO_SWITCH_BIDDING_STRATEGY,
    CANNOT_CHANGE_CAMPAIGN_TYPE,
    INVALID_OPERATION_IF_SERVING_STATUS_HAS_ENDED,
    CANNOT_CHANGE_TV_CAMPAIGN,
    CANNOT_ADD_CAMPAIGN_WITH_CONVERSION_OPTIMIZER_BIDDING_STRATEGY,
    FREQUENCY_CAP_TIME_UNIT_CANNOT_BE_NULL,
    FREQUENCY_CAP_LEVEL_CANNOT_BE_NULL,
    CANNOT_SET_BUDGET,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BudgetError : ApiError {
    private BudgetErrorReason reasonField;

    private bool reasonFieldSpecified;

    public BudgetErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BudgetError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum BudgetErrorReason {
    BUDGET_ERROR,
    BUDGET_PERIOD_NOT_AVAILABLE,
    MONEY_AMOUNT_IN_WRONG_CURRENCY,
    MONEY_AMOUNT_LESS_THAN_CURRENCY_MINIMUM_CPC,
    MONEY_AMOUNT_LESS_THAN_MAXIMUM_AD_GROUP_CPM,
    MONEY_AMOUNT_LESS_THAN_MAXIMUM_SITE_CPM,
    MONEY_AMOUNT_LESS_THAN_MINIMUM_AD_GROUP_CPC,
    MONEY_AMOUNT_LESS_THAN_MINIMUM_CRITERIA_CPC,
    MONEY_AMOUNT_TOO_LARGE,
    NEGATIVE_MONEY_AMOUNT,
    NON_MULTIPLE_OF_MINIMUM_CURRENCY_UNIT,
    INVALID_BUDGET_SCHEDULE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BiddingTransitionError : ApiError {
    private BiddingTransitionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public BiddingTransitionErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BiddingTransitionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum BiddingTransitionErrorReason {
    BID_TO_POSITION_ENABLED,
    BIDDING_STRATEGY_NOT_AVAILABLE_FOR_ACCOUNT_TYPE,
    BUDGET_OPTIMIZER_IS_ENABLED,
    CONVERSION_OPTIMIZER_IS_ENABLED,
    CONVERSION_TRACKING_NOT_ENABLED,
    CONVERSION_TRACKING_NOT_AVAILABLE_FOR_ACCOUNT_TYPE,
    USE_POSITION_PREFERENCE_IN_MANUALCPC_INSTEAD_TO_DISABLE_POSITION_PREFERENCE,
    INVALID_BID,
    CANNOT_SET_EXPLICIT_BID,
    EXPLICIT_BID_REQUIRED_FOR_TRANSITION,
    EXPLICIT_BID_TYPE_DOES_NOT_MATCH_CAMPAIGN_BIDDING_STRATEGY,
    MISSING_REQUIRED_BID,
    INVALID_STATUS,
    IS_CPM_CAMPAIGN,
    IS_PERCENT_CPA_CAMPAIGN,
    NOT_THE_PREVIOUS_BIDDING_STRATEGY,
    NOT_ENOUGH_CONVERSION_DATA,
    NOT_ENOUGH_CONVERSIONS,
    OPTED_IN_SEARCH,
    PROXY_BIDDING_ON,
    SITE_REMNANT_RESERVATION_ALLOWED,
    TRANSITION_TO_ITSELF,
    UNKNOWN_BIDDING_STRATEGY,
    UNSUPPORTED_TRANSITION,
    VCG_ENABLED,
    BIDDING_TRANSITION_FAILED,
    ACCELERATED_DELIVERY_NOT_SUPPORTED_FOR_BUDGET_OPTIMIZER,
    HAS_ACTIVE_EXPERIMENT,
    INCOMPATIBLE_WITH_CAMPAIGN_SETTING
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BiddingError : ApiError {
    private BiddingErrorReason reasonField;

    private bool reasonFieldSpecified;

    public BiddingErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BiddingError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum BiddingErrorReason {
    BID_AMOUNT_REQUIRED,
    BID_TOO_SMALL,
    BID_TOO_BIG,
    BID_TOO_MANY_FRACTIONAL_DIGITS,
    NON_POSITIVE_BID,
    BID_TOO_HIGH_FOR_DAILY_BUDGET,
    BID_TOO_HIGH_FOR_MONTHLY_BUDGET,
    MUST_EXCLUDE_0_TO_17_WITH_OTHER_AGE_EXCLUSIONS,
    CAMPAIGN_MUST_HAVE_A_BUDGET_TO_ENABLE_BUDGET_OPTIMIZER,
    CANNOT_SET_CONTENT_BID_WITHOUT_SETTING_KEYWORD_MAX_CPC_AS_WELL,
    CANNOT_CREATE_CAMPAIGN_WITH_CONVERSION_OPTIMIZER,
    PAY_PER_CONVERSION_NOT_AVAILABLE_FOR_CUSTOMER,
    PAY_PER_CONVERSION_NOT_ALLOWED_WITH_TARGET_CPA,
    PAY_PER_CONVERSION_NOT_ALLOWED_WITH_MANY_PER_CLICK,
    TARGET_CPA_NOT_AVAILABLE_FOR_CUSTOMER,
    MANY_PER_CLICK_NOT_AVAILABLE_FOR_CUSTOMER,
    CANNOT_SET_SITE_MAX_CPC,
    BID_ERROR
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "CampaignTargetServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Target))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class CampaignTargetService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public CampaignTargetService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201109/CampaignTargetService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignTargetPage get(CampaignTargetSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((CampaignTargetPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignTargetReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
CampaignTargetOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((CampaignTargetReturnValue) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignTargetReturnValue : ListReturnValue {
    private TargetList[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public TargetList[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdScheduleTargetList))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public abstract partial class TargetList {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private string targetListTypeField;

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("TargetList.Type")]
    public string TargetListType {
      get { return this.targetListTypeField; }
      set { this.targetListTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdScheduleTargetList : TargetList {
    private AdScheduleTarget[] targetsField;

    [System.Xml.Serialization.XmlElementAttribute("targets")]
    public AdScheduleTarget[] targets {
      get { return this.targetsField; }
      set { this.targetsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdScheduleTarget : Target {
    private DayOfWeek dayOfWeekField;

    private bool dayOfWeekFieldSpecified;

    private int startHourField;

    private bool startHourFieldSpecified;

    private MinuteOfHour startMinuteField;

    private bool startMinuteFieldSpecified;

    private int endHourField;

    private bool endHourFieldSpecified;

    private MinuteOfHour endMinuteField;

    private bool endMinuteFieldSpecified;

    private double bidMultiplierField;

    private bool bidMultiplierFieldSpecified;

    public DayOfWeek dayOfWeek {
      get { return this.dayOfWeekField; }
      set {
        this.dayOfWeekField = value;
        this.dayOfWeekSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool dayOfWeekSpecified {
      get { return this.dayOfWeekFieldSpecified; }
      set { this.dayOfWeekFieldSpecified = value; }
    }

    public int startHour {
      get { return this.startHourField; }
      set {
        this.startHourField = value;
        this.startHourSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool startHourSpecified {
      get { return this.startHourFieldSpecified; }
      set { this.startHourFieldSpecified = value; }
    }

    public MinuteOfHour startMinute {
      get { return this.startMinuteField; }
      set {
        this.startMinuteField = value;
        this.startMinuteSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool startMinuteSpecified {
      get { return this.startMinuteFieldSpecified; }
      set { this.startMinuteFieldSpecified = value; }
    }

    public int endHour {
      get { return this.endHourField; }
      set {
        this.endHourField = value;
        this.endHourSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool endHourSpecified {
      get { return this.endHourFieldSpecified; }
      set { this.endHourFieldSpecified = value; }
    }

    public MinuteOfHour endMinute {
      get { return this.endMinuteField; }
      set {
        this.endMinuteField = value;
        this.endMinuteSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool endMinuteSpecified {
      get { return this.endMinuteFieldSpecified; }
      set { this.endMinuteFieldSpecified = value; }
    }

    public double bidMultiplier {
      get { return this.bidMultiplierField; }
      set {
        this.bidMultiplierField = value;
        this.bidMultiplierSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool bidMultiplierSpecified {
      get { return this.bidMultiplierFieldSpecified; }
      set { this.bidMultiplierFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum DayOfWeek {
    MONDAY,
    TUESDAY,
    WEDNESDAY,
    THURSDAY,
    FRIDAY,
    SATURDAY,
    SUNDAY
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum MinuteOfHour {
    ZERO,
    FIFTEEN,
    THIRTY,
    FORTY_FIVE
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdScheduleTarget))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public abstract partial class Target {
    private string targetTypeField;

    [System.Xml.Serialization.XmlElementAttribute("Target.Type")]
    public string TargetType {
      get { return this.targetTypeField; }
      set { this.targetTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignTargetOperation : Operation {
    private TargetList operandField;

    public TargetList operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignTargetPage : Page {
    private TargetList[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public TargetList[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignTargetSelector {
    private long[] campaignIdsField;

    private string dummyField;

    [System.Xml.Serialization.XmlElementAttribute("campaignIds")]
    public long[] campaignIds {
      get { return this.campaignIdsField; }
      set { this.campaignIdsField = value; }
    }

    public string dummy {
      get { return this.dummyField; }
      set { this.dummyField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "ConversionTrackerServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class ConversionTrackerService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public ConversionTrackerService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201109/ConversionTrackerService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual ConversionTrackerPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] {serviceSelector});
      return ((ConversionTrackerPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual ConversionTrackerReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
ConversionTrackerOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((ConversionTrackerReturnValue) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ConversionTrackerReturnValue : ListReturnValue {
    private ConversionTracker[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public ConversionTracker[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdWordsConversionTracker))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public abstract partial class ConversionTracker {
    private long idField;

    private bool idFieldSpecified;

    private string nameField;

    private ConversionTrackerStatus statusField;

    private bool statusFieldSpecified;

    private ConversionTrackerCategory categoryField;

    private bool categoryFieldSpecified;

    private ConversionTrackerStats statsField;

    private int viewthroughLookbackWindowField;

    private bool viewthroughLookbackWindowFieldSpecified;

    private bool viewthroughConversionDeDupSearchField;

    private bool viewthroughConversionDeDupSearchFieldSpecified;

    private bool isProductAdsChargeableField;

    private bool isProductAdsChargeableFieldSpecified;

    private int productAdsChargeableConversionWindowField;

    private bool productAdsChargeableConversionWindowFieldSpecified;

    private string conversionTrackerTypeField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public ConversionTrackerStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    public ConversionTrackerCategory category {
      get { return this.categoryField; }
      set {
        this.categoryField = value;
        this.categorySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool categorySpecified {
      get { return this.categoryFieldSpecified; }
      set { this.categoryFieldSpecified = value; }
    }

    public ConversionTrackerStats stats {
      get { return this.statsField; }
      set { this.statsField = value; }
    }

    public int viewthroughLookbackWindow {
      get { return this.viewthroughLookbackWindowField; }
      set {
        this.viewthroughLookbackWindowField = value;
        this.viewthroughLookbackWindowSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool viewthroughLookbackWindowSpecified {
      get { return this.viewthroughLookbackWindowFieldSpecified; }
      set { this.viewthroughLookbackWindowFieldSpecified = value; }
    }

    public bool viewthroughConversionDeDupSearch {
      get { return this.viewthroughConversionDeDupSearchField; }
      set {
        this.viewthroughConversionDeDupSearchField = value;
        this.viewthroughConversionDeDupSearchSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool viewthroughConversionDeDupSearchSpecified {
      get { return this.viewthroughConversionDeDupSearchFieldSpecified; }
      set { this.viewthroughConversionDeDupSearchFieldSpecified = value; }
    }

    public bool isProductAdsChargeable {
      get { return this.isProductAdsChargeableField; }
      set {
        this.isProductAdsChargeableField = value;
        this.isProductAdsChargeableSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isProductAdsChargeableSpecified {
      get { return this.isProductAdsChargeableFieldSpecified; }
      set { this.isProductAdsChargeableFieldSpecified = value; }
    }

    public int productAdsChargeableConversionWindow {
      get { return this.productAdsChargeableConversionWindowField; }
      set {
        this.productAdsChargeableConversionWindowField = value;
        this.productAdsChargeableConversionWindowSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool productAdsChargeableConversionWindowSpecified {
      get { return this.productAdsChargeableConversionWindowFieldSpecified; }
      set { this.productAdsChargeableConversionWindowFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ConversionTracker.Type")]
    public string ConversionTrackerType {
      get { return this.conversionTrackerTypeField; }
      set { this.conversionTrackerTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ConversionTracker.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ConversionTrackerStatus {
    ENABLED,
    DISABLED,
    HIDDEN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ConversionTracker.Category", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ConversionTrackerCategory {
    DEFAULT,
    PAGE_VIEW,
    PURCHASE,
    SIGNUP,
    LEAD,
    REMARKETING
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ConversionTrackerStats {
    private int numConversionEventsField;

    private bool numConversionEventsFieldSpecified;

    private Money conversionValueField;

    private string mostRecentConversionDateField;

    private int numConvertedClicksField;

    private bool numConvertedClicksFieldSpecified;

    public int numConversionEvents {
      get { return this.numConversionEventsField; }
      set {
        this.numConversionEventsField = value;
        this.numConversionEventsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numConversionEventsSpecified {
      get { return this.numConversionEventsFieldSpecified; }
      set { this.numConversionEventsFieldSpecified = value; }
    }

    public Money conversionValue {
      get { return this.conversionValueField; }
      set { this.conversionValueField = value; }
    }

    public string mostRecentConversionDate {
      get { return this.mostRecentConversionDateField; }
      set { this.mostRecentConversionDateField = value; }
    }

    public int numConvertedClicks {
      get { return this.numConvertedClicksField; }
      set {
        this.numConvertedClicksField = value;
        this.numConvertedClicksSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numConvertedClicksSpecified {
      get { return this.numConvertedClicksFieldSpecified; }
      set { this.numConvertedClicksFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdWordsConversionTracker : ConversionTracker {
    private string snippetField;

    private AdWordsConversionTrackerMarkupLanguage markupLanguageField;

    private bool markupLanguageFieldSpecified;

    private AdWordsConversionTrackerHttpProtocol httpProtocolField;

    private bool httpProtocolFieldSpecified;

    private AdWordsConversionTrackerTextFormat textFormatField;

    private bool textFormatFieldSpecified;

    private string conversionPageLanguageField;

    private string backgroundColorField;

    private string userRevenueValueField;

    public string snippet {
      get { return this.snippetField; }
      set { this.snippetField = value; }
    }

    public AdWordsConversionTrackerMarkupLanguage markupLanguage {
      get { return this.markupLanguageField; }
      set {
        this.markupLanguageField = value;
        this.markupLanguageSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool markupLanguageSpecified {
      get { return this.markupLanguageFieldSpecified; }
      set { this.markupLanguageFieldSpecified = value; }
    }

    public AdWordsConversionTrackerHttpProtocol httpProtocol {
      get { return this.httpProtocolField; }
      set {
        this.httpProtocolField = value;
        this.httpProtocolSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool httpProtocolSpecified {
      get { return this.httpProtocolFieldSpecified; }
      set { this.httpProtocolFieldSpecified = value; }
    }

    public AdWordsConversionTrackerTextFormat textFormat {
      get { return this.textFormatField; }
      set {
        this.textFormatField = value;
        this.textFormatSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool textFormatSpecified {
      get { return this.textFormatFieldSpecified; }
      set { this.textFormatFieldSpecified = value; }
    }

    public string conversionPageLanguage {
      get { return this.conversionPageLanguageField; }
      set { this.conversionPageLanguageField = value; }
    }

    public string backgroundColor {
      get { return this.backgroundColorField; }
      set { this.backgroundColorField = value; }
    }

    public string userRevenueValue {
      get { return this.userRevenueValueField; }
      set { this.userRevenueValueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdWordsConversionTracker.MarkupLanguage", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AdWordsConversionTrackerMarkupLanguage {
    HTML,
    CHTML,
    XHTML,
    WML
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdWordsConversionTracker.HttpProtocol", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AdWordsConversionTrackerHttpProtocol {
    HTTP,
    HTTPS
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdWordsConversionTracker.TextFormat", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AdWordsConversionTrackerTextFormat {
    ONE_LINE,
    TWO_LINE,
    HIDDEN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ConversionTrackerOperation : Operation {
    private ConversionTracker operandField;

    public ConversionTracker operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionTrackerPage))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionBidLandscapePage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupBidLandscapePage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AlertPage))]
  public abstract partial class NoStatsPage : Page {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ConversionTrackerPage : NoStatsPage {
    private ConversionTracker[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public ConversionTracker[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ConversionTrackingError : ApiError {
    private ConversionTrackingErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ConversionTrackingErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ConversionTrackingError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ConversionTrackingErrorReason {
    ANALYTICS_NOT_ALLOWED,
    CANNOT_ADD_CONVERSION_TYPE_SUBCLASS,
    CANNNOT_CHANGE_CONVERSION_SUBCLASS,
    CANNOT_SET_HIDDEN_STATUS,
    CONVERSION_TYPE_NOT_FOUND,
    DOMAIN_EXCEPTION,
    DUPLICATE_NAME,
    EMAIL_FAILED,
    EXCEEDED_CONVERSION_TYPE_LIMIT,
    ID_IS_NULL,
    INVALID_COLOR,
    INVALID_CONVERSION,
    INVALID_DATE_RANGE,
    INVALID_EMAIL_ADDRESS,
    NAME_ALREADY_EXISTS,
    NO_RECIPIENTS,
    NO_SNIPPET,
    REMARKETING_TYPE_NOT_ALLOWED,
    TOO_MANY_WEBPAGES,
    UNKNOWN_SORTING_TYPE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "ConstantDataServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Criterion))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class ConstantDataService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public ConstantDataService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201109/ConstantDataService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual Carrier[] getCarrierCriterion() {
      object[] results = this.Invoke("getCarrierCriterion", new object[0]);
      return ((Carrier[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual Language[] getLanguageCriterion() {
      object[] results = this.Invoke("getLanguageCriterion", new object[0]);
      return ((Language[]) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "CreateAccountServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class CreateAccountService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public CreateAccountService() {
      this.Url = "https://adwords.google.com/api/adwords/mcm/v201109/CreateAccountService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/mcm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/mcm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual Account[] mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
CreateAccountOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((Account[]) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public partial class Account {
    private long customerIdField;

    private bool customerIdFieldSpecified;

    private string loginField;

    private string companyNameField;

    private bool canManageClientsField;

    private bool canManageClientsFieldSpecified;

    private string currencyCodeField;

    private string dateTimeZoneField;

    public long customerId {
      get { return this.customerIdField; }
      set {
        this.customerIdField = value;
        this.customerIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool customerIdSpecified {
      get { return this.customerIdFieldSpecified; }
      set { this.customerIdFieldSpecified = value; }
    }

    public string login {
      get { return this.loginField; }
      set { this.loginField = value; }
    }

    public string companyName {
      get { return this.companyNameField; }
      set { this.companyNameField = value; }
    }

    public bool canManageClients {
      get { return this.canManageClientsField; }
      set {
        this.canManageClientsField = value;
        this.canManageClientsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool canManageClientsSpecified {
      get { return this.canManageClientsFieldSpecified; }
      set { this.canManageClientsFieldSpecified = value; }
    }

    public string currencyCode {
      get { return this.currencyCodeField; }
      set { this.currencyCodeField = value; }
    }

    public string dateTimeZone {
      get { return this.dateTimeZoneField; }
      set { this.dateTimeZoneField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public partial class CreateAccountOperation : Operation {
    private Account operandField;

    private string descriptiveNameField;

    public Account operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }

    public string descriptiveName {
      get { return this.descriptiveNameField; }
      set { this.descriptiveNameField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public partial class CreateAccountError : ApiError {
    private CreateAccountErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CreateAccountErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CreateAccountError.Reason", Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public enum CreateAccountErrorReason {
    INVALID_TIMEZONE,
    INVALID_CURRENCY,
    INVALID_DESCRIPTIVE_NAME,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "CustomerSyncServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/ch/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class CustomerSyncService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public CustomerSyncService() {
      this.Url = "https://adwords.google.com/api/adwords/ch/v201109/CustomerSyncService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/ch/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/ch/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CustomerChangeData get(CustomerSyncSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((CustomerChangeData) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/ch/v201109")]
  public partial class AdGroupChangeData {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private ChangeStatus adGroupChangeStatusField;

    private bool adGroupChangeStatusFieldSpecified;

    private long[] changedAdsField;

    private long[] changedCriteriaField;

    private long[] deletedCriteriaField;

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }

    public ChangeStatus adGroupChangeStatus {
      get { return this.adGroupChangeStatusField; }
      set {
        this.adGroupChangeStatusField = value;
        this.adGroupChangeStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupChangeStatusSpecified {
      get { return this.adGroupChangeStatusFieldSpecified; }
      set { this.adGroupChangeStatusFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("changedAds")]
    public long[] changedAds {
      get { return this.changedAdsField; }
      set { this.changedAdsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("changedCriteria")]
    public long[] changedCriteria {
      get { return this.changedCriteriaField; }
      set { this.changedCriteriaField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("deletedCriteria")]
    public long[] deletedCriteria {
      get { return this.deletedCriteriaField; }
      set { this.deletedCriteriaField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/ch/v201109")]
  public enum ChangeStatus {
    FIELDS_UNCHANGED,
    FIELDS_CHANGED,
    NEW
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/ch/v201109")]
  public partial class CampaignChangeData {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private ChangeStatus campaignChangeStatusField;

    private bool campaignChangeStatusFieldSpecified;

    private AdGroupChangeData[] changedAdGroupsField;

    private long[] addedCampaignCriteriaField;

    private long[] deletedCampaignCriteriaField;

    private long[] addedAdExtensionsField;

    private long[] deletedAdExtensionsField;

    private bool campaignTargetingChangedField;

    private bool campaignTargetingChangedFieldSpecified;

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    public ChangeStatus campaignChangeStatus {
      get { return this.campaignChangeStatusField; }
      set {
        this.campaignChangeStatusField = value;
        this.campaignChangeStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignChangeStatusSpecified {
      get { return this.campaignChangeStatusFieldSpecified; }
      set { this.campaignChangeStatusFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("changedAdGroups")]
    public AdGroupChangeData[] changedAdGroups {
      get { return this.changedAdGroupsField; }
      set { this.changedAdGroupsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("addedCampaignCriteria")]
    public long[] addedCampaignCriteria {
      get { return this.addedCampaignCriteriaField; }
      set { this.addedCampaignCriteriaField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("deletedCampaignCriteria")]
    public long[] deletedCampaignCriteria {
      get { return this.deletedCampaignCriteriaField; }
      set { this.deletedCampaignCriteriaField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("addedAdExtensions")]
    public long[] addedAdExtensions {
      get { return this.addedAdExtensionsField; }
      set { this.addedAdExtensionsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("deletedAdExtensions")]
    public long[] deletedAdExtensions {
      get { return this.deletedAdExtensionsField; }
      set { this.deletedAdExtensionsField = value; }
    }

    public bool campaignTargetingChanged {
      get { return this.campaignTargetingChangedField; }
      set {
        this.campaignTargetingChangedField = value;
        this.campaignTargetingChangedSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignTargetingChangedSpecified {
      get { return this.campaignTargetingChangedFieldSpecified; }
      set { this.campaignTargetingChangedFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/ch/v201109")]
  public partial class CustomerChangeData {
    private CampaignChangeData[] changedCampaignsField;

    private string lastChangeTimestampField;

    [System.Xml.Serialization.XmlElementAttribute("changedCampaigns")]
    public CampaignChangeData[] changedCampaigns {
      get { return this.changedCampaignsField; }
      set { this.changedCampaignsField = value; }
    }

    public string lastChangeTimestamp {
      get { return this.lastChangeTimestampField; }
      set { this.lastChangeTimestampField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class DateTimeRange {
    private string minField;

    private string maxField;

    public string min {
      get { return this.minField; }
      set { this.minField = value; }
    }

    public string max {
      get { return this.maxField; }
      set { this.maxField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/ch/v201109")]
  public partial class CustomerSyncSelector {
    private DateTimeRange dateTimeRangeField;

    private long[] campaignIdsField;

    public DateTimeRange dateTimeRange {
      get { return this.dateTimeRangeField; }
      set { this.dateTimeRangeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("campaignIds")]
    public long[] campaignIds {
      get { return this.campaignIdsField; }
      set { this.campaignIdsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/ch/v201109")]
  public partial class CustomerSyncError : ApiError {
    private CustomerSyncErrorReason reasonField;

    private bool reasonFieldSpecified;

    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    public CustomerSyncErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CustomerSyncError.Reason", Namespace = "https://adwords.google.com/api/adwords/ch/v201109")]
  public enum CustomerSyncErrorReason {
    INVALID_CAMPAIGN_ID,
    INVALID_DATE_RANGE,
    TOO_MANY_CHANGES
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "DataServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataEntry))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class DataService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public DataService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201109/DataService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupBidLandscapePage getAdGroupBidLandscape(Selector serviceSelector) {
      object[] results = this.Invoke("getAdGroupBidLandscape", new object[] {serviceSelector});
      return ((AdGroupBidLandscapePage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CriterionBidLandscapePage getCriterionBidLandscape(Selector serviceSelector) {
      object[] results = this.Invoke("getCriterionBidLandscape", new object[] {serviceSelector});
      return ((CriterionBidLandscapePage) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BidLandscape.LandscapePoint", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BidLandscapeLandscapePoint {
    private Money bidField;

    private long clicksField;

    private bool clicksFieldSpecified;

    private Money costField;

    private Money marginalCpcField;

    private long impressionsField;

    private bool impressionsFieldSpecified;

    public Money bid {
      get { return this.bidField; }
      set { this.bidField = value; }
    }

    public long clicks {
      get { return this.clicksField; }
      set {
        this.clicksField = value;
        this.clicksSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool clicksSpecified {
      get { return this.clicksFieldSpecified; }
      set { this.clicksFieldSpecified = value; }
    }

    public Money cost {
      get { return this.costField; }
      set { this.costField = value; }
    }

    public Money marginalCpc {
      get { return this.marginalCpcField; }
      set { this.marginalCpcField = value; }
    }

    public long impressions {
      get { return this.impressionsField; }
      set {
        this.impressionsField = value;
        this.impressionsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool impressionsSpecified {
      get { return this.impressionsFieldSpecified; }
      set { this.impressionsFieldSpecified = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BidLandscape))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionBidLandscape))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupBidLandscape))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public abstract partial class DataEntry {
    private string dataEntryTypeField;

    [System.Xml.Serialization.XmlElementAttribute("DataEntry.Type")]
    public string DataEntryType {
      get { return this.dataEntryTypeField; }
      set { this.dataEntryTypeField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionBidLandscape))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupBidLandscape))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public abstract partial class BidLandscape : DataEntry {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private string startDateField;

    private string endDateField;

    private BidLandscapeLandscapePoint[] landscapePointsField;

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }

    public string startDate {
      get { return this.startDateField; }
      set { this.startDateField = value; }
    }

    public string endDate {
      get { return this.endDateField; }
      set { this.endDateField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("landscapePoints")]
    public BidLandscapeLandscapePoint[] landscapePoints {
      get { return this.landscapePointsField; }
      set { this.landscapePointsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CriterionBidLandscape : BidLandscape {
    private long criterionIdField;

    private bool criterionIdFieldSpecified;

    public long criterionId {
      get { return this.criterionIdField; }
      set {
        this.criterionIdField = value;
        this.criterionIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool criterionIdSpecified {
      get { return this.criterionIdFieldSpecified; }
      set { this.criterionIdFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupBidLandscape : BidLandscape {
    private AdGroupBidLandscapeType typeField;

    private bool typeFieldSpecified;

    private bool landscapeCurrentField;

    private bool landscapeCurrentFieldSpecified;

    public AdGroupBidLandscapeType type {
      get { return this.typeField; }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get { return this.typeFieldSpecified; }
      set { this.typeFieldSpecified = value; }
    }

    public bool landscapeCurrent {
      get { return this.landscapeCurrentField; }
      set {
        this.landscapeCurrentField = value;
        this.landscapeCurrentSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool landscapeCurrentSpecified {
      get { return this.landscapeCurrentFieldSpecified; }
      set { this.landscapeCurrentFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupBidLandscape.Type", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AdGroupBidLandscapeType {
    UNIFORM,
    DEFAULT,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CriterionBidLandscapePage : NoStatsPage {
    private CriterionBidLandscape[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public CriterionBidLandscape[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupBidLandscapePage : NoStatsPage {
    private AdGroupBidLandscape[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public AdGroupBidLandscape[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class DataError : ApiError {
    private DataErrorReason reasonField;

    private bool reasonFieldSpecified;

    public DataErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DataError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum DataErrorReason {
    CANNOT_CREATE_TABLE_ENTRY,
    NO_TABLE_ENTRY_CLASS_FOR_VIEW_TYPE,
    TABLE_SERVICE_ERROR
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "ExperimentServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class ExperimentService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public ExperimentService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201109/ExperimentService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual ExperimentPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] {serviceSelector});
      return ((ExperimentPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual ExperimentReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
ExperimentOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((ExperimentReturnValue) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ExperimentReturnValue : ListReturnValue {
    private Experiment[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public Experiment[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Experiment {
    private long idField;

    private bool idFieldSpecified;

    private long controlIdField;

    private bool controlIdFieldSpecified;

    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private string nameField;

    private ExperimentStatus statusField;

    private bool statusFieldSpecified;

    private ExperimentServingStatus servingStatusField;

    private bool servingStatusFieldSpecified;

    private int queryPercentageField;

    private bool queryPercentageFieldSpecified;

    private string startDateTimeField;

    private string endDateTimeField;

    private string lastModifiedDateTimeField;

    private ExperimentSummaryStats experimentSummaryStatsField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public long controlId {
      get { return this.controlIdField; }
      set {
        this.controlIdField = value;
        this.controlIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool controlIdSpecified {
      get { return this.controlIdFieldSpecified; }
      set { this.controlIdFieldSpecified = value; }
    }

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public ExperimentStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    public ExperimentServingStatus servingStatus {
      get { return this.servingStatusField; }
      set {
        this.servingStatusField = value;
        this.servingStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool servingStatusSpecified {
      get { return this.servingStatusFieldSpecified; }
      set { this.servingStatusFieldSpecified = value; }
    }

    public int queryPercentage {
      get { return this.queryPercentageField; }
      set {
        this.queryPercentageField = value;
        this.queryPercentageSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool queryPercentageSpecified {
      get { return this.queryPercentageFieldSpecified; }
      set { this.queryPercentageFieldSpecified = value; }
    }

    public string startDateTime {
      get { return this.startDateTimeField; }
      set { this.startDateTimeField = value; }
    }

    public string endDateTime {
      get { return this.endDateTimeField; }
      set { this.endDateTimeField = value; }
    }

    public string lastModifiedDateTime {
      get { return this.lastModifiedDateTimeField; }
      set { this.lastModifiedDateTimeField = value; }
    }

    public ExperimentSummaryStats experimentSummaryStats {
      get { return this.experimentSummaryStatsField; }
      set { this.experimentSummaryStatsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ExperimentStatus {
    ACTIVE,
    DELETED,
    PROMOTED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ExperimentServingStatus {
    RUNNING,
    PENDING,
    ENDED,
    DELETED,
    PROMOTED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ExperimentSummaryStats {
    private int adGroupsCountField;

    private bool adGroupsCountFieldSpecified;

    private int adGroupCriteriaCountField;

    private bool adGroupCriteriaCountFieldSpecified;

    private int adGroupAdsCountField;

    private bool adGroupAdsCountFieldSpecified;

    public int adGroupsCount {
      get { return this.adGroupsCountField; }
      set {
        this.adGroupsCountField = value;
        this.adGroupsCountSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupsCountSpecified {
      get { return this.adGroupsCountFieldSpecified; }
      set { this.adGroupsCountFieldSpecified = value; }
    }

    public int adGroupCriteriaCount {
      get { return this.adGroupCriteriaCountField; }
      set {
        this.adGroupCriteriaCountField = value;
        this.adGroupCriteriaCountSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupCriteriaCountSpecified {
      get { return this.adGroupCriteriaCountFieldSpecified; }
      set { this.adGroupCriteriaCountFieldSpecified = value; }
    }

    public int adGroupAdsCount {
      get { return this.adGroupAdsCountField; }
      set {
        this.adGroupAdsCountField = value;
        this.adGroupAdsCountSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupAdsCountSpecified {
      get { return this.adGroupAdsCountFieldSpecified; }
      set { this.adGroupAdsCountFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ExperimentOperation : Operation {
    private Experiment operandField;

    public Experiment operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ExperimentPage : Page {
    private Experiment[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public Experiment[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ExperimentServiceError : ApiError {
    private ExperimentServiceErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ExperimentServiceErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ExperimentServiceError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ExperimentServiceErrorReason {
    AFTER_MAXIMUM_ALLOWABLE_DATE,
    AOL_PARTNER_CAMPAIGNS_CANT_RUN_EXPERIMENTS,
    CANNOT_CREATE_EXPERIMENT_FOR_BIDDING_STRATEGY,
    CANNOT_CREATE_EXPERIMENT_FOR_BIDDING_STRATEGY_FEATURE,
    CANNOT_SET_DATE_TO_PAST,
    CANNOT_SET_END_DATE_WITHOUT_SETTING_START_DATE,
    DATE_OUTSIDE_CAMPAIGN_DATE_RANGE,
    EXPERIMENT_ALREADY_STARTED,
    EXPERIMENT_ENDED,
    EXPERIMENT_LIMIT_EXCEEDED,
    INVALID_EXPERIMENT_NAME,
    INVALID_QUERY_PERCENTAGE,
    CANNOT_CHANGE_QUERY_PERCENTAGE_AFTER_EXPERIMENT_HAS_STARTED,
    INVALID_STATUS_UPDATE,
    START_DATE_AFTER_END_DATE,
    NO_VALID_BUDGET,
    EXPERIMENT_NOT_ACTIVE,
    EXPERIMENT_SERVICE_ERROR
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "GeoLocationServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class GeoLocationService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public GeoLocationService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201109/GeoLocationService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual GeoLocation[] get(GeoLocationSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((GeoLocation[]) (results[0]));
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(InvalidGeoLocation))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class GeoLocation {
    private GeoPoint geoPointField;

    private Address addressField;

    private byte[] encodedLocationField;

    private string geoLocationTypeField;

    public GeoPoint geoPoint {
      get { return this.geoPointField; }
      set { this.geoPointField = value; }
    }

    public Address address {
      get { return this.addressField; }
      set { this.addressField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] encodedLocation {
      get { return this.encodedLocationField; }
      set { this.encodedLocationField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("GeoLocation.Type")]
    public string GeoLocationType {
      get { return this.geoLocationTypeField; }
      set { this.geoLocationTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class InvalidGeoLocation : GeoLocation {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class GeoLocationSelector {
    private Address[] addressesField;

    private string dummyField;

    [System.Xml.Serialization.XmlElementAttribute("addresses")]
    public Address[] addresses {
      get { return this.addressesField; }
      set { this.addressesField = value; }
    }

    public string dummy {
      get { return this.dummyField; }
      set { this.dummyField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class GeoLocationError : ApiError {
    private GeoLocationErrorReason reasonField;

    private bool reasonFieldSpecified;

    public GeoLocationErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GeoLocationError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum GeoLocationErrorReason {
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AdExtensionOverrideServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Stats))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class AdExtensionOverrideService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public AdExtensionOverrideService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201109/AdExtensionOverrideService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdExtensionOverridePage get(AdExtensionOverrideSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((AdExtensionOverridePage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdExtensionOverrideReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
AdExtensionOverrideOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((AdExtensionOverrideReturnValue) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdExtensionOverrideReturnValue : ListReturnValue {
    private AdExtensionOverride[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdExtensionOverride[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdExtensionOverride {
    private long adIdField;

    private bool adIdFieldSpecified;

    private AdExtension adExtensionField;

    private OverrideInfo overrideInfoField;

    private AdExtensionOverrideStatus statusField;

    private bool statusFieldSpecified;

    private AdExtensionOverrideApprovalStatus approvalStatusField;

    private bool approvalStatusFieldSpecified;

    private AdExtensionOverrideStats statsField;

    public long adId {
      get { return this.adIdField; }
      set {
        this.adIdField = value;
        this.adIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adIdSpecified {
      get { return this.adIdFieldSpecified; }
      set { this.adIdFieldSpecified = value; }
    }

    public AdExtension adExtension {
      get { return this.adExtensionField; }
      set { this.adExtensionField = value; }
    }

    public OverrideInfo overrideInfo {
      get { return this.overrideInfoField; }
      set { this.overrideInfoField = value; }
    }

    public AdExtensionOverrideStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    public AdExtensionOverrideApprovalStatus approvalStatus {
      get { return this.approvalStatusField; }
      set {
        this.approvalStatusField = value;
        this.approvalStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool approvalStatusSpecified {
      get { return this.approvalStatusFieldSpecified; }
      set { this.approvalStatusFieldSpecified = value; }
    }

    public AdExtensionOverrideStats stats {
      get { return this.statsField; }
      set { this.statsField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocationSyncExtension))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductExtension))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SitelinksExtension))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MobileExtension))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocationExtension))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdExtension {
    private long idField;

    private bool idFieldSpecified;

    private string adExtensionTypeField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("AdExtension.Type")]
    public string AdExtensionType {
      get { return this.adExtensionTypeField; }
      set { this.adExtensionTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class LocationSyncExtension : AdExtension {
    private string emailField;

    private string authTokenField;

    private long iconMediaIdField;

    private bool iconMediaIdFieldSpecified;

    private bool shouldSyncUrlField;

    private bool shouldSyncUrlFieldSpecified;

    public string email {
      get { return this.emailField; }
      set { this.emailField = value; }
    }

    public string authToken {
      get { return this.authTokenField; }
      set { this.authTokenField = value; }
    }

    public long iconMediaId {
      get { return this.iconMediaIdField; }
      set {
        this.iconMediaIdField = value;
        this.iconMediaIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool iconMediaIdSpecified {
      get { return this.iconMediaIdFieldSpecified; }
      set { this.iconMediaIdFieldSpecified = value; }
    }

    public bool shouldSyncUrl {
      get { return this.shouldSyncUrlField; }
      set {
        this.shouldSyncUrlField = value;
        this.shouldSyncUrlSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool shouldSyncUrlSpecified {
      get { return this.shouldSyncUrlFieldSpecified; }
      set { this.shouldSyncUrlFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ProductExtension : AdExtension {
    private int googleBaseCustomerIdField;

    private bool googleBaseCustomerIdFieldSpecified;

    private string advertiserNameField;

    private ProductConditionAndGroup[] productSelectionField;

    public int googleBaseCustomerId {
      get { return this.googleBaseCustomerIdField; }
      set {
        this.googleBaseCustomerIdField = value;
        this.googleBaseCustomerIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool googleBaseCustomerIdSpecified {
      get { return this.googleBaseCustomerIdFieldSpecified; }
      set { this.googleBaseCustomerIdFieldSpecified = value; }
    }

    public string advertiserName {
      get { return this.advertiserNameField; }
      set { this.advertiserNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("productSelection")]
    public ProductConditionAndGroup[] productSelection {
      get { return this.productSelectionField; }
      set { this.productSelectionField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ProductConditionAndGroup {
    private ProductCondition[] conditionsField;

    private string dummyField;

    [System.Xml.Serialization.XmlElementAttribute("conditions")]
    public ProductCondition[] conditions {
      get { return this.conditionsField; }
      set { this.conditionsField = value; }
    }

    public string dummy {
      get { return this.dummyField; }
      set { this.dummyField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class SitelinksExtension : AdExtension {
    private Sitelink[] sitelinksField;

    [System.Xml.Serialization.XmlElementAttribute("sitelinks")]
    public Sitelink[] sitelinks {
      get { return this.sitelinksField; }
      set { this.sitelinksField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Sitelink {
    private string displayTextField;

    private string destinationUrlField;

    public string displayText {
      get { return this.displayTextField; }
      set { this.displayTextField = value; }
    }

    public string destinationUrl {
      get { return this.destinationUrlField; }
      set { this.destinationUrlField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class MobileExtension : AdExtension {
    private string phoneNumberField;

    private string countryCodeField;

    private bool isCallOnlyField;

    private bool isCallOnlyFieldSpecified;

    public string phoneNumber {
      get { return this.phoneNumberField; }
      set { this.phoneNumberField = value; }
    }

    public string countryCode {
      get { return this.countryCodeField; }
      set { this.countryCodeField = value; }
    }

    public bool isCallOnly {
      get { return this.isCallOnlyField; }
      set {
        this.isCallOnlyField = value;
        this.isCallOnlySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isCallOnlySpecified {
      get { return this.isCallOnlyFieldSpecified; }
      set { this.isCallOnlyFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class LocationExtension : AdExtension {
    private Address addressField;

    private GeoPoint geoPointField;

    private byte[] encodedLocationField;

    private string companyNameField;

    private string phoneNumberField;

    private LocationExtensionSource sourceField;

    private bool sourceFieldSpecified;

    private long iconMediaIdField;

    private bool iconMediaIdFieldSpecified;

    private long imageMediaIdField;

    private bool imageMediaIdFieldSpecified;

    public Address address {
      get { return this.addressField; }
      set { this.addressField = value; }
    }

    public GeoPoint geoPoint {
      get { return this.geoPointField; }
      set { this.geoPointField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] encodedLocation {
      get { return this.encodedLocationField; }
      set { this.encodedLocationField = value; }
    }

    public string companyName {
      get { return this.companyNameField; }
      set { this.companyNameField = value; }
    }

    public string phoneNumber {
      get { return this.phoneNumberField; }
      set { this.phoneNumberField = value; }
    }

    public LocationExtensionSource source {
      get { return this.sourceField; }
      set {
        this.sourceField = value;
        this.sourceSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool sourceSpecified {
      get { return this.sourceFieldSpecified; }
      set { this.sourceFieldSpecified = value; }
    }

    public long iconMediaId {
      get { return this.iconMediaIdField; }
      set {
        this.iconMediaIdField = value;
        this.iconMediaIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool iconMediaIdSpecified {
      get { return this.iconMediaIdFieldSpecified; }
      set { this.iconMediaIdFieldSpecified = value; }
    }

    public long imageMediaId {
      get { return this.imageMediaIdField; }
      set {
        this.imageMediaIdField = value;
        this.imageMediaIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool imageMediaIdSpecified {
      get { return this.imageMediaIdFieldSpecified; }
      set { this.imageMediaIdFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "LocationExtension.Source", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum LocationExtensionSource {
    ADWORDS_FRONTEND,
    LBC_SYNC
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class OverrideInfo {
    private LocationOverrideInfo itemField;

    [System.Xml.Serialization.XmlElementAttribute("LocationOverrideInfo")]
    public LocationOverrideInfo Item {
      get { return this.itemField; }
      set { this.itemField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class LocationOverrideInfo {
    private int radiusField;

    private bool radiusFieldSpecified;

    private LocationOverrideInfoRadiusUnits radiusUnitsField;

    private bool radiusUnitsFieldSpecified;

    public int radius {
      get { return this.radiusField; }
      set {
        this.radiusField = value;
        this.radiusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool radiusSpecified {
      get { return this.radiusFieldSpecified; }
      set { this.radiusFieldSpecified = value; }
    }

    public LocationOverrideInfoRadiusUnits radiusUnits {
      get { return this.radiusUnitsField; }
      set {
        this.radiusUnitsField = value;
        this.radiusUnitsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool radiusUnitsSpecified {
      get { return this.radiusUnitsFieldSpecified; }
      set { this.radiusUnitsFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "LocationOverrideInfo.RadiusUnits", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum LocationOverrideInfoRadiusUnits {
    KILOMETERS,
    MILES
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdExtensionOverride.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AdExtensionOverrideStatus {
    ACTIVE,
    DELETED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdExtensionOverride.ApprovalStatus", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AdExtensionOverrideApprovalStatus {
    APPROVED,
    UNCHECKED,
    DISAPPROVED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdExtensionOverrideStats : Stats {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdExtensionOverrideOperation : Operation {
    private AdExtensionOverride operandField;

    public AdExtensionOverride operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdExtensionOverridePage : Page {
    private AdExtensionOverride[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public AdExtensionOverride[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdExtensionOverrideSelector {
    private long[] campaignIdsField;

    private long[] adIdsField;

    private long[] adExtensionIdsField;

    private AdExtensionOverrideStatus[] statusesField;

    private Paging pagingField;

    [System.Xml.Serialization.XmlElementAttribute("campaignIds")]
    public long[] campaignIds {
      get { return this.campaignIdsField; }
      set { this.campaignIdsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("adIds")]
    public long[] adIds {
      get { return this.adIdsField; }
      set { this.adIdsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("adExtensionIds")]
    public long[] adExtensionIds {
      get { return this.adExtensionIdsField; }
      set { this.adExtensionIdsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("statuses")]
    public AdExtensionOverrideStatus[] statuses {
      get { return this.statusesField; }
      set { this.statusesField = value; }
    }

    public Paging paging {
      get { return this.pagingField; }
      set { this.pagingField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdExtensionOverrideError : ApiError {
    private AdExtensionOverrideErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdExtensionOverrideErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdExtensionOverrideError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AdExtensionOverrideErrorReason {
    AD_ALREADY_HAS_ADEXTENSION_OVERRIDE,
    ADEXTENSION_ID_MUST_BE_SPECIFIED,
    ADEXTENSION_LATITUTE_CANNOT_CHANGE_AFTER_BEING_SET_ONCE,
    ADEXTENSION_LONGITUDE_CANNOT_CHANGE_AFTER_BEING_SET_ONCE,
    ADEXTENSION_NOT_UNDER_CAMPAIGN,
    CANNOT_OPERATE_ON_DELETED_OVERRIDE,
    CANNOT_OVERRIDE_EXTENSIONS_ON_NON_TEXT_AD,
    CANNOT_OVERRIDE_USING_NON_LOCATION_EXTENSION,
    INVALID_ADEXTENSION_ID,
    LOCATION_OVERRIDE_INFO_REQUIRED_FOR_NEW_LOCATION_EXTENSION_OVERRIDE,
    OVERRIDE_INFO_MUST_BE_NULL_AFTER_BEING_SET_ONCE,
    RADIUS_TOO_LARGE,
    RADIUS_TOO_SMALL,
    UNKNOWN_ADEXTENSION_OVERRIDE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "InfoServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/info/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class InfoService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public InfoService() {
      this.Url = "https://adwords.google.com/api/adwords/info/v201109/InfoService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/info/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/info/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual ApiUsageInfo get(InfoSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((ApiUsageInfo) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/info/v201109")]
  public partial class ApiUsageRecord {
    private string clientEmailField;

    private long clientCustomerIdField;

    private bool clientCustomerIdFieldSpecified;

    private long costField;

    private bool costFieldSpecified;

    public string clientEmail {
      get { return this.clientEmailField; }
      set { this.clientEmailField = value; }
    }

    public long clientCustomerId {
      get { return this.clientCustomerIdField; }
      set {
        this.clientCustomerIdField = value;
        this.clientCustomerIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool clientCustomerIdSpecified {
      get { return this.clientCustomerIdFieldSpecified; }
      set { this.clientCustomerIdFieldSpecified = value; }
    }

    public long cost {
      get { return this.costField; }
      set {
        this.costField = value;
        this.costSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool costSpecified {
      get { return this.costFieldSpecified; }
      set { this.costFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/info/v201109")]
  public partial class ApiUsageInfo {
    private ApiUsageRecord[] apiUsageRecordsField;

    private long costField;

    private bool costFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("apiUsageRecords")]
    public ApiUsageRecord[] apiUsageRecords {
      get { return this.apiUsageRecordsField; }
      set { this.apiUsageRecordsField = value; }
    }

    public long cost {
      get { return this.costField; }
      set {
        this.costField = value;
        this.costSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool costSpecified {
      get { return this.costFieldSpecified; }
      set { this.costFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/info/v201109")]
  public partial class InfoSelector {
    private string serviceNameField;

    private string methodNameField;

    private Operator operatorField;

    private bool operatorFieldSpecified;

    private DateRange dateRangeField;

    private string[] clientEmailsField;

    private long[] clientCustomerIdsField;

    private bool includeSubAccountsField;

    private bool includeSubAccountsFieldSpecified;

    private ApiUsageType apiUsageTypeField;

    private bool apiUsageTypeFieldSpecified;

    public string serviceName {
      get { return this.serviceNameField; }
      set { this.serviceNameField = value; }
    }

    public string methodName {
      get { return this.methodNameField; }
      set { this.methodNameField = value; }
    }

    public Operator @operator {
      get { return this.operatorField; }
      set {
        this.operatorField = value;
        this.operatorSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool operatorSpecified {
      get { return this.operatorFieldSpecified; }
      set { this.operatorFieldSpecified = value; }
    }

    public DateRange dateRange {
      get { return this.dateRangeField; }
      set { this.dateRangeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("clientEmails")]
    public string[] clientEmails {
      get { return this.clientEmailsField; }
      set { this.clientEmailsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("clientCustomerIds")]
    public long[] clientCustomerIds {
      get { return this.clientCustomerIdsField; }
      set { this.clientCustomerIdsField = value; }
    }

    public bool includeSubAccounts {
      get { return this.includeSubAccountsField; }
      set {
        this.includeSubAccountsField = value;
        this.includeSubAccountsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool includeSubAccountsSpecified {
      get { return this.includeSubAccountsFieldSpecified; }
      set { this.includeSubAccountsFieldSpecified = value; }
    }

    public ApiUsageType apiUsageType {
      get { return this.apiUsageTypeField; }
      set {
        this.apiUsageTypeField = value;
        this.apiUsageTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool apiUsageTypeSpecified {
      get { return this.apiUsageTypeFieldSpecified; }
      set { this.apiUsageTypeFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/info/v201109")]
  public enum ApiUsageType {
    FREE_USAGE_API_UNITS_PER_MONTH,
    TOTAL_USAGE_API_UNITS_PER_MONTH,
    OPERATION_COUNT,
    UNIT_COUNT,
    UNIT_COUNT_FOR_CLIENTS,
    METHOD_COST
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/info/v201109")]
  public partial class ApiUsageError : ApiError {
    private ApiUsageErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ApiUsageErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ApiUsageError.Reason", Namespace = "https://adwords.google.com/api/adwords/info/v201109")]
  public enum ApiUsageErrorReason {
    INVALID_DATE_RANGE,
    SERVICE_NAME_NOT_SPECIFIED,
    METHOD_NAME_NOT_SPECIFIED,
    OPERATOR_NOT_SPECIFIED,
    INVALID_CLIENT_EMAIL,
    MAY_ONLY_SELECT_BY_EMAIL_OR_ID,
    INVALID_CLIENT_CUSTOMER_ID,
    INVALID_TOKEN_HEADER
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "LocationCriterionServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Criterion))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class LocationCriterionService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public LocationCriterionService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201109/LocationCriterionService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual LocationCriterion[] get(Selector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((LocationCriterion[]) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class LocationCriterion {
    private Location locationField;

    private string canonicalNameField;

    private long reachField;

    private bool reachFieldSpecified;

    private string localeField;

    private string searchTermField;

    public Location location {
      get { return this.locationField; }
      set { this.locationField = value; }
    }

    public string canonicalName {
      get { return this.canonicalNameField; }
      set { this.canonicalNameField = value; }
    }

    public long reach {
      get { return this.reachField; }
      set {
        this.reachField = value;
        this.reachSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reachSpecified {
      get { return this.reachFieldSpecified; }
      set { this.reachFieldSpecified = value; }
    }

    public string locale {
      get { return this.localeField; }
      set { this.localeField = value; }
    }

    public string searchTerm {
      get { return this.searchTermField; }
      set { this.searchTermField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Date {
    private int yearField;

    private bool yearFieldSpecified;

    private int monthField;

    private bool monthFieldSpecified;

    private int dayField;

    private bool dayFieldSpecified;

    public int year {
      get { return this.yearField; }
      set {
        this.yearField = value;
        this.yearSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool yearSpecified {
      get { return this.yearFieldSpecified; }
      set { this.yearFieldSpecified = value; }
    }

    public int month {
      get { return this.monthField; }
      set {
        this.monthField = value;
        this.monthSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool monthSpecified {
      get { return this.monthFieldSpecified; }
      set { this.monthFieldSpecified = value; }
    }

    public int day {
      get { return this.dayField; }
      set {
        this.dayField = value;
        this.daySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool daySpecified {
      get { return this.dayFieldSpecified; }
      set { this.dayFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class LocationCriterionServiceError : ApiError {
    private LocationCriterionServiceErrorReason reasonField;

    private bool reasonFieldSpecified;

    public LocationCriterionServiceErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "LocationCriterionServiceError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum LocationCriterionServiceErrorReason {
    REQUIRED_LOCATION_CRITERION_PREDICATE_MISSING,
    TOO_MANY_LOCATION_CRITERION_PREDICATES_SPECIFIED,
    LOCATION_CRITERION_SERVICE_ERROR
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "MediaServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class MediaService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public MediaService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201109/MediaService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual MediaPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] {serviceSelector});
      return ((MediaPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual Media[] upload([System.Xml.Serialization.XmlElementAttribute("media")]
Media[] media) {
      object[] results = this.Invoke("upload", new object[] {media});
      return ((Media[]) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Media_Size_StringMapEntry {
    private MediaSize keyField;

    private bool keyFieldSpecified;

    private string valueField;

    public MediaSize key {
      get { return this.keyField; }
      set {
        this.keyField = value;
        this.keySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool keySpecified {
      get { return this.keyFieldSpecified; }
      set { this.keyFieldSpecified = value; }
    }

    public string value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Media.Size", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum MediaSize {
    FULL,
    SHRUNKEN,
    PREVIEW,
    VIDEO_THUMBNAIL
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Dimensions {
    private int widthField;

    private bool widthFieldSpecified;

    private int heightField;

    private bool heightFieldSpecified;

    public int width {
      get { return this.widthField; }
      set {
        this.widthField = value;
        this.widthSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool widthSpecified {
      get { return this.widthFieldSpecified; }
      set { this.widthFieldSpecified = value; }
    }

    public int height {
      get { return this.heightField; }
      set {
        this.heightField = value;
        this.heightSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool heightSpecified {
      get { return this.heightFieldSpecified; }
      set { this.heightFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Media_Size_DimensionsMapEntry {
    private MediaSize keyField;

    private bool keyFieldSpecified;

    private Dimensions valueField;

    public MediaSize key {
      get { return this.keyField; }
      set {
        this.keyField = value;
        this.keySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool keySpecified {
      get { return this.keyFieldSpecified; }
      set { this.keyFieldSpecified = value; }
    }

    public Dimensions value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Video))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Image))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Audio))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Media {
    private long mediaIdField;

    private bool mediaIdFieldSpecified;

    private MediaMediaType typeField;

    private bool typeFieldSpecified;

    private long referenceIdField;

    private bool referenceIdFieldSpecified;

    private Media_Size_DimensionsMapEntry[] dimensionsField;

    private Media_Size_StringMapEntry[] urlsField;

    private MediaMimeType mimeTypeField;

    private bool mimeTypeFieldSpecified;

    private string sourceUrlField;

    private string nameField;

    private long fileSizeField;

    private bool fileSizeFieldSpecified;

    private string creationTimeField;

    private string mediaTypeField;

    public long mediaId {
      get { return this.mediaIdField; }
      set {
        this.mediaIdField = value;
        this.mediaIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool mediaIdSpecified {
      get { return this.mediaIdFieldSpecified; }
      set { this.mediaIdFieldSpecified = value; }
    }

    public MediaMediaType type {
      get { return this.typeField; }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get { return this.typeFieldSpecified; }
      set { this.typeFieldSpecified = value; }
    }

    public long referenceId {
      get { return this.referenceIdField; }
      set {
        this.referenceIdField = value;
        this.referenceIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool referenceIdSpecified {
      get { return this.referenceIdFieldSpecified; }
      set { this.referenceIdFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("dimensions")]
    public Media_Size_DimensionsMapEntry[] dimensions {
      get { return this.dimensionsField; }
      set { this.dimensionsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("urls")]
    public Media_Size_StringMapEntry[] urls {
      get { return this.urlsField; }
      set { this.urlsField = value; }
    }

    public MediaMimeType mimeType {
      get { return this.mimeTypeField; }
      set {
        this.mimeTypeField = value;
        this.mimeTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool mimeTypeSpecified {
      get { return this.mimeTypeFieldSpecified; }
      set { this.mimeTypeFieldSpecified = value; }
    }

    public string sourceUrl {
      get { return this.sourceUrlField; }
      set { this.sourceUrlField = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public long fileSize {
      get { return this.fileSizeField; }
      set {
        this.fileSizeField = value;
        this.fileSizeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool fileSizeSpecified {
      get { return this.fileSizeFieldSpecified; }
      set { this.fileSizeFieldSpecified = value; }
    }

    public string creationTime {
      get { return this.creationTimeField; }
      set { this.creationTimeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("Media.Type")]
    public string MediaType {
      get { return this.mediaTypeField; }
      set { this.mediaTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Media.MediaType", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum MediaMediaType {
    AUDIO,
    DYNAMIC_IMAGE,
    ICON,
    IMAGE,
    STANDARD_ICON,
    VIDEO
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Media.MimeType", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum MediaMimeType {
    IMAGE_JPEG,
    IMAGE_GIF,
    IMAGE_PNG,
    FLASH,
    TEXT_HTML,
    PDF,
    MSWORD,
    MSEXCEL,
    RTF,
    AUDIO_WAV,
    AUDIO_MP3
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Video : Media {
    private long durationMillisField;

    private bool durationMillisFieldSpecified;

    private string streamingUrlField;

    private bool readyToPlayOnTheWebField;

    private bool readyToPlayOnTheWebFieldSpecified;

    private string industryStandardCommercialIdentifierField;

    private string advertisingIdField;

    private string youTubeVideoIdStringField;

    public long durationMillis {
      get { return this.durationMillisField; }
      set {
        this.durationMillisField = value;
        this.durationMillisSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool durationMillisSpecified {
      get { return this.durationMillisFieldSpecified; }
      set { this.durationMillisFieldSpecified = value; }
    }

    public string streamingUrl {
      get { return this.streamingUrlField; }
      set { this.streamingUrlField = value; }
    }

    public bool readyToPlayOnTheWeb {
      get { return this.readyToPlayOnTheWebField; }
      set {
        this.readyToPlayOnTheWebField = value;
        this.readyToPlayOnTheWebSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool readyToPlayOnTheWebSpecified {
      get { return this.readyToPlayOnTheWebFieldSpecified; }
      set { this.readyToPlayOnTheWebFieldSpecified = value; }
    }

    public string industryStandardCommercialIdentifier {
      get { return this.industryStandardCommercialIdentifierField; }
      set { this.industryStandardCommercialIdentifierField = value; }
    }

    public string advertisingId {
      get { return this.advertisingIdField; }
      set { this.advertisingIdField = value; }
    }

    public string youTubeVideoIdString {
      get { return this.youTubeVideoIdStringField; }
      set { this.youTubeVideoIdStringField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Image : Media {
    private byte[] dataField;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] data {
      get { return this.dataField; }
      set { this.dataField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Audio : Media {
    private long durationMillisField;

    private bool durationMillisFieldSpecified;

    private string streamingUrlField;

    private bool readyToPlayOnTheWebField;

    private bool readyToPlayOnTheWebFieldSpecified;

    public long durationMillis {
      get { return this.durationMillisField; }
      set {
        this.durationMillisField = value;
        this.durationMillisSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool durationMillisSpecified {
      get { return this.durationMillisFieldSpecified; }
      set { this.durationMillisFieldSpecified = value; }
    }

    public string streamingUrl {
      get { return this.streamingUrlField; }
      set { this.streamingUrlField = value; }
    }

    public bool readyToPlayOnTheWeb {
      get { return this.readyToPlayOnTheWebField; }
      set {
        this.readyToPlayOnTheWebField = value;
        this.readyToPlayOnTheWebSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool readyToPlayOnTheWebSpecified {
      get { return this.readyToPlayOnTheWebFieldSpecified; }
      set { this.readyToPlayOnTheWebFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class MediaPage {
    private Media[] entriesField;

    private int totalNumEntriesField;

    private bool totalNumEntriesFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public Media[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }

    public int totalNumEntries {
      get { return this.totalNumEntriesField; }
      set {
        this.totalNumEntriesField = value;
        this.totalNumEntriesSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool totalNumEntriesSpecified {
      get { return this.totalNumEntriesFieldSpecified; }
      set { this.totalNumEntriesFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class VideoError : ApiError {
    private VideoErrorReason reasonField;

    private bool reasonFieldSpecified;

    public VideoErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "VideoError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum VideoErrorReason {
    INVALID_VIDEO,
    STORAGE_ERROR,
    BAD_REQUEST,
    ERROR_GENERATING_STREAMING_URL,
    UNEXPECTED_SIZE,
    SERVER_ERROR,
    FILE_TOO_LARGE,
    VIDEO_PROCESSING_ERROR,
    INVALID_INPUT,
    PROBLEM_READING_FILE,
    INVALID_ISCI,
    INVALID_AD_ID
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class MediaError : ApiError {
    private MediaErrorReason reasonField;

    private bool reasonFieldSpecified;

    public MediaErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "MediaError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum MediaErrorReason {
    CANNOT_ADD_STANDARD_ICON,
    CANNOT_SELECT_STANDARD_ICON_WITH_OTHER_TYPES,
    DUPLICATE_MEDIA,
    EMPTY_FIELD,
    ENTITY_REFERENCED_IN_MULTIPLE_OPS,
    FIELD_NOT_SUPPORTED_FOR_MEDIA_SUB_TYPE,
    INVALID_MEDIA_ID,
    INVALID_MEDIA_TYPE,
    INVALID_MEDIA_SUB_TYPE,
    INVALID_REFERENCE_ID,
    INVALID_YOU_TUBE_ID,
    YOU_TUBE_VIDEO_NOT_FOUND,
    YOU_TUBE_SERVICE_UNAVAILABLE,
    YOU_TUBE_VIDEO_HAS_NON_POSITIVE_DURATION,
    MEDIA_FAILED_TRANSCODING,
    MEDIA_TYPE_DOES_NOT_MATCH_OBJECT_TYPE,
    NO_FIELDS_SPECIFIED,
    NULL_REFERENCE_ID_AND_MEDIA_ID,
    TOO_LONG,
    UNSUPPORTED_OPERATION,
    UNSUPPORTED_TYPE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ImageError : ApiError {
    private ImageErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ImageErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ImageError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ImageErrorReason {
    INVALID_IMAGE,
    STORAGE_ERROR,
    BAD_REQUEST,
    UNEXPECTED_SIZE,
    ANIMATED_NOT_ALLOWED,
    ANIMATION_TOO_LONG,
    SERVER_ERROR,
    CMYK_JPEG_NOT_ALLOWED,
    FLASH_NOT_ALLOWED,
    FLASH_WITHOUT_CLICKTAG,
    ANIMATED_VISUAL_EFFECT,
    FLASH_ERROR,
    LAYOUT_PROBLEM,
    PROBLEM_READING_IMAGE_FILE,
    ERROR_STORING_IMAGE,
    FLASH_HAS_NETWORK_OBJECTS,
    FLASH_HAS_NETWORK_METHODS,
    FLASH_HAS_URL,
    FLASH_HAS_MOUSE_TRACKING,
    FLASH_HAS_RANDOM_NUM,
    FLASH_SELF_TARGETS,
    FLASH_BAD_GETURL_TARGET,
    FLASH_VERSION_NOT_SUPPORTED,
    FILE_TOO_LARGE,
    IMAGE_DATA_TOO_LARGE,
    IMAGE_PROCESSING_ERROR,
    IMAGE_TOO_SMALL,
    INVALID_INPUT,
    PROBLEM_READING_FILE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AudioError : ApiError {
    private AudioErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AudioErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AudioError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AudioErrorReason {
    INVALID_AUDIO,
    PROBLEM_READING_AUDIO_FILE,
    ERROR_STORING_AUDIO,
    FILE_TOO_LARGE,
    UNSUPPORTED_AUDIO,
    ERROR_GENERATING_STREAMING_URL
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "MutateJobServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class MutateJobService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public MutateJobService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201109/MutateJobService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual Job[] get(JobSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((Job[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual JobResult getResult(JobSelector selector) {
      object[] results = this.Invoke("getResult", new object[] {selector});
      return ((JobResult) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual SimpleMutateJob mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
Operation[] operations, BulkMutateJobPolicy policy) {
      object[] results = this.Invoke("mutate", new object[] {operations, policy});
      return ((SimpleMutateJob) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class SimpleMutateResult {
    private Operand[] resultsField;

    private ApiError[] errorsField;

    [System.Xml.Serialization.XmlElementAttribute("results")]
    public Operand[] results {
      get { return this.resultsField; }
      set { this.resultsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("errors")]
    public ApiError[] errors {
      get { return this.errorsField; }
      set { this.errorsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Operand {
    private object itemField;

    [System.Xml.Serialization.XmlElementAttribute("Ad", typeof(Ad))]
    [System.Xml.Serialization.XmlElementAttribute("AdExtensionOverride", typeof(AdExtensionOverride))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroup", typeof(AdGroup))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroupAd", typeof(AdGroupAd))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroupCriterion", typeof(AdGroupCriterion))]
    [System.Xml.Serialization.XmlElementAttribute("Campaign", typeof(Campaign))]
    [System.Xml.Serialization.XmlElementAttribute("CampaignAdExtension", typeof(CampaignAdExtension))]
    [System.Xml.Serialization.XmlElementAttribute("CampaignCriterion", typeof(CampaignCriterion))]
    [System.Xml.Serialization.XmlElementAttribute("Job", typeof(Job))]
    [System.Xml.Serialization.XmlElementAttribute("Media", typeof(Media))]
    [System.Xml.Serialization.XmlElementAttribute("PlaceHolder", typeof(PlaceHolder))]
    [System.Xml.Serialization.XmlElementAttribute("Target", typeof(Target))]
    [System.Xml.Serialization.XmlElementAttribute("TargetList", typeof(TargetList))]
    public object Item {
      get { return this.itemField; }
      set { this.itemField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TextAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemplateAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RichMediaAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThirdPartyRedirectAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MobileImageAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MobileAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeprecatedAd))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class Ad {
    private long idField;

    private bool idFieldSpecified;

    private string urlField;

    private string displayUrlField;

    private AdApprovalStatus approvalStatusField;

    private bool approvalStatusFieldSpecified;

    private string[] disapprovalReasonsField;

    private bool trademarkDisapprovedField;

    private bool trademarkDisapprovedFieldSpecified;

    private string adTypeField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public string url {
      get { return this.urlField; }
      set { this.urlField = value; }
    }

    public string displayUrl {
      get { return this.displayUrlField; }
      set { this.displayUrlField = value; }
    }

    public AdApprovalStatus approvalStatus {
      get { return this.approvalStatusField; }
      set {
        this.approvalStatusField = value;
        this.approvalStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool approvalStatusSpecified {
      get { return this.approvalStatusFieldSpecified; }
      set { this.approvalStatusFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("disapprovalReasons")]
    public string[] disapprovalReasons {
      get { return this.disapprovalReasonsField; }
      set { this.disapprovalReasonsField = value; }
    }

    public bool trademarkDisapproved {
      get { return this.trademarkDisapprovedField; }
      set {
        this.trademarkDisapprovedField = value;
        this.trademarkDisapprovedSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool trademarkDisapprovedSpecified {
      get { return this.trademarkDisapprovedFieldSpecified; }
      set { this.trademarkDisapprovedFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("Ad.Type")]
    public string AdType {
      get { return this.adTypeField; }
      set { this.adTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Ad.ApprovalStatus", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AdApprovalStatus {
    APPROVED,
    FAMILY_SAFE,
    NON_FAMILY_SAFE,
    PORN,
    UNCHECKED,
    DISAPPROVED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class TextAd : Ad {
    private string headlineField;

    private string description1Field;

    private string description2Field;

    public string headline {
      get { return this.headlineField; }
      set { this.headlineField = value; }
    }

    public string description1 {
      get { return this.description1Field; }
      set { this.description1Field = value; }
    }

    public string description2 {
      get { return this.description2Field; }
      set { this.description2Field = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class TemplateAd : Ad {
    private long templateIdField;

    private bool templateIdFieldSpecified;

    private AdUnionId adUnionIdField;

    private TemplateElement[] templateElementsField;

    private Dimensions dimensionsField;

    private string nameField;

    private int durationField;

    private bool durationFieldSpecified;

    public long templateId {
      get { return this.templateIdField; }
      set {
        this.templateIdField = value;
        this.templateIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool templateIdSpecified {
      get { return this.templateIdFieldSpecified; }
      set { this.templateIdFieldSpecified = value; }
    }

    public AdUnionId adUnionId {
      get { return this.adUnionIdField; }
      set { this.adUnionIdField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("templateElements")]
    public TemplateElement[] templateElements {
      get { return this.templateElementsField; }
      set { this.templateElementsField = value; }
    }

    public Dimensions dimensions {
      get { return this.dimensionsField; }
      set { this.dimensionsField = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public int duration {
      get { return this.durationField; }
      set {
        this.durationField = value;
        this.durationSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool durationSpecified {
      get { return this.durationFieldSpecified; }
      set { this.durationFieldSpecified = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TempAdUnionId))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdUnionId {
    private long idField;

    private bool idFieldSpecified;

    private string adUnionIdTypeField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("AdUnionId.Type")]
    public string AdUnionIdType {
      get { return this.adUnionIdTypeField; }
      set { this.adUnionIdTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class TempAdUnionId : AdUnionId {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class TemplateElement {
    private string uniqueNameField;

    private TemplateElementField[] fieldsField;

    public string uniqueName {
      get { return this.uniqueNameField; }
      set { this.uniqueNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("fields")]
    public TemplateElementField[] fields {
      get { return this.fieldsField; }
      set { this.fieldsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class TemplateElementField {
    private string nameField;

    private TemplateElementFieldType typeField;

    private bool typeFieldSpecified;

    private string fieldTextField;

    private Media fieldMediaField;

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public TemplateElementFieldType type {
      get { return this.typeField; }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get { return this.typeFieldSpecified; }
      set { this.typeFieldSpecified = value; }
    }

    public string fieldText {
      get { return this.fieldTextField; }
      set { this.fieldTextField = value; }
    }

    public Media fieldMedia {
      get { return this.fieldMediaField; }
      set { this.fieldMediaField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TemplateElementField.Type", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum TemplateElementFieldType {
    ADDRESS,
    AUDIO,
    ENUM,
    IMAGE,
    BACKGROUND_IMAGE,
    NUMBER,
    TEXT,
    URL,
    VIDEO,
    VISIBLE_URL
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThirdPartyRedirectAd))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public abstract partial class RichMediaAd : Ad {
    private string nameField;

    private Dimensions dimensionsField;

    private string snippetField;

    private string impressionBeaconUrlField;

    private long certifiedVendorFormatIdField;

    private bool certifiedVendorFormatIdFieldSpecified;

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public Dimensions dimensions {
      get { return this.dimensionsField; }
      set { this.dimensionsField = value; }
    }

    public string snippet {
      get { return this.snippetField; }
      set { this.snippetField = value; }
    }

    public string impressionBeaconUrl {
      get { return this.impressionBeaconUrlField; }
      set { this.impressionBeaconUrlField = value; }
    }

    public long certifiedVendorFormatId {
      get { return this.certifiedVendorFormatIdField; }
      set {
        this.certifiedVendorFormatIdField = value;
        this.certifiedVendorFormatIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool certifiedVendorFormatIdSpecified {
      get { return this.certifiedVendorFormatIdFieldSpecified; }
      set { this.certifiedVendorFormatIdFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ThirdPartyRedirectAd : RichMediaAd {
    private bool isCookieTargetedField;

    private bool isCookieTargetedFieldSpecified;

    private bool isUserInterestTargetedField;

    private bool isUserInterestTargetedFieldSpecified;

    private bool isTaggedField;

    private bool isTaggedFieldSpecified;

    private VideoType[] videoTypesField;

    public bool isCookieTargeted {
      get { return this.isCookieTargetedField; }
      set {
        this.isCookieTargetedField = value;
        this.isCookieTargetedSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isCookieTargetedSpecified {
      get { return this.isCookieTargetedFieldSpecified; }
      set { this.isCookieTargetedFieldSpecified = value; }
    }

    public bool isUserInterestTargeted {
      get { return this.isUserInterestTargetedField; }
      set {
        this.isUserInterestTargetedField = value;
        this.isUserInterestTargetedSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isUserInterestTargetedSpecified {
      get { return this.isUserInterestTargetedFieldSpecified; }
      set { this.isUserInterestTargetedFieldSpecified = value; }
    }

    public bool isTagged {
      get { return this.isTaggedField; }
      set {
        this.isTaggedField = value;
        this.isTaggedSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isTaggedSpecified {
      get { return this.isTaggedFieldSpecified; }
      set { this.isTaggedFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("videoTypes")]
    public VideoType[] videoTypes {
      get { return this.videoTypesField; }
      set { this.videoTypesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum VideoType {
    ADOBE,
    REALPLAYER,
    QUICKTIME,
    WINDOWSMEDIA
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ProductAd : Ad {
    private string promotionLineField;

    public string promotionLine {
      get { return this.promotionLineField; }
      set { this.promotionLineField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class MobileImageAd : Ad {
    private MarkupLanguageType[] markupLanguagesField;

    private string[] mobileCarriersField;

    private Image imageField;

    [System.Xml.Serialization.XmlElementAttribute("markupLanguages")]
    public MarkupLanguageType[] markupLanguages {
      get { return this.markupLanguagesField; }
      set { this.markupLanguagesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("mobileCarriers")]
    public string[] mobileCarriers {
      get { return this.mobileCarriersField; }
      set { this.mobileCarriersField = value; }
    }

    public Image image {
      get { return this.imageField; }
      set { this.imageField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum MarkupLanguageType {
    HTML,
    CHTML,
    XHTML,
    WML
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class MobileAd : Ad {
    private string headlineField;

    private string descriptionField;

    private MarkupLanguageType[] markupLanguagesField;

    private string[] mobileCarriersField;

    private string businessNameField;

    private string countryCodeField;

    private string phoneNumberField;

    public string headline {
      get { return this.headlineField; }
      set { this.headlineField = value; }
    }

    public string description {
      get { return this.descriptionField; }
      set { this.descriptionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("markupLanguages")]
    public MarkupLanguageType[] markupLanguages {
      get { return this.markupLanguagesField; }
      set { this.markupLanguagesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("mobileCarriers")]
    public string[] mobileCarriers {
      get { return this.mobileCarriersField; }
      set { this.mobileCarriersField = value; }
    }

    public string businessName {
      get { return this.businessNameField; }
      set { this.businessNameField = value; }
    }

    public string countryCode {
      get { return this.countryCodeField; }
      set { this.countryCodeField = value; }
    }

    public string phoneNumber {
      get { return this.phoneNumberField; }
      set { this.phoneNumberField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ImageAd : Ad {
    private Image imageField;

    private string nameField;

    private long adToCopyImageFromField;

    private bool adToCopyImageFromFieldSpecified;

    public Image image {
      get { return this.imageField; }
      set { this.imageField = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public long adToCopyImageFrom {
      get { return this.adToCopyImageFromField; }
      set {
        this.adToCopyImageFromField = value;
        this.adToCopyImageFromSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adToCopyImageFromSpecified {
      get { return this.adToCopyImageFromFieldSpecified; }
      set { this.adToCopyImageFromFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class DeprecatedAd : Ad {
    private string nameField;

    private DeprecatedAdType typeField;

    private bool typeFieldSpecified;

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public DeprecatedAdType type {
      get { return this.typeField; }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get { return this.typeFieldSpecified; }
      set { this.typeFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DeprecatedAd.Type", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum DeprecatedAdType {
    VIDEO,
    CLICK_TO_CALL,
    IN_STREAM_VIDEO,
    FROOGLE,
    TEXT_LINK,
    GADGET,
    PRINT,
    TEXT_WIDE,
    GADGET_TEMPLATE,
    TEXT_WITH_VIDEO,
    AUDIO,
    LOCAL_BUSINESS_AD,
    AUDIO_TEMPLATE,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignAdExtensionStats : Stats {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdStats : Stats {
    private double percentServedField;

    private bool percentServedFieldSpecified;

    public double percentServed {
      get { return this.percentServedField; }
      set {
        this.percentServedField = value;
        this.percentServedSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool percentServedSpecified {
      get { return this.percentServedFieldSpecified; }
      set { this.percentServedFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroup {
    private long idField;

    private bool idFieldSpecified;

    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private string campaignNameField;

    private string nameField;

    private AdGroupStatus statusField;

    private bool statusFieldSpecified;

    private AdGroupBids bidsField;

    private AdGroupExperimentData experimentDataField;

    private Stats statsField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    public string campaignName {
      get { return this.campaignNameField; }
      set { this.campaignNameField = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public AdGroupStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    public AdGroupBids bids {
      get { return this.bidsField; }
      set { this.bidsField = value; }
    }

    public AdGroupExperimentData experimentData {
      get { return this.experimentDataField; }
      set { this.experimentDataField = value; }
    }

    public Stats stats {
      get { return this.statsField; }
      set { this.statsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroup.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AdGroupStatus {
    ENABLED,
    PAUSED,
    DELETED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupExperimentData {
    private long experimentIdField;

    private bool experimentIdFieldSpecified;

    private ExperimentDeltaStatus experimentDeltaStatusField;

    private bool experimentDeltaStatusFieldSpecified;

    private ExperimentDataStatus experimentDataStatusField;

    private bool experimentDataStatusFieldSpecified;

    private AdGroupExperimentBidMultipliers experimentBidMultipliersField;

    public long experimentId {
      get { return this.experimentIdField; }
      set {
        this.experimentIdField = value;
        this.experimentIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool experimentIdSpecified {
      get { return this.experimentIdFieldSpecified; }
      set { this.experimentIdFieldSpecified = value; }
    }

    public ExperimentDeltaStatus experimentDeltaStatus {
      get { return this.experimentDeltaStatusField; }
      set {
        this.experimentDeltaStatusField = value;
        this.experimentDeltaStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool experimentDeltaStatusSpecified {
      get { return this.experimentDeltaStatusFieldSpecified; }
      set { this.experimentDeltaStatusFieldSpecified = value; }
    }

    public ExperimentDataStatus experimentDataStatus {
      get { return this.experimentDataStatusField; }
      set {
        this.experimentDataStatusField = value;
        this.experimentDataStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool experimentDataStatusSpecified {
      get { return this.experimentDataStatusFieldSpecified; }
      set { this.experimentDataStatusFieldSpecified = value; }
    }

    public AdGroupExperimentBidMultipliers experimentBidMultipliers {
      get { return this.experimentBidMultipliersField; }
      set { this.experimentBidMultipliersField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ExperimentDeltaStatus {
    EXPERIMENT_ONLY,
    MODIFIED,
    CONTROL_ONLY,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ExperimentDataStatus {
    ACTIVE,
    DELETED,
    UNKNOWN
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPMAdGroupExperimentBidMultipliers))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPCAdGroupExperimentBidMultipliers))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public abstract partial class AdGroupExperimentBidMultipliers {
    private string adGroupExperimentBidMultipliersTypeField;

    [System.Xml.Serialization.XmlElementAttribute("AdGroupExperimentBidMultipliers.Type")]
    public string AdGroupExperimentBidMultipliersType {
      get { return this.adGroupExperimentBidMultipliersTypeField; }
      set { this.adGroupExperimentBidMultipliersTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ManualCPMAdGroupExperimentBidMultipliers : AdGroupExperimentBidMultipliers {
    private BidMultiplier maxCpmMultiplierField;

    public BidMultiplier maxCpmMultiplier {
      get { return this.maxCpmMultiplierField; }
      set { this.maxCpmMultiplierField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BidMultiplier {
    private double multiplierField;

    private bool multiplierFieldSpecified;

    private Bid multipliedBidField;

    public double multiplier {
      get { return this.multiplierField; }
      set {
        this.multiplierField = value;
        this.multiplierSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool multiplierSpecified {
      get { return this.multiplierFieldSpecified; }
      set { this.multiplierFieldSpecified = value; }
    }

    public Bid multipliedBid {
      get { return this.multipliedBidField; }
      set { this.multipliedBidField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ManualCPCAdGroupExperimentBidMultipliers : AdGroupExperimentBidMultipliers {
    private BidMultiplier maxCpcMultiplierField;

    private BidMultiplier maxContentCpcMultiplierField;

    public BidMultiplier maxCpcMultiplier {
      get { return this.maxCpcMultiplierField; }
      set { this.maxCpcMultiplierField = value; }
    }

    public BidMultiplier maxContentCpcMultiplier {
      get { return this.maxContentCpcMultiplierField; }
      set { this.maxContentCpcMultiplierField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupAd {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private Ad adField;

    private AdGroupAdExperimentData experimentDataField;

    private AdGroupAdStatus statusField;

    private bool statusFieldSpecified;

    private AdStats statsField;

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }

    public Ad ad {
      get { return this.adField; }
      set { this.adField = value; }
    }

    public AdGroupAdExperimentData experimentData {
      get { return this.experimentDataField; }
      set { this.experimentDataField = value; }
    }

    public AdGroupAdStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    public AdStats stats {
      get { return this.statsField; }
      set { this.statsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupAdExperimentData {
    private long experimentIdField;

    private bool experimentIdFieldSpecified;

    private ExperimentDeltaStatus experimentDeltaStatusField;

    private bool experimentDeltaStatusFieldSpecified;

    private ExperimentDataStatus experimentDataStatusField;

    private bool experimentDataStatusFieldSpecified;

    public long experimentId {
      get { return this.experimentIdField; }
      set {
        this.experimentIdField = value;
        this.experimentIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool experimentIdSpecified {
      get { return this.experimentIdFieldSpecified; }
      set { this.experimentIdFieldSpecified = value; }
    }

    public ExperimentDeltaStatus experimentDeltaStatus {
      get { return this.experimentDeltaStatusField; }
      set {
        this.experimentDeltaStatusField = value;
        this.experimentDeltaStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool experimentDeltaStatusSpecified {
      get { return this.experimentDeltaStatusFieldSpecified; }
      set { this.experimentDeltaStatusFieldSpecified = value; }
    }

    public ExperimentDataStatus experimentDataStatus {
      get { return this.experimentDataStatusField; }
      set {
        this.experimentDataStatusField = value;
        this.experimentDataStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool experimentDataStatusSpecified {
      get { return this.experimentDataStatusFieldSpecified; }
      set { this.experimentDataStatusFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupAd.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AdGroupAdStatus {
    ENABLED,
    PAUSED,
    DISABLED
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NegativeAdGroupCriterion))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BiddableAdGroupCriterion))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupCriterion {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private CriterionUse criterionUseField;

    private bool criterionUseFieldSpecified;

    private Criterion criterionField;

    private string adGroupCriterionTypeField;

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }

    public CriterionUse criterionUse {
      get { return this.criterionUseField; }
      set {
        this.criterionUseField = value;
        this.criterionUseSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool criterionUseSpecified {
      get { return this.criterionUseFieldSpecified; }
      set { this.criterionUseFieldSpecified = value; }
    }

    public Criterion criterion {
      get { return this.criterionField; }
      set { this.criterionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("AdGroupCriterion.Type")]
    public string AdGroupCriterionType {
      get { return this.adGroupCriterionTypeField; }
      set { this.adGroupCriterionTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum CriterionUse {
    BIDDABLE,
    NEGATIVE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class NegativeAdGroupCriterion : AdGroupCriterion {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BiddableAdGroupCriterion : AdGroupCriterion {
    private UserStatus userStatusField;

    private bool userStatusFieldSpecified;

    private SystemServingStatus systemServingStatusField;

    private bool systemServingStatusFieldSpecified;

    private ApprovalStatus approvalStatusField;

    private bool approvalStatusFieldSpecified;

    private string destinationUrlField;

    private AdGroupCriterionBids bidsField;

    private BiddableAdGroupCriterionExperimentData experimentDataField;

    private Bid firstPageCpcField;

    private QualityInfo qualityInfoField;

    private Stats statsField;

    public UserStatus userStatus {
      get { return this.userStatusField; }
      set {
        this.userStatusField = value;
        this.userStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool userStatusSpecified {
      get { return this.userStatusFieldSpecified; }
      set { this.userStatusFieldSpecified = value; }
    }

    public SystemServingStatus systemServingStatus {
      get { return this.systemServingStatusField; }
      set {
        this.systemServingStatusField = value;
        this.systemServingStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool systemServingStatusSpecified {
      get { return this.systemServingStatusFieldSpecified; }
      set { this.systemServingStatusFieldSpecified = value; }
    }

    public ApprovalStatus approvalStatus {
      get { return this.approvalStatusField; }
      set {
        this.approvalStatusField = value;
        this.approvalStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool approvalStatusSpecified {
      get { return this.approvalStatusFieldSpecified; }
      set { this.approvalStatusFieldSpecified = value; }
    }

    public string destinationUrl {
      get { return this.destinationUrlField; }
      set { this.destinationUrlField = value; }
    }

    public AdGroupCriterionBids bids {
      get { return this.bidsField; }
      set { this.bidsField = value; }
    }

    public BiddableAdGroupCriterionExperimentData experimentData {
      get { return this.experimentDataField; }
      set { this.experimentDataField = value; }
    }

    public Bid firstPageCpc {
      get { return this.firstPageCpcField; }
      set { this.firstPageCpcField = value; }
    }

    public QualityInfo qualityInfo {
      get { return this.qualityInfoField; }
      set { this.qualityInfoField = value; }
    }

    public Stats stats {
      get { return this.statsField; }
      set { this.statsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum UserStatus {
    ACTIVE,
    DELETED,
    PAUSED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum SystemServingStatus {
    ELIGIBLE,
    RARELY_SERVED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ApprovalStatus {
    APPROVED,
    PENDING_REVIEW,
    UNDER_REVIEW,
    DISAPPROVED
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PercentCPAAdGroupCriterionBids))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPMAdGroupCriterionBids))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPCAdGroupCriterionBids))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionOptimizerAdGroupCriterionBids))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BudgetOptimizerAdGroupCriterionBids))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public abstract partial class AdGroupCriterionBids {
    private string adGroupCriterionBidsTypeField;

    [System.Xml.Serialization.XmlElementAttribute("AdGroupCriterionBids.Type")]
    public string AdGroupCriterionBidsType {
      get { return this.adGroupCriterionBidsTypeField; }
      set { this.adGroupCriterionBidsTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class PercentCPAAdGroupCriterionBids : AdGroupCriterionBids {
    private int percentCpaField;

    private bool percentCpaFieldSpecified;

    private BidSource sourceField;

    private bool sourceFieldSpecified;

    public int percentCpa {
      get { return this.percentCpaField; }
      set {
        this.percentCpaField = value;
        this.percentCpaSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool percentCpaSpecified {
      get { return this.percentCpaFieldSpecified; }
      set { this.percentCpaFieldSpecified = value; }
    }

    public BidSource source {
      get { return this.sourceField; }
      set {
        this.sourceField = value;
        this.sourceSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool sourceSpecified {
      get { return this.sourceFieldSpecified; }
      set { this.sourceFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum BidSource {
    ADGROUP,
    CRITERION
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ManualCPMAdGroupCriterionBids : AdGroupCriterionBids {
    private Bid maxCpmField;

    private BidSource bidSourceField;

    private bool bidSourceFieldSpecified;

    public Bid maxCpm {
      get { return this.maxCpmField; }
      set { this.maxCpmField = value; }
    }

    public BidSource bidSource {
      get { return this.bidSourceField; }
      set {
        this.bidSourceField = value;
        this.bidSourceSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool bidSourceSpecified {
      get { return this.bidSourceFieldSpecified; }
      set { this.bidSourceFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ManualCPCAdGroupCriterionBids : AdGroupCriterionBids {
    private Bid maxCpcField;

    private BidSource bidSourceField;

    private bool bidSourceFieldSpecified;

    private bool enhancedCpcEnabledField;

    private bool enhancedCpcEnabledFieldSpecified;

    public Bid maxCpc {
      get { return this.maxCpcField; }
      set { this.maxCpcField = value; }
    }

    public BidSource bidSource {
      get { return this.bidSourceField; }
      set {
        this.bidSourceField = value;
        this.bidSourceSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool bidSourceSpecified {
      get { return this.bidSourceFieldSpecified; }
      set { this.bidSourceFieldSpecified = value; }
    }

    public bool enhancedCpcEnabled {
      get { return this.enhancedCpcEnabledField; }
      set {
        this.enhancedCpcEnabledField = value;
        this.enhancedCpcEnabledSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool enhancedCpcEnabledSpecified {
      get { return this.enhancedCpcEnabledFieldSpecified; }
      set { this.enhancedCpcEnabledFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ConversionOptimizerAdGroupCriterionBids : AdGroupCriterionBids {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BudgetOptimizerAdGroupCriterionBids : AdGroupCriterionBids {
    private Bid proxyBidField;

    private bool enhancedCpcEnabledField;

    private bool enhancedCpcEnabledFieldSpecified;

    public Bid proxyBid {
      get { return this.proxyBidField; }
      set { this.proxyBidField = value; }
    }

    public bool enhancedCpcEnabled {
      get { return this.enhancedCpcEnabledField; }
      set {
        this.enhancedCpcEnabledField = value;
        this.enhancedCpcEnabledSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool enhancedCpcEnabledSpecified {
      get { return this.enhancedCpcEnabledFieldSpecified; }
      set { this.enhancedCpcEnabledFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BiddableAdGroupCriterionExperimentData {
    private long experimentIdField;

    private bool experimentIdFieldSpecified;

    private ExperimentDeltaStatus experimentDeltaStatusField;

    private bool experimentDeltaStatusFieldSpecified;

    private ExperimentDataStatus experimentDataStatusField;

    private bool experimentDataStatusFieldSpecified;

    private AdGroupCriterionExperimentBidMultiplier experimentBidMultiplierField;

    public long experimentId {
      get { return this.experimentIdField; }
      set {
        this.experimentIdField = value;
        this.experimentIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool experimentIdSpecified {
      get { return this.experimentIdFieldSpecified; }
      set { this.experimentIdFieldSpecified = value; }
    }

    public ExperimentDeltaStatus experimentDeltaStatus {
      get { return this.experimentDeltaStatusField; }
      set {
        this.experimentDeltaStatusField = value;
        this.experimentDeltaStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool experimentDeltaStatusSpecified {
      get { return this.experimentDeltaStatusFieldSpecified; }
      set { this.experimentDeltaStatusFieldSpecified = value; }
    }

    public ExperimentDataStatus experimentDataStatus {
      get { return this.experimentDataStatusField; }
      set {
        this.experimentDataStatusField = value;
        this.experimentDataStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool experimentDataStatusSpecified {
      get { return this.experimentDataStatusFieldSpecified; }
      set { this.experimentDataStatusFieldSpecified = value; }
    }

    public AdGroupCriterionExperimentBidMultiplier experimentBidMultiplier {
      get { return this.experimentBidMultiplierField; }
      set { this.experimentBidMultiplierField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPCAdGroupCriterionExperimentBidMultiplier))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public abstract partial class AdGroupCriterionExperimentBidMultiplier {
    private string adGroupCriterionExperimentBidMultiplierTypeField;

    [System.Xml.Serialization.XmlElementAttribute("AdGroupCriterionExperimentBidMultiplier.Type")]
    public string AdGroupCriterionExperimentBidMultiplierType {
      get { return this.adGroupCriterionExperimentBidMultiplierTypeField; }
      set { this.adGroupCriterionExperimentBidMultiplierTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ManualCPCAdGroupCriterionExperimentBidMultiplier : AdGroupCriterionExperimentBidMultiplier {
    private BidMultiplier maxCpcMultiplierField;

    private MultiplierSource multiplierSourceField;

    private bool multiplierSourceFieldSpecified;

    public BidMultiplier maxCpcMultiplier {
      get { return this.maxCpcMultiplierField; }
      set { this.maxCpcMultiplierField = value; }
    }

    public MultiplierSource multiplierSource {
      get { return this.multiplierSourceField; }
      set {
        this.multiplierSourceField = value;
        this.multiplierSourceSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool multiplierSourceSpecified {
      get { return this.multiplierSourceFieldSpecified; }
      set { this.multiplierSourceFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum MultiplierSource {
    ADGROUP,
    CRITERION,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class QualityInfo {
    private bool isKeywordAdRelevanceAcceptableField;

    private bool isKeywordAdRelevanceAcceptableFieldSpecified;

    private bool isLandingPageQualityAcceptableField;

    private bool isLandingPageQualityAcceptableFieldSpecified;

    private bool isLandingPageLatencyAcceptableField;

    private bool isLandingPageLatencyAcceptableFieldSpecified;

    private int qualityScoreField;

    private bool qualityScoreFieldSpecified;

    public bool isKeywordAdRelevanceAcceptable {
      get { return this.isKeywordAdRelevanceAcceptableField; }
      set {
        this.isKeywordAdRelevanceAcceptableField = value;
        this.isKeywordAdRelevanceAcceptableSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isKeywordAdRelevanceAcceptableSpecified {
      get { return this.isKeywordAdRelevanceAcceptableFieldSpecified; }
      set { this.isKeywordAdRelevanceAcceptableFieldSpecified = value; }
    }

    public bool isLandingPageQualityAcceptable {
      get { return this.isLandingPageQualityAcceptableField; }
      set {
        this.isLandingPageQualityAcceptableField = value;
        this.isLandingPageQualityAcceptableSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isLandingPageQualityAcceptableSpecified {
      get { return this.isLandingPageQualityAcceptableFieldSpecified; }
      set { this.isLandingPageQualityAcceptableFieldSpecified = value; }
    }

    public bool isLandingPageLatencyAcceptable {
      get { return this.isLandingPageLatencyAcceptableField; }
      set {
        this.isLandingPageLatencyAcceptableField = value;
        this.isLandingPageLatencyAcceptableSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isLandingPageLatencyAcceptableSpecified {
      get { return this.isLandingPageLatencyAcceptableFieldSpecified; }
      set { this.isLandingPageLatencyAcceptableFieldSpecified = value; }
    }

    public int qualityScore {
      get { return this.qualityScoreField; }
      set {
        this.qualityScoreField = value;
        this.qualityScoreSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool qualityScoreSpecified {
      get { return this.qualityScoreFieldSpecified; }
      set { this.qualityScoreFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignAdExtension {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private AdExtension adExtensionField;

    private CampaignAdExtensionStatus statusField;

    private bool statusFieldSpecified;

    private CampaignAdExtensionApprovalStatus approvalStatusField;

    private bool approvalStatusFieldSpecified;

    private CampaignAdExtensionStats statsField;

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    public AdExtension adExtension {
      get { return this.adExtensionField; }
      set { this.adExtensionField = value; }
    }

    public CampaignAdExtensionStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    public CampaignAdExtensionApprovalStatus approvalStatus {
      get { return this.approvalStatusField; }
      set {
        this.approvalStatusField = value;
        this.approvalStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool approvalStatusSpecified {
      get { return this.approvalStatusFieldSpecified; }
      set { this.approvalStatusFieldSpecified = value; }
    }

    public CampaignAdExtensionStats stats {
      get { return this.statsField; }
      set { this.statsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignAdExtension.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum CampaignAdExtensionStatus {
    ACTIVE,
    DELETED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignAdExtension.ApprovalStatus", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum CampaignAdExtensionApprovalStatus {
    APPROVED,
    UNCHECKED,
    DISAPPROVED
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SimpleMutateJob))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BulkMutateJob))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public abstract partial class Job {
    private string customerJobKeyField;

    private ApiErrorReason failureReasonField;

    private JobStats statsField;

    private BillingSummary billingSummaryField;

    private string jobTypeField;

    public string customerJobKey {
      get { return this.customerJobKeyField; }
      set { this.customerJobKeyField = value; }
    }

    public ApiErrorReason failureReason {
      get { return this.failureReasonField; }
      set { this.failureReasonField = value; }
    }

    public JobStats stats {
      get { return this.statsField; }
      set { this.statsField = value; }
    }

    public BillingSummary billingSummary {
      get { return this.billingSummaryField; }
      set { this.billingSummaryField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("Job.Type")]
    public string JobType {
      get { return this.jobTypeField; }
      set { this.jobTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ApiErrorReason {
    private object itemField;

    [System.Xml.Serialization.XmlElementAttribute("AdErrorReason", typeof(AdErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("AdExtensionErrorReason", typeof(AdExtensionErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("AdExtensionOverrideErrorReason", typeof(AdExtensionOverrideErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroupAdErrorReason", typeof(AdGroupAdErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroupCriterionErrorReason", typeof(AdGroupCriterionErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroupServiceErrorReason", typeof(AdGroupServiceErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("AuthenticationErrorReason", typeof(AuthenticationErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("AuthorizationErrorReason", typeof(AuthorizationErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("BiddingErrorReason", typeof(BiddingErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("BiddingTransitionErrorReason", typeof(BiddingTransitionErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("BudgetErrorReason", typeof(BudgetErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("BulkMutateJobErrorReason", typeof(BulkMutateJobErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("CampaignAdExtensionErrorReason", typeof(CampaignAdExtensionErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("CampaignCriterionErrorReason", typeof(CampaignCriterionErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("CampaignErrorReason", typeof(CampaignErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("ClientTermsErrorReason", typeof(ClientTermsErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("CriterionErrorReason", typeof(CriterionErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("DatabaseErrorReason", typeof(DatabaseErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("DateErrorReason", typeof(DateErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("DistinctErrorReason", typeof(DistinctErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("EntityAccessDeniedReason", typeof(EntityAccessDeniedReason))]
    [System.Xml.Serialization.XmlElementAttribute("EntityCountLimitExceededReason", typeof(EntityCountLimitExceededReason))]
    [System.Xml.Serialization.XmlElementAttribute("EntityNotFoundReason", typeof(EntityNotFoundReason))]
    [System.Xml.Serialization.XmlElementAttribute("IdErrorReason", typeof(IdErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("ImageErrorReason", typeof(ImageErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("InternalApiErrorReason", typeof(InternalApiErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("JobErrorReason", typeof(JobErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("MediaErrorReason", typeof(MediaErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("NewEntityCreationErrorReason", typeof(NewEntityCreationErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("NotEmptyErrorReason", typeof(NotEmptyErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("NotWhitelistedErrorReason", typeof(NotWhitelistedErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("NullErrorReason", typeof(NullErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("OperationAccessDeniedReason", typeof(OperationAccessDeniedReason))]
    [System.Xml.Serialization.XmlElementAttribute("OperatorErrorReason", typeof(OperatorErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("PagingErrorReason", typeof(PagingErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("PolicyViolationErrorReason", typeof(PolicyViolationErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("QuotaCheckErrorReason", typeof(QuotaCheckErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("QuotaErrorReason", typeof(QuotaErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("QuotaExceededErrorReason", typeof(QuotaExceededErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("RangeErrorReason", typeof(RangeErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("RateExceededErrorReason", typeof(RateExceededErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("ReadOnlyErrorReason", typeof(ReadOnlyErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("RegionCodeErrorReason", typeof(RegionCodeErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("RejectedErrorReason", typeof(RejectedErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("RequestErrorReason", typeof(RequestErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("RequiredErrorReason", typeof(RequiredErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("SelectorErrorReason", typeof(SelectorErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("SettingErrorReason", typeof(SettingErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("SizeLimitErrorReason", typeof(SizeLimitErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("StatsQueryErrorReason", typeof(StatsQueryErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("StringLengthErrorReason", typeof(StringLengthErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("TargetErrorReason", typeof(TargetErrorReason))]
    public object Item {
      get { return this.itemField; }
      set { this.itemField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AdErrorReason {
    APPROXIMATELY_TOO_LONG,
    APPROXIMATELY_TOO_SHORT,
    BAD_SNIPPET,
    CANNOT_SET_BUSINESS_NAME_IF_URL_SET,
    CANNOT_SET_URL,
    CUSTOMER_NOT_APPROVED_MOBILEADS,
    CUSTOMER_NOT_APPROVED_THIRDPARTY_ADS,
    CUSTOMER_NOT_APPROVED_THIRDPARTY_REDIRECT_ADS,
    CUSTOMER_NOT_ELIGIBLE_FOR_UPDATING_BEACON_URL,
    DIMENSION_ALREADY_IN_UNION,
    DIMENSION_MUST_BE_SET,
    DIMENSION_NOT_IN_UNION,
    DISPLAY_URL_CANNOT_BE_SPECIFIED,
    DOMESTIC_PHONE_NUMBER_FORMAT,
    EMERGENCY_PHONE_NUMBER,
    EMPTY_FIELD,
    INCONSISTENT_STATUS_IN_TEMPLATE_UNION,
    INCORRECT_LENGTH,
    INVALID_AD_ADDRESS_CAMPAIGN_TARGET,
    INVALID_AD_TYPE,
    INVALID_ATTRIBUTES_FOR_MOBILE_IMAGE,
    INVALID_ATTRIBUTES_FOR_MOBILE_TEXT,
    INVALID_COUNTRY_CODE,
    INVALID_INPUT,
    INVALID_MARKUP_LANGUAGE,
    INVALID_MOBILE_CARRIER,
    INVALID_MOBILE_CARRIER_TARGET,
    INVALID_NUMBER_OF_ELEMENTS,
    INVALID_PHONE_NUMBER_FORMAT,
    INVALID_RICH_MEDIA_CERTIFIED_VENDOR_FORMAT_ID,
    INVALID_TEMPLATE_DATA,
    INVALID_TEMPLATE_ELEMENT_FIELD_TYPE,
    INVALID_TEMPLATE_ID,
    LINE_TOO_WIDE,
    MARKUP_LANGUAGES_PRESENT,
    MISSING_ADDRESS_COMPONENT,
    MISSING_ADVERTISEMENT_NAME,
    MISSING_BUSINESS_NAME,
    MISSING_DESCRIPTION1,
    MISSING_DESCRIPTION2,
    MISSING_DESTINATION_URL,
    MISSING_DIMENSION,
    MISSING_DISPLAY_URL,
    MISSING_HEADLINE,
    MISSING_HEIGHT,
    MISSING_IMAGE,
    MISSING_MARKUP_LANGUAGES,
    MISSING_MOBILE_CARRIER,
    MISSING_PHONE,
    MISSING_REQUIRED_TEMPLATE_FIELDS,
    MISSING_TEMPLATE_FIELD_VALUE,
    MISSING_TEXT,
    MISSING_URL_AND_PHONE,
    MISSING_VISIBLE_URL,
    MISSING_WIDTH,
    MUST_USE_TEMP_AD_UNION_ID_ON_ADD,
    TOO_LONG,
    TOO_SHORT,
    UNION_DIMENSIONS_CANNOT_CHANGE,
    UNKNOWN_ADDRESS_COMPONENT,
    UNKNOWN_FIELD_NAME,
    UNKNOWN_UNIQUE_NAME,
    UNSUPPORTED_DIMENSIONS,
    URL_INVALID_SCHEME,
    URL_INVALID_TOP_LEVEL_DOMAIN,
    URL_MALFORMED,
    URL_NO_HOST,
    URL_HOST_NAME_TOO_LONG,
    URL_NO_SCHEME,
    URL_NO_TOP_LEVEL_DOMAIN,
    URL_PATH_NOT_ALLOWED,
    URL_PORT_NOT_ALLOWED,
    URL_QUERY_NOT_ALLOWED,
    USER_DOES_NOT_HAVE_ACCESS_TO_TEMPLATE,
    INVALID_FORMAT,
    ELEMENT_NOT_PRESENT,
    IMAGE_ERROR,
    VALUE_NOT_IN_RANGE,
    FIELD_NOT_PRESENT,
    ADDRESS_NOT_COMPLETE,
    ADDRESS_INVALID,
    VIDEO_RETRIEVAL_ERROR,
    AUDIO_ERROR,
    INVALID_YOUTUBE_DISPLAY_URL
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdExtensionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AdExtensionErrorReason {
    ACCOUNT_DELETED,
    AD_EXTENSION_NO_LONGER_ACTIVE,
    CANNOT_HAVE_MULTIPLE_LOCATION_SYNC_EXTENSIONS_PER_CAMPAIGN,
    CANNOT_HAVE_MULTIPLE_MOBILE_EXTENSIONS_PER_CAMPAIGN,
    CANNOT_HAVE_MULTIPLE_PRODUCT_EXTENSIONS_PER_CAMPAIGN,
    CANNOT_HAVE_MULTIPLE_SITELINKS_EXTENSIONS_PER_CAMPAIGN,
    INVALID_AUTH_TOKEN_FOR_EMAIL,
    INVALID_COUNTRY_CODE,
    INVALID_DOMESTIC_PHONE_NUMBER_FORMAT,
    INVALID_DESTINATION_URL,
    INVALID_EMAIL,
    INVALID_ENCODED_LOCATION,
    INVALID_ENUM_CONDITION_OPERATOR,
    INVALID_ICON_DIMENSIONS,
    INVALID_ID,
    INVALID_IMAGE_DIMENSIONS,
    INVALID_INPUT,
    INVALID_LATITUDE,
    INVALID_LONGITUDE,
    INVALID_PHONE_NUMBER,
    INVALID_STRING_CONDITION_OPERATOR,
    INVALID_TOLL_PHONE_NUMBER_FORMAT,
    MEDIA_DOES_NOT_BELONG_TO_ACCOUNT,
    MEDIA_NOT_ICON_TYPE,
    MEDIA_NOT_IMAGE_TYPE,
    MISSING_ADVERTISER_NAME,
    MISSING_AUTH_TOKEN,
    MISSING_COUNTRY_CODE,
    MISSING_CITY_NAME,
    MISSING_EMAIL,
    MISSING_ENCODED_LOCATION,
    MISSING_CONDITION_OPERAND,
    MISSING_CONDITION_STRING_VALUE,
    MISSING_POSTAL_CODE,
    MISSING_STREET_ADDRESS,
    NUM_AND_GROUPS_OVER_LIMIT,
    NUM_CONDITIONS_OVER_LIMIT,
    NUM_LOCATION_EXTENSIONS_OVER_LIMIT,
    NOT_AUTHORIZED_TO_CREATE_EXTENSION,
    PHONE_NUMBER_NOT_SUPPORTED_FOR_COUNTRY,
    DISALLOWED_NUMBER_TYPE,
    PREMIUM_RATE_NUMBER_NOT_ALLOWED,
    TOO_LONG,
    USER_NOT_PERMITTED_TO_CREATE_LBC_SYNC_LOCATION_EXTENSION
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupAdError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AdGroupAdErrorReason {
    AD_NOT_UNDER_ADGROUP,
    CANNOT_OPERATE_ON_DELETED_ADGROUPAD,
    CANNOT_CREATE_DEPRECATED_ADS,
    EMPTY_FIELD,
    ENTITY_REFERENCED_IN_MULTIPLE_OPS,
    UNSUPPORTED_OPERATION
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupCriterionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AdGroupCriterionErrorReason {
    INVALID_ID_FILTER_TYPE,
    ID_FILTERS_HAVE_DIFF_FIELDS_SET,
    INAPPLICABLE_FOR_NEGATIVE,
    INAPPLICABLE_FILTER_SPECIFIED,
    TOO_MANY_OPERTAIONS,
    CANT_UPDATE_NEGATIVE,
    TYPE_MISMATCH,
    CONCRETE_TYPE_REQUIRED,
    BID_INCOMPATIBLE_WITH_ADGROUP,
    NETWORK_NOT_OVERRIDABLE,
    CURRENCY_MISMATCH,
    CRITERION_NOT_TARGETED,
    CANNOT_TARGET_AND_EXCLUDE,
    ILLEGAL_URL,
    INVALID_VERTICAL_PATH,
    NO_EFFECTIVE_BID_FOR_THIS_CRITERION,
    INVALID_KEYWORD_TEXT,
    INVALID_DESTINATION_URL,
    KEYWORD_LEVEL_BID_NOT_SUPPORTED_FOR_MANUALCPM,
    INVALID_USER_STATUS,
    CANNOT_ADD_CRITERIA_TYPE,
    CANNOT_EXCLUDE_CRITERIA_TYPE,
    PRODUCT_FILTER_TOO_LONG,
    INVALID_PRODUCT_FILTER,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupServiceError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AdGroupServiceErrorReason {
    DUPLICATE_ADGROUP_NAME,
    INVALID_ADGROUP_ID,
    INVALID_ADGROUP_NAME,
    USE_SET_OPERATOR_AND_MARK_STATUS_TO_DELETED,
    ADVERTISER_NOT_ON_CONTENT_NETWORK,
    BID_TOO_BIG,
    BID_TOO_SMALL,
    BID_TYPE_AND_BIDDING_STRATEGY_MISMATCH,
    INVALID_BID,
    MISSING_ADGROUP_NAME
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BulkMutateJobError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum BulkMutateJobErrorReason {
    CAN_RETURN_RESULT_FOR_ONLY_COMPLETED_JOBS,
    CAN_RETURN_RESULT_FOR_ONLY_ONE_JOB,
    CANNOT_UPDATE_JOB_ONCE_ALL_REQUEST_PARTS_ARE_RECEIVED,
    INVALID_SCOPING_ENTITY_TYPE,
    MISSING_SCOPING_ENTITY_FOR_OPERATION_STREAM,
    MORE_THAN_ONE_SCOPING_ENTITY_TYPE,
    PAYLOAD_STORE_UNAVAILABLE,
    REQUEST_PART_IS_OUT_OF_ORDER,
    TOO_FEW_OPERATIONS_IN_JOB,
    TOO_MANY_OPERATION_STREAMS_IN_REQUEST_PART,
    TOO_MANY_OPERATIONS_IN_JOB,
    TOO_MANY_OPERATIONS_IN_REQUEST_PART,
    TOO_MANY_RESULTS_TO_STORE,
    TOO_MANY_SCOPING_ENTITIES,
    UNKNOWN,
    LOST_RESULT,
    UNPROCESSED_RESULT,
    BATCH_FAILURE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignAdExtensionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum CampaignAdExtensionErrorReason {
    ADEXTENSION_NOT_UNDER_CAMPAIGN,
    CANNOT_ADD_DELETED_CAMPAIGN_ADEXTENSION,
    CANNOT_OPERATE_ON_DELETED_CAMPAIGN_ADEXTENSION,
    INVALID_ADEXTENSION_ID,
    MISSING_ADEXTENSION_ID,
    MUST_USE_CONCRETE_ADEXTENSION_DURING_ADD,
    MUST_USE_CONCRETE_ADEXTENSION,
    UNKNOWN_ERROR
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EntityAccessDenied.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum EntityAccessDeniedReason {
    READ_ACCESS_DENIED,
    WRITE_ACCESS_DENIED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IdError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum IdErrorReason {
    NOT_FOUND
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "JobError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum JobErrorReason {
    DUPLICATE_JOB_KEY_FOR_CUSTOMER,
    JOB_TYPE_NOT_SUPPORTED,
    PREREQUISITE_JOB_FAILED,
    SELECTOR_CANNOT_USE_BOTH_JOB_IDS_AND_JOB_KEYS,
    TOO_LATE_TO_CANCEL_JOB,
    TOO_MANY_PREREQUISITE_JOBS,
    TOO_MANY_JOBS_IN_QUEUE,
    USER_CANCELED_JOB,
    WORKFLOW_FAILURE,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PolicyViolationError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum PolicyViolationErrorReason {
    POLICY_ERROR
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "QuotaExceededError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum QuotaExceededErrorReason {
    QUOTA_EXCEEDED
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BulkMutateJobStats))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class JobStats {
    private int progressPercentField;

    private bool progressPercentFieldSpecified;

    private long pendingTimeMillisField;

    private bool pendingTimeMillisFieldSpecified;

    private long processingTimeMillisField;

    private bool processingTimeMillisFieldSpecified;

    private string jobStatsTypeField;

    public int progressPercent {
      get { return this.progressPercentField; }
      set {
        this.progressPercentField = value;
        this.progressPercentSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool progressPercentSpecified {
      get { return this.progressPercentFieldSpecified; }
      set { this.progressPercentFieldSpecified = value; }
    }

    public long pendingTimeMillis {
      get { return this.pendingTimeMillisField; }
      set {
        this.pendingTimeMillisField = value;
        this.pendingTimeMillisSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool pendingTimeMillisSpecified {
      get { return this.pendingTimeMillisFieldSpecified; }
      set { this.pendingTimeMillisFieldSpecified = value; }
    }

    public long processingTimeMillis {
      get { return this.processingTimeMillisField; }
      set {
        this.processingTimeMillisField = value;
        this.processingTimeMillisSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool processingTimeMillisSpecified {
      get { return this.processingTimeMillisFieldSpecified; }
      set { this.processingTimeMillisFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("JobStats.Type")]
    public string JobStatsType {
      get { return this.jobStatsTypeField; }
      set { this.jobStatsTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BulkMutateJobStats : JobStats {
    private int numOperationsField;

    private bool numOperationsFieldSpecified;

    private int numFailedOperationsField;

    private bool numFailedOperationsFieldSpecified;

    private int numUnprocessedOperationsField;

    private bool numUnprocessedOperationsFieldSpecified;

    public int numOperations {
      get { return this.numOperationsField; }
      set {
        this.numOperationsField = value;
        this.numOperationsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numOperationsSpecified {
      get { return this.numOperationsFieldSpecified; }
      set { this.numOperationsFieldSpecified = value; }
    }

    public int numFailedOperations {
      get { return this.numFailedOperationsField; }
      set {
        this.numFailedOperationsField = value;
        this.numFailedOperationsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numFailedOperationsSpecified {
      get { return this.numFailedOperationsFieldSpecified; }
      set { this.numFailedOperationsFieldSpecified = value; }
    }

    public int numUnprocessedOperations {
      get { return this.numUnprocessedOperationsField; }
      set {
        this.numUnprocessedOperationsField = value;
        this.numUnprocessedOperationsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numUnprocessedOperationsSpecified {
      get { return this.numUnprocessedOperationsFieldSpecified; }
      set { this.numUnprocessedOperationsFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BillingSummary {
    private int numOperationsField;

    private bool numOperationsFieldSpecified;

    private long numUnitsField;

    private bool numUnitsFieldSpecified;

    public int numOperations {
      get { return this.numOperationsField; }
      set {
        this.numOperationsField = value;
        this.numOperationsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numOperationsSpecified {
      get { return this.numOperationsFieldSpecified; }
      set { this.numOperationsFieldSpecified = value; }
    }

    public long numUnits {
      get { return this.numUnitsField; }
      set {
        this.numUnitsField = value;
        this.numUnitsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numUnitsSpecified {
      get { return this.numUnitsFieldSpecified; }
      set { this.numUnitsFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class SimpleMutateJob : Job {
    private long idField;

    private bool idFieldSpecified;

    private BasicJobStatus statusField;

    private bool statusFieldSpecified;

    private JobEvent[] historyField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public BasicJobStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("history")]
    public JobEvent[] history {
      get { return this.historyField; }
      set { this.historyField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum BasicJobStatus {
    COMPLETED,
    PROCESSING,
    FAILED,
    PENDING
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BulkMutateJobEvent))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class JobEvent {
    private string dateTimeField;

    private string jobEventTypeField;

    public string dateTime {
      get { return this.dateTimeField; }
      set { this.dateTimeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("JobEvent.Type")]
    public string JobEventType {
      get { return this.jobEventTypeField; }
      set { this.jobEventTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BulkMutateJobEvent : JobEvent {
    private BasicJobStatus statusField;

    private bool statusFieldSpecified;

    public BasicJobStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BulkMutateJob : Job {
    private long idField;

    private bool idFieldSpecified;

    private BulkMutateJobPolicy policyField;

    private BulkMutateRequest requestField;

    private BasicJobStatus statusField;

    private bool statusFieldSpecified;

    private BulkMutateJobEvent[] historyField;

    private BulkMutateResult resultField;

    private int numRequestPartsField;

    private bool numRequestPartsFieldSpecified;

    private int numRequestPartsReceivedField;

    private bool numRequestPartsReceivedFieldSpecified;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public BulkMutateJobPolicy policy {
      get { return this.policyField; }
      set { this.policyField = value; }
    }

    public BulkMutateRequest request {
      get { return this.requestField; }
      set { this.requestField = value; }
    }

    public BasicJobStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("history")]
    public BulkMutateJobEvent[] history {
      get { return this.historyField; }
      set { this.historyField = value; }
    }

    public BulkMutateResult result {
      get { return this.resultField; }
      set { this.resultField = value; }
    }

    public int numRequestParts {
      get { return this.numRequestPartsField; }
      set {
        this.numRequestPartsField = value;
        this.numRequestPartsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numRequestPartsSpecified {
      get { return this.numRequestPartsFieldSpecified; }
      set { this.numRequestPartsFieldSpecified = value; }
    }

    public int numRequestPartsReceived {
      get { return this.numRequestPartsReceivedField; }
      set {
        this.numRequestPartsReceivedField = value;
        this.numRequestPartsReceivedSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numRequestPartsReceivedSpecified {
      get { return this.numRequestPartsReceivedFieldSpecified; }
      set { this.numRequestPartsReceivedFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BulkMutateJobPolicy {
    private long[] prerequisiteJobIdsField;

    private string dummyField;

    [System.Xml.Serialization.XmlElementAttribute("prerequisiteJobIds")]
    public long[] prerequisiteJobIds {
      get { return this.prerequisiteJobIdsField; }
      set { this.prerequisiteJobIdsField = value; }
    }

    public string dummy {
      get { return this.dummyField; }
      set { this.dummyField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BulkMutateRequest {
    private int partIndexField;

    private bool partIndexFieldSpecified;

    private OperationStream[] operationStreamsField;

    public int partIndex {
      get { return this.partIndexField; }
      set {
        this.partIndexField = value;
        this.partIndexSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool partIndexSpecified {
      get { return this.partIndexFieldSpecified; }
      set { this.partIndexFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("operationStreams")]
    public OperationStream[] operationStreams {
      get { return this.operationStreamsField; }
      set { this.operationStreamsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class OperationStream {
    private EntityId scopingEntityIdField;

    private Operation[] operationsField;

    public EntityId scopingEntityId {
      get { return this.scopingEntityIdField; }
      set { this.scopingEntityIdField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("operations")]
    public Operation[] operations {
      get { return this.operationsField; }
      set { this.operationsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class EntityId {
    private EntityIdType typeField;

    private bool typeFieldSpecified;

    private long valueField;

    private bool valueFieldSpecified;

    public EntityIdType type {
      get { return this.typeField; }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get { return this.typeFieldSpecified; }
      set { this.typeFieldSpecified = value; }
    }

    public long value {
      get { return this.valueField; }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get { return this.valueFieldSpecified; }
      set { this.valueFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EntityId.Type", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum EntityIdType {
    ADGROUP_ID,
    AD_ID,
    CAMPAIGN_ID,
    CUSTOMER_ID
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignAdExtensionOperation : Operation {
    private CampaignAdExtension operandField;

    public CampaignAdExtension operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupOperation : Operation {
    private AdGroup operandField;

    public AdGroup operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupCriterionOperation : Operation {
    private AdGroupCriterion operandField;

    private ExemptionRequest[] exemptionRequestsField;

    public AdGroupCriterion operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("exemptionRequests")]
    public ExemptionRequest[] exemptionRequests {
      get { return this.exemptionRequestsField; }
      set { this.exemptionRequestsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ExemptionRequest {
    private PolicyViolationKey keyField;

    public PolicyViolationKey key {
      get { return this.keyField; }
      set { this.keyField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class PolicyViolationKey {
    private string policyNameField;

    private string violatingTextField;

    public string policyName {
      get { return this.policyNameField; }
      set { this.policyNameField = value; }
    }

    public string violatingText {
      get { return this.violatingTextField; }
      set { this.violatingTextField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupAdOperation : Operation {
    private AdGroupAd operandField;

    private ExemptionRequest[] exemptionRequestsField;

    public AdGroupAd operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("exemptionRequests")]
    public ExemptionRequest[] exemptionRequests {
      get { return this.exemptionRequestsField; }
      set { this.exemptionRequestsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BulkMutateResult {
    private int partIndexField;

    private bool partIndexFieldSpecified;

    private OperationStreamResult[] operationStreamResultsField;

    public int partIndex {
      get { return this.partIndexField; }
      set {
        this.partIndexField = value;
        this.partIndexSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool partIndexSpecified {
      get { return this.partIndexFieldSpecified; }
      set { this.partIndexFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("operationStreamResults")]
    public OperationStreamResult[] operationStreamResults {
      get { return this.operationStreamResultsField; }
      set { this.operationStreamResultsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class OperationStreamResult {
    private OperationResult[] operationResultsField;

    private string dummyField;

    [System.Xml.Serialization.XmlElementAttribute("operationResults")]
    public OperationResult[] operationResults {
      get { return this.operationResultsField; }
      set { this.operationResultsField = value; }
    }

    public string dummy {
      get { return this.dummyField; }
      set { this.dummyField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnprocessedResult))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnValueResult))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LostResult))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FailureResult))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BatchFailureResult))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public abstract partial class OperationResult {
    private string operationResultTypeField;

    [System.Xml.Serialization.XmlElementAttribute("OperationResult.Type")]
    public string OperationResultType {
      get { return this.operationResultTypeField; }
      set { this.operationResultTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class UnprocessedResult : OperationResult {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ReturnValueResult : OperationResult {
    private Operand returnValueField;

    public Operand returnValue {
      get { return this.returnValueField; }
      set { this.returnValueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class LostResult : OperationResult {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class FailureResult : OperationResult {
    private ApiException causeField;

    public ApiException cause {
      get { return this.causeField; }
      set { this.causeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BatchFailureResult : OperationResult {
    private int operationIndexInBatchField;

    private bool operationIndexInBatchFieldSpecified;

    public int operationIndexInBatch {
      get { return this.operationIndexInBatchField; }
      set {
        this.operationIndexInBatchField = value;
        this.operationIndexInBatchSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool operationIndexInBatchSpecified {
      get { return this.operationIndexInBatchFieldSpecified; }
      set { this.operationIndexInBatchFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class PlaceHolder {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class JobResult {
    private object itemField;

    [System.Xml.Serialization.XmlElementAttribute("BulkMutateResult", typeof(BulkMutateResult))]
    [System.Xml.Serialization.XmlElementAttribute("SimpleMutateResult", typeof(SimpleMutateResult))]
    public object Item {
      get { return this.itemField; }
      set { this.itemField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BulkMutateJobSelector))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public abstract partial class JobSelector {
    private bool includeHistoryField;

    private bool includeHistoryFieldSpecified;

    private bool includeStatsField;

    private bool includeStatsFieldSpecified;

    private string jobSelectorTypeField;

    public bool includeHistory {
      get { return this.includeHistoryField; }
      set {
        this.includeHistoryField = value;
        this.includeHistorySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool includeHistorySpecified {
      get { return this.includeHistoryFieldSpecified; }
      set { this.includeHistoryFieldSpecified = value; }
    }

    public bool includeStats {
      get { return this.includeStatsField; }
      set {
        this.includeStatsField = value;
        this.includeStatsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool includeStatsSpecified {
      get { return this.includeStatsFieldSpecified; }
      set { this.includeStatsFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("JobSelector.Type")]
    public string JobSelectorType {
      get { return this.jobSelectorTypeField; }
      set { this.jobSelectorTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BulkMutateJobSelector : JobSelector {
    private long[] jobIdsField;

    private BasicJobStatus[] jobStatusesField;

    private int resultPartIndexField;

    private bool resultPartIndexFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("jobIds")]
    public long[] jobIds {
      get { return this.jobIdsField; }
      set { this.jobIdsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("jobStatuses")]
    public BasicJobStatus[] jobStatuses {
      get { return this.jobStatusesField; }
      set { this.jobStatusesField = value; }
    }

    public int resultPartIndex {
      get { return this.resultPartIndexField; }
      set {
        this.resultPartIndexField = value;
        this.resultPartIndexSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool resultPartIndexSpecified {
      get { return this.resultPartIndexFieldSpecified; }
      set { this.resultPartIndexFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PolicyViolationError.Part", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class PolicyViolationErrorPart {
    private int indexField;

    private bool indexFieldSpecified;

    private int lengthField;

    private bool lengthFieldSpecified;

    public int index {
      get { return this.indexField; }
      set {
        this.indexField = value;
        this.indexSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool indexSpecified {
      get { return this.indexFieldSpecified; }
      set { this.indexFieldSpecified = value; }
    }

    public int length {
      get { return this.lengthField; }
      set {
        this.lengthField = value;
        this.lengthSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool lengthSpecified {
      get { return this.lengthFieldSpecified; }
      set { this.lengthFieldSpecified = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionPolicyError))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdParamPolicyError))]
  public partial class PolicyViolationError : ApiError {
    private PolicyViolationKey keyField;

    private string externalPolicyNameField;

    private string externalPolicyUrlField;

    private string externalPolicyDescriptionField;

    private bool isExemptableField;

    private bool isExemptableFieldSpecified;

    private PolicyViolationErrorPart[] violatingPartsField;

    public PolicyViolationKey key {
      get { return this.keyField; }
      set { this.keyField = value; }
    }

    public string externalPolicyName {
      get { return this.externalPolicyNameField; }
      set { this.externalPolicyNameField = value; }
    }

    public string externalPolicyUrl {
      get { return this.externalPolicyUrlField; }
      set { this.externalPolicyUrlField = value; }
    }

    public string externalPolicyDescription {
      get { return this.externalPolicyDescriptionField; }
      set { this.externalPolicyDescriptionField = value; }
    }

    public bool isExemptable {
      get { return this.isExemptableField; }
      set {
        this.isExemptableField = value;
        this.isExemptableSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isExemptableSpecified {
      get { return this.isExemptableFieldSpecified; }
      set { this.isExemptableFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("violatingParts")]
    public PolicyViolationErrorPart[] violatingParts {
      get { return this.violatingPartsField; }
      set { this.violatingPartsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CriterionPolicyError : PolicyViolationError {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class JobError : ApiError {
    private JobErrorReason reasonField;

    private bool reasonFieldSpecified;

    public JobErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class IdError : ApiError {
    private IdErrorReason reasonField;

    private bool reasonFieldSpecified;

    public IdErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupCriterionLimitExceeded : EntityCountLimitExceeded {
    private AdGroupCriterionLimitExceededCriteriaLimitType limitTypeField;

    private bool limitTypeFieldSpecified;

    public AdGroupCriterionLimitExceededCriteriaLimitType limitType {
      get { return this.limitTypeField; }
      set {
        this.limitTypeField = value;
        this.limitTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool limitTypeSpecified {
      get { return this.limitTypeFieldSpecified; }
      set { this.limitTypeFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupCriterionLimitExceeded.CriteriaLimitType", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AdGroupCriterionLimitExceededCriteriaLimitType {
    ADGROUP_KEYWORD,
    ADGROUP_WEBSITE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupAdCountLimitExceeded : EntityCountLimitExceeded {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class EntityAccessDenied : ApiError {
    private EntityAccessDeniedReason reasonField;

    private bool reasonFieldSpecified;

    public EntityAccessDeniedReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignAdExtensionError : ApiError {
    private CampaignAdExtensionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CampaignAdExtensionErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class BulkMutateJobError : ApiError {
    private BulkMutateJobErrorReason reasonField;

    private bool reasonFieldSpecified;

    public BulkMutateJobErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupServiceError : ApiError {
    private AdGroupServiceErrorReason reasonField;

    private bool reasonFieldSpecified;

    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    public AdGroupServiceErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupCriterionError : ApiError {
    private AdGroupCriterionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdGroupCriterionErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupAdError : ApiError {
    private AdGroupAdErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdGroupAdErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdExtensionError : ApiError {
    private AdExtensionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdExtensionErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdError : ApiError {
    private AdErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "ReportDefinitionServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class ReportDefinitionService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public ReportDefinitionService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201109/ReportDefinitionService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual ReportDefinitionPage get(ReportDefinitionSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((ReportDefinitionPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual ReportDefinitionField[] getReportFields(ReportDefinitionReportType reportType) {
      object[] results = this.Invoke("getReportFields", new object[] {reportType});
      return ((ReportDefinitionField[]) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class EnumValuePair {
    private string enumValueField;

    private string enumDisplayValueField;

    public string enumValue {
      get { return this.enumValueField; }
      set { this.enumValueField = value; }
    }

    public string enumDisplayValue {
      get { return this.enumDisplayValueField; }
      set { this.enumDisplayValueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ReportDefinitionField {
    private string fieldNameField;

    private string displayFieldNameField;

    private string xmlAttributeNameField;

    private string fieldTypeField;

    private string[] enumValuesField;

    private bool canSelectField;

    private bool canSelectFieldSpecified;

    private bool canFilterField;

    private bool canFilterFieldSpecified;

    private bool isEnumTypeField;

    private bool isEnumTypeFieldSpecified;

    private EnumValuePair[] enumValuePairsField;

    public string fieldName {
      get { return this.fieldNameField; }
      set { this.fieldNameField = value; }
    }

    public string displayFieldName {
      get { return this.displayFieldNameField; }
      set { this.displayFieldNameField = value; }
    }

    public string xmlAttributeName {
      get { return this.xmlAttributeNameField; }
      set { this.xmlAttributeNameField = value; }
    }

    public string fieldType {
      get { return this.fieldTypeField; }
      set { this.fieldTypeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("enumValues")]
    public string[] enumValues {
      get { return this.enumValuesField; }
      set { this.enumValuesField = value; }
    }

    public bool canSelect {
      get { return this.canSelectField; }
      set {
        this.canSelectField = value;
        this.canSelectSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool canSelectSpecified {
      get { return this.canSelectFieldSpecified; }
      set { this.canSelectFieldSpecified = value; }
    }

    public bool canFilter {
      get { return this.canFilterField; }
      set {
        this.canFilterField = value;
        this.canFilterSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool canFilterSpecified {
      get { return this.canFilterFieldSpecified; }
      set { this.canFilterFieldSpecified = value; }
    }

    public bool isEnumType {
      get { return this.isEnumTypeField; }
      set {
        this.isEnumTypeField = value;
        this.isEnumTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isEnumTypeSpecified {
      get { return this.isEnumTypeFieldSpecified; }
      set { this.isEnumTypeFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("enumValuePairs")]
    public EnumValuePair[] enumValuePairs {
      get { return this.enumValuePairsField; }
      set { this.enumValuePairsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ReportDefinition {
    private long idField;

    private bool idFieldSpecified;

    private Selector selectorField;

    private string reportNameField;

    private ReportDefinitionReportType reportTypeField;

    private bool reportTypeFieldSpecified;

    private bool hasAttachmentField;

    private bool hasAttachmentFieldSpecified;

    private ReportDefinitionDateRangeType dateRangeTypeField;

    private bool dateRangeTypeFieldSpecified;

    private DownloadFormat downloadFormatField;

    private bool downloadFormatFieldSpecified;

    private string creationTimeField;

    private bool includeZeroImpressionsField;

    private bool includeZeroImpressionsFieldSpecified;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public Selector selector {
      get { return this.selectorField; }
      set { this.selectorField = value; }
    }

    public string reportName {
      get { return this.reportNameField; }
      set { this.reportNameField = value; }
    }

    public ReportDefinitionReportType reportType {
      get { return this.reportTypeField; }
      set {
        this.reportTypeField = value;
        this.reportTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reportTypeSpecified {
      get { return this.reportTypeFieldSpecified; }
      set { this.reportTypeFieldSpecified = value; }
    }

    public bool hasAttachment {
      get { return this.hasAttachmentField; }
      set {
        this.hasAttachmentField = value;
        this.hasAttachmentSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool hasAttachmentSpecified {
      get { return this.hasAttachmentFieldSpecified; }
      set { this.hasAttachmentFieldSpecified = value; }
    }

    public ReportDefinitionDateRangeType dateRangeType {
      get { return this.dateRangeTypeField; }
      set {
        this.dateRangeTypeField = value;
        this.dateRangeTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool dateRangeTypeSpecified {
      get { return this.dateRangeTypeFieldSpecified; }
      set { this.dateRangeTypeFieldSpecified = value; }
    }

    public DownloadFormat downloadFormat {
      get { return this.downloadFormatField; }
      set {
        this.downloadFormatField = value;
        this.downloadFormatSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool downloadFormatSpecified {
      get { return this.downloadFormatFieldSpecified; }
      set { this.downloadFormatFieldSpecified = value; }
    }

    public string creationTime {
      get { return this.creationTimeField; }
      set { this.creationTimeField = value; }
    }

    public bool includeZeroImpressions {
      get { return this.includeZeroImpressionsField; }
      set {
        this.includeZeroImpressionsField = value;
        this.includeZeroImpressionsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool includeZeroImpressionsSpecified {
      get { return this.includeZeroImpressionsFieldSpecified; }
      set { this.includeZeroImpressionsFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ReportDefinition.ReportType", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ReportDefinitionReportType {
    KEYWORDS_PERFORMANCE_REPORT,
    AD_PERFORMANCE_REPORT,
    URL_PERFORMANCE_REPORT,
    ADGROUP_PERFORMANCE_REPORT,
    CAMPAIGN_PERFORMANCE_REPORT,
    ACCOUNT_PERFORMANCE_REPORT,
    DEMOGRAPHIC_PERFORMANCE_REPORT,
    GEO_PERFORMANCE_REPORT,
    SEARCH_QUERY_PERFORMANCE_REPORT,
    MANAGED_PLACEMENTS_PERFORMANCE_REPORT,
    AUTOMATIC_PLACEMENTS_PERFORMANCE_REPORT,
    CAMPAIGN_NEGATIVE_KEYWORDS_PERFORMANCE_REPORT,
    CAMPAIGN_NEGATIVE_PLACEMENTS_PERFORMANCE_REPORT,
    AD_EXTENSIONS_PERFORMANCE_REPORT,
    DESTINATION_URL_REPORT,
    CREATIVE_CONVERSION_REPORT,
    CRITERIA_PERFORMANCE_REPORT,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ReportDefinition.DateRangeType", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ReportDefinitionDateRangeType {
    TODAY,
    YESTERDAY,
    LAST_7_DAYS,
    THIS_WEEK_SUN_TODAY,
    THIS_WEEK_MON_TODAY,
    LAST_WEEK,
    LAST_14_DAYS,
    LAST_30_DAYS,
    LAST_BUSINESS_WEEK,
    LAST_WEEK_SUN_SAT,
    THIS_MONTH,
    LAST_MONTH,
    ALL_TIME,
    CUSTOM_DATE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum DownloadFormat {
    CSVFOREXCEL,
    CSV,
    TSV,
    XML,
    GZIPPED_CSV,
    GZIPPED_XML
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ReportDefinitionPage {
    private ReportDefinition[] entriesField;

    private int totalNumEntriesField;

    private bool totalNumEntriesFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public ReportDefinition[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }

    public int totalNumEntries {
      get { return this.totalNumEntriesField; }
      set {
        this.totalNumEntriesField = value;
        this.totalNumEntriesSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool totalNumEntriesSpecified {
      get { return this.totalNumEntriesFieldSpecified; }
      set { this.totalNumEntriesFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ReportDefinitionSelector {
    private long[] definitionIdsField;

    private Paging pagingField;

    [System.Xml.Serialization.XmlElementAttribute("definitionIds")]
    public long[] definitionIds {
      get { return this.definitionIdsField; }
      set { this.definitionIdsField = value; }
    }

    public Paging paging {
      get { return this.pagingField; }
      set { this.pagingField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ReportDefinitionError : ApiError {
    private ReportDefinitionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ReportDefinitionErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ReportDefinitionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum ReportDefinitionErrorReason {
    INVALID_FIELD_NAME_FOR_REPORT,
    UNABLE_TO_FIND_MAPPING_FOR_THIS_REPORT,
    INVALID_COLUMN_NAME_FOR_REPORT,
    INVALID_REPORT_DEFINITION_ID,
    REPORT_SELECTOR_CANNOT_BE_NULL,
    NO_ENUMS_FOR_THIS_COLUMN_NAME,
    INVALID_VIEW,
    SORTING_NOT_SUPPORTED,
    PAGING_NOT_SUPPORTED,
    CUSTOMER_SERVING_TYPE_REPORT_MISMATCH,
    CLIENT_SELECTOR_NO_CUSTOMER_IDENTIFIER,
    CLIENT_SELECTOR_INVALID_CUSTOMER_ID,
    REPORT_DEFINITION_ERROR
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CollectionSizeError : ApiError {
    private CollectionSizeErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CollectionSizeErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CollectionSizeError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum CollectionSizeErrorReason {
    TOO_FEW,
    TOO_MANY
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "ServicedAccountServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class ServicedAccountService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public ServicedAccountService() {
      this.Url = "https://adwords.google.com/api/adwords/mcm/v201109/ServicedAccountService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/mcm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/mcm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual ServicedAccountGraph get(ServicedAccountSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((ServicedAccountGraph) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public partial class CustomerId {
    private long idField;

    private bool idFieldSpecified;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public partial class Link {
    private CustomerId managerIdField;

    private CustomerId clientIdField;

    private LinkType typeOfLinkField;

    private bool typeOfLinkFieldSpecified;

    private string descriptiveNameField;

    private string linkTypeField;

    public CustomerId managerId {
      get { return this.managerIdField; }
      set { this.managerIdField = value; }
    }

    public CustomerId clientId {
      get { return this.clientIdField; }
      set { this.clientIdField = value; }
    }

    public LinkType typeOfLink {
      get { return this.typeOfLinkField; }
      set {
        this.typeOfLinkField = value;
        this.typeOfLinkSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeOfLinkSpecified {
      get { return this.typeOfLinkFieldSpecified; }
      set { this.typeOfLinkFieldSpecified = value; }
    }

    public string descriptiveName {
      get { return this.descriptiveNameField; }
      set { this.descriptiveNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("Link.Type")]
    public string LinkType {
      get { return this.linkTypeField; }
      set { this.linkTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public enum LinkType {
    ESTABLISHED,
    INVITATION,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public partial class ServicedAccountGraph {
    private Account[] accountsField;

    private Link[] linksField;

    [System.Xml.Serialization.XmlElementAttribute("accounts")]
    public Account[] accounts {
      get { return this.accountsField; }
      set { this.accountsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("links")]
    public Link[] links {
      get { return this.linksField; }
      set { this.linksField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public partial class ServicedAccountSelector {
    private long[] customerIdsField;

    private bool enablePagingField;

    private bool enablePagingFieldSpecified;

    private bool submanagersOnlyField;

    private bool submanagersOnlyFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("customerIds")]
    public long[] customerIds {
      get { return this.customerIdsField; }
      set { this.customerIdsField = value; }
    }

    public bool enablePaging {
      get { return this.enablePagingField; }
      set {
        this.enablePagingField = value;
        this.enablePagingSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool enablePagingSpecified {
      get { return this.enablePagingFieldSpecified; }
      set { this.enablePagingFieldSpecified = value; }
    }

    public bool submanagersOnly {
      get { return this.submanagersOnlyField; }
      set {
        this.submanagersOnlyField = value;
        this.submanagersOnlySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool submanagersOnlySpecified {
      get { return this.submanagersOnlyFieldSpecified; }
      set { this.submanagersOnlyFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public partial class ServicedAccountError : ApiError {
    private ServicedAccountErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ServicedAccountErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ServicedAccountError.Reason", Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public enum ServicedAccountErrorReason {
    BAD_IDS,
    NOT_AUTHORIZED,
    REQUESTS_TOO_FREQUENT,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "TargetingIdeaServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataEntry))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class TargetingIdeaService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public TargetingIdeaService() {
      this.Url = "https://adwords.google.com/api/adwords/o/v201109/TargetingIdeaService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/o/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/o/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual TargetingIdeaPage get(TargetingIdeaSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((TargetingIdeaPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/o/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/o/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual TargetingIdeaPage getBulkKeywordIdeas(TargetingIdeaSelector selector) {
      object[] results = this.Invoke("getBulkKeywordIdeas", new object[] {selector});
      return ((TargetingIdeaPage) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class WebpageDescriptor {
    private string urlField;

    private string titleField;

    public string url {
      get { return this.urlField; }
      set { this.urlField = value; }
    }

    public string title {
      get { return this.titleField; }
      set { this.titleField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class MonthlySearchVolume {
    private int yearField;

    private bool yearFieldSpecified;

    private int monthField;

    private bool monthFieldSpecified;

    private long countField;

    private bool countFieldSpecified;

    public int year {
      get { return this.yearField; }
      set {
        this.yearField = value;
        this.yearSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool yearSpecified {
      get { return this.yearFieldSpecified; }
      set { this.yearFieldSpecified = value; }
    }

    public int month {
      get { return this.monthField; }
      set {
        this.monthField = value;
        this.monthSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool monthSpecified {
      get { return this.monthFieldSpecified; }
      set { this.monthFieldSpecified = value; }
    }

    public long count {
      get { return this.countField; }
      set {
        this.countField = value;
        this.countSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool countSpecified {
      get { return this.countFieldSpecified; }
      set { this.countFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class Range {
    private ComparableValue minField;

    private ComparableValue maxField;

    public ComparableValue min {
      get { return this.minField; }
      set { this.minField = value; }
    }

    public ComparableValue max {
      get { return this.maxField; }
      set { this.maxField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class InStreamAdInfo {
    private int maxAdDurationField;

    private bool maxAdDurationFieldSpecified;

    private int minAdDurationField;

    private bool minAdDurationFieldSpecified;

    private int medianAdDurationField;

    private bool medianAdDurationFieldSpecified;

    private double preRollPercentField;

    private bool preRollPercentFieldSpecified;

    private double midRollPercentField;

    private bool midRollPercentFieldSpecified;

    private double postRollPercentField;

    private bool postRollPercentFieldSpecified;

    public int maxAdDuration {
      get { return this.maxAdDurationField; }
      set {
        this.maxAdDurationField = value;
        this.maxAdDurationSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool maxAdDurationSpecified {
      get { return this.maxAdDurationFieldSpecified; }
      set { this.maxAdDurationFieldSpecified = value; }
    }

    public int minAdDuration {
      get { return this.minAdDurationField; }
      set {
        this.minAdDurationField = value;
        this.minAdDurationSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool minAdDurationSpecified {
      get { return this.minAdDurationFieldSpecified; }
      set { this.minAdDurationFieldSpecified = value; }
    }

    public int medianAdDuration {
      get { return this.medianAdDurationField; }
      set {
        this.medianAdDurationField = value;
        this.medianAdDurationSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool medianAdDurationSpecified {
      get { return this.medianAdDurationFieldSpecified; }
      set { this.medianAdDurationFieldSpecified = value; }
    }

    public double preRollPercent {
      get { return this.preRollPercentField; }
      set {
        this.preRollPercentField = value;
        this.preRollPercentSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool preRollPercentSpecified {
      get { return this.preRollPercentFieldSpecified; }
      set { this.preRollPercentFieldSpecified = value; }
    }

    public double midRollPercent {
      get { return this.midRollPercentField; }
      set {
        this.midRollPercentField = value;
        this.midRollPercentSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool midRollPercentSpecified {
      get { return this.midRollPercentFieldSpecified; }
      set { this.midRollPercentFieldSpecified = value; }
    }

    public double postRollPercent {
      get { return this.postRollPercentField; }
      set {
        this.postRollPercentField = value;
        this.postRollPercentSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool postRollPercentSpecified {
      get { return this.postRollPercentFieldSpecified; }
      set { this.postRollPercentFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class AdFormatSpec {
    private SiteConstantsAdFormat formatField;

    private bool formatFieldSpecified;

    public SiteConstantsAdFormat format {
      get { return this.formatField; }
      set {
        this.formatField = value;
        this.formatSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool formatSpecified {
      get { return this.formatFieldSpecified; }
      set { this.formatFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SiteConstants.AdFormat", Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public enum SiteConstantsAdFormat {
    UNKNOWN,
    TEXT,
    IMAGE,
    VIDEO,
    INSTREAM
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(WebpageDescriptorAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(StringAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlacementTypeAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlacementAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(OpportunityIdeaTypeAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MonthlySearchVolumeAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MoneyAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LongRangeAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LongAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(KeywordAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerSetAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(InStreamAdInfoAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdeaTypeAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BidLandscapeAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdFormatSpecListAttribute))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public abstract partial class Attribute {
    private string attributeTypeField;

    [System.Xml.Serialization.XmlElementAttribute("Attribute.Type")]
    public string AttributeType {
      get { return this.attributeTypeField; }
      set { this.attributeTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class WebpageDescriptorAttribute : Attribute {
    private WebpageDescriptor valueField;

    public WebpageDescriptor value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class StringAttribute : Attribute {
    private string valueField;

    public string value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class PlacementTypeAttribute : Attribute {
    private SiteConstantsPlacementType valueField;

    private bool valueFieldSpecified;

    public SiteConstantsPlacementType value {
      get { return this.valueField; }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get { return this.valueFieldSpecified; }
      set { this.valueFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SiteConstants.PlacementType", Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public enum SiteConstantsPlacementType {
    UNKNOWN,
    SITE,
    VIDEO,
    FEED,
    GAME,
    MOBILE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class PlacementAttribute : Attribute {
    private Placement valueField;

    public Placement value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class OpportunityIdeaTypeAttribute : Attribute {
    private OpportunityIdeaType valueField;

    private bool valueFieldSpecified;

    public OpportunityIdeaType value {
      get { return this.valueField; }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get { return this.valueFieldSpecified; }
      set { this.valueFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public enum OpportunityIdeaType {
    KEYWORD,
    BID,
    BUDGET
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class MonthlySearchVolumeAttribute : Attribute {
    private MonthlySearchVolume[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public MonthlySearchVolume[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class MoneyAttribute : Attribute {
    private Money valueField;

    public Money value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class LongRangeAttribute : Attribute {
    private Range valueField;

    public Range value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class LongAttribute : Attribute {
    private long valueField;

    private bool valueFieldSpecified;

    public long value {
      get { return this.valueField; }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get { return this.valueFieldSpecified; }
      set { this.valueFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class KeywordAttribute : Attribute {
    private Keyword valueField;

    public Keyword value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class IntegerSetAttribute : Attribute {
    private int[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public int[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class IntegerAttribute : Attribute {
    private int valueField;

    private bool valueFieldSpecified;

    public int value {
      get { return this.valueField; }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get { return this.valueFieldSpecified; }
      set { this.valueFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class InStreamAdInfoAttribute : Attribute {
    private InStreamAdInfo valueField;

    public InStreamAdInfo value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class IdeaTypeAttribute : Attribute {
    private IdeaType valueField;

    private bool valueFieldSpecified;

    public IdeaType value {
      get { return this.valueField; }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get { return this.valueFieldSpecified; }
      set { this.valueFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public enum IdeaType {
    KEYWORD,
    PLACEMENT
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class DoubleAttribute : Attribute {
    private double valueField;

    private bool valueFieldSpecified;

    public double value {
      get { return this.valueField; }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get { return this.valueFieldSpecified; }
      set { this.valueFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class CriterionAttribute : Attribute {
    private Criterion valueField;

    public Criterion value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class BooleanAttribute : Attribute {
    private bool valueField;

    private bool valueFieldSpecified;

    public bool value {
      get { return this.valueField; }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get { return this.valueFieldSpecified; }
      set { this.valueFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class BidLandscapeAttribute : Attribute {
    private BidLandscape valueField;

    public BidLandscape value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class AdFormatSpecListAttribute : Attribute {
    private AdFormatSpec[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdFormatSpec[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class Type_AttributeMapEntry {
    private AttributeType keyField;

    private bool keyFieldSpecified;

    private Attribute valueField;

    public AttributeType key {
      get { return this.keyField; }
      set {
        this.keyField = value;
        this.keySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool keySpecified {
      get { return this.keyFieldSpecified; }
      set { this.keyFieldSpecified = value; }
    }

    public Attribute value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public enum AttributeType {
    UNKNOWN,
    AD_SHARE,
    APPROX_CONTENT_IMPRESSIONS_PER_DAY,
    AVERAGE_TARGETED_MONTHLY_SEARCHES,
    COMPETITION,
    CRITERION,
    EXTRACTED_FROM_WEBPAGE,
    FORMATS,
    GLOBAL_MONTHLY_SEARCHES,
    IDEA_TYPE,
    IN_STREAM_AD_INFO,
    KEYWORD_CATEGORY,
    NGRAM_GROUP,
    PLACEMENT_NAME,
    SAMPLE_URL,
    SEARCH_SHARE,
    PLACEMENT_CATEGORY,
    PLACEMENT_TYPE,
    TARGETED_MONTHLY_SEARCHES
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class TargetingIdea {
    private Type_AttributeMapEntry[] dataField;

    private string dummyField;

    [System.Xml.Serialization.XmlElementAttribute("data")]
    public Type_AttributeMapEntry[] data {
      get { return this.dataField; }
      set { this.dataField = value; }
    }

    public string dummy {
      get { return this.dummyField; }
      set { this.dummyField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class TargetingIdeaPage {
    private int totalNumEntriesField;

    private bool totalNumEntriesFieldSpecified;

    private TargetingIdea[] entriesField;

    public int totalNumEntries {
      get { return this.totalNumEntriesField; }
      set {
        this.totalNumEntriesField = value;
        this.totalNumEntriesSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool totalNumEntriesSpecified {
      get { return this.totalNumEntriesFieldSpecified; }
      set { this.totalNumEntriesFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public TargetingIdea[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class LongComparisonOperation {
    private long minimumField;

    private bool minimumFieldSpecified;

    private long maximumField;

    private bool maximumFieldSpecified;

    public long minimum {
      get { return this.minimumField; }
      set {
        this.minimumField = value;
        this.minimumSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool minimumSpecified {
      get { return this.minimumFieldSpecified; }
      set { this.minimumFieldSpecified = value; }
    }

    public long maximum {
      get { return this.maximumField; }
      set {
        this.maximumField = value;
        this.maximumSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool maximumSpecified {
      get { return this.maximumFieldSpecified; }
      set { this.maximumFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class DoubleComparisonOperation {
    private double minimumField;

    private bool minimumFieldSpecified;

    private double maximumField;

    private bool maximumFieldSpecified;

    public double minimum {
      get { return this.minimumField; }
      set {
        this.minimumField = value;
        this.minimumSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool minimumSpecified {
      get { return this.minimumFieldSpecified; }
      set { this.minimumFieldSpecified = value; }
    }

    public double maximum {
      get { return this.maximumField; }
      set {
        this.maximumField = value;
        this.maximumSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool maximumSpecified {
      get { return this.maximumFieldSpecified; }
      set { this.maximumFieldSpecified = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SeedAdGroupIdSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchShareSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelatedToUrlSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelatedToKeywordSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlacementTypeSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocationSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LanguageSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(KeywordMatchTypeSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(IncludeAdultContentSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdeaTextFilterSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(GlobalMonthlySearchesSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExcludedKeywordSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeviceTypeSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompetitionSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryProductsAndServicesSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AverageTargetedMonthlySearchesSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdTypeSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdShareSearchParameter))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public abstract partial class SearchParameter {
    private string searchParameterTypeField;

    [System.Xml.Serialization.XmlElementAttribute("SearchParameter.Type")]
    public string SearchParameterType {
      get { return this.searchParameterTypeField; }
      set { this.searchParameterTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class SeedAdGroupIdSearchParameter : SearchParameter {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class SearchShareSearchParameter : SearchParameter {
    private DoubleComparisonOperation operationField;

    public DoubleComparisonOperation operation {
      get { return this.operationField; }
      set { this.operationField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class RelatedToUrlSearchParameter : SearchParameter {
    private string[] urlsField;

    private bool includeSubUrlsField;

    private bool includeSubUrlsFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("urls")]
    public string[] urls {
      get { return this.urlsField; }
      set { this.urlsField = value; }
    }

    public bool includeSubUrls {
      get { return this.includeSubUrlsField; }
      set {
        this.includeSubUrlsField = value;
        this.includeSubUrlsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool includeSubUrlsSpecified {
      get { return this.includeSubUrlsFieldSpecified; }
      set { this.includeSubUrlsFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class RelatedToKeywordSearchParameter : SearchParameter {
    private Keyword[] keywordsField;

    [System.Xml.Serialization.XmlElementAttribute("keywords")]
    public Keyword[] keywords {
      get { return this.keywordsField; }
      set { this.keywordsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class PlacementTypeSearchParameter : SearchParameter {
    private SiteConstantsPlacementType[] placementTypesField;

    [System.Xml.Serialization.XmlElementAttribute("placementTypes")]
    public SiteConstantsPlacementType[] placementTypes {
      get { return this.placementTypesField; }
      set { this.placementTypesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class LocationSearchParameter : SearchParameter {
    private Location[] locationsField;

    [System.Xml.Serialization.XmlElementAttribute("locations")]
    public Location[] locations {
      get { return this.locationsField; }
      set { this.locationsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class LanguageSearchParameter : SearchParameter {
    private Language[] languagesField;

    [System.Xml.Serialization.XmlElementAttribute("languages")]
    public Language[] languages {
      get { return this.languagesField; }
      set { this.languagesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class KeywordMatchTypeSearchParameter : SearchParameter {
    private KeywordMatchType[] keywordMatchTypesField;

    [System.Xml.Serialization.XmlElementAttribute("keywordMatchTypes")]
    public KeywordMatchType[] keywordMatchTypes {
      get { return this.keywordMatchTypesField; }
      set { this.keywordMatchTypesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class IncludeAdultContentSearchParameter : SearchParameter {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class IdeaTextFilterSearchParameter : SearchParameter {
    private string[] includedField;

    private string[] excludedField;

    [System.Xml.Serialization.XmlElementAttribute("included")]
    public string[] included {
      get { return this.includedField; }
      set { this.includedField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("excluded")]
    public string[] excluded {
      get { return this.excludedField; }
      set { this.excludedField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class GlobalMonthlySearchesSearchParameter : SearchParameter {
    private LongComparisonOperation operationField;

    public LongComparisonOperation operation {
      get { return this.operationField; }
      set { this.operationField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class ExcludedKeywordSearchParameter : SearchParameter {
    private Keyword[] keywordsField;

    [System.Xml.Serialization.XmlElementAttribute("keywords")]
    public Keyword[] keywords {
      get { return this.keywordsField; }
      set { this.keywordsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class DeviceTypeSearchParameter : SearchParameter {
    private DeviceType deviceTypeField;

    private bool deviceTypeFieldSpecified;

    public DeviceType deviceType {
      get { return this.deviceTypeField; }
      set {
        this.deviceTypeField = value;
        this.deviceTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool deviceTypeSpecified {
      get { return this.deviceTypeFieldSpecified; }
      set { this.deviceTypeFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public enum DeviceType {
    MOBILE_WAP,
    MOBILE_WITH_FULL_BROWSER,
    DESKTOPS_AND_LAPTOPS
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class CompetitionSearchParameter : SearchParameter {
    private CompetitionSearchParameterLevel[] levelsField;

    [System.Xml.Serialization.XmlElementAttribute("levels")]
    public CompetitionSearchParameterLevel[] levels {
      get { return this.levelsField; }
      set { this.levelsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CompetitionSearchParameter.Level", Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public enum CompetitionSearchParameterLevel {
    LOW,
    MEDIUM,
    HIGH
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class CategoryProductsAndServicesSearchParameter : SearchParameter {
    private int categoryIdField;

    private bool categoryIdFieldSpecified;

    public int categoryId {
      get { return this.categoryIdField; }
      set {
        this.categoryIdField = value;
        this.categoryIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool categoryIdSpecified {
      get { return this.categoryIdFieldSpecified; }
      set { this.categoryIdFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class AverageTargetedMonthlySearchesSearchParameter : SearchParameter {
    private LongComparisonOperation operationField;

    public LongComparisonOperation operation {
      get { return this.operationField; }
      set { this.operationField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class AdTypeSearchParameter : SearchParameter {
    private SiteConstantsAdType[] adTypesField;

    [System.Xml.Serialization.XmlElementAttribute("adTypes")]
    public SiteConstantsAdType[] adTypes {
      get { return this.adTypesField; }
      set { this.adTypesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SiteConstants.AdType", Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public enum SiteConstantsAdType {
    UNKNOWN,
    TEXT,
    DISPLAY,
    INSTREAM
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class AdShareSearchParameter : SearchParameter {
    private DoubleComparisonOperation operationField;

    public DoubleComparisonOperation operation {
      get { return this.operationField; }
      set { this.operationField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class TargetingIdeaSelector {
    private SearchParameter[] searchParametersField;

    private IdeaType ideaTypeField;

    private bool ideaTypeFieldSpecified;

    private RequestType requestTypeField;

    private bool requestTypeFieldSpecified;

    private AttributeType[] requestedAttributeTypesField;

    private Paging pagingField;

    private string localeCodeField;

    private string currencyCodeField;

    [System.Xml.Serialization.XmlElementAttribute("searchParameters")]
    public SearchParameter[] searchParameters {
      get { return this.searchParametersField; }
      set { this.searchParametersField = value; }
    }

    public IdeaType ideaType {
      get { return this.ideaTypeField; }
      set {
        this.ideaTypeField = value;
        this.ideaTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ideaTypeSpecified {
      get { return this.ideaTypeFieldSpecified; }
      set { this.ideaTypeFieldSpecified = value; }
    }

    public RequestType requestType {
      get { return this.requestTypeField; }
      set {
        this.requestTypeField = value;
        this.requestTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool requestTypeSpecified {
      get { return this.requestTypeFieldSpecified; }
      set { this.requestTypeFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("requestedAttributeTypes")]
    public AttributeType[] requestedAttributeTypes {
      get { return this.requestedAttributeTypesField; }
      set { this.requestedAttributeTypesField = value; }
    }

    public Paging paging {
      get { return this.pagingField; }
      set { this.pagingField = value; }
    }

    public string localeCode {
      get { return this.localeCodeField; }
      set { this.localeCodeField = value; }
    }

    public string currencyCode {
      get { return this.currencyCodeField; }
      set { this.currencyCodeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public enum RequestType {
    IDEAS,
    STATS
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class TrafficEstimatorError : ApiError {
    private TrafficEstimatorErrorReason reasonField;

    private bool reasonFieldSpecified;

    public TrafficEstimatorErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TrafficEstimatorError.Reason", Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public enum TrafficEstimatorErrorReason {
    NO_CAMPAIGN_FOR_AD_GROUP_ESTIMATE_REQUEST,
    NO_AD_GROUP_FOR_KEYWORD_ESTIMATE_REQUEST,
    NO_MAX_CPC_FOR_KEYWORD_ESTIMATE_REQUEST,
    TOO_MANY_KEYWORD_ESTIMATE_REQUESTS,
    TOO_MANY_CAMPAIGN_ESTIMATE_REQUESTS,
    TOO_MANY_ADGROUP_ESTIMATE_REQUESTS,
    TOO_MANY_TARGETS,
    INVALID_INPUT,
    SERVICE_UNAVAILABLE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class TargetingIdeaError : ApiError {
    private TargetingIdeaErrorReason reasonField;

    private bool reasonFieldSpecified;

    public TargetingIdeaErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TargetingIdeaError.Reason", Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public enum TargetingIdeaErrorReason {
    DUPLICATE_SEARCH_FILTER_TYPES_PRESENT,
    INSUFFICIENT_SEARCH_PARAMETERS,
    INVALID_ATTRIBUTE_TYPE,
    INVALID_SEARCH_PARAMETERS,
    MUTUALLY_EXCLUSIVE_SEARCH_PARAMETERS_IN_QUERY,
    SERVICE_UNAVAILABLE,
    INVALID_URL_IN_SEARCH_PARAMETER,
    TOO_MANY_RESULTS_REQUESTED,
    NO_PAGING_IN_SELECTOR
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class MatchesRegexError : ApiError {
    private MatchesRegexErrorReason reasonField;

    private bool reasonFieldSpecified;

    public MatchesRegexErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "MatchesRegexError.Reason", Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public enum MatchesRegexErrorReason {
    UNKNOWN,
    DOES_NOT_MATCH
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class CurrencyCodeError : ApiError {
    private CurrencyCodeErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CurrencyCodeErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CurrencyCodeError.Reason", Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public enum CurrencyCodeErrorReason {
    UNSUPPORTED_CURRENCY_CODE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "TrafficEstimatorServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Estimate))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(EstimateRequest))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class TrafficEstimatorService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public TrafficEstimatorService() {
      this.Url = "https://adwords.google.com/api/adwords/o/v201109/TrafficEstimatorService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/o/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/o/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual TrafficEstimatorResult get(TrafficEstimatorSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((TrafficEstimatorResult) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class StatsEstimate {
    private Money averageCpcField;

    private double averagePositionField;

    private bool averagePositionFieldSpecified;

    private float clicksPerDayField;

    private bool clicksPerDayFieldSpecified;

    private Money totalCostField;

    public Money averageCpc {
      get { return this.averageCpcField; }
      set { this.averageCpcField = value; }
    }

    public double averagePosition {
      get { return this.averagePositionField; }
      set {
        this.averagePositionField = value;
        this.averagePositionSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool averagePositionSpecified {
      get { return this.averagePositionFieldSpecified; }
      set { this.averagePositionFieldSpecified = value; }
    }

    public float clicksPerDay {
      get { return this.clicksPerDayField; }
      set {
        this.clicksPerDayField = value;
        this.clicksPerDaySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool clicksPerDaySpecified {
      get { return this.clicksPerDayFieldSpecified; }
      set { this.clicksPerDayFieldSpecified = value; }
    }

    public Money totalCost {
      get { return this.totalCostField; }
      set { this.totalCostField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignEstimate))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(KeywordEstimate))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupEstimate))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class Estimate {
    private string estimateTypeField;

    [System.Xml.Serialization.XmlElementAttribute("Estimate.Type")]
    public string EstimateType {
      get { return this.estimateTypeField; }
      set { this.estimateTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class CampaignEstimate : Estimate {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private AdGroupEstimate[] adGroupEstimatesField;

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("adGroupEstimates")]
    public AdGroupEstimate[] adGroupEstimates {
      get { return this.adGroupEstimatesField; }
      set { this.adGroupEstimatesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class AdGroupEstimate : Estimate {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private KeywordEstimate[] keywordEstimatesField;

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("keywordEstimates")]
    public KeywordEstimate[] keywordEstimates {
      get { return this.keywordEstimatesField; }
      set { this.keywordEstimatesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class KeywordEstimate : Estimate {
    private long criterionIdField;

    private bool criterionIdFieldSpecified;

    private StatsEstimate minField;

    private StatsEstimate maxField;

    public long criterionId {
      get { return this.criterionIdField; }
      set {
        this.criterionIdField = value;
        this.criterionIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool criterionIdSpecified {
      get { return this.criterionIdFieldSpecified; }
      set { this.criterionIdFieldSpecified = value; }
    }

    public StatsEstimate min {
      get { return this.minField; }
      set { this.minField = value; }
    }

    public StatsEstimate max {
      get { return this.maxField; }
      set { this.maxField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class TrafficEstimatorResult {
    private CampaignEstimate[] campaignEstimatesField;

    private string dummyField;

    [System.Xml.Serialization.XmlElementAttribute("campaignEstimates")]
    public CampaignEstimate[] campaignEstimates {
      get { return this.campaignEstimatesField; }
      set { this.campaignEstimatesField = value; }
    }

    public string dummy {
      get { return this.dummyField; }
      set { this.dummyField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignEstimateRequest))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(KeywordEstimateRequest))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupEstimateRequest))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public abstract partial class EstimateRequest {
    private string estimateRequestTypeField;

    [System.Xml.Serialization.XmlElementAttribute("EstimateRequest.Type")]
    public string EstimateRequestType {
      get { return this.estimateRequestTypeField; }
      set { this.estimateRequestTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class CampaignEstimateRequest : EstimateRequest {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private AdGroupEstimateRequest[] adGroupEstimateRequestsField;

    private Criterion[] criteriaField;

    private NetworkSetting networkSettingField;

    private Money dailyBudgetField;

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("adGroupEstimateRequests")]
    public AdGroupEstimateRequest[] adGroupEstimateRequests {
      get { return this.adGroupEstimateRequestsField; }
      set { this.adGroupEstimateRequestsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("criteria")]
    public Criterion[] criteria {
      get { return this.criteriaField; }
      set { this.criteriaField = value; }
    }

    public NetworkSetting networkSetting {
      get { return this.networkSettingField; }
      set { this.networkSettingField = value; }
    }

    public Money dailyBudget {
      get { return this.dailyBudgetField; }
      set { this.dailyBudgetField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class AdGroupEstimateRequest : EstimateRequest {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private KeywordEstimateRequest[] keywordEstimateRequestsField;

    private Money maxCpcField;

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("keywordEstimateRequests")]
    public KeywordEstimateRequest[] keywordEstimateRequests {
      get { return this.keywordEstimateRequestsField; }
      set { this.keywordEstimateRequestsField = value; }
    }

    public Money maxCpc {
      get { return this.maxCpcField; }
      set { this.maxCpcField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class KeywordEstimateRequest : EstimateRequest {
    private Keyword keywordField;

    private Money maxCpcField;

    private bool isNegativeField;

    private bool isNegativeFieldSpecified;

    public Keyword keyword {
      get { return this.keywordField; }
      set { this.keywordField = value; }
    }

    public Money maxCpc {
      get { return this.maxCpcField; }
      set { this.maxCpcField = value; }
    }

    public bool isNegative {
      get { return this.isNegativeField; }
      set {
        this.isNegativeField = value;
        this.isNegativeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isNegativeSpecified {
      get { return this.isNegativeFieldSpecified; }
      set { this.isNegativeFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class TrafficEstimatorSelector {
    private CampaignEstimateRequest[] campaignEstimateRequestsField;

    private string dummyField;

    [System.Xml.Serialization.XmlElementAttribute("campaignEstimateRequests")]
    public CampaignEstimateRequest[] campaignEstimateRequests {
      get { return this.campaignEstimateRequestsField; }
      set { this.campaignEstimateRequestsField = value; }
    }

    public string dummy {
      get { return this.dummyField; }
      set { this.dummyField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "UserListServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class UserListService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public UserListService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201109/UserListService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual UserListPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] {serviceSelector});
      return ((UserListPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual UserListReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
UserListOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((UserListReturnValue) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class UserListReturnValue : ListReturnValue {
    private UserList[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public UserList[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RemarketingUserList))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LogicalUserList))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExternalRemarketingUserList))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class UserList {
    private long idField;

    private bool idFieldSpecified;

    private bool isReadOnlyField;

    private bool isReadOnlyFieldSpecified;

    private string nameField;

    private string descriptionField;

    private UserListMembershipStatus statusField;

    private bool statusFieldSpecified;

    private AccessReason accessReasonField;

    private bool accessReasonFieldSpecified;

    private AccountUserListStatus accountUserListStatusField;

    private bool accountUserListStatusFieldSpecified;

    private long membershipLifeSpanField;

    private bool membershipLifeSpanFieldSpecified;

    private long sizeField;

    private bool sizeFieldSpecified;

    private SizeRange sizeRangeField;

    private bool sizeRangeFieldSpecified;

    private UserListType typeField;

    private bool typeFieldSpecified;

    private string userListTypeField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public bool isReadOnly {
      get { return this.isReadOnlyField; }
      set {
        this.isReadOnlyField = value;
        this.isReadOnlySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isReadOnlySpecified {
      get { return this.isReadOnlyFieldSpecified; }
      set { this.isReadOnlyFieldSpecified = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public string description {
      get { return this.descriptionField; }
      set { this.descriptionField = value; }
    }

    public UserListMembershipStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    public AccessReason accessReason {
      get { return this.accessReasonField; }
      set {
        this.accessReasonField = value;
        this.accessReasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool accessReasonSpecified {
      get { return this.accessReasonFieldSpecified; }
      set { this.accessReasonFieldSpecified = value; }
    }

    public AccountUserListStatus accountUserListStatus {
      get { return this.accountUserListStatusField; }
      set {
        this.accountUserListStatusField = value;
        this.accountUserListStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool accountUserListStatusSpecified {
      get { return this.accountUserListStatusFieldSpecified; }
      set { this.accountUserListStatusFieldSpecified = value; }
    }

    public long membershipLifeSpan {
      get { return this.membershipLifeSpanField; }
      set {
        this.membershipLifeSpanField = value;
        this.membershipLifeSpanSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool membershipLifeSpanSpecified {
      get { return this.membershipLifeSpanFieldSpecified; }
      set { this.membershipLifeSpanFieldSpecified = value; }
    }

    public long size {
      get { return this.sizeField; }
      set {
        this.sizeField = value;
        this.sizeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool sizeSpecified {
      get { return this.sizeFieldSpecified; }
      set { this.sizeFieldSpecified = value; }
    }

    public SizeRange sizeRange {
      get { return this.sizeRangeField; }
      set {
        this.sizeRangeField = value;
        this.sizeRangeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool sizeRangeSpecified {
      get { return this.sizeRangeFieldSpecified; }
      set { this.sizeRangeFieldSpecified = value; }
    }

    public UserListType type {
      get { return this.typeField; }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get { return this.typeFieldSpecified; }
      set { this.typeFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("UserList.Type")]
    public string UserListType {
      get { return this.userListTypeField; }
      set { this.userListTypeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum UserListMembershipStatus {
    OPEN,
    CLOSED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AccessReason {
    OWNED,
    SHARED,
    LICENSED,
    SUBSCRIBED
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AccountUserListStatus {
    ACTIVE,
    INACTIVE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum SizeRange {
    LESS_THAN_FIVE_HUNDRED,
    LESS_THAN_ONE_THOUSAND,
    ONE_THOUSAND_TO_TEN_THOUSAND,
    TEN_THOUSAND_TO_FIFTY_THOUSAND,
    FIFTY_THOUSAND_TO_ONE_HUNDRED_THOUSAND,
    ONE_HUNDRED_THOUSAND_TO_THREE_HUNDRED_THOUSAND,
    THREE_HUNDRED_THOUSAND_TO_FIVE_HUNDRED_THOUSAND,
    FIVE_HUNDRED_THOUSAND_TO_ONE_MILLION,
    ONE_MILLION_TO_TWO_MILLION,
    TWO_MILLION_TO_THREE_MILLION,
    THREE_MILLION_TO_FIVE_MILLION,
    FIVE_MILLION_TO_TEN_MILLION,
    TEN_MILLION_TO_TWENTY_MILLION,
    TWENTY_MILLION_TO_THIRTY_MILLION,
    THIRTY_MILLION_TO_FIFTY_MILLION,
    OVER_FIFTY_MILLION
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "UserList.Type", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum UserListType {
    EXTERNAL_REMARKETING,
    LOGICAL,
    REMARKETING,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class RemarketingUserList : UserList {
    private UserListConversionType[] conversionTypesField;

    [System.Xml.Serialization.XmlElementAttribute("conversionTypes")]
    public UserListConversionType[] conversionTypes {
      get { return this.conversionTypesField; }
      set { this.conversionTypesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class UserListConversionType {
    private long idField;

    private bool idFieldSpecified;

    private string nameField;

    private UserListConversionTypeCategory categoryField;

    private bool categoryFieldSpecified;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public UserListConversionTypeCategory category {
      get { return this.categoryField; }
      set {
        this.categoryField = value;
        this.categorySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool categorySpecified {
      get { return this.categoryFieldSpecified; }
      set { this.categoryFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "UserListConversionType.Category", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum UserListConversionTypeCategory {
    BOOMERANG_EVENT,
    OTHER
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class LogicalUserList : UserList {
    private UserListLogicalRule[] rulesField;

    [System.Xml.Serialization.XmlElementAttribute("rules")]
    public UserListLogicalRule[] rules {
      get { return this.rulesField; }
      set { this.rulesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class UserListLogicalRule {
    private UserListLogicalRuleOperator operatorField;

    private bool operatorFieldSpecified;

    private LogicalUserListOperand[] ruleOperandsField;

    public UserListLogicalRuleOperator @operator {
      get { return this.operatorField; }
      set {
        this.operatorField = value;
        this.operatorSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool operatorSpecified {
      get { return this.operatorFieldSpecified; }
      set { this.operatorFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ruleOperands")]
    public LogicalUserListOperand[] ruleOperands {
      get { return this.ruleOperandsField; }
      set { this.ruleOperandsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "UserListLogicalRule.Operator", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum UserListLogicalRuleOperator {
    ALL,
    ANY,
    NONE,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class LogicalUserListOperand {
    private object itemField;

    [System.Xml.Serialization.XmlElementAttribute("UserInterest", typeof(UserInterest))]
    [System.Xml.Serialization.XmlElementAttribute("UserList", typeof(UserList))]
    public object Item {
      get { return this.itemField; }
      set { this.itemField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class UserInterest {
    private long idField;

    private bool idFieldSpecified;

    private string nameField;

    private SizeRange sizeRangeField;

    private bool sizeRangeFieldSpecified;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public SizeRange sizeRange {
      get { return this.sizeRangeField; }
      set {
        this.sizeRangeField = value;
        this.sizeRangeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool sizeRangeSpecified {
      get { return this.sizeRangeFieldSpecified; }
      set { this.sizeRangeFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class ExternalRemarketingUserList : UserList {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class UserListOperation : Operation {
    private UserList operandField;

    public UserList operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class UserListPage : Page {
    private UserList[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public UserList[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class UserListError : ApiError {
    private UserListErrorReason reasonField;

    private bool reasonFieldSpecified;

    public UserListErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "UserListError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum UserListErrorReason {
    EXTERNAL_REMARKETING_USER_LIST_MUTATE_NOT_SUPPORTED,
    CONCRETE_TYPE_REQUIRED,
    CONVERSION_TYPE_ID_REQUIRED,
    DUPLICATE_CONVERSION_TYPES,
    INVALID_CONVERSION_TYPE,
    INVALID_DESCRIPTION,
    INVALID_NAME,
    INVALID_USER_INTEREST_LOGICAL_RULE_OPERAND,
    INVALID_USER_LIST_LOGICAL_RULE_OPERAND,
    MEMBERSHIP_LIFE_SPAN_NOT_POSITIVE,
    NAME_ALREADY_USED,
    NEW_CONVERSION_TYPE_NAME_REQUIRED,
    OWNERSHIP_REQUIRED_FOR_SET,
    REMOVE_NOT_SUPPORTED,
    USER_LIST_MUTATE_NOT_SUPPORTED,
    USER_LIST_SERVICE_ERROR
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AdGroupAdServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Stats))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class AdGroupAdService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public AdGroupAdService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201109/AdGroupAdService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupAdPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] {serviceSelector});
      return ((AdGroupAdPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupAdReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
AdGroupAdOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((AdGroupAdReturnValue) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupAdReturnValue : ListReturnValue {
    private AdGroupAd[] valueField;

    private ApiError[] partialFailureErrorsField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdGroupAd[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("partialFailureErrors")]
    public ApiError[] partialFailureErrors {
      get { return this.partialFailureErrorsField; }
      set { this.partialFailureErrorsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupAdPage : Page {
    private AdGroupAd[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public AdGroupAd[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AdGroupCriterionServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class AdGroupCriterionService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public AdGroupCriterionService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201109/AdGroupCriterionService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupCriterionPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] {serviceSelector});
      return ((AdGroupCriterionPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupCriterionReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
AdGroupCriterionOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((AdGroupCriterionReturnValue) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupCriterionReturnValue : ListReturnValue {
    private AdGroupCriterion[] valueField;

    private ApiError[] partialFailureErrorsField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdGroupCriterion[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("partialFailureErrors")]
    public ApiError[] partialFailureErrors {
      get { return this.partialFailureErrorsField; }
      set { this.partialFailureErrorsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupCriterionPage : Page {
    private AdGroupCriterion[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public AdGroupCriterion[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AdGroupServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class AdGroupService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public AdGroupService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201109/AdGroupService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] {serviceSelector});
      return ((AdGroupPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
AdGroupOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((AdGroupReturnValue) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupReturnValue : ListReturnValue {
    private AdGroup[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdGroup[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdGroupPage : Page {
    private AdGroup[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public AdGroup[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AdParamServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class AdParamService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public AdParamService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201109/AdParamService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdParamPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] {serviceSelector});
      return ((AdParamPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdParam[] mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
AdParamOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((AdParam[]) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdParamOperation : Operation {
    private AdParam operandField;

    public AdParam operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdParam {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private long criterionIdField;

    private bool criterionIdFieldSpecified;

    private string insertionTextField;

    private int paramIndexField;

    private bool paramIndexFieldSpecified;

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }

    public long criterionId {
      get { return this.criterionIdField; }
      set {
        this.criterionIdField = value;
        this.criterionIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool criterionIdSpecified {
      get { return this.criterionIdFieldSpecified; }
      set { this.criterionIdFieldSpecified = value; }
    }

    public string insertionText {
      get { return this.insertionTextField; }
      set { this.insertionTextField = value; }
    }

    public int paramIndex {
      get { return this.paramIndexField; }
      set {
        this.paramIndexField = value;
        this.paramIndexSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool paramIndexSpecified {
      get { return this.paramIndexFieldSpecified; }
      set { this.paramIndexFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdParamPage {
    private AdParam[] entriesField;

    private int totalNumEntriesField;

    private bool totalNumEntriesFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public AdParam[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }

    public int totalNumEntries {
      get { return this.totalNumEntriesField; }
      set {
        this.totalNumEntriesField = value;
        this.totalNumEntriesSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool totalNumEntriesSpecified {
      get { return this.totalNumEntriesFieldSpecified; }
      set { this.totalNumEntriesFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdParamPolicyError : PolicyViolationError {
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class AdParamError : ApiError {
    private AdParamErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdParamErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdParamError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public enum AdParamErrorReason {
    AD_PARAM_CANNOT_BE_SPECIFIED_MULTIPLE_TIMES,
    AD_PARAM_DOES_NOT_EXIST,
    CRITERION_SPECIFIED_MUST_BE_KEYWORD,
    INVALID_ADGROUP_CRITERION_SPECIFIED,
    INVALID_INSERTION_TEXT_FORMAT,
    MUST_SPECIFY_ADGROUP_ID,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AlertServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class AlertService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public AlertService() {
      this.Url = "https://adwords.google.com/api/adwords/mcm/v201109/AlertService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/mcm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/mcm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AlertPage get(AlertSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((AlertPage) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public partial class Detail {
    private string triggerTimeField;

    public string triggerTime {
      get { return this.triggerTimeField; }
      set { this.triggerTimeField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public partial class Alert {
    private AlertSeverity alertSeverityField;

    private bool alertSeverityFieldSpecified;

    private AlertType alertTypeField;

    private bool alertTypeFieldSpecified;

    private long clientCustomerIdField;

    private bool clientCustomerIdFieldSpecified;

    private Detail[] detailsField;

    public AlertSeverity alertSeverity {
      get { return this.alertSeverityField; }
      set {
        this.alertSeverityField = value;
        this.alertSeveritySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool alertSeveritySpecified {
      get { return this.alertSeverityFieldSpecified; }
      set { this.alertSeverityFieldSpecified = value; }
    }

    public AlertType alertType {
      get { return this.alertTypeField; }
      set {
        this.alertTypeField = value;
        this.alertTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool alertTypeSpecified {
      get { return this.alertTypeFieldSpecified; }
      set { this.alertTypeFieldSpecified = value; }
    }

    public long clientCustomerId {
      get { return this.clientCustomerIdField; }
      set {
        this.clientCustomerIdField = value;
        this.clientCustomerIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool clientCustomerIdSpecified {
      get { return this.clientCustomerIdFieldSpecified; }
      set { this.clientCustomerIdFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("details")]
    public Detail[] details {
      get { return this.detailsField; }
      set { this.detailsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public enum AlertSeverity {
    GREEN,
    YELLOW,
    RED,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public enum AlertType {
    ACCOUNT_ON_TARGET,
    DECLINED_PAYMENT,
    CREDIT_CARD_EXPIRING,
    ACCOUNT_BUDGET_ENDING,
    CAMPAIGN_ENDING,
    PAYMENT_NOT_ENTERED,
    MISSING_BANK_REFERENCE_NUMBER,
    CAMPAIGN_ENDED,
    ACCOUNT_BUDGET_BURN_RATE,
    USER_INVITE_PENDING,
    USER_INVITE_ACCEPTED,
    MANAGER_LINK_PENDING,
    ZERO_DAILY_SPENDING_LIMIT,
    TV_ACCOUNT_ON_TARGET,
    TV_ACCOUNT_BUDGET_ENDING,
    TV_ZERO_DAILY_SPENDING_LIMIT,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public partial class AlertPage : NoStatsPage {
    private Alert[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public Alert[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public partial class AlertQuery {
    private ClientSpec clientSpecField;

    private bool clientSpecFieldSpecified;

    private FilterSpec filterSpecField;

    private bool filterSpecFieldSpecified;

    private AlertType[] typesField;

    private AlertSeverity[] severitiesField;

    private TriggerTimeSpec triggerTimeSpecField;

    private bool triggerTimeSpecFieldSpecified;

    private string triggerTimeField;

    private long[] clientCustomerIdsField;

    public ClientSpec clientSpec {
      get { return this.clientSpecField; }
      set {
        this.clientSpecField = value;
        this.clientSpecSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool clientSpecSpecified {
      get { return this.clientSpecFieldSpecified; }
      set { this.clientSpecFieldSpecified = value; }
    }

    public FilterSpec filterSpec {
      get { return this.filterSpecField; }
      set {
        this.filterSpecField = value;
        this.filterSpecSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool filterSpecSpecified {
      get { return this.filterSpecFieldSpecified; }
      set { this.filterSpecFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("types")]
    public AlertType[] types {
      get { return this.typesField; }
      set { this.typesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("severities")]
    public AlertSeverity[] severities {
      get { return this.severitiesField; }
      set { this.severitiesField = value; }
    }

    public TriggerTimeSpec triggerTimeSpec {
      get { return this.triggerTimeSpecField; }
      set {
        this.triggerTimeSpecField = value;
        this.triggerTimeSpecSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool triggerTimeSpecSpecified {
      get { return this.triggerTimeSpecFieldSpecified; }
      set { this.triggerTimeSpecFieldSpecified = value; }
    }

    public string triggerTime {
      get { return this.triggerTimeField; }
      set { this.triggerTimeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("clientCustomerIds")]
    public long[] clientCustomerIds {
      get { return this.clientCustomerIdsField; }
      set { this.clientCustomerIdsField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public enum ClientSpec {
    ALL,
    DIRECT,
    ID_LIST,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public enum FilterSpec {
    ALL,
    ONLY_SUBMANAGERS,
    ONLY_LEAF_CLIENTS,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public enum TriggerTimeSpec {
    ALL_TIME,
    CUSTOM_TIME,
    LAST_24_HOURS,
    LAST_7_DAYS
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public partial class AlertSelector {
    private AlertQuery queryField;

    private Paging pagingField;

    public AlertQuery query {
      get { return this.queryField; }
      set { this.queryField = value; }
    }

    public Paging paging {
      get { return this.pagingField; }
      set { this.pagingField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public partial class AlertError : ApiError {
    private AlertErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AlertErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AlertError.Reason", Namespace = "https://adwords.google.com/api/adwords/mcm/v201109")]
  public enum AlertErrorReason {
    NO_CLIENT_IDS_SELECTED,
    INVALID_CLIENT_ID_SELECTED,
    INVALID_CLIENT_ID_FORMAT,
    UNAVAILABLE,
    UNKNOWN
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "BulkMutateJobServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(JobEvent))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(JobSelector))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class BulkMutateJobService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public BulkMutateJobService() {
      this.Url = "https://adwords.google.com/api/adwords/job/v201109/BulkMutateJobService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual BulkMutateJob[] get(BulkMutateJobSelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((BulkMutateJob[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual BulkMutateJob mutate(JobOperation operation) {
      object[] results = this.Invoke("mutate", new object[] {operation});
      return ((BulkMutateJob) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class JobOperation : Operation {
    private Job operandField;

    public Job operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "BulkOpportunityServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataEntry))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class BulkOpportunityService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public BulkOpportunityService() {
      this.Url = "https://adwords.google.com/api/adwords/o/v201109/BulkOpportunityService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/o/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/o/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual BulkOpportunityPage get(BulkOpportunitySelector selector) {
      object[] results = this.Invoke("get", new object[] {selector});
      return ((BulkOpportunityPage) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class OpportunityAttribute_AttributeMapEntry {
    private OpportunityAttributeType keyField;

    private bool keyFieldSpecified;

    private Attribute valueField;

    public OpportunityAttributeType key {
      get { return this.keyField; }
      set {
        this.keyField = value;
        this.keySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool keySpecified {
      get { return this.keyFieldSpecified; }
      set { this.keyFieldSpecified = value; }
    }

    public Attribute value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public enum OpportunityAttributeType {
    UNKNOWN,
    IDEA_TYPE,
    CUSTOMER_ID,
    CAMPAIGN_ID,
    ADGROUP_ID,
    KEYWORD,
    CURRENT_BUDGET,
    NEW_BUDGET,
    CURRENT_BID,
    NEW_BID,
    IMPRESSIONS_CHANGE,
    CLICKS_CHANGE,
    COST_CHANGE,
    AVERAGE_MONTHLY_SEARCHES,
    BID_LANDSCAPE
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class OpportunityIdea {
    private OpportunityAttribute_AttributeMapEntry[] dataField;

    private string dummyField;

    [System.Xml.Serialization.XmlElementAttribute("data")]
    public OpportunityAttribute_AttributeMapEntry[] data {
      get { return this.dataField; }
      set { this.dataField = value; }
    }

    public string dummy {
      get { return this.dummyField; }
      set { this.dummyField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class Opportunity {
    private OpportunityIdea[] opportunityIdeasField;

    private string dummyField;

    [System.Xml.Serialization.XmlElementAttribute("opportunityIdeas")]
    public OpportunityIdea[] opportunityIdeas {
      get { return this.opportunityIdeasField; }
      set { this.opportunityIdeasField = value; }
    }

    public string dummy {
      get { return this.dummyField; }
      set { this.dummyField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class BulkOpportunityPage {
    private Opportunity[] entriesField;

    private int totalNumEntriesField;

    private bool totalNumEntriesFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public Opportunity[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }

    public int totalNumEntries {
      get { return this.totalNumEntriesField; }
      set {
        this.totalNumEntriesField = value;
        this.totalNumEntriesSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool totalNumEntriesSpecified {
      get { return this.totalNumEntriesFieldSpecified; }
      set { this.totalNumEntriesFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class BulkOpportunitySelector {
    private OpportunityIdeaType[] ideaTypesField;

    private OpportunityAttributeType[] requestedAttributeTypesField;

    private Paging pagingField;

    [System.Xml.Serialization.XmlElementAttribute("ideaTypes")]
    public OpportunityIdeaType[] ideaTypes {
      get { return this.ideaTypesField; }
      set { this.ideaTypesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("requestedAttributeTypes")]
    public OpportunityAttributeType[] requestedAttributeTypes {
      get { return this.requestedAttributeTypesField; }
      set { this.requestedAttributeTypesField = value; }
    }

    public Paging paging {
      get { return this.pagingField; }
      set { this.pagingField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class OpportunityError : ApiError {
    private OpportunityErrorReason reasonField;

    private bool reasonFieldSpecified;

    public OpportunityErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "OpportunityError.Reason", Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public enum OpportunityErrorReason {
    OPPORTUNITY_DOES_NOT_EXIST,
    RPC_ERROR
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public partial class BulkOpportunityServiceError : ApiError {
    private BulkOpportunityServiceErrorReason reasonField;

    private bool reasonFieldSpecified;

    public BulkOpportunityServiceErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BulkOpportunityServiceError.Reason", Namespace = "https://adwords.google.com/api/adwords/o/v201109")]
  public enum BulkOpportunityServiceErrorReason {
    TOO_MANY_RESULTS_REQUESTED,
    INVALID_PAGING,
    BULK_OPPORTUNITY_SERVICE_ERROR
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "CampaignAdExtensionServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Stats))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class CampaignAdExtensionService : AdWordsSoapClient {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public CampaignAdExtensionService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201109/CampaignAdExtensionService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignAdExtensionPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] {serviceSelector});
      return ((CampaignAdExtensionPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201109", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201109", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignAdExtensionReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
CampaignAdExtensionOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] {operations});
      return ((CampaignAdExtensionReturnValue) (results[0]));
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignAdExtensionReturnValue : ListReturnValue {
    private CampaignAdExtension[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public CampaignAdExtension[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201109")]
  public partial class CampaignAdExtensionPage : Page {
    private CampaignAdExtension[] entriesField;
    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public CampaignAdExtension[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }
}