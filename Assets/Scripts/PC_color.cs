using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC_color : MonoBehaviour {

    bool y,z;
    public Material m_green;
    public Material m_default;
    public Renderer Rend;
    public void Start()
    {
        Rend = GetComponent<Renderer>();
        Rend.enabled = true;
    }

    public void default0(bool x)
    {
        if(x==true)
            z = false;
    }

    public void manager(bool x)
    {
        z = x;
    }
    public void color(float Slider_v)
    {
        int Slider_i = (int)(Slider_v);
        if (Slider_i >= 10&&z==true)
            Rend.sharedMaterial = m_green;
        if(Slider_i >= 10&&z==false)
            Rend.sharedMaterial = m_default;
    }
}
