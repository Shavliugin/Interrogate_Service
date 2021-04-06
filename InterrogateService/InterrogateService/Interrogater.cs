using InterrogateService.Core.Common.Interfaces;
using InterrogateService.Core.Vk;
using InterrogateService.Core.Youtube;
using System;
using System.Collections.Generic;
using System.Threading;

namespace InterrogateService
{
    public class Interrogater
    {
        private YoutubeManager _youtubeManager;
        private VkPublicManager _vkManager;

        public Interrogater(YoutubeManager youtubeManager, VkPublicManager vkManager)
        {
            _youtubeManager = youtubeManager;
            _vkManager = vkManager;
        }
        public void Start()
        {
            var timer = new Timer(Interrogate, null, 0, 300000);
        }

        public void Interrogate(object obj)
        {
            _youtubeManager.Interrogate(getYoutubeChannels());
            _vkManager.Interrogate(getVkPublics());
        }

        private IEnumerable<SocialMediaSource> getVkPublics()
        {
            return new List<SocialMediaSource>
            {
                new SocialMediaSource()
                {
                    LastGotPostDateTime = DateTime.MinValue,
                    Id = "feminism_visually"
                }
            };
        }

        private IEnumerable<SocialMediaSource> getYoutubeChannels()
        {
            return new List<SocialMediaSource>
            {
                new SocialMediaSource()
                {
                    Id = "UCCYMY6j5mUvPMPzvN5bxuKA",
                    LastGotPostDateTime = DateTime.MinValue
                }
            };
        }
    }
}
