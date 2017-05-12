using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_Report : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
 
        string test = @"D:\Work\Software project\opdsystem\report\test.pdf";
        PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(test, FileMode.Create));


        doc.Open();
        Paragraph p = new Paragraph("Test");
        doc.Add(p);
        doc.Close();
    }
}