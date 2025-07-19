using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

public partial class CustomMessageBox : Form
{
    private Guna2Button btnOK;
    private Guna2Button btnCancel;
    private Guna2Button btnYes;
    private Guna2Button btnNo;
    private Guna2PictureBox picIcon;
    private Guna2HtmlLabel lblMessage;
    private Guna2HtmlLabel lblTitle;
    private Guna2Panel pnlMain;
    private Guna2Panel pnlButtons;
    private Guna2Panel pnlHeader;
    private Guna2ControlBox btnClose;
    private Guna2DragControl dragControl;
    private Guna2ShadowForm shadowForm;

    public enum MessageBoxType
    {
        Information,
        Warning,
        Error,
        Success,
        Question
    }

    public enum MessageBoxButtons
    {
        OK,
        OKCancel,
        YesNo,
        YesNoCancel
    }

    public DialogResult Result { get; private set; }

    public CustomMessageBox()
    {
        InitializeComponent();
        this.FormBorderStyle = FormBorderStyle.None;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.ShowInTaskbar = false;
        this.TopMost = true;
        this.Size = new Size(400, 220);
        this.BackColor = Color.White;
    }

    private void InitializeComponent()
    {
        // Shadow Form
        shadowForm = new Guna2ShadowForm();
        shadowForm.SetShadowForm(this);

        // Drag Control
        dragControl = new Guna2DragControl();
        dragControl.TargetControl = this;

        // Header Panel
        pnlHeader = new Guna2Panel();
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Height = 50;
        pnlHeader.FillColor = Color.FromArgb(94, 148, 255);
        pnlHeader.BackColor = Color.Transparent;

        // Close Button
        btnClose = new Guna2ControlBox();
        btnClose.Dock = DockStyle.Right;
        btnClose.FillColor = Color.Transparent;
        btnClose.HoverState.FillColor = Color.FromArgb(232, 17, 35);
        btnClose.IconColor = Color.White;
        btnClose.Click += (s, e) => { this.Result = DialogResult.Cancel; this.Close(); };

        // Title Label
        lblTitle = new Guna2HtmlLabel();
        lblTitle.Text = "Thông báo";
        lblTitle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.BackColor = Color.Transparent;
        lblTitle.Location = new Point(15, 15);
        lblTitle.AutoSize = true;

        // Main Panel
        pnlMain = new Guna2Panel();
        pnlMain.Dock = DockStyle.Fill;
        pnlMain.FillColor = Color.White;
        pnlMain.BackColor = Color.Transparent;
        pnlMain.Padding = new Padding(20);

        // Icon
        picIcon = new Guna2PictureBox();
        picIcon.Size = new Size(48, 48);
        picIcon.Location = new Point(20, 20);
        picIcon.SizeMode = PictureBoxSizeMode.StretchImage;
        picIcon.BackColor = Color.Transparent;

        // Message Label
        lblMessage = new Guna2HtmlLabel();
        lblMessage.Font = new Font("Segoe UI", 10);
        lblMessage.ForeColor = Color.FromArgb(64, 64, 64);
        lblMessage.BackColor = Color.Transparent;
        lblMessage.Location = new Point(80, 20);
        lblMessage.MaximumSize = new Size(280, 0);
        lblMessage.AutoSize = true;

        // Buttons Panel
        pnlButtons = new Guna2Panel();
        pnlButtons.Dock = DockStyle.Bottom;
        pnlButtons.Height = 60;
        pnlButtons.FillColor = Color.FromArgb(248, 249, 250);
        pnlButtons.BackColor = Color.Transparent;

        // Add controls to panels
        pnlHeader.Controls.Add(btnClose);
        pnlHeader.Controls.Add(lblTitle);
        pnlMain.Controls.Add(picIcon);
        pnlMain.Controls.Add(lblMessage);

        // Add panels to form
        this.Controls.Add(pnlMain);
        this.Controls.Add(pnlButtons);
        this.Controls.Add(pnlHeader);

        CreateButtons();
    }

    private void CreateButtons()
    {
        // OK Button
        btnOK = CreateButton("OK", Color.FromArgb(94, 148, 255));
        btnOK.Click += (s, e) => { this.Result = DialogResult.OK; this.Close(); };

        // Cancel Button
        btnCancel = CreateButton("Hủy", Color.FromArgb(108, 117, 125));
        btnCancel.Click += (s, e) => { this.Result = DialogResult.Cancel; this.Close(); };

        // Yes Button
        btnYes = CreateButton("Có", Color.FromArgb(40, 167, 69));
        btnYes.Click += (s, e) => { this.Result = DialogResult.Yes; this.Close(); };

        // No Button
        btnNo = CreateButton("Không", Color.FromArgb(220, 53, 69));
        btnNo.Click += (s, e) => { this.Result = DialogResult.No; this.Close(); };
    }

