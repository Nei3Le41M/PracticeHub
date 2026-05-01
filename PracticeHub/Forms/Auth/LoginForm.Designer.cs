namespace PracticeHub.Forms.Auth;

partial class LoginForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null!;

    private Panel authPanel = null!;
    private Label titleLabel = null!;
    private Panel switchPanel = null!;
    private Button loginTabButton = null!;
    private Button registerTabButton = null!;
    private Label emailLabel = null!;
    private StyledTextBox emailTextBox = null!;
    private Label passwordLabel = null!;
    private LinkLabel forgotPasswordLink = null!;
    private StyledTextBox passwordTextBox = null!;
    private Label emailErrorLabel = null!;
    private Label passwordErrorLabel = null!;
    private Button loginButton = null!;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
        authPanel = new Panel();
        pictureBox1 = new PictureBox();
        loginButton = new Button();
        passwordErrorLabel = new Label();
        passwordTextBox = new StyledTextBox();
        forgotPasswordLink = new LinkLabel();
        passwordLabel = new Label();
        emailErrorLabel = new Label();
        emailTextBox = new StyledTextBox();
        emailLabel = new Label();
        switchPanel = new Panel();
        registerTabButton = new Button();
        loginTabButton = new Button();
        titleLabel = new Label();
        authPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        switchPanel.SuspendLayout();
        SuspendLayout();
        // 
        // authPanel
        // 
        authPanel.BackColor = Color.FromArgb(247, 247, 247);
        authPanel.Controls.Add(pictureBox1);
        authPanel.Controls.Add(loginButton);
        authPanel.Controls.Add(passwordErrorLabel);
        authPanel.Controls.Add(passwordTextBox);
        authPanel.Controls.Add(forgotPasswordLink);
        authPanel.Controls.Add(passwordLabel);
        authPanel.Controls.Add(emailErrorLabel);
        authPanel.Controls.Add(emailTextBox);
        authPanel.Controls.Add(emailLabel);
        authPanel.Controls.Add(switchPanel);
        authPanel.Controls.Add(titleLabel);
        authPanel.Location = new Point(321, 109);
        authPanel.Name = "authPanel";
        authPanel.Size = new Size(640, 599);
        authPanel.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(222, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(40, 30);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 11;
        pictureBox1.TabStop = false;
        // 
        // loginButton
        // 
        loginButton.BackColor = Color.FromArgb(97, 119, 245);
        loginButton.FlatStyle = FlatStyle.Flat;
        loginButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
        loginButton.ForeColor = Color.White;
        loginButton.Location = new Point(35, 484);
        loginButton.Name = "loginButton";
        loginButton.Size = new Size(570, 42);
        loginButton.TabIndex = 7;
        loginButton.Text = "Войти в аккаунт";
        loginButton.UseVisualStyleBackColor = false;
        loginButton.Click += LoginButton_Click;
        // 
        // passwordErrorLabel
        // 
        passwordErrorLabel.AutoSize = true;
        passwordErrorLabel.ForeColor = Color.FromArgb(255, 77, 79);
        passwordErrorLabel.Location = new Point(35, 432);
        passwordErrorLabel.Name = "passwordErrorLabel";
        passwordErrorLabel.Size = new Size(0, 20);
        passwordErrorLabel.TabIndex = 10;
        passwordErrorLabel.Visible = false;
        // 
        // passwordTextBox
        // 
        passwordTextBox.BackColor = Color.FromArgb(243, 244, 246);
        passwordTextBox.Location = new Point(35, 373);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.Padding = new Padding(14);
        passwordTextBox.Size = new Size(570, 52);
        passwordTextBox.TabIndex = 6;
        // 
        // forgotPasswordLink
        // 
        forgotPasswordLink.ActiveLinkColor = Color.FromArgb(59, 130, 246);
        forgotPasswordLink.AutoSize = true;
        forgotPasswordLink.LinkColor = Color.FromArgb(59, 130, 246);
        forgotPasswordLink.Location = new Point(481, 344);
        forgotPasswordLink.Name = "forgotPasswordLink";
        forgotPasswordLink.Size = new Size(124, 20);
        forgotPasswordLink.TabIndex = 5;
        forgotPasswordLink.TabStop = true;
        forgotPasswordLink.Text = "Забыли пароль?";
        forgotPasswordLink.VisitedLinkColor = Color.FromArgb(59, 130, 246);
        forgotPasswordLink.Click += ForgotPasswordLink_Click;
        // 
        // passwordLabel
        // 
        passwordLabel.AutoSize = true;
        passwordLabel.Location = new Point(35, 344);
        passwordLabel.Name = "passwordLabel";
        passwordLabel.Size = new Size(62, 20);
        passwordLabel.TabIndex = 4;
        passwordLabel.Text = "Пароль";
        // 
        // emailErrorLabel
        // 
        emailErrorLabel.AutoSize = true;
        emailErrorLabel.ForeColor = Color.FromArgb(255, 77, 79);
        emailErrorLabel.Location = new Point(35, 311);
        emailErrorLabel.Name = "emailErrorLabel";
        emailErrorLabel.Size = new Size(0, 20);
        emailErrorLabel.TabIndex = 9;
        emailErrorLabel.Visible = false;
        // 
        // emailTextBox
        // 
        emailTextBox.BackColor = Color.FromArgb(243, 244, 246);
        emailTextBox.Location = new Point(35, 256);
        emailTextBox.Name = "emailTextBox";
        emailTextBox.Padding = new Padding(14);
        emailTextBox.Size = new Size(570, 52);
        emailTextBox.TabIndex = 3;
        // 
        // emailLabel
        // 
        emailLabel.AutoSize = true;
        emailLabel.Location = new Point(35, 227);
        emailLabel.Name = "emailLabel";
        emailLabel.Size = new Size(46, 20);
        emailLabel.TabIndex = 2;
        emailLabel.Text = "Email";
        // 
        // switchPanel
        // 
        switchPanel.BackColor = Color.FromArgb(243, 244, 246);
        switchPanel.Controls.Add(registerTabButton);
        switchPanel.Controls.Add(loginTabButton);
        switchPanel.Location = new Point(35, 118);
        switchPanel.Name = "switchPanel";
        switchPanel.Size = new Size(570, 60);
        switchPanel.TabIndex = 1;
        // 
        // registerTabButton
        // 
        registerTabButton.BackColor = Color.FromArgb(243, 244, 246);
        registerTabButton.FlatAppearance.BorderSize = 0;
        registerTabButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(243, 244, 246);
        registerTabButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 244, 246);
        registerTabButton.FlatStyle = FlatStyle.Flat;
        registerTabButton.Font = new Font("Segoe UI", 12F);
        registerTabButton.ForeColor = Color.FromArgb(73, 80, 87);
        registerTabButton.Location = new Point(286, 6);
        registerTabButton.Name = "registerTabButton";
        registerTabButton.Size = new Size(278, 48);
        registerTabButton.TabIndex = 1;
        registerTabButton.Text = "Регистрация";
        registerTabButton.UseVisualStyleBackColor = false;
        registerTabButton.Click += OpenRegisterLink_Click;
        // 
        // loginTabButton
        // 
        loginTabButton.BackColor = Color.White;
        loginTabButton.FlatAppearance.BorderSize = 0;
        loginTabButton.FlatAppearance.MouseDownBackColor = Color.White;
        loginTabButton.FlatAppearance.MouseOverBackColor = Color.White;
        loginTabButton.FlatStyle = FlatStyle.Flat;
        loginTabButton.Font = new Font("Segoe UI", 12F);
        loginTabButton.Location = new Point(6, 6);
        loginTabButton.Name = "loginTabButton";
        loginTabButton.Size = new Size(278, 48);
        loginTabButton.TabIndex = 0;
        loginTabButton.Text = "Войти";
        loginTabButton.UseVisualStyleBackColor = false;
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        titleLabel.ImageAlign = ContentAlignment.MiddleLeft;
        titleLabel.Location = new Point(262, 2);
        titleLabel.Name = "titleLabel";
        titleLabel.RightToLeft = RightToLeft.No;
        titleLabel.Size = new Size(145, 31);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "PracticeHub";
        titleLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // LoginForm
        // 
        AcceptButton = loginButton;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(247, 247, 247);
        ClientSize = new Size(1280, 720);
        Controls.Add(authPanel);
        MinimumSize = new Size(1000, 700);
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "PracticeHub - Вход";
        authPanel.ResumeLayout(false);
        authPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        switchPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private PictureBox pictureBox1;
}
