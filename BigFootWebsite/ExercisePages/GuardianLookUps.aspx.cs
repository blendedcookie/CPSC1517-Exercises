using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region More NameSpaces
using FSISSystem.SLain.BLL;
using FSISSystem.SLain.Data;
#endregion

public partial class ExercisePages_GuardianLookUps : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindProductList();
        }
        

    }


    protected void BindProductList()
    {
        try
        {
            Guardian sysmgr = new GuardianController();

            List<GuardianController> info = sysmgr.Guardian_List();



        }
        catch (Exception ex)
        {

        }
    }
}