    private Guna2Button CreateButton(string text, Color fillColor)
    {
        var button = new Guna2Button();
        button.Text = text;
        button.Size = new Size(80, 35);
        button.Font = new Font("Segoe UI", 9, FontStyle.Bold);
        button.FillColor = fillColor;
        button.ForeColor = Color.White;
        button.BorderRadius = 5;
        button.HoverState.FillColor = ControlPaint.Dark(fillColor, 0.1f);
        button.UseTransparentBackground = true;
        button.ShadowDecoration.Enabled = true;
        button.ShadowDecoration.Shadow = new Padding(2);
        button.ShadowDecoration.Color = Color.FromArgb(40, 0, 0, 0);
        return button;
    }

    private void SetIcon(MessageBoxType type)
    {
        switch (type)
        {
            case MessageBoxType.Information:
                picIcon.Image = CreateInfoIcon();
                pnlHeader.FillColor = Color.FromArgb(94, 148, 255);
                break;
            case MessageBoxType.Warning:
                picIcon.Image = CreateWarningIcon();
                pnlHeader.FillColor = Color.FromArgb(255, 193, 7);
                break;
            case MessageBoxType.Error:
                picIcon.Image = CreateErrorIcon();
                pnlHeader.FillColor = Color.FromArgb(220, 53, 69);
                break;
            case MessageBoxType.Success:
                picIcon.Image = CreateSuccessIcon();
                pnlHeader.FillColor = Color.FromArgb(40, 167, 69);
                break;
            case MessageBoxType.Question:
                picIcon.Image = CreateQuestionIcon();
                pnlHeader.FillColor = Color.FromArgb(108, 117, 125);
                break;
        }
        btnClose.FillColor = Color.Transparent;
        btnClose.HoverState.FillColor = Color.FromArgb(50, 255, 255, 255);
    }

    private Bitmap CreateInfoIcon()
    {
        var bitmap = new Bitmap(48, 48);
        using (var g = Graphics.FromImage(bitmap))
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Vẽ background circle
            using (var brush = new SolidBrush(Color.FromArgb(94, 148, 255)))
            {
                g.FillEllipse(brush, 0, 0, 48, 48);
            }

            // Vẽ chữ "i"
            using (var font = new Font("Segoe UI", 20, FontStyle.Bold))
            using (var brush = new SolidBrush(Color.White))
            {
                var stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                g.DrawString("i", font, brush, new RectangleF(0, 0, 48, 48), stringFormat);
            }
        }
        return bitmap;
    }

    private Bitmap CreateWarningIcon()
    {
        var bitmap = new Bitmap(48, 48);
        using (var g = Graphics.FromImage(bitmap))
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Vẽ triangle
            var points = new Point[] {
                new Point(24, 4),
                new Point(44, 40),
                new Point(4, 40)
            };

            using (var brush = new SolidBrush(Color.FromArgb(255, 193, 7)))
            {
                g.FillPolygon(brush, points);
            }

            // Vẽ dấu "!"
            using (var font = new Font("Segoe UI", 18, FontStyle.Bold))
            using (var brush = new SolidBrush(Color.White))
            {
                var stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                g.DrawString("!", font, brush, new RectangleF(0, 0, 48, 48), stringFormat);
            }
        }
        return bitmap;
    }

    private Bitmap CreateErrorIcon()
    {
        var bitmap = new Bitmap(48, 48);
        using (var g = Graphics.FromImage(bitmap))
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Vẽ background circle
            using (var brush = new SolidBrush(Color.FromArgb(220, 53, 69)))
            {
                g.FillEllipse(brush, 0, 0, 48, 48);
            }

            // Vẽ dấu "X"
            using (var pen = new Pen(Color.White, 4))
            {
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                g.DrawLine(pen, 14, 14, 34, 34);
                g.DrawLine(pen, 34, 14, 14, 34);
            }
        }
        return bitmap;
    }

    private Bitmap CreateSuccessIcon()
    {
        var bitmap = new Bitmap(48, 48);
        using (var g = Graphics.FromImage(bitmap))
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Vẽ background circle
            using (var brush = new SolidBrush(Color.FromArgb(40, 167, 69)))
            {
                g.FillEllipse(brush, 0, 0, 48, 48);
            }

            // Vẽ dấu check
            using (var pen = new Pen(Color.White, 4))
            {
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                var points = new Point[] {
                    new Point(12, 24),
                    new Point(20, 32),
                    new Point(36, 16)
                };
                g.DrawLines(pen, points);
            }
        }
        return bitmap;
    }

    private Bitmap CreateQuestionIcon()
    {
        var bitmap = new Bitmap(48, 48);
        using (var g = Graphics.FromImage(bitmap))
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Vẽ background circle
            using (var brush = new SolidBrush(Color.FromArgb(108, 117, 125)))
            {
                g.FillEllipse(brush, 0, 0, 48, 48);
            }

            // Vẽ dấu "?"
            using (var font = new Font("Segoe UI", 20, FontStyle.Bold))
            using (var brush = new SolidBrush(Color.White))
            {
                var stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                g.DrawString("?", font, brush, new RectangleF(0, 0, 48, 48), stringFormat);
            }
        }
        return bitmap;
    }

    private void SetButtons(MessageBoxButtons buttons)
    {
        pnlButtons.Controls.Clear();

        switch (buttons)
        {
            case MessageBoxButtons.OK:
                btnOK.Location = new Point(310, 12);
                pnlButtons.Controls.Add(btnOK);
                break;
            case MessageBoxButtons.OKCancel:
                btnCancel.Location = new Point(220, 12);
                btnOK.Location = new Point(310, 12);
                pnlButtons.Controls.Add(btnCancel);
                pnlButtons.Controls.Add(btnOK);
                break;
            case MessageBoxButtons.YesNo:
                btnNo.Location = new Point(220, 12);
                btnYes.Location = new Point(310, 12);
                pnlButtons.Controls.Add(btnNo);
                pnlButtons.Controls.Add(btnYes);
                break;
            case MessageBoxButtons.YesNoCancel:
                btnCancel.Location = new Point(130, 12);
                btnNo.Location = new Point(220, 12);
                btnYes.Location = new Point(310, 12);
                pnlButtons.Controls.Add(btnCancel);
                pnlButtons.Controls.Add(btnNo);
                pnlButtons.Controls.Add(btnYes);
                break;
        }
    }

    public static DialogResult Show(string message, string title = "Thông báo",
        MessageBoxType type = MessageBoxType.Information,
        MessageBoxButtons buttons = MessageBoxButtons.OK)
    {
        using (var msgBox = new CustomMessageBox())
        {
            msgBox.lblMessage.Text = message;
            msgBox.lblTitle.Text = title;
            msgBox.SetIcon(type);
            msgBox.SetButtons(buttons);

            // Tự động điều chỉnh kích thước dựa trên nội dung
            msgBox.AdjustSize();

            msgBox.ShowDialog();
            return msgBox.Result;
        }
    }

    private void AdjustSize()
    {
        // Tính toán kích thước phù hợp
        var messageSize = TextRenderer.MeasureText(lblMessage.Text, lblMessage.Font,
            new Size(280, 0), TextFormatFlags.WordBreak);

        var newHeight = Math.Max(220, messageSize.Height + 140);
        var newWidth = Math.Max(400, messageSize.Width + 140);

        this.Size = new Size(newWidth, newHeight);

        // Điều chỉnh vị trí message
        lblMessage.MaximumSize = new Size(newWidth - 140, 0);

        // Căn giữa form
        this.StartPosition = FormStartPosition.CenterScreen;
    }

}

