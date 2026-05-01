using System.Text.Json;

namespace PracticeHub.Helpers;

internal static class WindowStateStore
{
    private static readonly string StateFilePath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "PracticeHub",
        "window-state.json");

    public static void Apply(Form form)
    {
        var state = Load();
        if (state is null)
        {
            return;
        }

        if (state.Width > 0 && state.Height > 0)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Bounds = new Rectangle(state.X, state.Y, state.Width, state.Height);
        }

        form.WindowState = state.IsMaximized ? FormWindowState.Maximized : FormWindowState.Normal;
    }

    public static void Save(Form form)
    {
        var directory = Path.GetDirectoryName(StateFilePath);
        if (!string.IsNullOrWhiteSpace(directory))
        {
            Directory.CreateDirectory(directory);
        }

        var bounds = form.WindowState == FormWindowState.Normal ? form.Bounds : form.RestoreBounds;
        var state = new WindowStateDto(
            X: bounds.X,
            Y: bounds.Y,
            Width: bounds.Width,
            Height: bounds.Height,
            IsMaximized: form.WindowState == FormWindowState.Maximized);

        File.WriteAllText(StateFilePath, JsonSerializer.Serialize(state));
    }

    private static WindowStateDto? Load()
    {
        if (!File.Exists(StateFilePath))
        {
            return null;
        }

        try
        {
            var json = File.ReadAllText(StateFilePath);
            return JsonSerializer.Deserialize<WindowStateDto>(json);
        }
        catch
        {
            return null;
        }
    }

    private sealed record WindowStateDto(int X, int Y, int Width, int Height, bool IsMaximized);
}
