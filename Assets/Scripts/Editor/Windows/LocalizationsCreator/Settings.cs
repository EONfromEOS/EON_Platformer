﻿using System;
using System.IO;
using UnityEngine;

namespace DungeonsEditor.Windows
{
    public partial class LocalizationsCreator
    {
        [Serializable]
        public class Settings
        {
            [SerializeField] private string _directoryName = "Localizations";
            [SerializeField] private string _fileExtension = "json";
            [SerializeField] private string _classifierName = "Classifier";
            [SerializeField] private string _localizationDefaultName = "Localization";

            private readonly string _directoryPath;
            private readonly string _classifierFullPath;

            public Settings()
            {
                _directoryPath = Path.Combine(Application.streamingAssetsPath, _directoryName);
                _classifierFullPath = Path.Combine(_directoryPath, $"{_classifierName}.{_fileExtension}");
            }

            public string DirectoryPath => _directoryPath;
            public string FileExtention => _fileExtension;
            public string ClassifierName => _classifierName;
            public string ClassifierFullPath => _classifierFullPath;
            public string LocalizationDefaultName => _localizationDefaultName;
        }
    }
}