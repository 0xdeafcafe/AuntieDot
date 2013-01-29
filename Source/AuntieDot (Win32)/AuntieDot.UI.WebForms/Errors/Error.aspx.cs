using AuntieDot.UI.Wen.Errors;
using System;

namespace AuntieDot.UI.Web.Errors
{
	public partial class Error : System.Web.UI.Page
	{
		public ErrorDB.ErrorStatusFormat errorMessage;

		protected void Page_Load(object sender, EventArgs e)
		{
			Response.TrySkipIisCustomErrors = true;

			int EID;
			if (!int.TryParse(Page.Request.QueryString["hsc"], out EID))
				EID = 404;

			errorMessage = ErrorDB.GetFormatFromCode(EID) ?? new ErrorDB.ErrorStatusFormat()
				                                                 {
					                                                 ErrorCode = EID,
					                                                 DevComment = "HTTP request failed! Unknown Error, HTTP/1.1 " + EID,
					                                                 NorComment = "Can't insert whitty message due to unknown error."
				                                                 };

			Page.Title = "Error " + EID;
		}
	}
}