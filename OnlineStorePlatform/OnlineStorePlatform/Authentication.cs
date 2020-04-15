using OnlineStorePlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;

namespace OnlineStorePlatform
{
    public class Authentication : System.Web.Http.Filters.ActionFilterAttribute
    {
        string[] ls;
        bool or;
        public Authentication(string[] ls, bool or)
        {
            this.ls = ls;
            this.or = or;
        }
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
            }
            else
            {
                base.OnActionExecuting(actionContext);
                string authenticationToken = actionContext.Request.Headers.Authorization.Parameter;
                string decodedToken = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationToken));
                string identifier = decodedToken.Substring(0, decodedToken.IndexOf(":"));
                string password = decodedToken.Substring(decodedToken.IndexOf(":") + 1);
                User user = User.login(identifier, password);
                if (user == null)
                {
                    actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
					return;

                }
                string userType = user.GetType().Name;
                for (int i = 0; i < ls.Length; i++)
                {
                    if (or)
                    {
                        if (string.Equals(userType, ls[i], StringComparison.OrdinalIgnoreCase))
                            return;
                    }
                    else
                    {
                        if (!string.Equals(userType, ls[i], StringComparison.OrdinalIgnoreCase))
                        {
                            actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Forbidden);
                            return;
                        }
                    }
                }
                if (or)
                    actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Forbidden);
            }
        }
    }
}