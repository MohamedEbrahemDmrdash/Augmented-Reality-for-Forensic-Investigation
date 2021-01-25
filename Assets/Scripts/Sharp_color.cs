using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sharp_color : MonoBehaviour {
    bool y = false;
    public Material m_yellow;
    public Material m_default;
    public Renderer Rend;
    public void Start()
    {
        Rend = GetComponent<Renderer>();
        Rend.enabled = true;
    }

    public void default_0(bool x)
    {
        y = false;
    }

    public void officeboy(bool x)
    {
        y = x;
    }

    public void color(float Slider_v)
    {
        int Slider_i = (int)(Slider_v);
        if (Slider_i < 13)
            Rend.sharedMaterial = m_default;
        if (Slider_i >= 13&&y==true)
            Rend.sharedMaterial = m_yellow;
        if (Slider_i >= 13 && y == false)
            Rend.sharedMaterial = m_default;
    }
}
