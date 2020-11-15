using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infraestructure.Repositories;

namespace SocialMedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostsRepository _postsRepository;
        public PostController(IPostsRepository postsRepository)
        {
            _postsRepository = postsRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {
            var post = await _postsRepository.GetPosts();

            return Ok(post);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost(int id)
        {
            var post = await _postsRepository.GetPost(id);

            return Ok(post);
        }
    }
}