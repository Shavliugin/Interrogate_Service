using System.Collections.Generic;
using System.Threading;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace InterrogateService.Core.Vk
{
    public static class VkPublicManager
    {
        public static void Start()
        {
            var api = new VkApi();

            api.Authorize(new ApiAuthParams()
            {
                Login = "+79147225763",
                Password = "Ktotyrj20189242324426",
                ApplicationId = 7814158,
                Settings = Settings.All
            });

            var timer = new Timer(Interrogate, api, 0, 300000);
        }


        private static void Interrogate(object api)
        {

            var vkApi = api as VkApi;
            var vkPublics = getVkPublics();

            foreach (var vkPublic in vkPublics)
            {
                var wall = vkApi.Wall.Get(new WallGetParams()
                {
                    Domain = vkPublic.Name
                });

                foreach (var post in wall.WallPosts)
                {
                    if (post.Id > vkPublic.LastGotPostId)
                    {
                        //TODO: Делаем сообщение
                    }
                }
            }


        }

        private static IEnumerable<VkPublic> getVkPublics()
        {
            return new List<VkPublic>()
            {
                new VkPublic()
                {
                LastGotPostId = 0,
                Name = "feminism_visually"
                }
            };
        }
    }
}

