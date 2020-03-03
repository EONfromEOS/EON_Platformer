﻿using Game.Model;
using UnityEngine;

namespace Game
{
    public class EnvironmentMouseController : ElementMouseController
    {
        [SerializeField] private Environment _environment;

        private protected override IInfoElement InfoElement => (IInfoElement)_environment;

        #region Unity
        private void OnValidate()
        {
            if ((_environment is IInfoElement) == false)
            {
                _environment = null;
                Debug.LogError($"{_environment.name} needs to implement {nameof(IInfoElement)}");
            }
        }

        private void OnMouseEnter()
        {
            WhenMouseEnter();
        }

        private void OnMouseExit()
        {
            WhenMouseExit();
        }

        private void OnMouseDown()
        {
            if (PlayerIsClose())
            {

            }
            else
            {
                _notifier?.ShowMessage(_playerFarMessage, InfoElement.Sprite);
            }

            _infoPanel.Present(InfoElement);
        }
        #endregion
    }
}
