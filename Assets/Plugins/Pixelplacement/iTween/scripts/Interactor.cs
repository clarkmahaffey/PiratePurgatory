using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour {

    [SerializeField] private float interactRange;

    private InteractiveObject interactiveObject;
    private Camera cam;
    private RaycastHit hit;
    //private ReticleController reticleController;

	void Start () {
        cam = Camera.main;
        //reticleController = GameObject.FindObjectOfType<ReticleController>();
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.E)) {

            Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, interactRange);
            if (hit.transform) {
                interactiveObject = hit.transform.GetComponent<InteractiveObject>();
            }

        //reticleController.ShowIcon(interactiveObject);

        
            if (interactiveObject) {
                interactiveObject.PerformAction();
            }
        }
    }
}