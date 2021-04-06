using Google.Apis.YouTube.v3;
using Google.Apis.Services;

namespace InterrogateService.Core.Youtube
{
    public static class YoutubeManager
    {
        public static void Start()
        {
            Interrogate(null);
        }

        public static async void Interrogate(object api)
        {
            var service = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyCnhCLd24zICvGgU_AagWtypes81FO2gKE"
            });

            var searchListRequest = service.Search.List("snippet");
            searchListRequest.ChannelId = "UCCYMY6j5mUvPMPzvN5bxuKA";
            searchListRequest.Type = "video";
            searchListRequest.Order = SearchResource.ListRequest.OrderEnum.Date;

            var searchListResult = searchListRequest.Execute();
        }
    }
}
