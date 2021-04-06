using System;

namespace InterrogateService.Core.Common.Interfaces
{
    public class SocialMediaSource
    {
        /// <summary>
        /// Идентификатор, по которому ищется контент в соц. сетях
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Время последнего полученного поста
        /// </summary>
        public DateTime LastGotPostDateTime { get; set; }
    }
}
