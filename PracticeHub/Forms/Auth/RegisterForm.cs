using System.Text.RegularExpressions;
using PracticeHub.Helpers;

namespace PracticeHub.Forms.Auth;

public partial class RegisterForm : Form
{
    private readonly LoginForm loginForm;
    private bool isSwitchingToLogin;

    public RegisterForm(LoginForm loginForm)
    {
        InitializeComponent();
        this.loginForm = loginForm;
        fullNameTextBox.SetPlaceholder("Иванов Иван Иванович");
        emailTextBox.SetPlaceholder("you@university.ru");
        groupTextBox.SetPlaceholder("ИС-301");
        courseComboBox.SetSelectedIndex(0);
        passwordTextBox.SetPlaceholder("Введите пароль");
        passwordTextBox.SetPasswordMode(true);
        repeatPasswordTextBox.SetPlaceholder("Повтор");
        repeatPasswordTextBox.SetPasswordMode(true);
        fullNameTextBox.TextChanged += (_, _) => ValidateFullNameField();
        emailTextBox.TextChanged += (_, _) => ValidateEmailField();
        groupTextBox.TextChanged += (_, _) => ValidateGroupField();
        courseComboBox.SelectedIndexChanged += (_, _) => ValidateCourseField();
        passwordTextBox.TextChanged += (_, _) => ValidatePasswordField();
        repeatPasswordTextBox.TextChanged += (_, _) => ValidateRepeatPasswordField();
        Resize += RegisterForm_Resize;
        Shown += (_, _) => CenterAuthPanel();
        FormClosing += RegisterForm_FormClosing;
        FormClosed += RegisterForm_FormClosed;
    }

    private void RegisterButton_Click(object? sender, EventArgs e)
    {
        var fullName = fullNameTextBox.Text.Trim();
        var email = emailTextBox.Text.Trim();
        var group = groupTextBox.Text.Trim();
        var course = courseComboBox.GetSelectedText();
        var password = passwordTextBox.Text;
        var repeatPassword = repeatPasswordTextBox.Text;

        var isFullNameValid = ValidateFullNameField();
        var isEmailValid = ValidateEmailField();
        var isGroupValid = ValidateGroupField();
        var isCourseValid = ValidateCourseField();
        var isPasswordValid = ValidatePasswordField();
        var isRepeatValid = ValidateRepeatPasswordField();
        if (!isFullNameValid || !isEmailValid || !isGroupValid || !isCourseValid || !isPasswordValid || !isRepeatValid)
        {
            return;
        }

        if (!AuthMemoryStore.Register(fullName, email, group, course, password, out var errorMessage))
        {
            MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        MessageBox.Show("Регистрация прошла успешно. Теперь войдите в систему.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        OpenLoginForm();
    }

    private void OpenLoginForm_Click(object? sender, EventArgs e)
    {
        OpenLoginForm();
    }

    private void OpenLoginForm()
    {
        isSwitchingToLogin = true;
        loginForm.Show();
        loginForm.StartPosition = FormStartPosition.Manual;
        loginForm.Bounds = Bounds;
        loginForm.WindowState = WindowState;
        Close();
    }

    private void RegisterForm_Resize(object? sender, EventArgs e)
    {
        CenterAuthPanel();
    }

    private void CenterAuthPanel()
    {
        authPanel.Left = (ClientSize.Width - authPanel.Width) / 2;
        authPanel.Top = (ClientSize.Height - authPanel.Height) / 2;
    }

    private void RegisterForm_FormClosed(object? sender, FormClosedEventArgs e)
    {
        if (isSwitchingToLogin)
        {
            return;
        }

        Application.Exit();
    }

    private void RegisterForm_FormClosing(object? sender, FormClosingEventArgs e)
    {
        WindowStateStore.Save(this);
    }

    private bool ValidateFullNameField()
    {
        if (string.IsNullOrWhiteSpace(fullNameTextBox.Text))
        {
            SetFullNameError("Введите ФИО");
            return false;
        }

        SetFullNameError(null);
        return true;
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

    private bool ValidateGroupField()
    {
        if (string.IsNullOrWhiteSpace(groupTextBox.Text))
        {
            SetGroupError("Укажите группу");
            return false;
        }

        SetGroupError(null);
        return true;
    }

    private bool ValidateCourseField()
    {
        if (courseComboBox.GetSelectedText() == "Курс")
        {
            SetCourseError("Выберите курс");
            return false;
        }

        SetCourseError(null);
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
        ValidateRepeatPasswordField();
        return true;
    }

    private bool ValidateRepeatPasswordField()
    {
        var value = repeatPasswordTextBox.Text;
        if (string.IsNullOrWhiteSpace(value))
        {
            SetRepeatPasswordError("Повторите пароль");
            return false;
        }

        if (value != passwordTextBox.Text)
        {
            SetRepeatPasswordError("Пароли не совпадают");
            return false;
        }

        SetRepeatPasswordError(null);
        return true;
    }

    private void SetFullNameError(string? message)
    {
        fullNameErrorLabel.Text = message ?? string.Empty;
        fullNameErrorLabel.Visible = !string.IsNullOrEmpty(message);
        fullNameTextBox.SetErrorState(!string.IsNullOrEmpty(message));
    }

    private void SetEmailError(string? message)
    {
        emailErrorLabel.Text = message ?? string.Empty;
        emailErrorLabel.Visible = !string.IsNullOrEmpty(message);
        emailTextBox.SetErrorState(!string.IsNullOrEmpty(message));
    }

    private void SetGroupError(string? message)
    {
        groupErrorLabel.Text = message ?? string.Empty;
        groupErrorLabel.Visible = !string.IsNullOrEmpty(message);
        groupTextBox.SetErrorState(!string.IsNullOrEmpty(message));
    }

    private void SetCourseError(string? message)
    {
        courseErrorLabel.Text = message ?? string.Empty;
        courseErrorLabel.Visible = !string.IsNullOrEmpty(message);
        courseComboBox.SetErrorState(!string.IsNullOrEmpty(message));
    }

    private void SetPasswordError(string? message)
    {
        passwordErrorLabel.Text = message ?? string.Empty;
        passwordErrorLabel.Visible = !string.IsNullOrEmpty(message);
        passwordTextBox.SetErrorState(!string.IsNullOrEmpty(message));
    }

    private void SetRepeatPasswordError(string? message)
    {
        repeatPasswordErrorLabel.Text = message ?? string.Empty;
        repeatPasswordErrorLabel.Visible = !string.IsNullOrEmpty(message);
        repeatPasswordTextBox.SetErrorState(!string.IsNullOrEmpty(message));
    }
}
