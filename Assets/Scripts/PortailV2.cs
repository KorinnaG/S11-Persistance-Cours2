using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortailV2 : MonoBehaviour
{
    public int indexSceneACharger;

    [SerializeField] GameObject audio;

    private void OnTriggerEnter2D(Collider2D autre)
    {
        if (autre.CompareTag("Joueur"))
        {
            JeuEspaceV2.instance.ChangerScene(indexSceneACharger);
        }


    }

}
