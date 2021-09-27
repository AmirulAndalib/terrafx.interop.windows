// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_MFReadWriteClassFactory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0F, 0xED, 0xE2, 0x48,
                    0xC2, 0x98,
                    0x37, 0x4A,
                    0xBE,
                    0xD5,
                    0x16,
                    0x63,
                    0x12,
                    0xDD,
                    0xD8,
                    0x3F
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_MFSourceReader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3C, 0x13, 0x77, 0x17,
                    0x81, 0x08,
                    0x1B, 0x41,
                    0xA5,
                    0x77,
                    0xAD,
                    0x54,
                    0x5F,
                    0x07,
                    0x14,
                    0xC4
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mfreadwrite", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSourceReaderFromURL([NativeTypeName("LPCWSTR")] ushort* pwszURL, IMFAttributes* pAttributes, IMFSourceReader** ppSourceReader);

        [DllImport("mfreadwrite", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSourceReaderFromByteStream(IMFByteStream* pByteStream, IMFAttributes* pAttributes, IMFSourceReader** ppSourceReader);

        [DllImport("mfreadwrite", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSourceReaderFromMediaSource(IMFMediaSource* pMediaSource, IMFAttributes* pAttributes, IMFSourceReader** ppSourceReader);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SOURCE_READER_ASYNC_CALLBACK
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAC, 0xBE, 0x3D, 0x1E,
                    0x43, 0xBB,
                    0x35, 0x4C,
                    0xB5,
                    0x07,
                    0xCD,
                    0x64,
                    0x44,
                    0x64,
                    0xC9,
                    0x65
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SOURCE_READER_D3D_MANAGER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA2, 0x2D, 0x82, 0xEC,
                    0xE9, 0xE1,
                    0x29, 0x4B,
                    0xA0,
                    0xD8,
                    0x56,
                    0x3C,
                    0x71,
                    0x9F,
                    0x52,
                    0x69
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SOURCE_READER_DISABLE_DXVA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFD, 0x6C, 0x45, 0xAA,
                    0x43, 0x39,
                    0x1E, 0x4A,
                    0xA7,
                    0x7D,
                    0x18,
                    0x38,
                    0xC0,
                    0xEA,
                    0x2E,
                    0x35
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SOURCE_READER_MEDIASOURCE_CONFIG
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEB, 0xAB, 0x85, 0x90,
                    0x54, 0x03,
                    0xF9, 0x48,
                    0xAB,
                    0xB5,
                    0x20,
                    0x0D,
                    0xF8,
                    0x38,
                    0xC6,
                    0x8E
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SOURCE_READER_MEDIASOURCE_CHARACTERISTICS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC8, 0xF5, 0x23, 0x6D,
                    0xD7, 0xC5,
                    0x9B, 0x4A,
                    0x99,
                    0x71,
                    0x5D,
                    0x11,
                    0xF8,
                    0xBC,
                    0xA8,
                    0x80
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SOURCE_READER_ENABLE_VIDEO_PROCESSING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3D, 0x4F, 0x39, 0xFB,
                    0xF1, 0xCC,
                    0xEE, 0x42,
                    0xBB,
                    0xB3,
                    0xF9,
                    0xB8,
                    0x45,
                    0xD5,
                    0x68,
                    0x1D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SOURCE_READER_ENABLE_ADVANCED_VIDEO_PROCESSING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2C, 0xDA, 0x81, 0x0F,
                    0x37, 0xB5,
                    0x72, 0x46,
                    0xA8,
                    0xB2,
                    0xA6,
                    0x81,
                    0xB1,
                    0x73,
                    0x07,
                    0xA3
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SOURCE_READER_DISABLE_CAMERA_PLUGINS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDD, 0x65, 0x33, 0x9D,
                    0x8F, 0x05,
                    0xFB, 0x4C,
                    0x9F,
                    0x97,
                    0xB3,
                    0x14,
                    0xCC,
                    0x99,
                    0xC8,
                    0xAD
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SOURCE_READER_DISCONNECT_MEDIASOURCE_ON_SHUTDOWN
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x65, 0x71, 0xB6, 0x56,
                    0x9E, 0x21,
                    0x6D, 0x45,
                    0xA2,
                    0x2E,
                    0x2D,
                    0x30,
                    0x04,
                    0xC7,
                    0xFE,
                    0x56
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SOURCE_READER_ENABLE_TRANSCODE_ONLY_TRANSFORMS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x08, 0xF0, 0xD4, 0xDF,
                    0xFD, 0xB5,
                    0x78, 0x4E,
                    0xAE,
                    0x44,
                    0x62,
                    0xA1,
                    0xE6,
                    0x7B,
                    0xBE,
                    0x27
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SOURCE_READER_D3D11_BIND_FLAGS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7B, 0x19, 0xF3, 0x33,
                    0x3A, 0xF7,
                    0x14, 0x4E,
                    0x8D,
                    0x85,
                    0x0E,
                    0x4C,
                    0x43,
                    0x68,
                    0x78,
                    0x8D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_MFSinkWriter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x17, 0xFB, 0xBB, 0xA3,
                    0x73, 0x82,
                    0x52, 0x4E,
                    0x9E,
                    0x0E,
                    0x97,
                    0x39,
                    0xDC,
                    0x88,
                    0x79,
                    0x90
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mfreadwrite", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSinkWriterFromURL([NativeTypeName("LPCWSTR")] ushort* pwszOutputURL, IMFByteStream* pByteStream, IMFAttributes* pAttributes, IMFSinkWriter** ppSinkWriter);

        [DllImport("mfreadwrite", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSinkWriterFromMediaSink(IMFMediaSink* pMediaSink, IMFAttributes* pAttributes, IMFSinkWriter** ppSinkWriter);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SINK_WRITER_ASYNC_CALLBACK
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3E, 0x18, 0xCB, 0x48,
                    0x0B, 0x7B,
                    0xF4, 0x46,
                    0x82,
                    0x2E,
                    0x5E,
                    0x1D,
                    0x2D,
                    0xDA,
                    0x43,
                    0x54
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SINK_WRITER_DISABLE_THROTTLING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD8, 0x45, 0xB8, 0x08,
                    0x74, 0x2B,
                    0xFE, 0x4A,
                    0x9D,
                    0x53,
                    0xBE,
                    0x16,
                    0xD2,
                    0xD5,
                    0xAE,
                    0x4F
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SINK_WRITER_D3D_MANAGER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA2, 0x2D, 0x82, 0xEC,
                    0xE9, 0xE1,
                    0x29, 0x4B,
                    0xA0,
                    0xD8,
                    0x56,
                    0x3C,
                    0x71,
                    0x9F,
                    0x52,
                    0x69
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SINK_WRITER_ENCODER_CONFIG
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x04, 0xCD, 0x91, 0xAD,
                    0xCC, 0xA7,
                    0xC7, 0x4A,
                    0x99,
                    0xB6,
                    0xA5,
                    0x7B,
                    0x9A,
                    0x4A,
                    0x7C,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_READWRITE_DISABLE_CONVERTERS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x65, 0xB0, 0xD5, 0x98,
                    0x74, 0x13,
                    0x47, 0x48,
                    0x8D,
                    0x5D,
                    0x31,
                    0x52,
                    0x0F,
                    0xEE,
                    0x71,
                    0x56
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_READWRITE_ENABLE_HARDWARE_TRANSFORMS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1C, 0xA9, 0x34, 0xA6,
                    0x2B, 0x82,
                    0xB9, 0x41,
                    0xA4,
                    0x94,
                    0x4D,
                    0xE4,
                    0x64,
                    0x36,
                    0x12,
                    0xB0
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_READWRITE_MMCSS_CLASS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x43, 0x38, 0x39,
                    0xEB, 0xD0,
                    0xB1, 0x40,
                    0x87,
                    0xA0,
                    0x33,
                    0x18,
                    0x87,
                    0x1B,
                    0x5A,
                    0x53
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_READWRITE_MMCSS_PRIORITY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCE, 0x19, 0xAD, 0x43,
                    0x3F, 0xF3,
                    0xA9, 0x4B,
                    0xA5,
                    0x80,
                    0xE4,
                    0xCD,
                    0x12,
                    0xF2,
                    0xD1,
                    0x44
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_READWRITE_MMCSS_CLASS_AUDIO
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDA, 0x47, 0x08, 0x43,
                    0x90, 0x08,
                    0x0E, 0x4B,
                    0x93,
                    0x8C,
                    0x05,
                    0x43,
                    0x32,
                    0xC5,
                    0x47,
                    0xE1
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_READWRITE_MMCSS_PRIORITY_AUDIO
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x85, 0xB8, 0x3D, 0x27,
                    0xE2, 0x2D,
                    0xB2, 0x4D,
                    0xA6,
                    0xA7,
                    0xFD,
                    0xB6,
                    0x6F,
                    0xB4,
                    0x0B,
                    0x61
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_READWRITE_D3D_OPTIONAL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD9, 0x79, 0x64, 0x21,
                    0x71, 0x30,
                    0xCA, 0x42,
                    0xBB,
                    0x6C,
                    0x4C,
                    0x22,
                    0x10,
                    0x2E,
                    0x1D,
                    0x18
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_MEDIASINK_AUTOFINALIZE_SUPPORTED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBE, 0x31, 0xC1, 0x48,
                    0x5A, 0x13,
                    0xCB, 0x41,
                    0x82,
                    0x90,
                    0x03,
                    0x65,
                    0x25,
                    0x09,
                    0xC9,
                    0x99
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_MEDIASINK_ENABLE_AUTOFINALIZE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x65, 0x42, 0x01, 0x34,
                    0x7E, 0xCB,
                    0xDE, 0x4C,
                    0xAC,
                    0x7C,
                    0xEF,
                    0xFD,
                    0x3B,
                    0x3C,
                    0x25,
                    0x30
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_READWRITE_ENABLE_AUTOFINALIZE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x29, 0xA1, 0x7C, 0xDD,
                    0xD1, 0x8C,
                    0xC5, 0x4D,
                    0x9D,
                    0xDE,
                    0xCE,
                    0x16,
                    0x86,
                    0x75,
                    0xDE,
                    0x61
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFReadWriteClassFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x12, 0x2E, 0xFE, 0xE7,
                    0x1C, 0x66,
                    0xDA, 0x40,
                    0x92,
                    0xF9,
                    0x4F,
                    0x00,
                    0x2A,
                    0xB6,
                    0x76,
                    0x27
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSourceReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF2, 0x66, 0xAE, 0x70,
                    0x09, 0xC8,
                    0x4F, 0x4E,
                    0x89,
                    0x15,
                    0xBD,
                    0xCB,
                    0x40,
                    0x6B,
                    0x79,
                    0x93
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSourceReaderEx
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF0, 0x1C, 0x98, 0x7B,
                    0x0E, 0x56,
                    0x16, 0x41,
                    0x98,
                    0x75,
                    0xB0,
                    0x99,
                    0x89,
                    0x5F,
                    0x23,
                    0xD7
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSourceReaderCallback
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x99, 0x8D, 0xEC, 0xDE,
                    0x1D, 0xFA,
                    0x82, 0x4D,
                    0x84,
                    0xC2,
                    0x2C,
                    0x89,
                    0x69,
                    0x94,
                    0x48,
                    0x67
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSourceReaderCallback2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE6, 0x9F, 0x83, 0xCF,
                    0x2A, 0x8C,
                    0xD2, 0x4D,
                    0xB6,
                    0xEA,
                    0xC2,
                    0x2D,
                    0x69,
                    0x61,
                    0xAF,
                    0x05
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSinkWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCD, 0xF1, 0x37, 0x31,
                    0x5E, 0xFE,
                    0x05, 0x48,
                    0xA5,
                    0xD8,
                    0xFB,
                    0x47,
                    0x74,
                    0x48,
                    0xCB,
                    0x3D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSinkWriterEx
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAB, 0x72, 0x8D, 0x58,
                    0xC1, 0x5B,
                    0x6A, 0x49,
                    0x87,
                    0x14,
                    0xB7,
                    0x06,
                    0x17,
                    0x14,
                    0x1B,
                    0x25
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSinkWriterEncoderConfig
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9E, 0x77, 0xC3, 0x17,
                    0xDE, 0x3C,
                    0xDE, 0x4E,
                    0x8C,
                    0x60,
                    0x38,
                    0x99,
                    0xF5,
                    0xF5,
                    0x3A,
                    0xD6
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSinkWriterCallback
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDE, 0x76, 0x6F, 0x66,
                    0xD2, 0x33,
                    0xB9, 0x41,
                    0xA4,
                    0x58,
                    0x29,
                    0xED,
                    0x0A,
                    0x97,
                    0x2C,
                    0x58
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSinkWriterCallback2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x58, 0xBD, 0x56, 0x24,
                    0x67, 0xC0,
                    0x13, 0x45,
                    0x84,
                    0xFE,
                    0x8D,
                    0x0C,
                    0x88,
                    0xFF,
                    0xDC,
                    0x61
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
