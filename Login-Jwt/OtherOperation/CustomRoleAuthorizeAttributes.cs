using LoginDemo1.DataContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

//using Mysqlx.Session;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace LoginDemo1.OtherOperation
{
    public class CustomRoleAuthorizeAttributes: AuthorizeAttribute,IAuthorizationFilter
    {
        private readonly string _role;
        public CustomRoleAuthorizeAttributes(string role)
        {
            _role = role;
        }
        //public void OnAuthorization(AuthorizationFilterContext context)
        //{
        //    var authorizationHeader = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault();
        //    if (authorizationHeader == null || !authorizationHeader!.StartsWith("Bearer")) 
        //    {
        //        context.Result = new UnauthorizedResult();
        //        return;
        //    }
        //    var token=authorizationHeader.Substring("Bearer".Length);
        //    var tokenValidationParameters = new TokenValidationParameters
        //    {
        //        ValidateIssuer = true,
        //        ValidateAudience = true,
        //        ValidateLifetime = true,
        //        //ValidateIssuerSigningKey = true,
        //        ValidIssuer = "http://localhost:7085",
        //        ValidAudience = "http://localhost:3000",
        //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("bd1a1ccAS09R37f361a4Dd351e7c0de65f0776bfc278ea8d312c763bb6c#3ac!a=="))
        //    };
        //    var tokenHandler=new JwtSecurityTokenHandler();
        //    //try {
        //        //var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out var validatedToken);
        //        var princi = tokenHandler.ReadJwtToken(token).RawPayload;
        //        dynamic jsonObj = JsonConvert.DeserializeObject(princi);
        //        if (jsonObj != null)
        //        {
        //            if (jsonObj.Role == _role)
        //            {
        //                context.Result= new OkResult();
        //                return;
        //            }
        //            context.Result = new ForbidResult();
        //            return;
        //        }


        //var role = principal.Claims.FirstOrDefault(c => c.Type == "Role");
        //if (role == null||role.Value != _role) { 
        //    context.Result = new ForbidResult();
        //    return;
        //}
        //context.Result= new OkResult();
        //return;




        //}catch(Exception ex)
        //{
        //    context.Result = new NotFoundResult();

        //    return;

        //}
        //}
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var authorizationHeader = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault();
            if (authorizationHeader == null || !authorizationHeader.StartsWith("Bearer ")) // Check if the header starts with "Bearer "
            {
                context.Result = new NotFoundResult();
                return;
            }
            var token = authorizationHeader.Substring("Bearer ".Length); // Remove the "Bearer " prefix from the token
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                //ValidateIssuerSigningKey = true,
                ValidIssuer = "https://localhost:7085",
                ValidAudience = "https://127.0.0.1:8080",
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                 var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out var validatedToken); // Validate the token and get the principal
                var jsonObj = principal.Claims.FirstOrDefault(c => c.Type == "Role")?.Value; // Get the role claim from the principal
                //var principal = tokenHandler.ReadJwtToken(token).RawPayload;
                //dynamic jsonObj = JsonConvert.DeserializeObject(principal);
                if (jsonObj != null)
                {
                    if (jsonObj == _role)
                    {
                        context.Result = new OkResult();
                       
                        return;
                        
                    }
                    context.Result = new ForbidResult();
                    return;
                }
            }
            catch (SecurityTokenException ex) // Catch the exception if the token is not valid or well formed
            {
                // Handle the exception, such as by logging the error, requesting a new token, or redirecting the user to the login page
                context.Result = new NotFoundResult();
                return;
            }
        }

    }
}
