using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePostComment;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Comments
{
    public class ListModel : PageModel
    {
        PostCommentClient client = new PostCommentClient();

        public ListModel()
        {
            Comments = new List<CommentDTO>();
        }

        public List<CommentDTO> Comments { get; set; }

        public async Task OnGetAsync(int? id)
        {
            if (!id.HasValue)
                return;
            var item = await client.GetPostByIdAsync(id.Value);
            ViewData["Post"] = item.PostId.ToString() + " : " + item.Description.Trim();
            foreach (var comment in item.Comments)
            {
                CommentDTO cdto = new CommentDTO();
                cdto.PostPostId = comment.PostPostId;
                cdto.Text = comment.Text;
                cdto.CommentId = comment.CommentId;
                Comments.Add(cdto);
            }
        }
    }
}