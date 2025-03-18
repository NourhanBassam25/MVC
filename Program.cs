using System.Diagnostics.Eventing.Reader;

namespace MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.UseRouting();

            app.UseStaticFiles();
            //app.UseEndpoints(endpoints =>
            //{
            //    //endpoints.MapGet("/Home", async context =>
                //{
                //    await context.Response.WriteAsync("Home Page");
                //});
                //endpoints.MapGet("/Products", async context =>
                //{
                //    await context.Response.WriteAsync("Products Page");
                //});

                #region Parameter with routing
                //endpoints.MapGet("/Books/{id}/{auther}", async context =>
                //{
                //    int id = Convert.ToInt32(context.Request.RouteValues ["id"]);
                //    string auther = context.Request.RouteValues["auther"].ToString();

                //    await context.Response.WriteAsync($"Your request Book with Id => {id} , Auther => {auther}");
                //}); 
                #endregion

                #region optional parameter

                //endpoints.MapGet("/products/{id?}", async context =>
                //{
                //    var idData = context.Request.RouteValues["id"];

                //    if (idData is not null)
                //    {

                //        int id = Convert.ToInt32(idData);

                //        await context.Response.WriteAsync($"Your Request Product with id => {id}");
                //    }
                //    else
                //        await context.Response.WriteAsync("You are at products page");
                //});
                #endregion

                #region Routing constraints

                //endpoints.MapGet("/Books/{id:int}/{auther:alpha:minlength(4):maxlength(8)}", async context =>
                //{
                //    int id = Convert.ToInt32(context.Request.RouteValues["id"]);
                //    string auther = context.Request.RouteValues["auther"].ToString();

                //    await context.Response.WriteAsync($"Your request Book with Id => {id} , Auther => {auther}");
                //});
                #endregion


          //  });
                #region Action Result

                app.MapControllerRoute
                (
                    name: "default",
                    pattern: "/{Controller=Home}/{Action=Index}",
                    defaults: new { Controller = "Home", Action = "Index" }
                );

                #endregion

                //app.Run(async (HttpContext) =>
                //{ 
                //    await HttpContext.Response.WriteAsync("Your Requested Page not Found");
                //});

              app.Run();
        }
    }
}
