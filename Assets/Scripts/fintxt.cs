using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
public class fintxt : MonoBehaviour {
    public Text txt1;
    public Text txt2;
    public Text txt3;
    public Text txt4;
    public Text txt5;
    public bool x ;
    public bool x1 ;
    public bool x2 ;
    public bool x3 ;
    public bool x4 ;
    public bool x5 ;
    public bool x6 ;
    public bool x7 ;
    public bool x8 ;
    public void fin()
    {
        string y = "";
        if (txt1.text != "")
        {
            y += txt1.text + Environment.NewLine + "";
        }
        if (txt2.text != "")
        {
            y += txt2.text + Environment.NewLine + "";
        }
        if (txt3.text != "")
        {
            y += txt3.text + Environment.NewLine + "";
        }
        if (txt4.text != "")
        {
            y += txt4.text + Environment.NewLine + "";
        }
        if (txt5.text != "")
        {
            y += txt5.text + Environment.NewLine + "";
        }


        string path = "";
        if (x == true)
        {
            path = pathForDecumentsFiles("chair_2.txt");
        }
        else if (x1 == true)
        {
            path = pathForDecumentsFiles("sharp.txt");
            x1 = false;
        }
        else if (x2 == true)
        {
            path = pathForDecumentsFiles("chair_1.txt");
        }
        else if (x3 == true)
        {
            path = pathForDecumentsFiles("pc.txt");
        }
        else if (x4 == true)
        {
            path = pathForDecumentsFiles("files.txt");
        }
        else if (x5 == true)
        {
            path = pathForDecumentsFiles("chair_3.txt");
        }
        else if (x6 == true)
        {
            path = pathForDecumentsFiles("desk.txt");
        }
        else if (x7 == true)
        {
            path = pathForDecumentsFiles("window.txt");
        }
        else if (x8 == true)
        {
            path = pathForDecumentsFiles("Cup.txt");
        }


        File.WriteAllText(path, y);
    }

    public string pathForDecumentsFiles(string filename)
    {
        string path = Application.persistentDataPath;
        path = path.Substring(0, path.LastIndexOf('/'));
        return Path.Combine(path, filename);
    }


  

}
