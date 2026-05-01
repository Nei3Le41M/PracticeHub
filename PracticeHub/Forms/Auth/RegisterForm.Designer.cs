namespace PracticeHub.Forms.Auth;

partial class RegisterForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null!;

    private Panel authPanel = null!;
    private Panel switchPanel = null!;
    private Button loginTabButton = null!;
    private Button registerTabButton = null!;
    private StyledTextBox fullNameTextBox = null!;
    private StyledTextBox emailTextBox = null!;
    private StyledTextBox groupTextBox = null!;
    private StyledComboBox courseComboBox = null!;
    private StyledTextBox passwordTextBox = null!;
    private StyledTextBox repeatPasswordTextBox = null!;
    private Label fullNameErrorLabel = null!;
    private Label emailErrorLabel = null!;
    private Label groupErrorLabel = null!;
    private Label courseErrorLabel = null!;
    private Label passwordErrorLabel = null!;
    private Label repeatPasswordErrorLabel = null!;
    private Button registerButton = null!;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
        authPanel = new Panel();
        pictureBox1 = new PictureBox();
        titleLabel = new Label();
        registerButton = new Button();
        repeatPasswordErrorLabel = new Label();
        repeatPasswordTextBox = new StyledTextBox();
        passwordErrorLabel = new Label();
        passwordTextBox = new StyledTextBox();
        courseErrorLabel = new Label();
        courseComboBox = new StyledComboBox();
        groupErrorLabel = new Label();
        groupTextBox = new StyledTextBox();
        emailErrorLabel = new Label();
        emailTextBox = new StyledTextBox();
        fullNameErrorLabel = new Label();
        fullNameTextBox = new StyledTextBox();
        switchPanel = new Panel();
        registerTabButton = new Button();
        loginTabButton = new Button();
        authPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        switchPanel.SuspendLayout();
        SuspendLayout();
        // 
        // authPanel
        // 
        authPanel.BackColor = Color.FromArgb(247, 247, 247);
        authPanel.Controls.Add(pictureBox1);
        authPanel.Controls.Add(titleLabel);
        authPanel.Controls.Add(registerButton);
        authPanel.Controls.Add(repeatPasswordErrorLabel);
        authPanel.Controls.Add(repeatPasswordTextBox);
        authPanel.Controls.Add(passwordErrorLabel);
        authPanel.Controls.Add(passwordTextBox);
        authPanel.Controls.Add(courseErrorLabel);
        authPanel.Controls.Add(courseComboBox);
        authPanel.Controls.Add(groupErrorLabel);
        authPanel.Controls.Add(groupTextBox);
        authPanel.Controls.Add(emailErrorLabel);
        authPanel.Controls.Add(emailTextBox);
        authPanel.Controls.Add(fullNameErrorLabel);
        authPanel.Controls.Add(fullNameTextBox);
        authPanel.Controls.Add(switchPanel);
        authPanel.Location = new Point(308, 77);
        authPanel.Name = "authPanel";
        authPanel.Size = new Size(664, 672);
        authPanel.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(233, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(40, 30);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 16;
        pictureBox1.TabStop = false;
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        titleLabel.ImageAlign = ContentAlignment.MiddleLeft;
        titleLabel.Location = new Point(273, 2);
        titleLabel.Name = "titleLabel";
        titleLabel.RightToLeft = RightToLeft.No;
        titleLabel.Size = new Size(145, 31);
        titleLabel.TabIndex = 15;
        titleLabel.Text = "PracticeHub";
        titleLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // registerButton
        // 
        registerButton.BackColor = Color.FromArgb(42, 45, 52);
        registerButton.FlatStyle = FlatStyle.Flat;
        registerButton.Font = new Font("Segoe UI", 10F);
        registerButton.ForeColor = Color.White;
        registerButton.Location = new Point(35, 597);
        registerButton.Name = "registerButton";
        registerButton.Size = new Size(594, 42);
        registerButton.TabIndex = 8;
        registerButton.Text = "Создать аккаунт";
        registerButton.UseVisualStyleBackColor = false;
        registerButton.Click += RegisterButton_Click;
        // 
        // repeatPasswordErrorLabel
        // 
        repeatPasswordErrorLabel.AutoSize = true;
        repeatPasswordErrorLabel.ForeColor = Color.FromArgb(255, 77, 79);
        repeatPasswordErrorLabel.Location = new Point(339, 574);
        repeatPasswordErrorLabel.Name = "repeatPasswordErrorLabel";
        repeatPasswordErrorLabel.Size = new Size(0, 20);
        repeatPasswordErrorLabel.TabIndex = 14;
        repeatPasswordErrorLabel.Visible = false;
        // 
        // repeatPasswordTextBox
        // 
        repeatPasswordTextBox.BackColor = Color.FromArgb(243, 244, 246);
        repeatPasswordTextBox.Location = new Point(339, 519);
        repeatPasswordTextBox.Name = "repeatPasswordTextBox";
        repeatPasswordTextBox.Padding = new Padding(14);
        repeatPasswordTextBox.Size = new Size(290, 52);
        repeatPasswordTextBox.TabIndex = 7;
        // 
        // passwordErrorLabel
        // 
        passwordErrorLabel.AutoSize = true;
        passwordErrorLabel.ForeColor = Color.FromArgb(255, 77, 79);
        passwordErrorLabel.Location = new Point(35, 574);
        passwordErrorLabel.Name = "passwordErrorLabel";
        passwordErrorLabel.Size = new Size(0, 20);
        passwordErrorLabel.TabIndex = 13;
        passwordErrorLabel.Visible = false;
        // 
        // passwordTextBox
        // 
        passwordTextBox.BackColor = Color.FromArgb(243, 244, 246);
        passwordTextBox.Location = new Point(35, 519);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.Padding = new Padding(14);
        passwordTextBox.Size = new Size(290, 52);
        passwordTextBox.TabIndex = 6;
        // 
        // courseErrorLabel
        // 
        courseErrorLabel.AutoSize = true;
        courseErrorLabel.ForeColor = Color.FromArgb(255, 77, 79);
        courseErrorLabel.Location = new Point(339, 474);
        courseErrorLabel.Name = "courseErrorLabel";
        courseErrorLabel.Size = new Size(0, 20);
        courseErrorLabel.TabIndex = 12;
        courseErrorLabel.Visible = false;
        // 
        // courseComboBox
        // 
        courseComboBox.BackColor = Color.FromArgb(243, 244, 246);
        courseComboBox.Items.AddRange(new object[] { "Курс", "1", "2", "3", "4", "5", "6" });
        courseComboBox.Location = new Point(339, 419);
        courseComboBox.Name = "courseComboBox";
        courseComboBox.Padding = new Padding(14, 8, 14, 8);
        courseComboBox.Size = new Size(290, 52);
        courseComboBox.TabIndex = 5;
        // 
        // groupErrorLabel
        // 
        groupErrorLabel.AutoSize = true;
        groupErrorLabel.ForeColor = Color.FromArgb(255, 77, 79);
        groupErrorLabel.Location = new Point(35, 474);
        groupErrorLabel.Name = "groupErrorLabel";
        groupErrorLabel.Size = new Size(0, 20);
        groupErrorLabel.TabIndex = 11;
        groupErrorLabel.Visible = false;
        // 
        // groupTextBox
        // 
        groupTextBox.BackColor = Color.FromArgb(243, 244, 246);
        groupTextBox.Location = new Point(35, 419);
        groupTextBox.Name = "groupTextBox";
        groupTextBox.Padding = new Padding(14);
        groupTextBox.Size = new Size(290, 52);
        groupTextBox.TabIndex = 4;
        // 
        // emailErrorLabel
        // 
        emailErrorLabel.AutoSize = true;
        emailErrorLabel.ForeColor = Color.FromArgb(255, 77, 79);
        emailErrorLabel.Location = new Point(35, 374);
        emailErrorLabel.Name = "emailErrorLabel";
        emailErrorLabel.Size = new Size(0, 20);
        emailErrorLabel.TabIndex = 10;
        emailErrorLabel.Visible = false;
        // 
        // emailTextBox
        // 
        emailTextBox.BackColor = Color.FromArgb(243, 244, 246);
        emailTextBox.Location = new Point(35, 319);
        emailTextBox.Name = "emailTextBox";
        emailTextBox.Padding = new Padding(14);
        emailTextBox.Size = new Size(594, 52);
        emailTextBox.TabIndex = 3;
        // 
        // fullNameErrorLabel
        // 
        fullNameErrorLabel.AutoSize = true;
        fullNameErrorLabel.ForeColor = Color.FromArgb(255, 77, 79);
        fullNameErrorLabel.Location = new Point(35, 274);
        fullNameErrorLabel.Name = "fullNameErrorLabel";
        fullNameErrorLabel.Size = new Size(0, 20);
        fullNameErrorLabel.TabIndex = 9;
        fullNameErrorLabel.Visible = false;
        // 
        // fullNameTextBox
        // 
        fullNameTextBox.BackColor = Color.FromArgb(243, 244, 246);
        fullNameTextBox.Location = new Point(35, 219);
        fullNameTextBox.Name = "fullNameTextBox";
        fullNameTextBox.Padding = new Padding(14);
        fullNameTextBox.Size = new Size(594, 52);
        fullNameTextBox.TabIndex = 2;
        // 
        // switchPanel
        // 
        switchPanel.BackColor = Color.FromArgb(243, 244, 246);
        switchPanel.Controls.Add(registerTabButton);
        switchPanel.Controls.Add(loginTabButton);
        switchPanel.Location = new Point(35, 100);
        switchPanel.Name = "switchPanel";
        switchPanel.Size = new Size(594, 60);
        switchPanel.TabIndex = 1;
        // 
        // registerTabButton
        // 
        registerTabButton.BackColor = Color.White;
        registerTabButton.FlatAppearance.BorderSize = 0;
        registerTabButton.FlatAppearance.MouseDownBackColor = Color.White;
        registerTabButton.FlatAppearance.MouseOverBackColor = Color.White;
        registerTabButton.FlatStyle = FlatStyle.Flat;
        registerTabButton.Font = new Font("Segoe UI", 12F);
        registerTabButton.Location = new Point(298, 6);
        registerTabButton.Name = "registerTabButton";
        registerTabButton.Size = new Size(290, 48);
        registerTabButton.TabIndex = 1;
        registerTabButton.Text = "Регистрация";
        registerTabButton.UseVisualStyleBackColor = false;
        // 
        // loginTabButton
        // 
        loginTabButton.BackColor = Color.FromArgb(243, 244, 246);
        loginTabButton.FlatAppearance.BorderSize = 0;
        loginTabButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(243, 244, 246);
        loginTabButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 244, 246);
        loginTabButton.FlatStyle = FlatStyle.Flat;
        loginTabButton.Font = new Font("Segoe UI", 12F);
        loginTabButton.ForeColor = Color.FromArgb(73, 80, 87);
        loginTabButton.Location = new Point(6, 6);
        loginTabButton.Name = "loginTabButton";
        loginTabButton.Size = new Size(290, 48);
        loginTabButton.TabIndex = 0;
        loginTabButton.Text = "Войти";
        loginTabButton.UseVisualStyleBackColor = false;
        loginTabButton.Click += OpenLoginForm_Click;
        // 
        // RegisterForm
        // 
        AcceptButton = registerButton;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(247, 247, 247);
        ClientSize = new Size(1280, 720);
        Controls.Add(authPanel);
        MinimumSize = new Size(1000, 700);
        Name = "RegisterForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "PracticeHub - Регистрация";
        authPanel.ResumeLayout(false);
        authPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        switchPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private PictureBox pictureBox1;
    private Label titleLabel;
}
