using System.Collections.Generic;
using System.Data;
using System.Linq;
using Blogger.Models;
using Dapper;

namespace Blogger.Repositories{

    public class BlogsRepository
    {
        private readonly IDbConnection _db;
        public BlogsRepository(IDbConnection db)
        {
            _db = db;
        }

    internal List<Blog> GetBlogById(string blogId)
    {
        string sql = @"
        Select * FROM Blogs
        WHERE  blogId = @creatorId
        ";
        return _db.Query<Blog>(sql, new {blogId}).ToList();
    }
    }
}