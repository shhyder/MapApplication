using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Security;
using Google.Api.Ads.AdWords.Lib;
using Google.Api.Ads.AdWords.v201109;

namespace BusinessLogic.Marker
{
    public class GoogleSearchCount
    {
        int _marker_ID;

        public GoogleSearchCount(int marker_ID)
        {
            _marker_ID = marker_ID;
        }

        public string GetCount(ref DataSet.DSParameter ds)
        {
            

            string keyword = ds.Marker[0].Marker_Tag;



            AdWordsUser user = new AdWordsUser();


            // Get the TargetingIdeaService.
            TargetingIdeaService targetingIdeaService =
                (TargetingIdeaService)user.GetService(AdWordsService.v201109.TargetingIdeaService);


         
            // Create the selector.
            TargetingIdeaSelector selector = new TargetingIdeaSelector();
            selector.requestType = RequestType.IDEAS;
            selector.ideaType = IdeaType.KEYWORD;


            selector.requestedAttributeTypes = new AttributeType[] {AttributeType.TARGETED_MONTHLY_SEARCHES};

            // Create related to url search parameter.
            Keyword ky = new Keyword();
            ky.matchType = KeywordMatchType.EXACT;
            ky.text = keyword;
            RelatedToKeywordSearchParameter relatedToKeywordSearchParameter = new RelatedToKeywordSearchParameter();
            relatedToKeywordSearchParameter.keywords = new Keyword[] { ky };
            //relatedToKeywordSearchParameter.SearchParameterType =  
            //relatedToUrlSearchParameter.urls = new string[] { url };
            //relatedToUrlSearchParameter.includeSubUrls = false;
            selector.searchParameters = new SearchParameter[] { relatedToKeywordSearchParameter };


            // Set selector paging.
            selector.paging = new Paging();

            int offset = 0;
            int pageSize = 1;

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

                                if (entry.key == AttributeType.TARGETED_MONTHLY_SEARCHES)
                                {
                                    MonthlySearchVolumeAttribute msVAttribute = entry.value as MonthlySearchVolumeAttribute;

                                    foreach( MonthlySearchVolume msv in msVAttribute.value )
                                    {
                                        ds.Keyword.AddKeywordRow(0, msv.month,msv.year, 1, _marker_ID, 2, 2, DateTime.Now,
                                                        Convert.ToInt32( msv.count ), 0);
                                    }
                                 
                                    
         
                                    
                                    
                                    //Placement placement = (Placement)msVAttribute.value;
                                    //writer.WriteLine("Related placement urls were found at '{0}'.",
                                    //   (placementAttribute.value as Placement).url);
                                }


                                if (entry.key == AttributeType.AVERAGE_TARGETED_MONTHLY_SEARCHES)
                                {
                                    
                                    //MonthlySearchVolumeAttribute msVAttribute = entry.value as MonthlySearchVolumeAttribute;


                                    //ds.Keyword.AddKeywordRow(0, 0, 0, 1, _marker_ID, 2, 2, DateTime.Now,
                                    //                    0, 0);



                                    //Placement placement = (Placement)msVAttribute.value;
                                    //writer.WriteLine("Related placement urls were found at '{0}'.",
                                    //   (placementAttribute.value as Placement).url);
                                }
                            }
                            i++;
                        }
                    }
                    offset += pageSize;
                } while (1 != 1);
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
