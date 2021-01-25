using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair_2 : MonoBehaviour {
    private Animator anim;
    public void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void case_1(float Slider_v)
    {
            anim.SetFloat("Slide_3", Slider_v); //chair_2
            anim.SetFloat("Slider_4", Slider_v);//chair_3
            anim.SetFloat("Slid_2", Slider_v);//chair_1
            anim.SetFloat("Slid", Slider_v);//desk
            anim.SetFloat("P_Slid", Slider_v);//files
            anim.SetFloat("Slider_5", Slider_v);//sharp
            anim.SetFloat("Slider_6", Slider_v);//window
            anim.SetFloat("Cup", Slider_v);//cup
        }
}
