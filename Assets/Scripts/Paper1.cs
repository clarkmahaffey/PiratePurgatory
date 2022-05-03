using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Paper1 : MonoBehaviour {
    public GameObject button1;
    public GameObject text1;
    public GameObject button2;
    public GameObject text2;
    public bool pickedUpPaper;
    public bool inPaper1Trigger;
 
 void Start ()
 {
       pickedUpPaper = false;
       button1.SetActive (false);
       text1.SetActive (false);
       button2.SetActive (false);
       text2.SetActive (false);
       inPaper1Trigger = false;
 }

     public void OnTriggerEnter(Collider other) {
         inPaper1Trigger = true;
     }
    
    void Update ()
 {
        if (inPaper1Trigger == true) {
            //if (pickedUpPaper == false){
             button1.SetActive(true);
             text1.SetActive (true);
            if (Input.GetKeyDown (KeyCode.R)) {
                button1.SetActive (false);
                text1.SetActive (false);
                button2.SetActive (true);
                text2.SetActive (true);
                pickedUpPaper = true;
            }
         //}
        }
        if (pickedUpPaper == true) {
            if (Input.GetKeyDown (KeyCode.X)) {
                button2.SetActive (false);
                text2.SetActive (false);
            }
        }
 }
     public void OnTriggerExit(Collider other) 
     {
         inPaper1Trigger = false;
         button1.SetActive(false);
         text1.SetActive (false);
     }

}