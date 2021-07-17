using System.Data;
using Blogger.Models;
using Dapper;

namespace Blogger.Repositories
{
    public class ProfileRepository
    {
        private readonly IDbConnection _db;
        public ProfileRepository(IDbConnection db)
        {
            _db = db;
        }
        public Profile Get(string id)
        {
            string sql = "SELECT * FROM Profiles where id = @Id";
            return _db.QueryFirstOrDefault<Profile>(sql, new {id});
        }

        public Profile CreateProfile(Profile profileData){
            var sql = @"
            INSERT INTO Profiles(Id, Name, Email, Picture)
            VALUES (@Id, @Name, @Email, @Picture);
            SELECT LAST_INSERT_ID();
            ";

            string id = _db.ExecuteScalar<string>(sql, profileData);
            profileData.Id = id;
            return profileData;
        }


    }
}