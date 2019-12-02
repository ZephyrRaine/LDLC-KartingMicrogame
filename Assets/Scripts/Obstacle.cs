using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        //On essaie de récupérer un composant Lives sur l'objet avec lequel on est rentré en collision
        Lives livesComponent = other.gameObject.GetComponent<Lives>();
        
        if(livesComponent != null)
        {
            //Si il y en a un, on appelle sa fonction TakeDamage 
            livesComponent.TakeDamage();
            //et on détruit l'obstacle
            Destroy(gameObject);
        }
    }
}
