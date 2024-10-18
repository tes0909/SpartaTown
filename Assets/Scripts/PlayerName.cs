using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerName : MonoBehaviour
{
    TMP_Text nameTxt;
    void Start()
    {
        nameTxt = GetComponent<TMP_Text>();
        if(nameTxt != null)
        {
            nameTxt.text = DataManager.instance.playerName;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
