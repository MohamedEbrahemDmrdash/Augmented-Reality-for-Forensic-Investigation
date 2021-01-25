using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
public class shtxt : MonoBehaviour {
    private TextMeshProUGUI txt1;
    public GameObject go;
    public bool x ;
    public bool x1 ;
    public bool x2 ;
    public bool x3 ;
    public bool x4 ;
    public bool x5 ;
    public bool x6 ;
    public bool x7 ;
    public bool x8;
    // Use this for initialization
    void Start () {
        go.SetActive(true);
        txt1 = GetComponent<TextMeshProUGUI>();
	}
    public string pathForDecumentsFiles(string filename)
    {
        string path = Application.persistentDataPath;
        path = path.Substring(0, path.LastIndexOf('/'));
        return Path.Combine(path, filename);
    }

    public void shtx()
    {
        Start();
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
        else if(x8==true)
        {
            path = pathForDecumentsFiles("Cup.txt");
        }
        txt1.text = File.ReadAllText(path);
    }
}
