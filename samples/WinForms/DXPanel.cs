// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Numerics;
using System.Windows.Forms;
using TerraFX.Samples.DirectX;
using static TerraFX.Interop.DXGI_FORMAT;
using static TerraFX.Interop.Windows;

namespace TerraFX.Samples.WinForms
{
    public partial class DXPanel : Panel
    {
        private DXSample? _dxSample;
        private bool _useWarpDevice;

        public DXPanel()
        {
            InitializeComponent();
        }

        public DXSample? DXSample
        {
            get
            {
                return _dxSample;
            }

            set
            {
                if (value == _dxSample)
                {
                    return;
                }

                if (_dxSample is not null)
                {
                    _dxSample.OnDestroy();
                }

                if (value is not null)
                {
                    var backgroundColor = new Vector4(BackColor.R / 255.0f, BackColor.G / 255.0f, BackColor.B / 255.0f, BackColor.A / 255.0f);
                    value.OnInit(DXGI_FORMAT_UNKNOWN, backgroundColor, DXGI_FORMAT_UNKNOWN, 1.0f, 2, Handle, true, ClientSize, _useWarpDevice);
                }

                _dxSample = value;
                Invalidate();
            }
        }

        public bool UseWarpDevice
        {
            get
            {
                return (_dxSample?.UseWarpDevice).GetValueOrDefault();
            }

            set
            {
                if (_dxSample is not null)
                {
                    _dxSample.OnDestroy();

                    var backgroundColor = new Vector4(0.0f, 0.2f, 0.4f, 1.0f);
                    _dxSample.OnInit(DXGI_FORMAT_UNKNOWN, backgroundColor, DXGI_FORMAT_UNKNOWN, 1.0f, 2, Handle, true, ClientSize, _useWarpDevice);
                }
                _useWarpDevice = value;
            }
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            if (_dxSample is not null)
            {
                _dxSample.BackgroundColor = new Vector4(BackColor.R / 255.0f, BackColor.G / 255.0f, BackColor.B / 255.0f, BackColor.A / 255.0f);
            }
            base.OnBackColorChanged(e);
        }

        private void DXPanel_ClientSizeChanged(object? sender, EventArgs eventArgs)
        {
            _dxSample?.OnWindowSizeChanged(ClientSize);
        }

        private void DXPanel_KeyUp(object sender, KeyEventArgs eventArgs)
        {
            _dxSample?.OnKeyUp(eventArgs.KeyValue);
        }

        private void DXPanel_KeyDown(object sender, KeyEventArgs eventArgs)
        {
            _dxSample?.OnKeyDown(eventArgs.KeyValue);
        }

        protected override void WndProc(ref Message m)
        {
            if ((m.Msg == WM_PAINT) && (_dxSample is not null))
            {
                _dxSample.OnUpdate();
                _dxSample.OnRender();
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
}
