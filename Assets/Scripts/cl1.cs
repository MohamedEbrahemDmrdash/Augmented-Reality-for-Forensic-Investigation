using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cl1 : MonoBehaviour {
    public GameObject go1;
    public GameObject go2;
    public GameObject go3;
    public GameObject go4;
    public GameObject go5;

    public Text txt1;
    public Text txt2;
    public Text txt3;
    public Text txt4;
    public Text txt5;
    public void clr1()
    {
        txt1.text = "";
        if (txt5.text != "")
        {
            go5.SetActive(false);
            txt1.text = txt5.text;
            txt5.text = "";
        }
        else if (txt4.text != "")
        {
            go4.SetActive(false);
            txt1.text = txt4.text;
            txt4.text = "";
        }
        else if (txt3.text != "")
        {
            go3.SetActive(false);
            txt1.text = txt3.text;
            txt3.text = "";
        }
        else if (txt2.text != "")
        {
            go2.SetActive(false);
            txt1.text = txt2.text;
            txt2.text = "";
        }
        else
        {
            go1.SetActive(false);
            txt1.text = "";
        }
    }
}
