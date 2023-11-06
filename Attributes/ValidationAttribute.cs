using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Models;

public class ValidateContactNameAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if (context.HttpContext.Request.Method == "POST" || context.HttpContext.Request.Method == "PUT")
        {
            if (context.ActionArguments.ContainsKey("contact") && context.ActionArguments["contact"] is Contact contact)
            {
                if (string.IsNullOrEmpty(contact.Name))
                {
                    context.Result = new BadRequestObjectResult("Contact name is required.");
                    return;
                }
            }
        }

        base.OnActionExecuting(context);
    }
}
