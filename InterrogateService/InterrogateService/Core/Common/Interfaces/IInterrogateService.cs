using System.Collections.Generic;

namespace InterrogateService.Core.Common.Interfaces
{
    interface IInterrogateService
    {
        void Interrogate(IEnumerable<SocialMediaSource> socialMediaSources);
    }
}
