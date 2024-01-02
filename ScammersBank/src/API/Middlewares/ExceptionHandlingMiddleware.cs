using Domain.Exceptions;
using System.Net;
using System.Text.Json;

namespace API.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                var response = context.Response;
                response.ContentType = "application/json";

                response.StatusCode = ex switch
                {
                    InvalidAccountTypeException e => (int)HttpStatusCode.UnprocessableContent,
                    InvalidTransactionTypeException e => (int)HttpStatusCode.UnprocessableContent,
                    AccountNotFoundException e => (int)HttpStatusCode.NotFound,
                    TransactionNotFoundException e => (int)HttpStatusCode.NotFound,
                    UserNotFoundException e => (int)HttpStatusCode.NotFound,
                    _ => (int)HttpStatusCode.InternalServerError
                };

                await response.WriteAsync(JsonSerializer.Serialize(new { message = ex?.Message }));
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ExceptionHandlingMiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionHandlingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlingMiddleware>();
        }
    }
}
