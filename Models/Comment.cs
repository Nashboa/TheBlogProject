using System;

namespace TheBlogProject.Models
{
    public class Comment
    {
        #region Keys
        public int Id { get; set; }

        public int PostId { get; set; }

        public string AuthorId { get; set; }
        #endregion

        #region Comment Properties 
        public string Content { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Updated { get; set; }
        #endregion

        #region Navigation
        public Post Post { get; set; }

        public virtual BlogUser Author { get; set; }


        #endregion


    }
}
