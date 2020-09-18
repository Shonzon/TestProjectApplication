using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TestProjectApplication.DataManager;
using TestProjectApplication.Models;

namespace TestProjectApplication.DAL
{
    public class HomeDAL
    {
        private DataAccessManager accessManager = new DataAccessManager();
        public List<PostModel> GetAllPostList()
        {
            try
            {
                accessManager.SqlConnectionOpen(DataBase.TestDB);
                List<PostModel> postlist = new List<PostModel>();
                List<SqlParameter> aParameters = new List<SqlParameter>();
                SqlDataReader dr = accessManager.GetSqlDataReader("sp_GetAllPostData", aParameters);
                while (dr.Read())
                {
                    PostModel post = new PostModel();
                    post.PostId = (int)dr["PostId"];
                    post.PostName = dr["PostName"].ToString();
                    post.PostBy = dr["PostBy"].ToString();
                    post.PostDate =(DateTime) dr["PostDate"];
                    post.CommentList = JsonConvert.DeserializeObject<List<CommentModel>>(dr["CommentList"].ToString());
                    postlist.Add(post);
                }
                return postlist;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                accessManager.SqlConnectionClose();
            }
        }
    }
}