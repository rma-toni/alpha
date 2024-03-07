using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    int money;
    public Text moneyText;

    //DEBUG
    public Button moneyButton;

    // Start is called before the first frame update
    void Start()
    {
        money = SLManager.Load();
        moneyText.text = money.ToString();
        moneyButton.onClick.AddListener(click);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void click()
    {
        Debug.Log("Ay me presionaron");
        money++;
        SLManager.Save(money);
        moneyText.text = money.ToString();
    }
}
