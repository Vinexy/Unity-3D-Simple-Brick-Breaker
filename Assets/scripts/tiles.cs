using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tiles : MonoBehaviour
{
    
    [SerializeField] Text scoreText;
    private int totalTiles;
    private int counter;
    private int totalScore;
    [SerializeField] int score;
    void Start()
    {
        totalTiles = transform.childCount;

    }

    // Update is called once per frame
    void Update()
    {

        counter = transform.childCount;
        score = ((totalTiles - counter) * 10);
        scoreText.text = PlayerPrefs.GetString("playername")+ ": " + score.ToString();
        PlayerPrefs.SetInt("score", score);
        if (counter == 0)
        {
            totalScore += score;
            PlayerPrefs.SetInt("score", totalScore);
            SceneManager.LoadScene("level2");
            
            Debug.Log(totalScore);
        }
    }
}
