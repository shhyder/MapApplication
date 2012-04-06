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

using Google.Api.Ads.Common.Lib;

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Google.Api.Ads.AdWords.Lib {
  /// <summary>
  /// Lists all the services available through this library.
  /// </summary>
  public partial class AdWordsService : AdsService {
    /// <summary>
    /// Gets the OAuth scope parameter for getting request token.
    /// </summary>
    /// <returns>The OAuth scope parameter for AdWords API.</returns>
    public static string GetOAuthScope(AdWordsAppConfig config) {
      return string.Format("{0}/api/adwords/", config.AdWordsApiServer);
    }

    /// <summary>
    /// Creates a service creation parameter for defining an AdWords service.
    /// </summary>
    /// <param name="version">Service version.</param>
    /// <param name="groupName">Group name.</param>
    /// <param name="serviceName">Service name.</param>
    /// <returns>A service creation parameter defining this service.</returns>
    protected static ServiceSignature MakeServiceSignature(string version, string groupName,
        string serviceName) {
      return new AdWordsServiceSignature(version, serviceName, groupName);
    }

    /// <summary>
    /// Creates a service creation parameter for defining a v13 service.
    /// </summary>
    /// <param name="version">Service version, for instance, v13.</param>
    /// <param name="serviceName">Service name, for instance, CampaignService.
    /// </param>
    /// <returns>A service creation parameter defining this service.</returns>
    protected static ServiceSignature MakeLegacyServiceSignature(string version,
        string serviceName) {
      return new LegacyAdwordsServiceSignature(version, serviceName);
    }

    /// <summary>
    /// Gets all service types defined in this service.
    /// </summary>
    /// <returns>The nested types that define service versions under this
    /// service.</returns>
    public override Type[] GetServiceTypes() {
      return MethodInfo.GetCurrentMethod().DeclaringType.GetNestedTypes();
    }
  }
}
