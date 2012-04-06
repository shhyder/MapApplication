using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Google.Api.Ads.AdWords.Lib;
using Google.Api.Ads.AdWords.v201109;



namespace Web.Models
{
    public class PlacementIdeas
    {


        public string GetPlacement()
        {






            AdWordsUser user = new AdWordsUser();


            // Get the TargetingIdeaService.
            TargetingIdeaService targetingIdeaService =
                (TargetingIdeaService)user.GetService(AdWordsService.v201109.TargetingIdeaService);


            // Create seed url.
            string url = "mars.google.com";

            // Create the selector.
            TargetingIdeaSelector selector = new TargetingIdeaSelector();
            selector.requestType = RequestType.IDEAS;
            selector.ideaType = IdeaType.KEYWORD;

         
            selector.requestedAttributeTypes = new AttributeType[] {AttributeType.AVERAGE_TARGETED_MONTHLY_SEARCHES,AttributeType.TARGETED_MONTHLY_SEARCHES,
          AttributeType.IDEA_TYPE};

            // Create related to url search parameter.
            Keyword ky = new Keyword();
            ky.matchType = KeywordMatchType.EXACT;
            ky.text = "Paris";
            RelatedToKeywordSearchParameter relatedToKeywordSearchParameter = new RelatedToKeywordSearchParameter();
            relatedToKeywordSearchParameter.keywords = new Keyword[] {ky};
            //relatedToKeywordSearchParameter.SearchParameterType =  
            //relatedToUrlSearchParameter.urls = new string[] { url };
            //relatedToUrlSearchParameter.includeSubUrls = false;
            selector.searchParameters = new SearchParameter[] { relatedToKeywordSearchParameter };

            
            // Set selector paging.
            selector.paging = new Paging();

            int offset = 0;
            int pageSize = 500;

            TargetingIdeaPage page = new TargetingIdeaPage();

            try
            {
                do
                {
                    selector.paging.startIndex = offset;
                    selector.paging.numberResults = pageSize;

                    // Get placement ideas.
                    page = targetingIdeaService.get(selector);

                    // Display the results.
                    if (page != null && page.entries != null)
                    {
                        int i = offset;

                        foreach (TargetingIdea idea in page.entries)
                        {
                            foreach (Type_AttributeMapEntry entry in idea.data)
                            {
                                if (entry.key == AttributeType.CRITERION)
                                {
                                    CriterionAttribute placementAttribute = entry.value as CriterionAttribute;
                                    Placement placement = (Placement)placementAttribute.value;
                                    //writer.WriteLine("Related placement urls were found at '{0}'.",
                                     //   (placementAttribute.value as Placement).url);
                                }

                                if (entry.key == AttributeType.TARGETED_MONTHLY_SEARCHES )
                                {
                                    MonthlySearchVolumeAttribute msVAttribute = entry.value as MonthlySearchVolumeAttribute;
                                    //Placement placement = (Placement)msVAttribute.value;
                                    //writer.WriteLine("Related placement urls were found at '{0}'.",
                                    //   (placementAttribute.value as Placement).url);
                                }
                            }
                            i++;
                        }
                    }
                    offset += pageSize;
                } while (offset < page.totalNumEntries);
                //writer.WriteLine("Number of related placements found: {0}", page.totalNumEntries);
            }
            catch (Exception ex)
            {
                throw new System.ApplicationException("Failed to retrieve related placements.", ex);
            }

            return "";
        }

    }


}