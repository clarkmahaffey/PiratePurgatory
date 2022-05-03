using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Canvas : MonoBehaviour {
    public GameObject button1;
    public GameObject text1;
    public GameObject button2;
    public GameObject text2;
    public GameObject quit;
    public GameObject camera;
    public bool read;
 
 void Start ()
 {
       button1.SetActive (true);
       text1.SetActive (true);
       button2.SetActive (false);
       text2.SetActive (false);
       quit.SetActive(false);
       read = false;
 }
 
 void Update()
 {
     
     if (read == true) {
         if (Input.GetKeyDown (KeyCode.X)) {
       button2.SetActive (false);
       text2.SetActive (false);
     }
     } else {
         if (Input.GetKeyDown (KeyCode.X)) {
         read = true;
       button1.SetActive (false);
       text1.SetActive (false);
      button2.SetActive (true);
       text2.SetActive (true);
     }
     }
     if (camera.activeSelf == true) {
         quit.SetActive(true);
     }
 }
}