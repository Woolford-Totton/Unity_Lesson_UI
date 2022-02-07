using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_Input : MonoBehaviour
{
    public float movespd = 0.05f;

    private float horiaxis=0;

    private float veraxis = 0;


    // Start is called before the first frame update
    void OnGUI()
    {
       
    }

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        veraxis = -(Input.GetAxis("Vertical_Keyboard")+ Input.GetAxis("Vertical"));

        horiaxis = Input.GetAxis("Horizontal_Keyboard") + Input.GetAxis("Horizontal");



        transform.Translate(horiaxis* movespd, veraxis* movespd,0);


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Pellet")
        { 
            
        }
    }
}
