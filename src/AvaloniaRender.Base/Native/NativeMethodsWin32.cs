﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaRender.Core.Native
{
    internal class NativeMethodsWin32
    {
        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);
    }
}
