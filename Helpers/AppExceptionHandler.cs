using Authentication_Authorization_AddApiEndpoints.Dtos;
using Microsoft.AspNetCore.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace Authentication_Authorization_AddApiEndpoints.Helpers
{
    public class AppExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, 
            Exception exception, CancellationToken cancellationToken)
        { 
            if (exception is ValidationException validationException)
            {
                httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                await httpContext.Response.WriteAsJsonAsync(validationException.ValidationResult, cancellationToken);
                return true;
            } 
            return false; 
        }
    }
}
