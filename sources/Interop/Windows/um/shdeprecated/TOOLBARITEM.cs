// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct TOOLBARITEM
    {
        public IDockingWindow* ptbar;

        [NativeTypeName("BORDERWIDTHS")]
        public RECT rcBorderTool;

        [NativeTypeName("LPWSTR")]
        public ushort* pwszItem;

        [NativeTypeName("BOOL")]
        public int fShow;

        [NativeTypeName("HMONITOR")]
        public IntPtr hMon;
    }
}