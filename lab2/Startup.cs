app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute(
        name: "user",
        pattern: "User/{action=Index}/{id?}",
        defaults: new { controller = "User" });
});
