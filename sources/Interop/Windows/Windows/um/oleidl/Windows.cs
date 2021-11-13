// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("#define UPDFCACHE_NODATACACHE ( 0x1 )")]
        public const int UPDFCACHE_NODATACACHE = (0x1);

        [NativeTypeName("#define UPDFCACHE_ONSAVECACHE ( 0x2 )")]
        public const int UPDFCACHE_ONSAVECACHE = (0x2);

        [NativeTypeName("#define UPDFCACHE_ONSTOPCACHE ( 0x4 )")]
        public const int UPDFCACHE_ONSTOPCACHE = (0x4);

        [NativeTypeName("#define UPDFCACHE_NORMALCACHE ( 0x8 )")]
        public const int UPDFCACHE_NORMALCACHE = (0x8);

        [NativeTypeName("#define UPDFCACHE_IFBLANK ( 0x10 )")]
        public const int UPDFCACHE_IFBLANK = (0x10);

        [NativeTypeName("#define UPDFCACHE_ONLYIFBLANK ( 0x80000000 )")]
        public const uint UPDFCACHE_ONLYIFBLANK = (0x80000000);

        [NativeTypeName("#define UPDFCACHE_IFBLANKORONSAVECACHE ( ( UPDFCACHE_IFBLANK | UPDFCACHE_ONSAVECACHE )  )")]
        public const int UPDFCACHE_IFBLANKORONSAVECACHE = (((0x10) | (0x2)));

        [NativeTypeName("#define UPDFCACHE_ALL ( ( DWORD  )~UPDFCACHE_ONLYIFBLANK )")]
        public const uint UPDFCACHE_ALL = ((uint)(~(0x80000000)));

        [NativeTypeName("#define UPDFCACHE_ALLBUTNODATACACHE ( ( UPDFCACHE_ALL & ( DWORD  )~UPDFCACHE_NODATACACHE )  )")]
        public const uint UPDFCACHE_ALLBUTNODATACACHE = unchecked((((uint)(~(0x80000000))) & (uint)(~(0x1))));

        [NativeTypeName("#define MK_ALT ( 0x20 )")]
        public const int MK_ALT = (0x20);

        [NativeTypeName("#define DROPEFFECT_NONE ( 0 )")]
        public const int DROPEFFECT_NONE = (0);

        [NativeTypeName("#define DROPEFFECT_COPY ( 1 )")]
        public const int DROPEFFECT_COPY = (1);

        [NativeTypeName("#define DROPEFFECT_MOVE ( 2 )")]
        public const int DROPEFFECT_MOVE = (2);

        [NativeTypeName("#define DROPEFFECT_LINK ( 4 )")]
        public const int DROPEFFECT_LINK = (4);

        [NativeTypeName("#define DROPEFFECT_SCROLL ( 0x80000000 )")]
        public const uint DROPEFFECT_SCROLL = (0x80000000);

        [NativeTypeName("#define DD_DEFSCROLLINSET ( 11 )")]
        public const int DD_DEFSCROLLINSET = (11);

        [NativeTypeName("#define DD_DEFSCROLLDELAY ( 50 )")]
        public const int DD_DEFSCROLLDELAY = (50);

        [NativeTypeName("#define DD_DEFSCROLLINTERVAL ( 50 )")]
        public const int DD_DEFSCROLLINTERVAL = (50);

        [NativeTypeName("#define DD_DEFDRAGDELAY ( 200 )")]
        public const int DD_DEFDRAGDELAY = (200);

        [NativeTypeName("#define DD_DEFDRAGMINDIST ( 2 )")]
        public const int DD_DEFDRAGMINDIST = (2);

        [NativeTypeName("#define CFSTR_ENTERPRISE_ID (TEXT(\"EnterpriseDataProtectionId\"))")]
        public const string CFSTR_ENTERPRISE_ID = ("EnterpriseDataProtectionId");

        public static ref readonly Guid IID_IOleAdviseHolder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x11, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IOleCache
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1E, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IOleCache2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x28, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IOleCacheControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x29, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IParseDisplayName
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1A, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IOleContainer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1B, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IOleClientSite
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x18, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IOleObject
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x12, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IOleWindow
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x14, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IOleLink
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1D, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IOleItemContainer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1C, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IOleInPlaceUIWindow
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x15, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IOleInPlaceActiveObject
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x17, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IOleInPlaceFrame
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x16, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IOleInPlaceObject
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x13, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IOleInPlaceSite
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x19, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IContinue
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2A, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IViewObject
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0D, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IViewObject2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x27, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDropSource
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x21, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDropTarget
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x22, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDropSourceNotify
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2B, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IEnterpriseDropTarget
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x78, 0x38, 0x0E, 0x39,
                    0x55, 0xFD,
                    0x18, 0x4E,
                    0x81,
                    0x9D,
                    0x46,
                    0x82,
                    0x08,
                    0x1C,
                    0x0C,
                    0xFD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IEnumOLEVERB
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x04, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0xC0,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
