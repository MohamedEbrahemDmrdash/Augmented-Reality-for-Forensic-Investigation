using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ADMIN : MonoBehaviour
{
    public GameObject username;
    public GameObject password;
    public GameObject admin;
    public void LoginButton()
    {
        bool UN = false;
        bool PW = false;
        if (username.GetComponent<InputField>().text == "admin")
        {
            UN = true;
        }
        else
        {
            Debug.LogWarning("Username Invaild");
        }
        
        if (password.GetComponent<InputField>().text == "admin")
        {
            PW = true;
        }
        else
        {
            Debug.LogWarning("Password Is invalid");
        }
        if (UN == true && PW == true)
        {
            username.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";
            admin.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (username.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }
        }
    }
}
