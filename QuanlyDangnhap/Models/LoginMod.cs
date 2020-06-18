using DevExpress.Data.Filtering.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyDangnhap.Models
{
    class LoginMod
    {
        protected string user { get; set; }
        protected string pass { get; set; }
        protected bool status { get; set; }
        public LoginMod(string _user , string _pass)
        {
            this.user = _user;
            this.pass = _pass;

        }
        public string checkdangnhap()
        {
            string str = "";
            string[] para = new string[2] { "@Dangnhap", "@Matkhau" };
            object value = new object[2] { user, pass };
            return str;
            
        }


    }
}
