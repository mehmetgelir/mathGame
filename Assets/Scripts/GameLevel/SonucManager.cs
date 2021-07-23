using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SonucManager : MonoBehaviour
{
    public void oyunaYenidenBasla()
    {
        SceneManager.LoadScene("gameLevel");
    }

    public void anaMenuyeDon()
    {
        SceneManager.LoadScene("menuLevel");
    }
}
