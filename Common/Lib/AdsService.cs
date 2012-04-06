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

using System;
using System.Collections.Generic;
using System.Reflection;

namespace Google.Api.Ads.Common.Lib {
  /// <summary>
  /// Lists all the services available through this library.
  /// </summary>
  public abstract class AdsService {
    /// <summary>
    /// Gets all service types defined in this service.
    /// </summary>
    /// <returns>The nested types that define service versions under this
    /// service.</returns>
    public abstract Type[] GetServiceTypes();
  }
}
