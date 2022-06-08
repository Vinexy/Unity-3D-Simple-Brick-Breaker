using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startScreen : MonoBehaviour
{
    public string input;
    [SerializeField] InputField playername;
    
    public void playButton()
    {
         PlayerPrefs.SetString("playername", playername.text);
         SceneManager.LoadScene("level1");
        Debug.Log(PlayerPrefs.GetString("playername"));


    }


}
