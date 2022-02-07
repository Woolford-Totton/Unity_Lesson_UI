using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class Scr_UI : MonoBehaviour
{
   

    private Button Mybutton = null;

    private Text Mytext = null;

    private Image Myimage = null;

    private byte[] fileData;
    // Start is called before the first frame update
    void Start()
    {
        var prefabbutton =Resources.Load("Prefab/Prefab_UI_Button");

        GameObject Button_object = (GameObject)Instantiate(prefabbutton, new Vector3(0, 0, 0), Quaternion.identity);

        Mybutton = Button_object.GetComponent<Button>();

        Mybutton.transform.SetParent(this.gameObject.GetComponent<RectTransform>());

        Mybutton.onClick.AddListener(btn_click);

        RectTransform Rect_button = Button_object.GetComponent<RectTransform>();
        
        Button_object.transform.Translate(Rect_button.rect.width*0.5f, (Screen.height * 1.0f)- Rect_button.rect.height * 0.5f, 0);

        var prefabtext = Resources.Load("Prefab/Prefab_UI_Text");

        GameObject Text_object = (GameObject)Instantiate(prefabtext, new Vector3(0, 0, 0), Quaternion.identity);

        Mytext = Text_object.GetComponent<Text>();

        Mytext.transform.SetParent(this.gameObject.GetComponent<RectTransform>());

        Mytext.text = "Hello World!";

        RectTransform Rect_text = Text_object.GetComponent<RectTransform>();

        Mytext.transform.Translate((Screen.width * 1.0f), (Screen.height * 1.0f) - Rect_text.rect.height * 0.5f, 0);

        var prefabimage = Resources.Load("Prefab/Prefab_UI_Image");

        GameObject Image_object = (GameObject)Instantiate(prefabimage, new Vector3(0, 0, 0), Quaternion.identity);

        Myimage = Image_object.GetComponent<Image>();

        Myimage.transform.SetParent(this.gameObject.GetComponent<RectTransform>());

        
            
        string filePath = "Assets/images/Love_Heart_symbol";
       
        Sprite heartimage=Resources.Load<Sprite>(filePath) as Sprite;

        Myimage.sprite = heartimage;

        RectTransform Rect_image = Image_object.GetComponent<RectTransform>();

        Myimage.transform.Translate((Screen.width * 0.5f), (Screen.height * 0.5f) - Rect_image.rect.height * 0.0f, 0);






    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    public void btn_click()
    {
        Text btntext = Mybutton.GetComponentInChildren<Text>();

        btntext.text = "Changed text";
    }
    //private void OnGUI()
    //{
    //    Texture2D mytexture = new Texture2D(2,2);
    //    string filePath = "Assets/Resources/Assets/images/Love_Heart_symbol.png";
    //    fileData = File.ReadAllBytes(filePath);
    //    mytexture.LoadImage(fileData);
    //    GUI.DrawTexture(new Rect(Screen.width * 0.0f, Screen.height * 0.75f, Screen.width*0.25f, Screen.height*0.25f), mytexture);
    //}
}

