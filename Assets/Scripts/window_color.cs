using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class window_color : MonoBehaviour {
    bool y = false;
    public Material m_green;
    public Material m_default;
    public Renderer Rend;
    public void Start()
    {
        Rend = GetComponent<Renderer>();
        Rend.enabled = true;
        Rend.sharedMaterial = m_default;
    }

    public void manager(bool x)
    {
        y = x;
    }

    public void default_0(bool x)
    {
        y = false;
    }
    public void color(float Slider_v)
    {
        int Slider_i = (int)(Slider_v);
        if (Slider_v >= 9 && Slider_v < 10)
        {
            Rend.sharedMaterial = m_default;
        }
        if (Slider_i >= 10 && y==true)
            Rend.sharedMaterial = m_green;
        if (Slider_i >= 10 && y == false)
            Rend.sharedMaterial = m_default;
    }

    
}
