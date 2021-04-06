using InterrogateService.Core.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace InterrogateService.Core.Vk
{
    public class VkPublicManager: IInterrogateService
    {
        private VkApi _api { get; set; }

        private VkApi Api
        {
            get
            {
                if (_api != null)
                    return _api;

                _api = new VkApi();

                _api.Authorize(new ApiAuthParams()
                {
                    Login = "+79147225763",
                    Password = "Ktotyrj20189242324426",
                    ApplicationId = 7814158,
                    Settings = Settings.All
                });

                return _api;
            }            
        }

        public void Interrogate(IEnumerable<SocialMediaSource> vkPublics)
        {
            foreach (var vkPublic in vkPublics)
            {
                var wall = Api.Wall.Get(new WallGetParams()
                {
                    Domain = vkPublic.Id
                });

                foreach (var post in wall.WallPosts)
                {
                    if (post.Date > vkPublic.LastGotPostDateTime)
                    {
                        //TODO: Делаем сообщение
                    }
                }
            }
        }        
    }
}

