using Blogger.Models;
using Blogger.Repositories;

namespace Blogger.Service
{
    public class ProfileService
    {
        private readonly ProfileRepository _pr;
        public ProfileService(ProfileRepository pr)
        {
            _pr = pr;
        }
        public Profile Get(string id)
    {
        Profile foundProfile = _pr.Get(id);
        return foundProfile;

    }
    public Profile CreateProfile(Profile profileData)
    {
        return _pr.CreateProfile(profileData);

    }


    }

}