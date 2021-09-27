// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.SPEVENTENUM;
using static TerraFX.Interop.SPPHRASERNG;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const float")]
        public const float Speech_Default_Weight = (1);

        [NativeTypeName("const LONG")]
        public const int Speech_Max_Word_Length = (128);

        [NativeTypeName("const LONG")]
        public const int Speech_Max_Pron_Length = (384);

        [NativeTypeName("const LONG")]
        public const int Speech_StreamPos_Asap = (0);

        [NativeTypeName("const LONG")]
        public const int Speech_StreamPos_RealTime = (-1);

        [NativeTypeName("const LONG")]
        public const int SpeechAllElements = (int)(SPPR_ALL_ELEMENTS);

        [NativeTypeName("#define _SAPI_VER 0x054")]
        public const int _SAPI_VER = 0x054;

        [NativeTypeName("#define SPDUI_EngineProperties L\"EngineProperties\"")]
        public const string SPDUI_EngineProperties = "EngineProperties";

        [NativeTypeName("#define SPDUI_AddRemoveWord L\"AddRemoveWord\"")]
        public const string SPDUI_AddRemoveWord = "AddRemoveWord";

        [NativeTypeName("#define SPDUI_UserTraining L\"UserTraining\"")]
        public const string SPDUI_UserTraining = "UserTraining";

        [NativeTypeName("#define SPDUI_MicTraining L\"MicTraining\"")]
        public const string SPDUI_MicTraining = "MicTraining";

        [NativeTypeName("#define SPDUI_RecoProfileProperties L\"RecoProfileProperties\"")]
        public const string SPDUI_RecoProfileProperties = "RecoProfileProperties";

        [NativeTypeName("#define SPDUI_AudioProperties L\"AudioProperties\"")]
        public const string SPDUI_AudioProperties = "AudioProperties";

        [NativeTypeName("#define SPDUI_AudioVolume L\"AudioVolume\"")]
        public const string SPDUI_AudioVolume = "AudioVolume";

        [NativeTypeName("#define SPDUI_UserEnrollment L\"UserEnrollment\"")]
        public const string SPDUI_UserEnrollment = "UserEnrollment";

        [NativeTypeName("#define SPDUI_ShareData L\"ShareData\"")]
        public const string SPDUI_ShareData = "ShareData";

        [NativeTypeName("#define SPDUI_Tutorial L\"Tutorial\"")]
        public const string SPDUI_Tutorial = "Tutorial";

        [NativeTypeName("#define SPREG_USER_ROOT L\"HKEY_CURRENT_USER\\\\SOFTWARE\\\\Microsoft\\\\Speech\"")]
        public const string SPREG_USER_ROOT = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech";

        [NativeTypeName("#define SPREG_LOCAL_MACHINE_ROOT L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\"")]
        public const string SPREG_LOCAL_MACHINE_ROOT = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech";

        [NativeTypeName("#define SPCAT_AUDIOOUT L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\AudioOutput\"")]
        public const string SPCAT_AUDIOOUT = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioOutput";

        [NativeTypeName("#define SPCAT_AUDIOIN L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\AudioInput\"")]
        public const string SPCAT_AUDIOIN = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioInput";

        [NativeTypeName("#define SPCAT_VOICES L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\Voices\"")]
        public const string SPCAT_VOICES = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\Voices";

        [NativeTypeName("#define SPCAT_RECOGNIZERS L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\Recognizers\"")]
        public const string SPCAT_RECOGNIZERS = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\Recognizers";

        [NativeTypeName("#define SPCAT_APPLEXICONS L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\AppLexicons\"")]
        public const string SPCAT_APPLEXICONS = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AppLexicons";

        [NativeTypeName("#define SPCAT_PHONECONVERTERS L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\PhoneConverters\"")]
        public const string SPCAT_PHONECONVERTERS = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\PhoneConverters";

        [NativeTypeName("#define SPCAT_TEXTNORMALIZERS L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\TextNormalizers\"")]
        public const string SPCAT_TEXTNORMALIZERS = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\TextNormalizers";

        [NativeTypeName("#define SPCAT_RECOPROFILES L\"HKEY_CURRENT_USER\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\RecoProfiles\"")]
        public const string SPCAT_RECOPROFILES = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech\\RecoProfiles";

        [NativeTypeName("#define SPMMSYS_AUDIO_IN_TOKEN_ID L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\AudioInput\\\\TokenEnums\\\\MMAudioIn\\\\\"")]
        public const string SPMMSYS_AUDIO_IN_TOKEN_ID = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioInput\\TokenEnums\\MMAudioIn\\";

        [NativeTypeName("#define SPMMSYS_AUDIO_OUT_TOKEN_ID L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\AudioOutput\\\\TokenEnums\\\\MMAudioOut\\\\\"")]
        public const string SPMMSYS_AUDIO_OUT_TOKEN_ID = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioOutput\\TokenEnums\\MMAudioOut\\";

        [NativeTypeName("#define SPCURRENT_USER_LEXICON_TOKEN_ID L\"HKEY_CURRENT_USER\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\CurrentUserLexicon\"")]
        public const string SPCURRENT_USER_LEXICON_TOKEN_ID = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech\\CurrentUserLexicon";

        [NativeTypeName("#define SPCURRENT_USER_SHORTCUT_TOKEN_ID L\"HKEY_CURRENT_USER\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\CurrentUserShortcut\"")]
        public const string SPCURRENT_USER_SHORTCUT_TOKEN_ID = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech\\CurrentUserShortcut";

        [NativeTypeName("#define SPTOKENVALUE_CLSID L\"CLSID\"")]
        public const string SPTOKENVALUE_CLSID = "CLSID";

        [NativeTypeName("#define SPTOKENKEY_FILES L\"Files\"")]
        public const string SPTOKENKEY_FILES = "Files";

        [NativeTypeName("#define SPTOKENKEY_UI L\"UI\"")]
        public const string SPTOKENKEY_UI = "UI";

        [NativeTypeName("#define SPTOKENKEY_ATTRIBUTES L\"Attributes\"")]
        public const string SPTOKENKEY_ATTRIBUTES = "Attributes";

        [NativeTypeName("#define SPTOKENKEY_RETAINEDAUDIO L\"SecondsPerRetainedAudioEvent\"")]
        public const string SPTOKENKEY_RETAINEDAUDIO = "SecondsPerRetainedAudioEvent";

        [NativeTypeName("#define SPTOKENKEY_AUDIO_LATENCY_WARNING L\"LatencyWarningThreshold\"")]
        public const string SPTOKENKEY_AUDIO_LATENCY_WARNING = "LatencyWarningThreshold";

        [NativeTypeName("#define SPTOKENKEY_AUDIO_LATENCY_TRUNCATE L\"LatencyTruncateThreshold\"")]
        public const string SPTOKENKEY_AUDIO_LATENCY_TRUNCATE = "LatencyTruncateThreshold";

        [NativeTypeName("#define SPTOKENKEY_AUDIO_LATENCY_UPDATE_INTERVAL L\"LatencyUpdateInterval\"")]
        public const string SPTOKENKEY_AUDIO_LATENCY_UPDATE_INTERVAL = "LatencyUpdateInterval";

        [NativeTypeName("#define SPVOICECATEGORY_TTSRATE L\"DefaultTTSRate\"")]
        public const string SPVOICECATEGORY_TTSRATE = "DefaultTTSRate";

        [NativeTypeName("#define SPPROP_RESOURCE_USAGE L\"ResourceUsage\"")]
        public const string SPPROP_RESOURCE_USAGE = "ResourceUsage";

        [NativeTypeName("#define SPPROP_HIGH_CONFIDENCE_THRESHOLD L\"HighConfidenceThreshold\"")]
        public const string SPPROP_HIGH_CONFIDENCE_THRESHOLD = "HighConfidenceThreshold";

        [NativeTypeName("#define SPPROP_NORMAL_CONFIDENCE_THRESHOLD L\"NormalConfidenceThreshold\"")]
        public const string SPPROP_NORMAL_CONFIDENCE_THRESHOLD = "NormalConfidenceThreshold";

        [NativeTypeName("#define SPPROP_LOW_CONFIDENCE_THRESHOLD L\"LowConfidenceThreshold\"")]
        public const string SPPROP_LOW_CONFIDENCE_THRESHOLD = "LowConfidenceThreshold";

        [NativeTypeName("#define SPPROP_RESPONSE_SPEED L\"ResponseSpeed\"")]
        public const string SPPROP_RESPONSE_SPEED = "ResponseSpeed";

        [NativeTypeName("#define SPPROP_COMPLEX_RESPONSE_SPEED L\"ComplexResponseSpeed\"")]
        public const string SPPROP_COMPLEX_RESPONSE_SPEED = "ComplexResponseSpeed";

        [NativeTypeName("#define SPPROP_ADAPTATION_ON L\"AdaptationOn\"")]
        public const string SPPROP_ADAPTATION_ON = "AdaptationOn";

        [NativeTypeName("#define SPPROP_PERSISTED_BACKGROUND_ADAPTATION L\"PersistedBackgroundAdaptation\"")]
        public const string SPPROP_PERSISTED_BACKGROUND_ADAPTATION = "PersistedBackgroundAdaptation";

        [NativeTypeName("#define SPPROP_PERSISTED_LANGUAGE_MODEL_ADAPTATION L\"PersistedLanguageModelAdaptation\"")]
        public const string SPPROP_PERSISTED_LANGUAGE_MODEL_ADAPTATION = "PersistedLanguageModelAdaptation";

        [NativeTypeName("#define SPPROP_UX_IS_LISTENING L\"UXIsListening\"")]
        public const string SPPROP_UX_IS_LISTENING = "UXIsListening";

        [NativeTypeName("#define SPTOPIC_SPELLING L\"Spelling\"")]
        public const string SPTOPIC_SPELLING = "Spelling";

        [NativeTypeName("#define SPWILDCARD L\"...\"")]
        public const string SPWILDCARD = "...";

        [NativeTypeName("#define SPDICTATION L\"*\"")]
        public const string SPDICTATION = "*";

        [NativeTypeName("#define SPINFDICTATION L\"*+\"")]
        public const string SPINFDICTATION = "*+";

        [NativeTypeName("#define SPREG_SAFE_USER_TOKENS L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\UserTokens\"")]
        public const string SPREG_SAFE_USER_TOKENS = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\UserTokens";

        [NativeTypeName("#define SP_LOW_CONFIDENCE ( -1 )")]
        public const int SP_LOW_CONFIDENCE = (-1);

        [NativeTypeName("#define SP_NORMAL_CONFIDENCE ( 0 )")]
        public const int SP_NORMAL_CONFIDENCE = (0);

        [NativeTypeName("#define SP_HIGH_CONFIDENCE ( +1 )")]
        public const int SP_HIGH_CONFIDENCE = (+1);

        [NativeTypeName("#define DEFAULT_WEIGHT ( 1 )")]
        public const int DEFAULT_WEIGHT = (1);

        [NativeTypeName("#define SP_MAX_WORD_LENGTH ( 128 )")]
        public const int SP_MAX_WORD_LENGTH = (128);

        [NativeTypeName("#define SP_MAX_PRON_LENGTH ( 384 )")]
        public const int SP_MAX_PRON_LENGTH = (384);

        [NativeTypeName("#define SP_EMULATE_RESULT ( 0x40000000 )")]
        public const int SP_EMULATE_RESULT = (0x40000000);

        [NativeTypeName("#define SPFEI_FLAGCHECK ( (1ui64 << SPEI_RESERVED1) | (1ui64 << SPEI_RESERVED2) )")]
        public const ulong SPFEI_FLAGCHECK = ((1UL << (int)(SPEI_RESERVED1)) | (1UL << (int)(SPEI_RESERVED2)));

        [NativeTypeName("#define SPFEI_ALL_TTS_EVENTS (0x000000000000FFFEui64 | SPFEI_FLAGCHECK)")]
        public const ulong SPFEI_ALL_TTS_EVENTS = (0x000000000000FFFEUL | ((1UL << (int)(SPEI_RESERVED1)) | (1UL << (int)(SPEI_RESERVED2))));

        [NativeTypeName("#define SPFEI_ALL_SR_EVENTS (0x003FFFFC00000000ui64 | SPFEI_FLAGCHECK)")]
        public const ulong SPFEI_ALL_SR_EVENTS = (0x003FFFFC00000000UL | ((1UL << (int)(SPEI_RESERVED1)) | (1UL << (int)(SPEI_RESERVED2))));

        [NativeTypeName("#define SPFEI_ALL_EVENTS 0xEFFFFFFFFFFFFFFFui64")]
        public const ulong SPFEI_ALL_EVENTS = 0xEFFFFFFFFFFFFFFFUL;

        [NativeTypeName("#define SP_SPPHRASESIZE_500 sizeof(SPPHRASE_50)")]
        public static uint SP_SPPHRASESIZE_500 => unchecked((uint)((uint)(sizeof(SPPHRASE_50))));

        [NativeTypeName("#define SP_SPPHRASESIZE_530 sizeof(SPPHRASE_53)")]
        public static uint SP_SPPHRASESIZE_530 => unchecked((uint)((uint)(sizeof(SPPHRASE_53))));

        [NativeTypeName("#define SP_GETWHOLEPHRASE SPPR_ALL_ELEMENTS")]
        public const SPPHRASERNG SP_GETWHOLEPHRASE = SPPR_ALL_ELEMENTS;

        [NativeTypeName("#define SPRR_ALL_ELEMENTS SPPR_ALL_ELEMENTS")]
        public const SPPHRASERNG SPRR_ALL_ELEMENTS = SPPR_ALL_ELEMENTS;

        [NativeTypeName("#define SP_STREAMPOS_ASAP ( 0 )")]
        public const int SP_STREAMPOS_ASAP = (0);

        [NativeTypeName("#define SP_STREAMPOS_REALTIME ( -1 )")]
        public const int SP_STREAMPOS_REALTIME = (-1);

        [NativeTypeName("#define SPRULETRANS_TEXTBUFFER (SPSTATEHANDLE)(-1)")]
        public static IntPtr SPRULETRANS_TEXTBUFFER => (nint)(-1);

        [NativeTypeName("#define SPRULETRANS_WILDCARD (SPSTATEHANDLE)(-2)")]
        public static IntPtr SPRULETRANS_WILDCARD => (nint)(-2);

        [NativeTypeName("#define SPRULETRANS_DICTATION (SPSTATEHANDLE)(-3)")]
        public static IntPtr SPRULETRANS_DICTATION => (nint)(-3);

        [NativeTypeName("#define SPRP_NORMAL 0")]
        public const int SPRP_NORMAL = 0;

        [NativeTypeName("#define SP_MAX_LANGIDS ( 20 )")]
        public const int SP_MAX_LANGIDS = (20);

        public static ref readonly Guid IID_ISpNotifySource
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEF, 0x4A, 0xFF, 0x5E,
                    0x87, 0x84,
                    0xD2, 0x11,
                    0x96,
                    0x1C,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xE6,
                    0x28
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpNotifySink
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDC, 0x84, 0x96, 0x25,
                    0xC3, 0x37,
                    0xD2, 0x11,
                    0x96,
                    0x03,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xE6,
                    0x28
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpNotifyTranslator
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x14, 0x66, 0xA1, 0xAC,
                    0x3D, 0x5D,
                    0xD2, 0x11,
                    0x96,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xE6,
                    0x28
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpDataKey
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0x65, 0x05, 0x14,
                    0x6C, 0xE1,
                    0xD2, 0x11,
                    0xBB,
                    0x90,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xE6,
                    0xC0
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpRegDataKey
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2B, 0x6E, 0xA6, 0x92,
                    0x30, 0xC8,
                    0x49, 0x41,
                    0x83,
                    0xDF,
                    0x6F,
                    0xC2,
                    0xBA,
                    0x1E,
                    0x7A,
                    0x5B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpObjectTokenCategory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x45, 0x38, 0x3D, 0x2D,
                    0xAF, 0x39,
                    0x50, 0x48,
                    0xBB,
                    0xF9,
                    0x40,
                    0xB4,
                    0x97,
                    0x80,
                    0x01,
                    0x1D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpObjectToken
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x89, 0x65, 0x05, 0x14,
                    0x6C, 0xE1,
                    0xD2, 0x11,
                    0xBB,
                    0x90,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xE6,
                    0xC0
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpObjectTokenInit
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCF, 0xB0, 0xAA, 0xB8,
                    0x6F, 0x34,
                    0xD8, 0x49,
                    0x94,
                    0x99,
                    0xC8,
                    0xB0,
                    0x3F,
                    0x16,
                    0x1D,
                    0x51
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IEnumSpObjectTokens
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9E, 0x4F, 0xB6, 0x06,
                    0xDA, 0x7F,
                    0xD2, 0x11,
                    0xB4,
                    0xF2,
                    0x00,
                    0xC0,
                    0x4F,
                    0x79,
                    0x73,
                    0x96
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpObjectWithToken
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0x9F, 0x55, 0x5B,
                    0x52, 0xE9,
                    0xD2, 0x11,
                    0xBB,
                    0x91,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xE6,
                    0xC0
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpResourceManager
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x18, 0x4E, 0x38, 0x93,
                    0x14, 0x50,
                    0xD5, 0x43,
                    0xAD,
                    0xBB,
                    0xA7,
                    0x8E,
                    0x05,
                    0x59,
                    0x26,
                    0xBD
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpEventSource
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCE, 0x9C, 0x7A, 0xBE,
                    0x9E, 0x5F,
                    0xD2, 0x11,
                    0x96,
                    0x0F,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xE6,
                    0x28
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpEventSource2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x35, 0xA4, 0x73, 0x23,
                    0x4B, 0x6A,
                    0x9E, 0x42,
                    0xA6,
                    0xAC,
                    0xD4,
                    0x23,
                    0x1A,
                    0x61,
                    0x97,
                    0x5B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpEventSink
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC9, 0x9C, 0x7A, 0xBE,
                    0x9E, 0x5F,
                    0xD2, 0x11,
                    0x96,
                    0x0F,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xE6,
                    0x28
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpStreamFormat
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBE, 0x30, 0xD5, 0xBE,
                    0x06, 0x26,
                    0x4D, 0x4F,
                    0xA1,
                    0xC0,
                    0x54,
                    0xC5,
                    0xCD,
                    0xA5,
                    0x56,
                    0x6F
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpStream
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA9, 0xCC, 0xE3, 0x12,
                    0x18, 0x75,
                    0xC5, 0x44,
                    0xA5,
                    0xE7,
                    0xBA,
                    0x5A,
                    0x79,
                    0xCB,
                    0x92,
                    0x9E
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpStreamFormatConverter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2C, 0x93, 0x8A, 0x67,
                    0x71, 0xEA,
                    0x46, 0x44,
                    0x9B,
                    0x41,
                    0x78,
                    0xFD,
                    0xA6,
                    0x28,
                    0x0A,
                    0x29
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpAudio
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8F, 0x76, 0x5C, 0xC0,
                    0xE8, 0xFA,
                    0xC2, 0x4E,
                    0x8E,
                    0x07,
                    0x33,
                    0x83,
                    0x21,
                    0xC1,
                    0x24,
                    0x52
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpMMSysAudio
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6E, 0x6F, 0x80, 0x15,
                    0x70, 0x1D,
                    0x48, 0x4B,
                    0x98,
                    0xE6,
                    0x3B,
                    0x1A,
                    0x00,
                    0x75,
                    0x09,
                    0xAB
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpTranscript
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCE, 0x3B, 0xF6, 0x10,
                    0x1A, 0x20,
                    0xD3, 0x11,
                    0xAC,
                    0x70,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xE6,
                    0xC0
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpLexicon
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC2, 0xA7, 0x41, 0xDA,
                    0x83, 0x53,
                    0xB2, 0x4D,
                    0x91,
                    0x6B,
                    0x6C,
                    0x17,
                    0x19,
                    0xE3,
                    0xDB,
                    0x58
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpContainerLexicon
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2F, 0x57, 0x65, 0x85,
                    0x94, 0xC0,
                    0xCC, 0x41,
                    0xB5,
                    0x6E,
                    0x10,
                    0xBD,
                    0x9C,
                    0x3F,
                    0xF0,
                    0x44
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpShortcut
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE2, 0x81, 0xF6, 0x3D,
                    0x56, 0xEA,
                    0xD9, 0x11,
                    0x8B,
                    0xDE,
                    0xF6,
                    0x6B,
                    0xAD,
                    0x1E,
                    0x3F,
                    0x3A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpPhoneConverter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0xC5, 0x45, 0x84,
                    0xAC, 0x0C,
                    0x38, 0x4A,
                    0xAB,
                    0xFE,
                    0x9B,
                    0x2C,
                    0xE2,
                    0x82,
                    0x64,
                    0x55
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpPhoneticAlphabetConverter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD4, 0xDC, 0x3A, 0x13,
                    0xB4, 0x19,
                    0x20, 0x40,
                    0x9F,
                    0xDC,
                    0x84,
                    0x2E,
                    0x78,
                    0x25,
                    0x3B,
                    0x17
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpPhoneticAlphabetSelection
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFD, 0x5E, 0x74, 0xB2,
                    0xCE, 0x42,
                    0xCA, 0x48,
                    0x81,
                    0xF1,
                    0xA9,
                    0x6E,
                    0x02,
                    0x53,
                    0x8A,
                    0x90
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpVoice
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x74, 0xDF, 0x44, 0x6C,
                    0xB9, 0x72,
                    0x92, 0x49,
                    0xA1,
                    0xEC,
                    0xEF,
                    0x99,
                    0x6E,
                    0x04,
                    0x22,
                    0xD4
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpPhrase
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x54, 0x03, 0x5C, 0x1A,
                    0x21, 0xB6,
                    0x5A, 0x4B,
                    0x87,
                    0x91,
                    0xD3,
                    0x06,
                    0xED,
                    0x37,
                    0x9E,
                    0x53
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpPhraseAlt
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x98, 0xBC, 0xCE, 0x8F,
                    0x49, 0x4E,
                    0x67, 0x40,
                    0x9C,
                    0x6C,
                    0xD8,
                    0x6A,
                    0x0E,
                    0x09,
                    0x2E,
                    0x3D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpPhrase2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x52, 0xDA, 0x64, 0xF2,
                    0x57, 0xE4,
                    0x96, 0x46,
                    0xB8,
                    0x56,
                    0xA7,
                    0x37,
                    0xB7,
                    0x17,
                    0xAF,
                    0x79
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpRecoResult
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBE, 0x53, 0xB0, 0x20,
                    0x35, 0xE2,
                    0xCD, 0x43,
                    0x9A,
                    0x2A,
                    0x8D,
                    0x17,
                    0xA4,
                    0x8B,
                    0x78,
                    0x42
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpRecoResult2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC4, 0xC6, 0xCA, 0x27,
                    0xF2, 0x88,
                    0xF2, 0x41,
                    0x88,
                    0x17,
                    0x0C,
                    0x95,
                    0xE5,
                    0x9F,
                    0x1E,
                    0x6E
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpXMLRecoResult
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2B, 0x36, 0x39, 0xAE,
                    0xA8, 0x45,
                    0x74, 0x40,
                    0x9B,
                    0x9E,
                    0xCC,
                    0xF4,
                    0x9A,
                    0xA2,
                    0xD0,
                    0xB6
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpGrammarBuilder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8F, 0x82, 0x37, 0x81,
                    0x1A, 0x59,
                    0x42, 0x4A,
                    0xBE,
                    0x58,
                    0x49,
                    0xEA,
                    0x7E,
                    0xBA,
                    0xAC,
                    0x68
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpRecoGrammar
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x29, 0xDB, 0x77, 0x21,
                    0x45, 0x7F,
                    0xD0, 0x47,
                    0x85,
                    0x54,
                    0x06,
                    0x7E,
                    0x91,
                    0xC8,
                    0x05,
                    0x02
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpGrammarBuilder2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x26, 0x00, 0xB1, 0x8A,
                    0xCC, 0x20,
                    0x20, 0x4B,
                    0x8C,
                    0x22,
                    0xA4,
                    0x9C,
                    0x9B,
                    0xA7,
                    0x8F,
                    0x60
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpRecoGrammar2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9E, 0xBC, 0x37, 0x4B,
                    0xD6, 0x9E,
                    0xA3, 0x44,
                    0x93,
                    0xD3,
                    0x18,
                    0xF0,
                    0x22,
                    0xB7,
                    0x9E,
                    0xC3
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechResourceLoader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x83, 0x57, 0xAC, 0xB9,
                    0xD0, 0xFC,
                    0x21, 0x4B,
                    0xB1,
                    0x19,
                    0xB4,
                    0xF8,
                    0xDA,
                    0x8F,
                    0xD2,
                    0xC3
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpRecoContext
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2F, 0xA6, 0x40, 0xF7,
                    0x15, 0x7C,
                    0x9E, 0x48,
                    0x82,
                    0x34,
                    0x94,
                    0x0A,
                    0x33,
                    0xD9,
                    0x27,
                    0x2D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpRecoContext2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1C, 0x31, 0xAD, 0xBE,
                    0xFF, 0x52,
                    0x7F, 0x43,
                    0x94,
                    0x64,
                    0x6B,
                    0x21,
                    0x05,
                    0x4C,
                    0xA7,
                    0x3D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpProperties
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x71, 0xB9, 0x4F, 0x5B,
                    0x15, 0xB1,
                    0xE1, 0x4D,
                    0xAD,
                    0x97,
                    0xE4,
                    0x82,
                    0xE3,
                    0xBF,
                    0x6E,
                    0xE4
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpRecognizer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0xF2, 0xB5, 0xC2,
                    0xA0, 0xDA,
                    0x07, 0x45,
                    0x9E,
                    0x16,
                    0x5A,
                    0x1E,
                    0xAA,
                    0x2B,
                    0x7A,
                    0x5C
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpSerializeState
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0x01, 0xB5, 0x21,
                    0xC7, 0x0E,
                    0xC9, 0x46,
                    0x92,
                    0xC3,
                    0xA2,
                    0xBC,
                    0x78,
                    0x4C,
                    0x54,
                    0xB9
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpRecognizer2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x74, 0xD9, 0xC6, 0x8F,
                    0x1E, 0xC8,
                    0x98, 0x40,
                    0x93,
                    0xC5,
                    0x01,
                    0x47,
                    0xF6,
                    0x1E,
                    0xD4,
                    0xD3
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpRecoCategory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF9, 0xD0, 0x0C, 0xDA,
                    0xA2, 0x14,
                    0x09, 0x4F,
                    0x8C,
                    0x2A,
                    0x85,
                    0xCC,
                    0x48,
                    0x97,
                    0x93,
                    0x45
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpRecognizer3
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3C, 0x94, 0x1B, 0xDF,
                    0x38, 0x58,
                    0xA2, 0x4A,
                    0x87,
                    0x06,
                    0xD7,
                    0xCD,
                    0x5B,
                    0x33,
                    0x34,
                    0x99
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpEnginePronunciation
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4B, 0xCE, 0x60, 0xC3,
                    0xD1, 0x76,
                    0x14, 0x42,
                    0xAD,
                    0x68,
                    0x52,
                    0x65,
                    0x7D,
                    0x50,
                    0x83,
                    0xDA
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpDisplayAlternates
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE2, 0xC7, 0xD7, 0xC8,
                    0xDE, 0x0D,
                    0xB7, 0x44,
                    0xAF,
                    0xE3,
                    0xB0,
                    0xC9,
                    0x91,
                    0xFB,
                    0xEB,
                    0x5E
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechDataKey
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9B, 0xC0, 0x17, 0xCE,
                    0xFA, 0x4E,
                    0xD5, 0x44,
                    0xA4,
                    0xC9,
                    0x59,
                    0xD9,
                    0x58,
                    0x5A,
                    0xB0,
                    0xCD
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechObjectToken
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDC, 0x3A, 0x4A, 0xC7,
                    0x27, 0xB7,
                    0x00, 0x45,
                    0xA8,
                    0x4A,
                    0xB5,
                    0x26,
                    0x72,
                    0x1C,
                    0x8B,
                    0x8C
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechObjectTokens
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x76, 0xB7, 0x85, 0x92,
                    0x7B, 0x2E,
                    0xC0, 0x4B,
                    0xB5,
                    0x3E,
                    0x58,
                    0x0E,
                    0xB6,
                    0xFA,
                    0x96,
                    0x7F
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechObjectTokenCategory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0xAC, 0x7E, 0xCA,
                    0x01, 0x2D,
                    0x45, 0x41,
                    0x86,
                    0xD4,
                    0x5A,
                    0xE7,
                    0xD7,
                    0x0F,
                    0x44,
                    0x69
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechAudioBufferInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD8, 0x03, 0xB1, 0x11,
                    0x42, 0x11,
                    0xDF, 0x4E,
                    0xA0,
                    0x93,
                    0x82,
                    0xFB,
                    0x39,
                    0x15,
                    0xF8,
                    0xCC
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechAudioStatus
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x91, 0x9C, 0x2D, 0xC6,
                    0x58, 0x74,
                    0xF6, 0x47,
                    0x86,
                    0x2D,
                    0x1E,
                    0xF8,
                    0x6F,
                    0xB0,
                    0xB2,
                    0x78
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechAudioFormat
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x90, 0xC5, 0xE9, 0xE6,
                    0x18, 0x3E,
                    0xE3, 0x40,
                    0x82,
                    0x99,
                    0x06,
                    0x1F,
                    0x98,
                    0xBD,
                    0xE7,
                    0xC7
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechWaveFormatEx
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD5, 0xF0, 0x1E, 0x7A,
                    0x81, 0x15,
                    0x41, 0x47,
                    0x88,
                    0xE4,
                    0x20,
                    0x9A,
                    0x49,
                    0xF1,
                    0x1A,
                    0x10
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechBaseStream
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6F, 0x33, 0x50, 0x64,
                    0x49, 0x7D,
                    0xED, 0x4C,
                    0x80,
                    0x97,
                    0x49,
                    0xD6,
                    0xDE,
                    0xE3,
                    0x72,
                    0x94
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechFileStream
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x25, 0xF1, 0x67, 0xAF,
                    0x39, 0xAB,
                    0x93, 0x4E,
                    0xB4,
                    0xA2,
                    0xCC,
                    0x2E,
                    0x66,
                    0xE1,
                    0x82,
                    0xA7
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechMemoryStream
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x68, 0x4B, 0xB1, 0xEE,
                    0x8B, 0x80,
                    0xBE, 0x4A,
                    0xA5,
                    0xEA,
                    0xB5,
                    0x1D,
                    0xA7,
                    0x58,
                    0x80,
                    0x08
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechCustomStream
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4F, 0x9F, 0x9E, 0x1A,
                    0x4F, 0x10,
                    0xB8, 0x4D,
                    0xA1,
                    0x15,
                    0xEF,
                    0xD7,
                    0xFD,
                    0x0C,
                    0x97,
                    0xAE
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechAudio
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x75, 0xE1, 0xF8, 0xCF,
                    0x9E, 0x01,
                    0xD3, 0x11,
                    0xA0,
                    0x8E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xF9,
                    0xB5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechMMSysAudio
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6D, 0xAF, 0x76, 0x3C,
                    0xD7, 0x1F,
                    0x31, 0x48,
                    0x81,
                    0xD1,
                    0x3B,
                    0x71,
                    0xD5,
                    0xA1,
                    0x3C,
                    0x44
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechVoice
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD8, 0x16, 0x93, 0x26,
                    0xBD, 0x57,
                    0xD2, 0x11,
                    0x9E,
                    0xEE,
                    0x00,
                    0xC0,
                    0x4F,
                    0x79,
                    0x73,
                    0x96
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechVoiceStatus
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x07, 0x7B, 0xE4, 0x8B,
                    0xF6, 0x57,
                    0xD2, 0x11,
                    0x9E,
                    0xEE,
                    0x00,
                    0xC0,
                    0x4F,
                    0x79,
                    0x73,
                    0x96
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid DIID__ISpeechVoiceEvents
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD1, 0xAC, 0x72, 0xA3,
                    0xEF, 0x3B,
                    0xBD, 0x4B,
                    0x8F,
                    0xFB,
                    0xCB,
                    0x3E,
                    0x2B,
                    0x41,
                    0x6A,
                    0xF8
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechRecognizer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0C, 0x1C, 0x5F, 0x2D,
                    0x75, 0xBD,
                    0x08, 0x4B,
                    0x94,
                    0x78,
                    0x3B,
                    0x11,
                    0xFE,
                    0xA2,
                    0x58,
                    0x6C
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechRecognizerStatus
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0xE7, 0xF9, 0xBF,
                    0xEC, 0x53,
                    0x4E, 0x48,
                    0xBB,
                    0x8A,
                    0x0E,
                    0x1B,
                    0x55,
                    0x51,
                    0xE3,
                    0x5C
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechRecoContext
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9D, 0xA4, 0x0A, 0x58,
                    0x1E, 0x7E,
                    0x09, 0x48,
                    0xB8,
                    0xE2,
                    0x57,
                    0xDA,
                    0x80,
                    0x61,
                    0x04,
                    0xB8
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechRecoGrammar
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9F, 0xF7, 0xD6, 0xB6,
                    0x58, 0x21,
                    0x50, 0x4E,
                    0xB5,
                    0xBC,
                    0x9A,
                    0x9C,
                    0xCD,
                    0x85,
                    0x2A,
                    0x09
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid DIID__ISpeechRecoContextEvents
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x42, 0xCB, 0x8F, 0x7B,
                    0x9D, 0x0E,
                    0x00, 0x4F,
                    0xA0,
                    0x48,
                    0x7B,
                    0x04,
                    0xD6,
                    0x17,
                    0x9D,
                    0x3D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechGrammarRule
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCF, 0x19, 0xE7, 0xAF,
                    0xD1, 0x5D,
                    0xF2, 0x44,
                    0x99,
                    0x9C,
                    0x7A,
                    0x39,
                    0x9F,
                    0x1C,
                    0xFC,
                    0xCC
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechGrammarRules
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x44, 0x3B, 0xFA, 0x6F,
                    0x2D, 0xFC,
                    0xD1, 0x40,
                    0x8A,
                    0xFC,
                    0x32,
                    0x91,
                    0x1C,
                    0x7F,
                    0x1A,
                    0xD1
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechGrammarRuleState
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2C, 0x6F, 0x28, 0xD4,
                    0x67, 0xEE,
                    0xAE, 0x45,
                    0xB9,
                    0x28,
                    0x28,
                    0xD6,
                    0x95,
                    0x36,
                    0x2E,
                    0xDA
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechGrammarRuleStateTransition
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB1, 0x1D, 0xFD, 0xCA,
                    0xD1, 0x41,
                    0x06, 0x4A,
                    0x98,
                    0x63,
                    0xE2,
                    0xE8,
                    0x1D,
                    0xA1,
                    0x7A,
                    0x9A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechGrammarRuleStateTransitions
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x57, 0xE6, 0xBC, 0xEA,
                    0xBC, 0x75,
                    0xA2, 0x44,
                    0xAA,
                    0x7F,
                    0xC5,
                    0x64,
                    0x76,
                    0x74,
                    0x29,
                    0x63
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechTextSelectionInformation
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7A, 0x7E, 0x9C, 0x3B,
                    0xEE, 0x6E,
                    0xED, 0x4D,
                    0x90,
                    0x92,
                    0x11,
                    0x65,
                    0x72,
                    0x79,
                    0xAD,
                    0xBE
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechRecoResult
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCF, 0x79, 0x28, 0xED,
                    0xD9, 0xCE,
                    0xE6, 0x4E,
                    0xA5,
                    0x34,
                    0xDE,
                    0x01,
                    0x91,
                    0xD5,
                    0x46,
                    0x8D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechRecoResult2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6D, 0x24, 0x0A, 0x8E,
                    0xC8, 0xD3,
                    0xDE, 0x45,
                    0x86,
                    0x57,
                    0x04,
                    0x29,
                    0x0C,
                    0x45,
                    0x8C,
                    0x3C
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechRecoResultTimes
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFB, 0xB8, 0xB3, 0x62,
                    0xE7, 0xF6,
                    0xBE, 0x41,
                    0xBD,
                    0xCB,
                    0x05,
                    0x6B,
                    0x1C,
                    0x29,
                    0xEF,
                    0xC0
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechPhraseAlternate
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2A, 0x4A, 0x86, 0x27,
                    0x9F, 0x2B,
                    0xB8, 0x4C,
                    0x92,
                    0xD3,
                    0x0D,
                    0x27,
                    0x22,
                    0xFD,
                    0x1E,
                    0x73
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechPhraseAlternates
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD5, 0xB6, 0x38, 0xB2,
                    0x76, 0xF2,
                    0x3D, 0x4C,
                    0xA6,
                    0xC1,
                    0x29,
                    0x74,
                    0x80,
                    0x1C,
                    0x3C,
                    0xC2
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechPhraseInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCF, 0x59, 0x15, 0x96,
                    0x67, 0x4E,
                    0x62, 0x46,
                    0x8B,
                    0xF0,
                    0xD9,
                    0x3F,
                    0x1F,
                    0xCD,
                    0x61,
                    0xB3
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechPhraseElement
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x96, 0x6F, 0x17, 0xE6,
                    0x73, 0xE3,
                    0x01, 0x48,
                    0xB2,
                    0x23,
                    0x3B,
                    0x62,
                    0xC0,
                    0x68,
                    0xC0,
                    0xB4
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechPhraseElements
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x28, 0xB3, 0x26, 0x06,
                    0x78, 0x34,
                    0x7D, 0x46,
                    0xA0,
                    0xB3,
                    0xD0,
                    0x85,
                    0x3B,
                    0x93,
                    0xDD,
                    0xA3
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechPhraseReplacement
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0xA4, 0x90, 0x28,
                    0xA7, 0x53,
                    0xB5, 0x4F,
                    0x94,
                    0xEC,
                    0x06,
                    0xD4,
                    0x99,
                    0x8E,
                    0x3D,
                    0x02
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechPhraseReplacements
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2F, 0x66, 0xBC, 0x38,
                    0x57, 0x22,
                    0x25, 0x45,
                    0x95,
                    0x9E,
                    0x20,
                    0x69,
                    0xD2,
                    0x59,
                    0x6C,
                    0x05
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechPhraseProperty
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x48, 0x3D, 0x56, 0xCE,
                    0x1E, 0x96,
                    0x32, 0x47,
                    0xA2,
                    0xE1,
                    0x37,
                    0x8A,
                    0x42,
                    0xB4,
                    0x30,
                    0xBE
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechPhraseProperties
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x47, 0x6B, 0x16, 0x08,
                    0x2E, 0x10,
                    0x23, 0x4B,
                    0xA5,
                    0x99,
                    0xBD,
                    0xB9,
                    0x8D,
                    0xBF,
                    0xD1,
                    0xF4
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechPhraseRule
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x12, 0xE1, 0xBF, 0xA7,
                    0xA0, 0xA4,
                    0xD9, 0x48,
                    0xB6,
                    0x02,
                    0xC3,
                    0x13,
                    0x84,
                    0x3F,
                    0x69,
                    0x64
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechPhraseRules
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x93, 0xD5, 0x47, 0x90,
                    0xDD, 0x01,
                    0x72, 0x4B,
                    0x81,
                    0xA3,
                    0xE4,
                    0xA0,
                    0xCA,
                    0x69,
                    0xF4,
                    0x07
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechLexicon
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7A, 0x62, 0xA7, 0x3D,
                    0xAE, 0xC7,
                    0x23, 0x4B,
                    0x87,
                    0x08,
                    0x63,
                    0x8C,
                    0x50,
                    0x36,
                    0x2C,
                    0x25
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechLexiconWords
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x62, 0x98, 0x19, 0x8D,
                    0x5E, 0x41,
                    0xD5, 0x47,
                    0xAC,
                    0x4F,
                    0xFA,
                    0xA6,
                    0x08,
                    0xB4,
                    0x24,
                    0xE6
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechLexiconWord
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3C, 0x93, 0x5B, 0x4E,
                    0xBE, 0xC9,
                    0xED, 0x48,
                    0x88,
                    0x42,
                    0x1E,
                    0xE5,
                    0x1B,
                    0xB1,
                    0xD4,
                    0xFF
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechLexiconPronunciations
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x28, 0x91, 0x82, 0x72,
                    0x82, 0x56,
                    0x04, 0x47,
                    0xA0,
                    0xD4,
                    0x3E,
                    0x2B,
                    0xB6,
                    0xF2,
                    0xEA,
                    0xD3
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechLexiconPronunciation
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5D, 0x2C, 0x25, 0x95,
                    0x43, 0x9E,
                    0x4A, 0x4F,
                    0x98,
                    0x99,
                    0x48,
                    0xEE,
                    0x73,
                    0x35,
                    0x2F,
                    0x9F
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechXMLRecoResult
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAF, 0x54, 0xEC, 0xAA,
                    0x85, 0x8F,
                    0x24, 0x49,
                    0x94,
                    0x4D,
                    0xB7,
                    0x9D,
                    0x39,
                    0xD7,
                    0x2E,
                    0x19
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechRecoResultDispatch
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0xEB, 0x60, 0x6D,
                    0xED, 0xAC,
                    0xA6, 0x40,
                    0xBB,
                    0xF3,
                    0x4E,
                    0x55,
                    0x7F,
                    0x71,
                    0xDE,
                    0xE2
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechPhraseInfoBuilder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x36, 0x18, 0x15, 0x3B,
                    0x3A, 0xDF,
                    0x0A, 0x4E,
                    0x84,
                    0x6C,
                    0xD2,
                    0xAD,
                    0xC9,
                    0x33,
                    0x43,
                    0x33
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpeechPhoneConverter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x53, 0xF3, 0xE4, 0xC3,
                    0x3F, 0x43,
                    0xD6, 0x43,
                    0x89,
                    0xA1,
                    0x6A,
                    0x62,
                    0xA7,
                    0x05,
                    0x4C,
                    0x3D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpNotifyTranslator
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x72, 0x53, 0xAE, 0xE2,
                    0x40, 0x5D,
                    0xD2, 0x11,
                    0x96,
                    0x0E,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xE6,
                    0x28
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpObjectTokenCategory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7F, 0x18, 0x10, 0xA9,
                    0x7A, 0x0C,
                    0xAC, 0x45,
                    0x92,
                    0xCC,
                    0x59,
                    0xED,
                    0xAF,
                    0xB7,
                    0x7B,
                    0x53
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpObjectToken
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x52, 0x17, 0x41, 0xEF,
                    0x36, 0x37,
                    0xB4, 0x4C,
                    0x9C,
                    0x8C,
                    0x8E,
                    0xF4,
                    0xCC,
                    0xB5,
                    0x8E,
                    0xFE
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpResourceManager
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x73, 0x93, 0x74, 0x96,
                    0x91, 0x33,
                    0xD2, 0x11,
                    0x9E,
                    0xE3,
                    0x00,
                    0xC0,
                    0x4F,
                    0x79,
                    0x73,
                    0x96
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpStreamFormatConverter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3A, 0x94, 0x13, 0x70,
                    0xEC, 0xE2,
                    0xD2, 0x11,
                    0xA0,
                    0x86,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xF9,
                    0xB5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpMMAudioEnum
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0x90, 0x18, 0xAB,
                    0x1F, 0xE9,
                    0xD2, 0x11,
                    0xBB,
                    0x91,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xE6,
                    0xC0
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpMMAudioIn
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x2E, 0x3D, 0xCF,
                    0xF2, 0x53,
                    0xD2, 0x11,
                    0x96,
                    0x0C,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xE6,
                    0x28
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpMMAudioOut
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEB, 0x80, 0xC6, 0xA8,
                    0x32, 0x3D,
                    0xD2, 0x11,
                    0x9E,
                    0xE7,
                    0x00,
                    0xC0,
                    0x4F,
                    0x79,
                    0x73,
                    0x96
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpStream
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x9C, 0x5D, 0x71,
                    0x42, 0x44,
                    0xD2, 0x11,
                    0x96,
                    0x05,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xE6,
                    0x28
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpVoice
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x77, 0x93, 0x74, 0x96,
                    0x91, 0x33,
                    0xD2, 0x11,
                    0x9E,
                    0xE3,
                    0x00,
                    0xC0,
                    0x4F,
                    0x79,
                    0x73,
                    0x96
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpSharedRecoContext
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x04, 0x62, 0x20, 0x47,
                    0xCA, 0x5E,
                    0xD2, 0x11,
                    0x96,
                    0x0F,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xE6,
                    0x28
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpInprocRecognizer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6B, 0x9B, 0xB8, 0x41,
                    0x99, 0x93,
                    0xD2, 0x11,
                    0x96,
                    0x23,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xE6,
                    0x28
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpSharedRecognizer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x90, 0x48, 0xEE, 0x3B,
                    0xE9, 0x4F,
                    0x37, 0x4A,
                    0x8C,
                    0x1E,
                    0x5E,
                    0x7E,
                    0x12,
                    0x79,
                    0x1C,
                    0x1F
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpLexicon
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x96, 0xE3, 0x55, 0x06,
                    0xD0, 0x25,
                    0xD3, 0x11,
                    0x9C,
                    0x26,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xF8,
                    0x7C
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpUnCompressedLexicon
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x15, 0x7C, 0xE3, 0xC9,
                    0x92, 0xDF,
                    0x27, 0x47,
                    0x85,
                    0xD6,
                    0x72,
                    0xE5,
                    0xEE,
                    0xB6,
                    0x99,
                    0x5A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpCompressedLexicon
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x16, 0x37, 0x90, 0x90,
                    0x42, 0x2F,
                    0xD3, 0x11,
                    0x9C,
                    0x26,
                    0x00,
                    0xC0,
                    0x4F,
                    0x8E,
                    0xF8,
                    0x7C
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpShortcut
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1A, 0x2F, 0x72, 0x0D,
                    0xCF, 0x9F,
                    0x62, 0x4E,
                    0x96,
                    0xD8,
                    0x6D,
                    0xF8,
                    0xF0,
                    0x1A,
                    0x26,
                    0xAA
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpPhoneConverter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x43, 0xF7, 0x85, 0x91,
                    0x43, 0x11,
                    0x28, 0x4C,
                    0x86,
                    0xB5,
                    0xBF,
                    0xF1,
                    0x4F,
                    0x20,
                    0xE5,
                    0xC8
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_SpPhoneticAlphabetConverter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x26, 0x41, 0x41, 0x4F,
                    0xE3, 0xDF,
                    0x29, 0x46,
                    0x99,
                    0xEE,
                    0x79,
                    0x79,
                    0x78,
                    0x31,
                    0x7E,
                    0xAD
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpNullPhoneConverter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE9, 0x24, 0x5F, 0x45,
                    0x96, 0x73,
                    0x16, 0x4A,
                    0x97,
                    0x15,
                    0x7C,
                    0x0F,
                    0xDB,
                    0xE3,
                    0xEF,
                    0xE3
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_SpTextSelectionInformation
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0A, 0x03, 0x92, 0x0F,
                    0xFD, 0xCB,
                    0xB8, 0x4A,
                    0xA1,
                    0x64,
                    0xFF,
                    0x59,
                    0x85,
                    0x54,
                    0x7F,
                    0xF6
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpPhraseInfoBuilder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8D, 0xC2, 0x3F, 0xC2,
                    0x5F, 0xC5,
                    0x20, 0x47,
                    0x8B,
                    0x32,
                    0x91,
                    0xF7,
                    0x3C,
                    0x2B,
                    0xD5,
                    0xD1
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpAudioFormat
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x70, 0x68, 0xF9, 0x9E,
                    0x60, 0xE1,
                    0x92, 0x47,
                    0x82,
                    0x0D,
                    0x48,
                    0xCF,
                    0x06,
                    0x49,
                    0xE4,
                    0xEC
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpWaveFormatEx
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4C, 0x57, 0x9A, 0xC7,
                    0xBE, 0x63,
                    0xB9, 0x44,
                    0x80,
                    0x1F,
                    0x28,
                    0x3F,
                    0x87,
                    0xF8,
                    0x98,
                    0xBE
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpInProcRecoContext
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x42, 0x68, 0xAD, 0x73,
                    0xE0, 0xAC,
                    0xE8, 0x45,
                    0xA4,
                    0xDD,
                    0x87,
                    0x95,
                    0x88,
                    0x1A,
                    0x2C,
                    0x2A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpCustomStream
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3F, 0xF1, 0xBE, 0x8D,
                    0x48, 0x19,
                    0xA8, 0x4A,
                    0x8C,
                    0xF0,
                    0x04,
                    0x8E,
                    0xEB,
                    0xED,
                    0x95,
                    0xD8
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpFileStream
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB3, 0x12, 0x78, 0x94,
                    0xE1, 0x2A,
                    0x44, 0x46,
                    0xBA,
                    0x86,
                    0x9E,
                    0x90,
                    0xDE,
                    0xD7,
                    0xEC,
                    0x91
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_SpMemoryStream
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7D, 0xEF, 0xB7, 0x5F,
                    0xF4, 0xDF,
                    0x8A, 0x46,
                    0xB6,
                    0xB7,
                    0x2F,
                    0xCB,
                    0xD1,
                    0x88,
                    0xF9,
                    0x94
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
