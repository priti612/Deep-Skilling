using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebAhandson3.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string path = @"C:\Temp\ExceptionLog.txt";

            Directory.CreateDirectory(@"C:\Temp");

            File.AppendAllText(path,
                DateTime.Now + Environment.NewLine +
                context.Exception.Message + Environment.NewLine +
                "---------------------------" + Environment.NewLine);

            context.Result = new ObjectResult("Internal Server Error")
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };

            context.ExceptionHandled = true;
        }
    }
}