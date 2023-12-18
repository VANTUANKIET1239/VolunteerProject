using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.BLL;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;

namespace VolunProject.Data.DAL
{
    public class PostDAL
    {
        public static bool CreatePost(PostDTO postDTO, bool state)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            Post post = new Post();
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
            int allPost = volunteerDBEntities.Posts.Count();
            string newID = "POS" + (allPost + 1).ToString("0000000");
            post.Caption = postDTO.Caption;
            post.Image = postDTO.Image;
            post.PostID = newID;
            post.VolunteerID = curVol.VolunteerID;
            post.CreateDate = DateTime.Now;
            post.PostLike = 0;
            post.State = state;
            volunteerDBEntities.Posts.Add(post);
            return volunteerDBEntities.SaveChanges() > 0;
        }
        public static ICollection<Post> getAllPost()
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var allPost = volunteerDBEntities.Posts.ToList();
            allPost.Reverse();
            return allPost;
        }
    }
}
