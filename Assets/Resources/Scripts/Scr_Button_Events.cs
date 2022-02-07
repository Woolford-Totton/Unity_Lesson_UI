using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class Scr_Button_Events : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void button_click_change_text()
    {
        Button btn = gameObject.GetComponent<Button>();

        Text btntext = btn.GetComponentInChildren<Text>();

        btntext.text = "Changed text";
    }
}
