using System;
using System.Drawing;
using System.Windows.Forms;

public class CustomSlider : Control
{
    public int Minimum { get; set; } = 0;
    public int Maximum { get; set; } = 100;

    private int value = 0;
    public int Value
    {
        get => value;
        set
        {
            this.value = Math.Max(Minimum, Math.Min(Maximum, value));
            Invalidate();
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    public event EventHandler ValueChanged;

    private bool dragging = false;

    public Color TrackColor { get; set; } = Color.DimGray;
    public Color ProgressColor { get; set; } = Color.DeepSkyBlue;
    public Color ThumbColor { get; set; } = Color.White;

    public int TrackHeight { get; set; } = 6;
    public int ThumbRadius { get; set; } = 7;

    public CustomSlider()
    {
        DoubleBuffered = true;
        Height = 24;
        Cursor = Cursors.Hand;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        if (Width <= ThumbRadius * 2)
            return;

        Graphics g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        int trackY = Height / 2 - TrackHeight / 2;
        int usableWidth = Width - ThumbRadius * 2;

        float percent = (float)(Value - Minimum) / (Maximum - Minimum);
        int progressWidth = (int)(usableWidth * percent);

        // Track
        g.FillRectangle(new SolidBrush(TrackColor),
            ThumbRadius, trackY, usableWidth, TrackHeight);

        // Progress
        g.FillRectangle(new SolidBrush(ProgressColor),
            ThumbRadius, trackY, progressWidth, TrackHeight);

        // Thumb
        int thumbX = ThumbRadius + progressWidth;
        int thumbY = Height / 2;

        g.FillEllipse(new SolidBrush(ThumbColor),
            thumbX - ThumbRadius,
            thumbY - ThumbRadius,
            ThumbRadius * 2,
            ThumbRadius * 2);
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        dragging = true;
        SetValueFromMouse(e.X);
        base.OnMouseDown(e);
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        if (dragging)
            SetValueFromMouse(e.X);

        base.OnMouseMove(e);
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        dragging = false;
        SetValueFromMouse(e.X);
        base.OnMouseUp(e);
    }

    private void SetValueFromMouse(int mouseX)
    {
        int usableWidth = Width - ThumbRadius * 2;
        int x = Math.Max(0, Math.Min(usableWidth, mouseX - ThumbRadius));
        float percent = (float)x / usableWidth;

        Value = Minimum + (int)((Maximum - Minimum) * percent);
    }
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Invalidate();
    }

}

