using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour {
    public GameObject obj;
    bool y,z ;
    public void Start()
    {
        obj.SetActive(false);
    }

    public void case_1(float Slider_v)
    {
        int Slider_i = (int)Slider_v;
            switch (Slider_i)
            {
                case 10:
                case 11:
                    obj.SetActive(true);
                    break;
                default:
                    obj.SetActive(false);
                    break;
            }
    }
    
}
