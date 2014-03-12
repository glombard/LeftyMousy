using System;
using System.Windows.Forms;

namespace LeftyMousy
{
    internal class MouseIcon : IDisposable
    {
        private readonly NotifyIcon _icon;

        public MouseIcon()
        {
            _icon = new NotifyIcon();
        }

        public void Dispose()
        {
            _icon.Dispose();
        }

        public void Show()
        {
            _icon.MouseClick += Clicked;
            _icon.Icon = IconResource.mouse;
            SetText();
            _icon.Visible = true;
            // _icon.ContextMenuStrip = ...
        }

        private void Clicked(object sender, MouseEventArgs e)
        {
            NativeMethods.SwapMouseButton(!SystemInformation.MouseButtonsSwapped);
            SetText();
        }

        private void SetText()
        {
            bool swapped = SystemInformation.MouseButtonsSwapped;
            _icon.Text = string.Format("Switch to {0} mode", swapped ? "righty" : "lefty");
        }
    }
}