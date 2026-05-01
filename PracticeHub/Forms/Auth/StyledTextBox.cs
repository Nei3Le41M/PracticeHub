namespace PracticeHub.Forms.Auth;

public sealed class StyledTextBox : UserControl
{
    private readonly TextBox innerTextBox;
    private bool isHovered;
    private bool isFocused;
    private bool hasError;

    public StyledTextBox()
    {
        DoubleBuffered = true;
        Size = new Size(570, 52);
        Padding = new Padding(14, 14, 14, 14);
        BackColor = ColorTranslator.FromHtml("#F3F4F6");

        innerTextBox = new TextBox
        {
            BorderStyle = BorderStyle.None,
            Dock = DockStyle.Fill,
            BackColor = BackColor,
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204)
        };

        Controls.Add(innerTextBox);

        innerTextBox.MouseEnter += (_, _) => SetHoverState(true);
        innerTextBox.MouseLeave += (_, _) => SetHoverState(false);
        MouseEnter += (_, _) => SetHoverState(true);
        MouseLeave += (_, _) => SetHoverState(false);

        innerTextBox.Enter += (_, _) =>
        {
            isFocused = true;
            Invalidate();
        };

        innerTextBox.Leave += (_, _) =>
        {
            isFocused = false;
            Invalidate();
        };

        Click += (_, _) => innerTextBox.Focus();
        innerTextBox.TextChanged += (_, _) => OnTextChanged(EventArgs.Empty);
    }

    [System.Diagnostics.CodeAnalysis.AllowNull]
    public override string Text
    {
        get => innerTextBox.Text;
        set => innerTextBox.Text = value ?? string.Empty;
    }

    public void Clear()
    {
        innerTextBox.Clear();
    }

    public void SetPasswordMode(bool isPassword)
    {
        innerTextBox.UseSystemPasswordChar = isPassword;
    }

    public void SetPlaceholder(string placeholderText)
    {
        innerTextBox.PlaceholderText = placeholderText;
    }

    public void SetErrorState(bool isError)
    {
        hasError = isError;
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        var borderColor = ColorTranslator.FromHtml("#D1D5DB");
        if (isFocused)
        {
            borderColor = ColorTranslator.FromHtml("#5B7CFA");
        }
        else if (hasError)
        {
            borderColor = ColorTranslator.FromHtml("#FF4D4F");
        }
        else if (isHovered)
        {
            borderColor = ColorTranslator.FromHtml("#374151");
        }

        using var pen = new Pen(borderColor, 1.6f);
        var borderRect = new Rectangle(0, 0, Width - 1, Height - 1);
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        e.Graphics.DrawRoundedRectangle(pen, borderRect, new Size(12, 12));
    }

    private void SetHoverState(bool hovered)
    {
        isHovered = hovered;
        Invalidate();
    }
}
