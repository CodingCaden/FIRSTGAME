﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{


    public void RestartButton()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
