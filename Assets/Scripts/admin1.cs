using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class admin1 : MonoBehaviour {
    public GameObject l1;
    public GameObject l2;
    public GameObject l3;
    public GameObject l4;
    public GameObject l5;
    public Text txt1;
    public Text txt2;
    public Text txt3;
    public Text txt4;
    public Text txt5;
    public bool x;
    public bool x1;
    public bool x2;
    public bool x3;
    public bool x4;
    public bool x5;
    public bool x6;
    public bool x7;
    public bool x8;

    public void LoginButton()
    {
        txt1.text = "";
        txt2.text = "";
        txt3.text = "";
        txt4.text = "";
        txt5.text = "";
        l1.SetActive(false);
        l2.SetActive(false);
        l3.SetActive(false);
        l4.SetActive(false);
        l5.SetActive(false);


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



        StreamReader reader = new StreamReader(path);
        string y = "";
        string z = "";
        for (int i = 0; i < 5; i++)
        {
            z = reader.ReadLine();
            while (z != "")
            {
                y += z + Environment.NewLine;
                z = reader.ReadLine();
            }
            if (z == "")
            {
                if (txt1.text == "")
                {
                    txt1.text = y;
                    l1.SetActive(true);
                }
                else if (txt2.text == "")
                {
                    txt2.text = y;
                    l2.SetActive(true);
                }
                else if (txt3.text == "")
                {
                    txt3.text = y;
                    l3.SetActive(true);
                }
                else if (txt4.text == "")
                {
                    txt4.text = y;
                    l4.SetActive(true);
                }
                else
                {
                    txt5.text = y;
                    l5.SetActive(true);
                }
                y = "";
            }
            if (reader.EndOfStream)
            {
                break;
            }
        }
    }
    public string pathForDecumentsFiles(string filename)
    {
        string path = Application.persistentDataPath;
        path = path.Substring(0, path.LastIndexOf('/'));
        return Path.Combine(path, filename);
    }
}

