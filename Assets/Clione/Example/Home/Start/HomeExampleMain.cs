﻿using Clione.Home;

namespace Clione.Example
{
    public class HomeExampleMain : ScenePresenterBase
    {
        private void Start()
        {
            SceneLoader.Initialize(new ClioneSceneManager());
        }

        public override void Initialize(object param)
        {
        }

        public override void InitializeOpenWindowAndScreen()
        {
            SceneLoader.LoadScene("OutGame");
        }
    }
}