using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Models;
using ServiceReferencePostComment;

namespace RazorPagesMovie.Pages.Posts
{
    public class DeleteModel : PageModel
    {
        PostCommentClient client = new PostCommentClient();

        public DeleteModel() { }

        [BindProperty]
        public PostDTO PostDTO { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();
            var post = await client.GetPostByIdAsync(id.Value);
            if (post != null)
            {
                PostDTO = new PostDTO();
                PostDTO.PostId = post.PostId;
                PostDTO.Domain = post.Domain;
                PostDTO.Description = post.Description;
                PostDTO.Date = post.Date;
                return Page();
            }
            else
                return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
                return NotFound();
            int result = 0;
            // Nu pot fi sterse inregistrari parinte daca exista descendenti (cheie FK activa)
            // "Prind" exceptia si afisez o pagina cu eroare. Nu e finisat aici...
            try
            {
                result = await client.DeletePostAsync(id.Value);
                // result ar trebui valorificat mai departe in cod...
            }
            catch
            {
                return RedirectToPage("/Error");
            }

            return RedirectToPage("./Index");
        }

    }
}