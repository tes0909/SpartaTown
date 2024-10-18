using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    public TMP_InputField nameInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnclickJoinBtn()
    {
        if (nameInput.text.Length < 2 || nameInput.text.Length > 10)
            return;
        SceneManager.LoadScene(1);
        DataManager.instance.playerName = nameInput.text;
    }
}
