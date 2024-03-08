using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(changeScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void changeScene()
    {
        SceneManager.LoadScene("main1");
    }
}
