using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : Movement
{
    [SerializeField] GameObject panel;
    [SerializeField] Text ScoreText;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText = FindObjectOfType<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + score;

        if (score == 50)
        {
            panel.SetActive(true);
        }

        if(panel.active == true)
        {
            score = 50;
        }
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene(2);
    }
 
    public void LoadLevel3()
    {
        SceneManager.LoadScene(3);
    }
}
