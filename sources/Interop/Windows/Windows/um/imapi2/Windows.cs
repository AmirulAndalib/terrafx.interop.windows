// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("#define IMAPI_SECTOR_SIZE ( 2048 )")]
        public const int IMAPI_SECTOR_SIZE = (2048);

        [NativeTypeName("#define IMAPI2_DEFAULT_COMMAND_TIMEOUT 10")]
        public const int IMAPI2_DEFAULT_COMMAND_TIMEOUT = 10;

        [NativeTypeName("#define IMAPI_SECTORS_PER_SECOND_AT_1X_CD 75")]
        public const int IMAPI_SECTORS_PER_SECOND_AT_1X_CD = 75;

        [NativeTypeName("#define IMAPI_SECTORS_PER_SECOND_AT_1X_DVD 680")]
        public const int IMAPI_SECTORS_PER_SECOND_AT_1X_DVD = 680;

        [NativeTypeName("#define IMAPI_SECTORS_PER_SECOND_AT_1X_BD 2195")]
        public const int IMAPI_SECTORS_PER_SECOND_AT_1X_BD = 2195;

        [NativeTypeName("#define IMAPI_SECTORS_PER_SECOND_AT_1X_HD_DVD 4568")]
        public const int IMAPI_SECTORS_PER_SECOND_AT_1X_HD_DVD = 4568;

        [NativeTypeName("#define IMAPILib2_MajorVersion 1")]
        public const int IMAPILib2_MajorVersion = 1;

        [NativeTypeName("#define IMAPILib2_MinorVersion 0")]
        public const int IMAPILib2_MinorVersion = 0;

        public static ref readonly Guid IID_IDiscMaster2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_DDiscMaster2Events
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x31, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscRecorder2Ex
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x32, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscRecorder2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x33, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWriteEngine2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x35, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWriteEngine2EventArgs
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x36, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_DWriteEngine2Events
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x37, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscFormat2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x52, 0x41, 0x35, 0x27,
                    0x64, 0x8F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscFormat2Erase
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x56, 0x41, 0x35, 0x27,
                    0x64, 0x8F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_DDiscFormat2EraseEvents
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3A, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscFormat2Data
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x53, 0x41, 0x35, 0x27,
                    0x64, 0x9F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_DDiscFormat2DataEvents
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3C, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscFormat2DataEventArgs
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3D, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscFormat2TrackAtOnce
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x54, 0x41, 0x35, 0x27,
                    0x64, 0x8F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_DDiscFormat2TrackAtOnceEvents
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3F, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscFormat2TrackAtOnceEventArgs
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscFormat2RawCD
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x55, 0x41, 0x35, 0x27,
                    0x64, 0x8F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_DDiscFormat2RawCDEvents
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x42, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscFormat2RawCDEventArgs
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x43, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBurnVerification
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x34, 0xD8, 0xFF, 0xD2,
                    0x8B, 0x95,
                    0x6D, 0x42,
                    0x84,
                    0x70,
                    0x2A,
                    0x13,
                    0x87,
                    0x9C,
                    0x6A,
                    0x91
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWriteSpeedDescriptor
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x44, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMultisession
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMultisessionSequential
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x51, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMultisessionSequential2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x22, 0xCA, 0x07, 0xB5,
                    0x04, 0x22,
                    0xDD, 0x11,
                    0x96,
                    0x6A,
                    0x00,
                    0x1A,
                    0xA0,
                    0x1B,
                    0xBC,
                    0x58
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMultisessionRandomWrite
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x23, 0xCA, 0x07, 0xB5,
                    0x04, 0x22,
                    0xDD, 0x11,
                    0x96,
                    0x6A,
                    0x00,
                    0x1A,
                    0xA0,
                    0x1B,
                    0xBC,
                    0x58
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IStreamPseudoRandomBased
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x45, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IStreamConcatenate
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x46, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IStreamInterleave
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x47, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IRawCDImageCreator
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x35, 0x98, 0x25,
                    0x65, 0x9D,
                    0xCE, 0x49,
                    0xB3,
                    0x35,
                    0x40,
                    0x63,
                    0x0D,
                    0x90,
                    0x12,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IRawCDImageTrackInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x51, 0x35, 0x98, 0x25,
                    0x65, 0x9D,
                    0xCE, 0x49,
                    0xB3,
                    0x35,
                    0x40,
                    0x63,
                    0x0D,
                    0x90,
                    0x12,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBlockRange
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x25, 0xCA, 0x07, 0xB5,
                    0x04, 0x22,
                    0xDD, 0x11,
                    0x96,
                    0x6A,
                    0x00,
                    0x1A,
                    0xA0,
                    0x1B,
                    0xBC,
                    0x58
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBlockRangeList
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x26, 0xCA, 0x07, 0xB5,
                    0x04, 0x22,
                    0xDD, 0x11,
                    0x96,
                    0x6A,
                    0x00,
                    0x1A,
                    0xA0,
                    0x1B,
                    0xBC,
                    0x58
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_MsftDiscMaster2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2E, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftDiscRecorder2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2D, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftWriteEngine2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2C, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftDiscFormat2Erase
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2B, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftDiscFormat2Data
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2A, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftDiscFormat2TrackAtOnce
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x29, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftDiscFormat2RawCD
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x28, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftStreamZero
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x27, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftStreamPrng001
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x26, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftStreamConcatenate
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x25, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftStreamInterleave
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftWriteSpeedDescriptor
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x23, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftMultisessionSequential
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x22, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftMultisessionRandomWrite
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xCA, 0x07, 0xB5,
                    0x04, 0x22,
                    0xDD, 0x11,
                    0x96,
                    0x6A,
                    0x00,
                    0x1A,
                    0xA0,
                    0x1B,
                    0xBC,
                    0x58
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftRawCDImageCreator
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0x35, 0x98, 0x25,
                    0x65, 0x9D,
                    0xCE, 0x49,
                    0xB3,
                    0x35,
                    0x40,
                    0x63,
                    0x0D,
                    0x90,
                    0x12,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
