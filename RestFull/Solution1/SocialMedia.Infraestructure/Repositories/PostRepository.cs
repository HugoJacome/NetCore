using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entity;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Infraestructure.Repositories
{
    public class PostRepository: IPostsRepository
    {
        private readonly SocialMediaContext _context;

        public PostRepository(SocialMediaContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Post>> GetPosts()
        {
            var posts = await _context.Posts.ToListAsync();

            return posts;
        }
        public async Task<Post> GetPost(int id)
        {
            var posts = await _context.Posts.Where(post => post.PostId == id).FirstOrDefaultAsync();

            return posts;
        }
    }
}
