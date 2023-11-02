public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime RegistrationDate { get; set; }
   public class UserController : Controller
{
    // Дія для відображення списку користувачів
    public IActionResult Index()
    {
        // Отримайте список користувачів з деякого джерела даних (наприклад, бази даних або колекції об'єктів).
        List<User> users = GetUsersFromDataSource(); // Потрібно реалізувати цей метод.

        return View(users);
    }

    // Дія для відображення докладної інформації про користувача
    public IActionResult Details(int id)
    {
        // Отримайте користувача за ідентифікатором id.
        User user = GetUserById(id); // Потрібно реалізувати цей метод.

        if (user == null)
        {
            return NotFound(); // Повернення статусу 404, якщо користувача не знайдено.
        }

        return View(user);
    }
}

}
