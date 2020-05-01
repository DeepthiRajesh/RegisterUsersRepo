using RegisteredUsers.Domain.Entities.Entity;
using RegisteredUsers.Presentation.UI.ViewModel;

namespace RegisteredUsers.Presentation.UI.Controllers.API.Helpers
{
    public static class UserControllerHelpers
    {
        public static User ToUserDomain(this UserViewModel model)
        {
            return new User
            {
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                BirthDate = model.BirthDate,
                IsDeleted = model.IsDeleted,
                Email = model.Email,
                Password = model.Password,
                UserType = model.UserType
            };
        }
    }
}
