using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpWepon : MonoBehaviour {

    public float distance;
    public GameObject display;
    public GameObject Weapon;
    public GameObject hoverText;
    public GameObject realWeapon;
    public GameObject arrow;
    public GameObject jumptrigger;

    void Update ()
    {
        distance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if(distance <= 2)
        {
            hoverText.GetComponent<Text>().text = "Pick up Pistol";
            display.SetActive(true);
            hoverText.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (distance <= 2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                display.SetActive(false);
                hoverText.SetActive(false);
                Weapon.SetActive(false);
                realWeapon.SetActive(true);
                jumptrigger.SetActive(true);
            }
        }

    }

    private void OnMouseExit()
    {
        display.SetActive(false);
        hoverText.SetActive(false);
    }

}
