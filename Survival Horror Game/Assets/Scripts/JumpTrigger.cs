using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour {

    public GameObject monster;
    public AudioSource slam;
    public AudioSource jumpAudio;
    public GameObject door;

    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        door.GetComponent<Animation>().Play("JumpDoorAnim");
        slam.Play();
        monster.SetActive(true);
        StartCoroutine(PlayJumpAudio());
    }

    IEnumerator PlayJumpAudio()
    {
        yield return new WaitForSeconds(0.4f);
        jumpAudio.Play();
    }
}
