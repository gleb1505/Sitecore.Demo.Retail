namespace Sitecore.Foundation.Commerce.Models
{
    public interface IUser
    {
        string UserId { get; }
        string UserName { get; }
        string FirstName { get; }
        string Email { get; }
        string LastName { get; }
        string Phone { get; }
    }
}