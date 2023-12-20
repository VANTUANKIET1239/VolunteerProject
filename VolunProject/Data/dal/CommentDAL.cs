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
    public class CommentDAL
    {
        public static bool CreateComment(CommentDTO commentDTO)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            Comment comment = new Comment();
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
            int allCmt = volunteerDBEntities.Comments.Count();
            string newID = "CMT" + (allCmt + 1).ToString("0000000");
            comment.CommentContent = commentDTO.CommentContent;
            comment.CommentID = newID;
            comment.State = commentDTO.State;
            comment.VolunteerID = commentDTO.VolunteerID;
            comment.PostID = commentDTO.PostID;
            volunteerDBEntities.Comments.Add(comment);
            return volunteerDBEntities.SaveChanges() > 0;
        }
        public static ICollection<Comment> GetAllCommentByID(string postID)
        {
            VolunteerDBEntities volunteerDBEntities = new VolunteerDBEntities();
            var allComment = volunteerDBEntities.Comments.Where(x => x.PostID == postID).ToList();
            allComment.Reverse();
            return allComment;
        }
    }
}
