﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("GameScene");
        Player.points = 0;
    }
}