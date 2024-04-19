using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotothegame : MonoBehaviour
{
    keepPlaying myAudio;

    private void Start()
    {
        myAudio = FindObjectOfType<keepPlaying>();
    }
    public void GoGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
