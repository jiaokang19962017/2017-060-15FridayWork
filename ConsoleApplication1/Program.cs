using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace ConsoleApplication1
{
    class Program
    {
        private static readonly string strConn = ConfigurationManager.ConnectionStrings["strConn"].ToString();
        static void Main(string[] args)
        {
            #region 1.	使用ExecuteDataReader()返回读取UserInfo表中的数据。要求查询所有字段。
            /* using (SqlConnection con = new SqlConnection(strConn))
             {
                 string sql = @"select
                                                 UserId,
                                                 UserName,
                                                 UserSex,
                                                 UserAge,
                                                 UserEmail
                                        from UserInfo";
                 SqlCommand cmd = new SqlCommand(sql, con);
                 con.Open();
                 SqlDataReader sr = cmd.ExecuteReader();
                 if (sr.HasRows)
                 {
                     while (sr.Read())
                     {
                         for (int i = 0; i < sr.FieldCount; i++)
                         {
                             Console.Write(sr[i] + "\t");
                         }
                         Console.WriteLine();
                     }
                 }
             }*/
            #endregion


            #region 2.	使用List<T>泛型集合存取UserInfo表中的数据，并遍历输出。
            /*   List<UserInfo> luser = new List<UserInfo>();//定义一个泛型集合来接收数据
               using (SqlConnection con = new SqlConnection(strConn))
               {
                   string sql = @"select
                                                    UserId,
                                                    UserName,
                                                    UserSex,
                                                    UserAge,
                                                    UserEmail
                                           from UserInfo";
                   using (SqlCommand cmd = new SqlCommand(sql, con))
                   {
                       con.Open();
                       SqlDataReader dr = cmd.ExecuteReader();
                       if (dr.HasRows)
                       {
                           while (dr.Read())
                           {

                               UserInfo ufo = new UserInfo();
                               ufo.Userid = dr.GetInt32(0);
                               ufo.UserName = dr.GetString(1);
                               ufo.UserSex = dr.GetBoolean(2);
                               ufo.UserAge = dr.GetInt32(3);
                               ufo.UserAddress = dr.GetString(4);
                               luser.Add(ufo);//这一步不要忘记,将对象添加到集合当中
                           }
                           dr.Close();
                       }
                           //遍历出集合
                           foreach (UserInfo item in luser)
                           {
                               Console.WriteLine(item.Userid + "\t" + item.UserName + "\t" + item.UserSex + "\t" + item.UserAge + "\t" + item.UserAddress);

                           }
                       }
                   }*/





            #endregion

            #region 3.	使用Users表实现防止SQL注入式攻击登录。
            /*  Console.WriteLine("请输入帐号:");
              string loginid = Console.ReadLine();
              Console.WriteLine("请输入密码:");
              string loginpwd = Console.ReadLine();

              using (SqlConnection con = new SqlConnection(strConn))
              {
                  string sql = "select COUNT(*) from Users where LoginId=@loginid and LoginPwd=@loginpwd";
                  SqlCommand cmd = new SqlCommand(sql, con);
                  SqlParameter[] parm = new SqlParameter[] 
                  {
                     new SqlParameter("@LoginId",loginid),
                     new SqlParameter("@LoginPwd",loginpwd)
                  };
                  cmd.Parameters.AddRange(parm);
                  con.Open();
               int result =Convert.ToInt32(cmd.ExecuteScalar());
                  if (result > 0)
                  {
                      Console.WriteLine("登录成功");
                  }
                  else
                  {
                      Console.WriteLine("登录失败");
                  }
              }*/
            #endregion
            #region 使用SqlParameters实现UserInfo表的增删改查。MyRegion

            #endregion

        }
    }
    }