// Cách sử dụng:
public class MessageBoxHelper
{
    public static DialogResult ShowInfo(string message, string title = "Thông tin")
    {
        return CustomMessageBox.Show(message, title, CustomMessageBox.MessageBoxType.Information);
    }

    public static DialogResult ShowWarning(string message, string title = "Cảnh báo")
    {
        return CustomMessageBox.Show(message, title, CustomMessageBox.MessageBoxType.Warning);
    }

    public static DialogResult ShowError(string message, string title = "Lỗi")
    {
        return CustomMessageBox.Show(message, title, CustomMessageBox.MessageBoxType.Error);
    }

    public static DialogResult ShowSuccess(string message, string title = "Thành công")
    {
        return CustomMessageBox.Show(message, title, CustomMessageBox.MessageBoxType.Success);
    }

    public static DialogResult ShowQuestion(string message, string title = "Xác nhận")
    {
        return CustomMessageBox.Show(message, title, CustomMessageBox.MessageBoxType.Question,
            CustomMessageBox.MessageBoxButtons.YesNo);
    }
}

// Ví dụ sử dụng:
/*
// Thông tin
MessageBoxHelper.ShowInfo("Thao tác đã được thực hiện thành công!");

// Cảnh báo
MessageBoxHelper.ShowWarning("Dữ liệu chưa được lưu. Bạn có muốn tiếp tục?");

// Lỗi
MessageBoxHelper.ShowError("Có lỗi xảy ra trong quá trình xử lý!");

// Thành công
MessageBoxHelper.ShowSuccess("Dữ liệu đã được lưu thành công!");

// Xác nhận
if (MessageBoxHelper.ShowQuestion("Bạn có chắc chắn muốn xóa?") == DialogResult.Yes)
{
    // Thực hiện xóa
}

// Sử dụng trực tiếp
var result = CustomMessageBox.Show("Nội dung thông báo", "Tiêu đề", 
    CustomMessageBox.MessageBoxType.Question, CustomMessageBox.MessageBoxButtons.YesNoCancel);
*/