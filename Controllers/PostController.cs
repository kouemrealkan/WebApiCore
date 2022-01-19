using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCore.Models;
using WebApiCore.Service;

namespace WebApiCore.Controllers
{
    [Route("api/posts")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _postService.GetAll();

            return Ok(response);

        }

        [HttpPost]
        public ActionResult Create(Posts post) 
        {
            var response = _postService.Create(post);
             return Ok(response);
        }

        [HttpGet("{id}")]
        public ActionResult GetPost(int id)
        {
            var response = _postService.GetPost(id);
            return Ok(response);
        }



        // /posts/3  => getById
        // /posts =>GetAll
    }
}
