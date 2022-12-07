using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment category);
        //void CategoryDelet(Category category);
        //void CategoryUpdate(Category category);
        //List<Category> GetList();
        List<Comment> GetList(int id);
    }
}
