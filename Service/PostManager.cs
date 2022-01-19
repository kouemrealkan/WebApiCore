using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCore.Models;
using WebApiCore.Repository;

namespace WebApiCore.Service
{
    public class PostManager : IPostService
    {
        private readonly IGenericRepository<Posts> _repository;
        public PostManager(IGenericRepository<Posts> repository)
        {
            _repository = repository;
        }
        public Posts Create(Posts post)
        {
            return _repository.Add(post);
            
        }

        public Posts GetPost(int id)
        {
            return _repository.GetById(id);
        }

        public List<Posts> GetAll()
        {
            return _repository.GetAll();
        }

        
    }
}
