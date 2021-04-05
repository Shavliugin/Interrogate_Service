namespace InterrogateService.Core
{
    public class VkPublic
    {
        /// <summary>
        /// Название паблика
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Идентификатор последнего полученного поста
        /// </summary>
        public long? LastGotPostId { get; set; }
    }
}
