using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace AWMService.WebAPI.Filters
{
    public class ValidateModelFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                // Возвращаем стандартный ответ 400 Bad Request от ASP.NET Core с деталями ошибок валидации
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }
    }
}