using System.Runtime.InteropServices;

namespace LeftyMousy
{
    internal static class NativeMethods
    {
        [DllImport("user32.dll")]
        internal static extern bool SwapMouseButton(bool fSwap);
    }
}