using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
