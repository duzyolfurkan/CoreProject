using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
	public class CommentManager : ICommentService
	{
		ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		public List<Comment> GetListAll(int id)
		{
			return _commentDal.GetListAll(x => x.BlogID == id);

		}

        public void CommentAdd(Comment comment)
        {
            _commentDal.Insert(comment);
        }
    }
}
