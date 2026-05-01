namespace PracticeHub.Forms.Auth;

public sealed class StyledComboBox : UserControl
{
    private readonly ComboBox innerComboBox;
    private bool isHovered;
    private bool isFocused;
    private bool hasError;

    public StyledComboBox()
    {
        DoubleBuffered = true;
        Size = new Size(290, 52);
        Padding = new Padding(14, 8, 14, 8);
        BackColor = ColorTranslator.FromHtml("#F3F4F6");

        innerComboBox = new ComboBox
        {
            Dock = DockStyle.Fill,
            BackColor = BackColor,
            FlatStyle = FlatStyle.Flat,
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204)
        };

        Controls.Add(innerComboBox);

        innerComboBox.MouseEnter += (_, _) => SetHoverState(true);
        innerComboBox.MouseLeave += (_, _) => SetHoverState(false);
        MouseEnter += (_, _) => SetHoverState(true);
        MouseLeave += (_, _) => SetHoverState(false);

        innerComboBox.Enter += (_, _) =>
        {
            isFocused = true;
            Invalidate();
        };

        innerComboBox.Leave += (_, _) =>
        {
            isFocused = false;
            Invalidate();
        };

        innerComboBox.SelectedIndexChanged += (_, _) => SelectedIndexChanged?.Invoke(this, EventArgs.Empty);
    }

    [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
    public ComboBox.ObjectCollection Items => innerComboBox.Items;

    public event EventHandler? SelectedIndexChanged;

    public void SetSelectedIndex(int index) => innerComboBox.SelectedIndex = index;

    public string GetSelectedText() => innerComboBox.SelectedItem?.ToString() ?? string.Empty;

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
