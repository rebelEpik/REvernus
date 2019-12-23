﻿using System;
using Prism.Mvvm;

namespace REvernus.Settings
{
    [Serializable]
    public class MarketOrdersTabSettings : BindableBase, ICloneable
    {
        private uint _autoUpdateMintues = 5;
        private bool _autoUpdateTimerEnabled = true;
        private bool _showInEveClient = true;
        private string _marketUpHotkey = "Control+X";
        private string _marketDownHotkey = "Control+Z";

        public uint AutoUpdateMintues
        {
            get => _autoUpdateMintues;
            set
            {
                if (value == 0)
                {
                    value = 1;
                }
                SetProperty(ref _autoUpdateMintues, value);
            }
        }

        public bool AutoUpdateTimerEnabled
        {
            get => _autoUpdateTimerEnabled;
            set => SetProperty(ref _autoUpdateTimerEnabled, value);
        }

        public bool ShowInEveClient
        {
            get => _showInEveClient;
            set => SetProperty(ref _showInEveClient, value);
        }

        public string MarketUpHotkey
        {
            get => _marketUpHotkey;
            set => SetProperty(ref _marketUpHotkey, value);
        }

        public string MarketDownHotkey
        {
            get => _marketDownHotkey;
            set => SetProperty(ref _marketDownHotkey, value);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}