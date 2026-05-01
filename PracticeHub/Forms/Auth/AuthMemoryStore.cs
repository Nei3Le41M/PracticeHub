namespace PracticeHub.Forms.Auth;

internal static class AuthMemoryStore
{
    private static readonly List<UserCredentials> Users =
    [
        new UserCredentials("Администратор системы", "admin@practicehub.local", "ADM-01", "4", "admin123")
    ];

    public static bool Register(
        string fullName,
        string email,
        string group,
        string course,
        string password,
        out string errorMessage)
    {
        if (string.IsNullOrWhiteSpace(fullName) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(group) ||
            string.IsNullOrWhiteSpace(course) ||
            string.IsNullOrWhiteSpace(password))
        {
            errorMessage = "Заполните все поля регистрации.";
            return false;
        }

        if (Users.Any(u => string.Equals(u.Email, email, StringComparison.OrdinalIgnoreCase)))
        {
            errorMessage = "Пользователь с таким Email уже существует.";
            return false;
        }

        Users.Add(new UserCredentials(fullName.Trim(), email.Trim(), group.Trim(), course.Trim(), password));
        errorMessage = string.Empty;
        return true;
    }

    public static bool Login(string email, string password)
    {
        return Users.Any(u =>
            string.Equals(u.Email, email, StringComparison.OrdinalIgnoreCase) &&
            u.Password == password);
    }

    private sealed record UserCredentials(string FullName, string Email, string Group, string Course, string Password);
}
