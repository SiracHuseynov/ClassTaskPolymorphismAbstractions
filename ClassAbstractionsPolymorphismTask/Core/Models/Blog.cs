using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Blog
    {
        private static int _id;
        public int Id { get; set; }

        public  string Title { get; set; }
        public  string Description { get; set; }
        Comment[] Comments = new Comment[] { };

        public override string ToString()
        {
            return $"Title {Title}, Description: {Description}";
        }

        public Comment GetComment(int commentId)
        {
            bool f = false;
            if(Comments.Length > 0)
            {
                foreach (Comment comment in Comments)
                {
                    if (comment.Id == commentId)
                    {
                        f = true;
                        return comment;
                    }
                }
                if(f == false)
                {
                    Console.WriteLine($"id'i{commentId} olan comment yoxdur!");
                }
            }
            else
            {
                Console.WriteLine("Comment yoxdur!");
            }
            return null;
        }

        public Comment[] GetAllComments()
        {
            if(Comments.Length > 0)
            {
                return Comments;
            }
            return null;
        }

        public void AddComment(Comment comment)
        {
            Array.Resize(ref Comments, Comments.Length + 1);
            Comments[Comments.Length - 1] = comment;
        }

        public Comment[] RemoveComment(int commentId)
        {
            Comment[] filteredComment = new Comment[] { };
            bool f = false;
            if(Comments.Length > 0)
            {
                foreach (Comment comment in Comments)
                {
                    if (comment.Id != commentId)
                    {
                        Array.Resize(ref filteredComment, filteredComment.Length + 1);
                        filteredComment[filteredComment.Length - 1] = comment;
                        f = true;
                    }

                }
            }
            else
            {
                Console.WriteLine("Blogda comment yoxdur!");
            }

            Comments = filteredComment;

            return filteredComment;
        }

        public void UpdateComment(int commentId, Comment comment)
        {
            bool f = false;
            if(Comments.Length > 0)
            {
                foreach (Comment item in Comments)
                {
                    if (item.Id == commentId)
                    {
                        item.Content = comment.Content;
                        Console.WriteLine($"Id: {item.Id}, Content: {item.Content}");
                        f = true;
                    }
                }
                if(f == false)
                {
                    Console.WriteLine($"id'i {commentId} olan comment yoxdur!");
                }
            }
            else
            {
                Console.WriteLine("Comment yoxdur!");
            }

            
        }

        public Blog(string title, string description)
        {
            _id++;
            Id = _id;
            Title = title;
            Description = description;
        }


    }
}
