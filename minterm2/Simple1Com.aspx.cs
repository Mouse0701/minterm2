using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace minterm2
{
    public partial class Simple1Com : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string temp = "";
            temp += Request.Form.Get("tb_CellPhone") + "<br/>";
            temp += Request.Form.Get("tb_Ps") + "<br/>";
            temp += Request.Form.Get("rb_Gender") + "<br/>";
            temp += Request.Form.Get("tb_Num") + "<br/>";
            temp += Request.Form.Get("hd_Num") + "<br/>";
            temp += Request.Form.Get("hd_Num");
            // 驗證碼 md5編碼 Password
            lb_Msg.Text = temp;

        }
    }
}