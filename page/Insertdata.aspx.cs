using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_Insertdata : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string sym_host = TextBox1.Text;
        string sym_sub = TextBox2.Text;
        string comment_sym = TextBox3.Text;
        string symtom = DropDownList1.SelectedValue;
        int symtom_id = Convert.ToInt32(symtom);
        string dis = DropDownList2.SelectedValue;
        int dis_id = Convert.ToInt32(dis);

        Symptoms s = new Symptoms(sym_host, sym_sub,comment_sym,symtom_id, dis_id);
        Symptoms.sent_savesym(s);
        ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('บันทึกข้อมูลเสร็จสิ้น');", true);

    }
}