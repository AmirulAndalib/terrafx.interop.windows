// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public partial struct STORAGE_OPERATIONAL_REASON
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        public STORAGE_OPERATIONAL_STATUS_REASON Reason;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winioctl.h:2727:5)")]
        public _RawBytes_e__Union RawBytes;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _RawBytes_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winioctl.h:2732:9)")]
            public _ScsiSenseKey_e__Struct ScsiSenseKey;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winioctl.h:2742:9)")]
            public _NVDIMM_N_e__Struct NVDIMM_N;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint AsUlong;

            public partial struct _ScsiSenseKey_e__Struct
            {
                public byte SenseKey;

                public byte ASC;

                public byte ASCQ;

                public byte Reserved;
            }

            public unsafe partial struct _NVDIMM_N_e__Struct
            {
                public byte CriticalHealth;

                [NativeTypeName("BYTE [2]")]
                public fixed byte ModuleHealth[2];

                public byte ErrorThresholdStatus;
            }
        }
    }
}