namespace InterrogateService.Core.Common
{
    public class User
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Телефон пользователя
        /// </summary>
        string Phone { get; set; }

        /// <summary>
        /// Электронная почта пользователя
        /// </summary>
        string Email { get; set; }
    }
}
