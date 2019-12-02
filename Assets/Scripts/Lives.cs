using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lives : MonoBehaviour
{
    public int livesNumber;
    public TMP_Text textComponent;
    // Start is called before the first frame update
    void Start()
    {
        //On met le texte à jour pour afficher le nombre de vies
        textComponent.text = livesNumber.ToString();
    }

    public void TakeDamage()
    {
        //On enlève une vie
        livesNumber--;
        //On met le texte à jour
        textComponent.text = livesNumber.ToString();
    }
}
