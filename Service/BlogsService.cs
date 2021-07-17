using System.Collections.Generic;
using Blogger.Models;
using Blogger.Repositories;

namespace Blogger.Service
{
    public class BlogsService
    {
        private readonly BlogsRepository _br;
        public BlogsService(BlogsRepository br)
        {
            _br = br;
        }
        public List<Blog> GetBlogByProfileId(string id)
        {
          return _br.GetBlogById(id);
    }
}
}