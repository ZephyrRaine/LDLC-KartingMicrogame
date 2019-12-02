using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    //Lien vers le Prefab de l'obstacle à faire apparaître
    public GameObject obstaclePrefab;

    public GameObject missilePrefab;

    void Update()
    {
        //Lorsqu'on appuie sur la touche P
        if(Input.GetKeyDown(KeyCode.P))
        {
            //On crée un clone de "obstaclePrefab" dans la scène, un peu derrière le kart, avec la même rotation
            Instantiate(obstaclePrefab, transform.position - transform.forward * 3f, transform.rotation);
        }        

        //Lorsqu'on appuie sur la touche M
        if(Input.GetKeyDown(KeyCode.M))
        {
            //On crée un clone de "missilePrefab" dans la scène, un peu devant le kart, avec la même rotation
            Instantiate(missilePrefab, transform.position + transform.forward * 3f, transform.rotation);
        }        
    }
}
