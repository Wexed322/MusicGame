using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void loadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void loadScene(int id)
    {
        SceneManager.LoadScene(id);
    }


    public void OnApplicationQuit()
    {
        Application.Quit();
    }

}