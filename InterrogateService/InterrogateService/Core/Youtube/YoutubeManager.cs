using Google.Apis.YouTube.v3;
using Google.Apis.Services;
using System.Collections.Generic;
using InterrogateService.Core.Common.Interfaces;

namespace InterrogateService.Core.Youtube
{
    public class YoutubeManager : IInterrogateService
    {
        private YouTubeService _youtubeService { get; set; }

        private YouTubeService youtubeService
        {
            get
            {
                if (_youtubeService != null)
                    return _youtubeService;

                _youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = "AIzaSyCnhCLd24zICvGgU_AagWtypes81FO2gKE"
                });

                return _youtubeService;
            }
        }

        public void Interrogate(IEnumerable<SocialMediaSource> youtubeChannels)
        {
            foreach (var youtubeChannel in youtubeChannels)
            {
                var searchListRequest = youtubeService.Search.List("snippet");
                searchListRequest.Type = "video";
                searchListRequest.MaxResults = 5;
                searchListRequest.ChannelId = youtubeChannel.Id;
                searchListRequest.Order = SearchResource.ListRequest.OrderEnum.Date;

                var searchListResult = searchListRequest.Execute();

                foreach (var item in searchListResult.Items)
                {
                    //TODO: Логика
                }
            }
        }
    }
}
