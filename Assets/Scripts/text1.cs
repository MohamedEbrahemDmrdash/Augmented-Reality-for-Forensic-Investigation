using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class text1 : MonoBehaviour
{
    public GameObject In;
    public bool x ;
    public bool x1 ;
    public bool x2 ;
    public bool x3 ;
    public bool x4 ;
    public bool x5 ;
    public bool x6 ;
    public bool x7 ;
    public bool x8;
    public void LoginButton()
    {
        string y = DateTime.Now + Environment.NewLine + In.GetComponent<InputField>().text;
        string path = "";
        if (x == true)
        {
            path = pathForDecumentsFiles("chair_2.txt");
        }
        else if (x1 == true)
        {
            path = pathForDecumentsFiles("sharp.txt");
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
        if (In.GetComponent<InputField>().text != "")
        {
            System.IO.File.AppendAllText(path, y + Environment.NewLine + "" + Environment.NewLine);
        }
        else
        {
            Debug.Log("Empty hint!");
        }
    }
    public string pathForDecumentsFiles(string filename)
    {
        string path = Application.persistentDataPath;
        path = path.Substring(0, path.LastIndexOf('/'));
        return Path.Combine(path, filename);
    }
}