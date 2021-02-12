// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct NTFS_STATISTICS
    {
        [NativeTypeName("DWORD")]
        public uint LogFileFullExceptions;

        [NativeTypeName("DWORD")]
        public uint OtherExceptions;

        [NativeTypeName("DWORD")]
        public uint MftReads;

        [NativeTypeName("DWORD")]
        public uint MftReadBytes;

        [NativeTypeName("DWORD")]
        public uint MftWrites;

        [NativeTypeName("DWORD")]
        public uint MftWriteBytes;

        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:11359:5)")]
        public _MftWritesUserLevel_e__Struct MftWritesUserLevel;

        [NativeTypeName("WORD")]
        public ushort MftWritesFlushForLogFileFull;

        [NativeTypeName("WORD")]
        public ushort MftWritesLazyWriter;

        [NativeTypeName("WORD")]
        public ushort MftWritesUserRequest;

        [NativeTypeName("DWORD")]
        public uint Mft2Writes;

        [NativeTypeName("DWORD")]
        public uint Mft2WriteBytes;

        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:11372:5)")]
        public _Mft2WritesUserLevel_e__Struct Mft2WritesUserLevel;

        [NativeTypeName("WORD")]
        public ushort Mft2WritesFlushForLogFileFull;

        [NativeTypeName("WORD")]
        public ushort Mft2WritesLazyWriter;

        [NativeTypeName("WORD")]
        public ushort Mft2WritesUserRequest;

        [NativeTypeName("DWORD")]
        public uint RootIndexReads;

        [NativeTypeName("DWORD")]
        public uint RootIndexReadBytes;

        [NativeTypeName("DWORD")]
        public uint RootIndexWrites;

        [NativeTypeName("DWORD")]
        public uint RootIndexWriteBytes;

        [NativeTypeName("DWORD")]
        public uint BitmapReads;

        [NativeTypeName("DWORD")]
        public uint BitmapReadBytes;

        [NativeTypeName("DWORD")]
        public uint BitmapWrites;

        [NativeTypeName("DWORD")]
        public uint BitmapWriteBytes;

        [NativeTypeName("WORD")]
        public ushort BitmapWritesFlushForLogFileFull;

        [NativeTypeName("WORD")]
        public ushort BitmapWritesLazyWriter;

        [NativeTypeName("WORD")]
        public ushort BitmapWritesUserRequest;

        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:11397:5)")]
        public _BitmapWritesUserLevel_e__Struct BitmapWritesUserLevel;

        [NativeTypeName("DWORD")]
        public uint MftBitmapReads;

        [NativeTypeName("DWORD")]
        public uint MftBitmapReadBytes;

        [NativeTypeName("DWORD")]
        public uint MftBitmapWrites;

        [NativeTypeName("DWORD")]
        public uint MftBitmapWriteBytes;

        [NativeTypeName("WORD")]
        public ushort MftBitmapWritesFlushForLogFileFull;

        [NativeTypeName("WORD")]
        public ushort MftBitmapWritesLazyWriter;

        [NativeTypeName("WORD")]
        public ushort MftBitmapWritesUserRequest;

        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:11412:5)")]
        public _MftBitmapWritesUserLevel_e__Struct MftBitmapWritesUserLevel;

        [NativeTypeName("DWORD")]
        public uint UserIndexReads;

        [NativeTypeName("DWORD")]
        public uint UserIndexReadBytes;

        [NativeTypeName("DWORD")]
        public uint UserIndexWrites;

        [NativeTypeName("DWORD")]
        public uint UserIndexWriteBytes;

        [NativeTypeName("DWORD")]
        public uint LogFileReads;

        [NativeTypeName("DWORD")]
        public uint LogFileReadBytes;

        [NativeTypeName("DWORD")]
        public uint LogFileWrites;

        [NativeTypeName("DWORD")]
        public uint LogFileWriteBytes;

        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:11433:5)")]
        public _Allocate_e__Struct Allocate;

        [NativeTypeName("DWORD")]
        public uint DiskResourcesExhausted;

        public partial struct _MftWritesUserLevel_e__Struct
        {
            [NativeTypeName("WORD")]
            public ushort Write;

            [NativeTypeName("WORD")]
            public ushort Create;

            [NativeTypeName("WORD")]
            public ushort SetInfo;

            [NativeTypeName("WORD")]
            public ushort Flush;
        }

        public partial struct _Mft2WritesUserLevel_e__Struct
        {
            [NativeTypeName("WORD")]
            public ushort Write;

            [NativeTypeName("WORD")]
            public ushort Create;

            [NativeTypeName("WORD")]
            public ushort SetInfo;

            [NativeTypeName("WORD")]
            public ushort Flush;
        }

        public partial struct _BitmapWritesUserLevel_e__Struct
        {
            [NativeTypeName("WORD")]
            public ushort Write;

            [NativeTypeName("WORD")]
            public ushort Create;

            [NativeTypeName("WORD")]
            public ushort SetInfo;
        }

        public partial struct _MftBitmapWritesUserLevel_e__Struct
        {
            [NativeTypeName("WORD")]
            public ushort Write;

            [NativeTypeName("WORD")]
            public ushort Create;

            [NativeTypeName("WORD")]
            public ushort SetInfo;

            [NativeTypeName("WORD")]
            public ushort Flush;
        }

        public partial struct _Allocate_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint Calls;

            [NativeTypeName("DWORD")]
            public uint Clusters;

            [NativeTypeName("DWORD")]
            public uint Hints;

            [NativeTypeName("DWORD")]
            public uint RunsReturned;

            [NativeTypeName("DWORD")]
            public uint HintsHonored;

            [NativeTypeName("DWORD")]
            public uint HintsClusters;

            [NativeTypeName("DWORD")]
            public uint Cache;

            [NativeTypeName("DWORD")]
            public uint CacheClusters;

            [NativeTypeName("DWORD")]
            public uint CacheMiss;

            [NativeTypeName("DWORD")]
            public uint CacheMissClusters;
        }
    }
}
