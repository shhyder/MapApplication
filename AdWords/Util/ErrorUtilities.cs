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
using System.Text;

namespace Google.Api.Ads.AdWords.Util {
  /// <summary>
  /// Provides utility methods for handling API errors.
  /// </summary>
  public class ErrorUtilities {
    /// <summary>
    /// Gets the operation index that corresponds to an ApiError.
    /// </summary>
    /// <param name="fieldPath">The fieldPath from ApiError.</param>
    /// <returns>The operation index, or -1 if the index cannot be retrieved.
    /// </returns>
    public static int GetOperationIndex(string fieldPath) {
      string[] parts = fieldPath.Split('.');

      if (parts.Length > 0 && parts[0].StartsWith("operations[")) {
        int index = 0;
        if (int.TryParse(parts[0].Split(new char[] { '[', ']' })[1], out index)) {
          return index;
        }
      }
      return -1;
    }
  }
}
