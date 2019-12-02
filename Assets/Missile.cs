using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    //Vitesse par seconde
    public float speed;
    private void FixedUpdate() 
    {
        //On fait avancer le missile de speed/par seconde en fonction du forward de l'objet (vers l'avant)
        transform.position += transform.forward * Time.deltaTime * speed;        
    }

    private void OnCollisionEnter(Collision other) 
    {
        //Si on tire sur un obstacle ou sur un mur
        if(other.gameObject.GetComponent<Obstacle>() != null || other.gameObject.name.Contains("Mur"))
        {
            //On le détruit
            Destroy(other.gameObject);
        }

        //On détruit le missile à la moindre collision
        Destroy(gameObject);
    }
}
