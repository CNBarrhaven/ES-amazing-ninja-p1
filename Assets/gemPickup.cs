using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;

public class gemPickup : MonoBehaviour
{
    public GameObject HealthBar;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "gem")
        {
            HealthBar.GetComponent<LifeHUD>().HealPlayer();

        }
    }
}
