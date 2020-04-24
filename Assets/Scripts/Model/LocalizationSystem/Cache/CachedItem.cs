﻿using System;
using UnityEngine;

namespace Dungeons.Model.LocalizationSystem
{
    [Serializable]
    public class CachedItem
    {
        [SerializeField] private LocalizationTextID _key;

        private string _value;

        public string Value => _value;

        public void ToCache(Localizer localizer)
        {
            _value = localizer.GetLocalizedText(_key);
        }
    }
}