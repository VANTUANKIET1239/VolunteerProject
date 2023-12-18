using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.DAL;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;

namespace VolunProject.Data.BLL
{
    public class PostBLL
    {
        public static bool CreatePost(PostDTO postDTO, bool state)
        {
            return PostDAL.CreatePost(postDTO, state);
        }
        public static ICollection<PostDTO> getAllPost()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Post, PostDTO>());
            var mapper = new Mapper(config);
            List<PostDTO> dto = mapper.Map<List<PostDTO>>(PostDAL.getAllPost());
            return dto;
        }
    }
}
