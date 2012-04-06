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

using Google.Api.Ads.AdWords.Lib;
using Google.Api.Ads.Common.Util;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Google.Api.Ads.AdWords.Util.Data {
  /// <summary>
  /// Defines data utility functions for the client library.
  /// </summary>
  public static class DataUtilities {
    /// <summary>
    /// Saves the contents of a sandbox account into an XML.
    /// </summary>
    /// <param name="user">The AdWordsUser to be used for downloading sandbox contents.</param>
    /// <param name="fileName">The XML file to which the dump is to be
    /// saved.</param>
    /// <param name="campaignFields">The list of names of campaign fields that
    /// should be saved.</param>
    /// <param name="adGroupFields">The list of names of ad group fields that
    /// should be saved.</param>
    /// <param name="adFields">The list of names of ad fields that should be
    /// saved.</param>
    /// <param name="criterionFields">The list of names of criterion fields that
    /// should be saved.</param>
    /// <param name="campaignCriterionFields">The list of names of campaign
    /// criterion fields that should be saved.</param>
    public static void DownloadSandboxContents(AdWordsUser user, string fileName,
        string[] campaignFields, string[] adGroupFields, string[] adFields,
        string[] criterionFields, string[] campaignCriterionFields) {
      AccountManager manager = new AccountManager(user);
      LocalClientAccount[] allClients = manager.DownloadAllAccounts(campaignFields, adGroupFields,
          adFields, criterionFields, campaignCriterionFields);

      XmlDocument xDoc = SerializationUtilities.LoadXml("<Accounts/>");

      foreach (LocalClientAccount account in allClients) {
        XmlElement xClient = xDoc.CreateElement("Account");
        SerializeAccount(xClient, account);
        xDoc.DocumentElement.AppendChild(xClient);
      }
      xDoc.Save(fileName);
    }

    /// <summary>
    /// Restores the contents of a sandbox account from an XML.
    /// </summary>
    /// <param name="fileName">The XML file containing a sandbox dump.</param>
    /// <param name="user">The AdWordsUser to be used for uploading file
    /// contents to the sandbox.</param>
    public static void RestoreSandboxContents(AdWordsUser user, string fileName) {
      XmlDocument xDoc = new XmlDocument();
      xDoc.Load(fileName);

      List<LocalClientAccount> allClients = new List<LocalClientAccount>();

      XmlNodeList xClients = xDoc.SelectNodes("Accounts/Account");

      foreach (XmlElement xClient in xClients) {
        allClients.Add(DeSerializeAccount(xClient));
      }

      new AccountManager(user).UploadAllAccounts(allClients);
    }

    /// <summary>
    /// Deserialize an account from an XML node.
    /// </summary>
    /// <param name="accountNode">The XML node that contains serialized data.
    /// </param>
    /// <returns>The deserialized ClientAccount object.</returns>
    private static LocalClientAccount DeSerializeAccount(XmlElement accountNode) {
      XmlNode clientAccountNode = accountNode.SelectSingleNode("ClientAccount");
      XmlDocument xmldoc = new XmlDocument();
      xmldoc.AppendChild(xmldoc.ImportNode(clientAccountNode, true));
      MemoryStream memoryStream = new MemoryStream();
      xmldoc.Save(memoryStream);
      memoryStream.Seek(0, SeekOrigin.Begin);
      return (LocalClientAccount)new XmlSerializer(typeof(LocalClientAccount)).Deserialize(memoryStream);
    }

    /// <summary>
    /// A generic serialization function to serialize an Object as XML.
    /// </summary>
    /// <param name="accountNode">The XML node to which serialization
    /// happens.</param>
    /// <param name="client">The account details to be serialized.</param>
    private static void SerializeAccount(XmlElement accountNode, LocalClientAccount client) {
      MemoryStream memoryStream = new MemoryStream();
      XmlSerializer serializer = new XmlSerializer(typeof(LocalClientAccount));
      serializer.Serialize(memoryStream, client);
      memoryStream.Seek(0, SeekOrigin.Begin);
      XmlDocument xmldoc = new XmlDocument();
      xmldoc.Load(memoryStream);
      XmlNode importedNode = accountNode.OwnerDocument.ImportNode(xmldoc.DocumentElement, true);
      accountNode.AppendChild(importedNode);
    }
  }
}
