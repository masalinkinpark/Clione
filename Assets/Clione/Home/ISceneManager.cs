﻿using System;
using System.Collections;
using UnityEngine;

namespace Clione.Home
{
    public interface ISceneManager
    {
        MonoBehaviour Mono { get; }
        string CurrentSceneName { get; }
        string CurrentWindowPath { get; }
        string CurrentScreenPath { get; }
        bool IsLoadingScene { get; }
        void InitializeSetUp();
        IEnumerator LoadScene(string loadSceneName, object param = null, Action onComplete = null);
        IEnumerator LoadWindow(string loadWindowPath, string loadScreenPath, Action onComplete = null);
        IEnumerator LoadScreen(string loadScreenPath, Action onComplete = null);
    }
}