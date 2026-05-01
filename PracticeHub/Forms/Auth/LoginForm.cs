using System.Text.RegularExpressions;
using PracticeHub.Helpers;

namespace PracticeHub.Forms.Auth;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
        emailTextBox.SetPlaceholder("you@university.ru");
        passwordTextBox.SetPlaceholder("Введите пароль");
        passwordTextBox.SetPasswordMode(true);
        emailTextBox.TextChanged += (_, _) => ValidateEmailField();
        passwordTextBox.TextChanged += (_, _) => ValidatePasswordField();
        Resize += LoginForm_Resize;
        Shown += (_, _) => CenterAuthPanel();
        FormClosing += LoginForm_FormClosing;
    }

    private void LoginButton_Click(object? sender, EventArgs e)
    {
        var username = emailTextBox.Text.Trim();
        var password = passwordTextBox.Text;

        var isEmailValid = ValidateEmailField();
        var isPasswordValid = ValidatePasswordField();
        if (!isEmailValid || !isPasswordValid)
        {
            return;
        }

        if (AuthMemoryStore.Login(username, password))
        {
            MessageBox.Show("Вход выполнен успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            emailTextBox.Clear();
            passwordTextBox.Clear();
            return;
        }

        MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void OpenRegisterLink_Click(object? sender, EventArgs e)
    {
        var registerForm = new RegisterForm(this)
        {
            StartPosition = FormStartPosition.Manual,
            Bounds = Bounds,
            WindowState = WindowState
        };
        registerForm.Show();
        Hide();
    }

    private void ForgotPasswordLink_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Функция восстановления пароля будет добавлена позже.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void LoginForm_Resize(object? sender, EventArgs e)
    {
        CenterAuthPanel();
    }

    private void CenterAuthPanel()
    {
        authPanel.Left = (ClientSize.Width - authPanel.Width) / 2;
        authPanel.Top = (ClientSize.Height - authPanel.Height) / 2;
    }

    private bool ValidateEmailField()
    {
        var value = emailTextBox.Text.Trim();
        if (string.IsNullOrWhiteSpace(value))
        {
            SetEmailError("Введите email");
            return false;
        }

        if (!Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            SetEmailError("Некорректный email");
            return false;
        }

        SetEmailError(null);
        return true;
    }

    private bool ValidatePasswordField()
    {
        var value = passwordTextBox.Text;
        if (string.IsNullOrWhiteSpace(value))
        {
            SetPasswordError("Введите пароль");
            return false;
        }

        if (value.Length < 8)
        {
            SetPasswordError("Минимум 8 символов");
            return false;
        }

        SetPasswordError(null);
        return true;
    }

    private void SetEmailError(string? message)
    {
        emailErrorLabel.Text = message ?? string.Empty;
        emailErrorLabel.Visible = !string.IsNullOrEmpty(message);
        emailTextBox.SetErrorState(!string.IsNullOrEmpty(message));
    }

    private void SetPasswordError(string? message)
    {
        passwordErrorLabel.Text = message ?? string.Empty;
        passwordErrorLabel.Visible = !string.IsNullOrEmpty(message);
        passwordTextBox.SetErrorState(!string.IsNullOrEmpty(message));
    }

    private void LoginForm_FormClosing(object? sender, FormClosingEventArgs e)
    {
        WindowStateStore.Save(this);
    }
}
