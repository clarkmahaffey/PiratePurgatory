using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneEnter : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutsceneCam;
    public GameObject little_ghost;
    public AudioSource source;
    public AudioClip clip;
    public CanvasGroup fade;
    public bool inCutscene;
    [SerializeField] private Animator Ghost;
    [SerializeField] private string GhostMove = "Ascend";
    public int timer;
    
    void Start() {
     fade.alpha = 0;
     inCutscene = false;
     timer = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        inCutscene = true;
        cutsceneCam.SetActive(true);
        thePlayer.SetActive(false);
        little_ghost.SetActive(true);
        Ghost.Play(GhostMove, 0, 0.0f);
        source.Play();
        fade.alpha = 0.005f;
    }
    
    void Update() {
        if (inCutscene) {
            timer++;
            if (timer > 120) {
                fade.alpha += 0.01f;
            }
        }
    }
}