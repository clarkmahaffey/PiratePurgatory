using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnimText : MonoBehaviour {
    public GameObject button1;
    public GameObject text1;
    public bool pickedUpPaper;
    public bool inPaper1Trigger;
 
 void Start ()
 {
       pickedUpPaper = false;
       button1.SetActive (false);
       text1.SetActive (false);
       inPaper1Trigger = false;
 }

     public void OnTriggerEnter(Collider other) {
         button1.SetActive(true);
         text1.SetActive (true);
     }
    
     public void OnTriggerExit(Collider other) 
     {
         button1.SetActive(false);
         text1.SetActive (false);
     }

}