﻿using Hangfire.Dashboard;
using Hangfire.Dashboard.BasicAuthorization;

namespace Worker.Configuration;

public class HangfireDashboard
{
    public static BasicAuthAuthorizationFilter[] AuthAuthorizationFilters()
    {
        return
        [
            new BasicAuthAuthorizationFilter(new BasicAuthAuthorizationFilterOptions
            {
                SslRedirect = false,
                RequireSsl = false,
                LoginCaseSensitive = true,
                Users = new []
                {
                    new BasicAuthAuthorizationUser
                    {
                        Login = "admin",
                        PasswordClear = "admin"
                    }
                }
            })
        ];
    }
}