using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interrupteur : MonoBehaviour
{
    public GameObject mur;

    private void OnTriggerEnter(Collider other) {
        //Si l'autre objet avec lequel on rentre en collision s'appelle "Kart"
        if(other.gameObject.name == "Kart")
        {
            //On détruit l'objet contenu dans la variable "mur" et le gameObject sur lequel est attaché ce script
            Destroy(mur);
            Destroy(gameObject);
        }
    }
}
