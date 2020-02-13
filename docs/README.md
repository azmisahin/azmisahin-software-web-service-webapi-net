# ![Logo](media/favicon.png)

# Web Api with .netframework

It uses the ASP.NET Web API to create an API that returns a list of web products.

# Test Project
![Test-Project](media/test-project.png)

[Document Web Site](https://azmisahin.github.io/azmisahin-software-web-service-webapi-net/)

![api-documentation](media/api-documentation.png)

# Password Policy
IdentityConfig.cs
```
manager.PasswordValidator = new PasswordValidator
{
    RequiredLength = 6,
    RequireNonLetterOrDigit = false,
    RequireDigit = false,
    RequireLowercase = false,
    RequireUppercase = false,
};
```