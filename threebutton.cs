﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class threebutton : MonoBehaviour
{
    public void LoadScene1()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void LoadScene2()
    {
        SceneManager.LoadScene("Scene2");
    }
    public void LoadScene3()
    {
        SceneManager.LoadScene("Screen");
    }
    public void MasterScene()
    {
        SceneManager.LoadScene("MasterScene");
    }
}
