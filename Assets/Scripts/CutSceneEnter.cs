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
    [SerializeField] private Animator Ghost;
    [SerializeField] private string GhostMove = "Ascend";

    void OnTriggerEnter(Collider other)
    {
        cutsceneCam.SetActive(true);
        thePlayer.SetActive(false);
        little_ghost.SetActive(true);
        Ghost.Play(GhostMove, 0, 0.0f);
        source.Play();
    }
}