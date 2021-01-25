using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class showvideo : MonoBehaviour {

	 public void GotoMainScene()
    {
        SceneManager.LoadScene("demo2");
    }
     public void GotoMainScene2()
     {
         SceneManager.LoadScene("SampleScene");
     }
	
}
