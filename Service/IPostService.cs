using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCore.Models;

namespace WebApiCore.Service
{
    public interface IPostService
    {
        Posts Create(Posts post);

        Posts GetPost(int id);

        List<Posts> GetAll();

    }
}
