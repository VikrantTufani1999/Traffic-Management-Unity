using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void LoadNext()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadHome()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadSettings()
    {
        SceneManager.LoadScene(5);
    }

    public void LoadStore()
    {
        SceneManager.LoadScene(6);
    }

    public void LoadUnlocks()
    {
        SceneManager.LoadScene(7);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
