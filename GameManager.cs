using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int money;

    public SLManager sl;
    // Start is called before the first frame update
    void Start()
    {
        sl.Load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
