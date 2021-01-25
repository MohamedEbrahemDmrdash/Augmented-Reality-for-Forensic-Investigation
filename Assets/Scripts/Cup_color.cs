using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup_color : MonoBehaviour {
    bool y = false;
    bool z = false;
    public Material m_yellow;
    public Material m_green;
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
        z = false;
    }

    public void manager(bool x)
    {
        y = x;
    }

    public void officeboy(bool x)
    {
        z = x;
    }

    public void color(float Slider_v)
    {
        int Slider_i = (int)(Slider_v);
        if (Slider_i == 9)
        {
            Rend.sharedMaterial = m_default;
        }
        if (Slider_i > 11 && Slider_i < 13&&y==true)
        {
            Rend.sharedMaterial = m_green;
        }
        if ((Slider_i >= 13 || Slider_i == 11)&&z==true)
        {
            Rend.sharedMaterial = m_yellow;
        }
        if ((Slider_i >= 13 || Slider_i == 11) && z == false)
        {
            Rend.sharedMaterial = m_default;
        }
        if (Slider_i > 11 && Slider_i < 13 && y == false)
        {
            Rend.sharedMaterial = m_default;
        }
    }
}
