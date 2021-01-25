using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair_3_color : MonoBehaviour {
    bool y = false;
    public Material m_blue;
    public Material m_default;
    public Renderer Rend;
    public void Start()
    {
        Rend = GetComponent<Renderer>();
        Rend.enabled = true;
    }

    public void secretary(bool x)
    {
        y = x;
    }

    public void default_o(bool x)
    {
        y = false;
    }
    public void color(float Slider_v)
    {
        int Slider_i = (int)(Slider_v);
        if (Slider_i >= 9 && Slider_i < 15)
            Rend.sharedMaterial = m_default;
        if (Slider_i >= 15&&y==true)
            Rend.sharedMaterial = m_blue;
        if (Slider_i >= 15 && y == false)
            Rend.sharedMaterial = m_default;
    }
}
