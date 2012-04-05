﻿// Copyright (c) 2010-2011 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
#if WIN8

using System;
using System.Runtime.InteropServices;
namespace SharpDX.Direct2D1
{
    internal partial class PropertyBinding
    {
        public delegate void SetDelegate<T>(T value) where T : struct;
        public delegate T GetDelegate<T>() where T : struct;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int NativeSetFunctionDelegate(IntPtr thisPtr, IntPtr dataPtr, int dataSize);
        private int NativeSetFunctionDelegateImpl(IntPtr thisPtr, IntPtr dataPtr, int dataSize)
        {

            return 0;
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int NativeGetFunctionDelegate(IntPtr thisPtr, IntPtr dataPtr, int dataSize, ref int actualSize);
        private int NativeGetFunctionDelegateImpl(IntPtr thisPtr, IntPtr dataPtr, int dataSize, ref int actualSize)
        {

            return 0;
        }
    }
}
#endif