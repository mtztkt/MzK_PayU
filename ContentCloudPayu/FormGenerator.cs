using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ContentCloudPayu
{
   public class FormGenerator
    {
        StringBuilder _sb;

        public string GenerateForm(string[,] Variables, string PostUrl)
        {
            _sb = new StringBuilder();

            Emit("<html>\n");
            Emit("<head>\n");
            Emit("<meta http-equiv=\"Expires\" content=\"0\">\n");
            Emit("<meta http-equiv=\"Cache-Control\" content=\"no-cache\">\n");
            Emit("<meta http-equiv=\"Pragma\" content=\"no-cache\">\n");
            Emit("</head>\n");
            Emit("<body onLoad=\"document.forms.paypal.submit()\">\n");
            Emit("<form ID=\"paypal\" action=\"{0}\" method=\"post\" target=\"_top\">\n", PostUrl);
            for (int j = 0; j < Variables.Length / 2; j++)
            {
                Hidden(Variables.GetValue(j, 0).ToString(), Variables.GetValue(j, 1).ToString());
            }
            Emit("</form>\n");
            Emit("</body>\n");
            Emit("</html>\n");

            return _sb.ToString();




        }

        private void Hidden(string name, string value)
        {
            if (value == null) return;  // Omit this hidden tag
            const string fmt = "<input type=\"hidden\" name=\"{0}\" value=\"{1}\" />\n";
            //const string fmtEnc = "{0}={1}\n";
            var dataType = value.GetType().Name;
            value = HttpContext.Current.Server.HtmlEncode(value.ToString());
            Emit(fmt, name, value);
        }


        private void Emit(string fmt, params object[] parameters)
        {
            _sb.AppendFormat(fmt, parameters);
        }


    }
}
