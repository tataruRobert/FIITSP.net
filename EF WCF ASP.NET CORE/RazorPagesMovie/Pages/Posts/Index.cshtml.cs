using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Models;
using ServiceReferencePostComment;

namespace RazorPagesMovie.Pages.Posts
{
    public class IndexModel : PageModel
    {
        PostCommentClient client = new PostCommentClient();

        public IndexModel()
        {
            Posts = new List<PostDTO>();
        }

        public List<PostDTO> Posts { get; set; }

        public async Task OnGetAsync()
        {
            var posts = await client.GetPostsAsync();
            foreach (var item in posts)
            {
                // Trebuia folosit AutoMapper. Transform Post in PostDTO
                PostDTO pd = new PostDTO();
                pd.Description = item.Description;
                pd.PostId = item.PostId;
                pd.Domain = item.Domain;
                pd.Date = item.Date;
                foreach (var comment in item.Comments)
                {
                    CommentDTO cdto = new CommentDTO();
                    cdto.PostPostId = comment.PostPostId;
                    cdto.Text = comment.Text;
                    pd.Comment.Add(cdto);
                }
                Posts.Add(pd);
            }
        }
    }
}