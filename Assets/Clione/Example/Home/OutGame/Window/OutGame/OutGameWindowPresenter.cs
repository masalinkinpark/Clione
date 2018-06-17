﻿using UnityEngine;

namespace Clione.Example
{
    public class OutGameWindowPresenter : WindowPresenterBase
    {
        [SerializeField] private OutGameWindowView _view;

        public override void Initialize()
        {
            _view.Initialize();
            SetEvent();
        }

        private void SetEvent()
        {
            _view.OnClickedMoveScreenAction += MoveScreen;
            _view.OnClickedInGameButtonAction += () =>
            {
                SceneLoader.Instance.LoadWindow(
                    ExampleResourcePrefabPath.GetWindowPath(OutGameWindowType.PreBattleWindow.ToString()),
                    ExampleResourcePrefabPath.GetScreenPath(OutGameScreenType.PreBattleScreen.ToString())
                );
            };
        }

        private static void MoveScreen(OutGameScreenType type)
        {
            SceneLoader.Instance.LoadScreen(ExampleResourcePrefabPath.GetScreenPath(type.ToString()));
        }
    }
}