using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CapsuleCollector : MonoBehaviour
{
    public int contador;
    public TMP_Text score;

    public void Awake()
    {
        contador = 0;
        score.text = "Capsulas: " + contador;
    }

    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Capsula")
        {
            Debug.Log("Capsula recogido");
            contador = contador + 1;
            score.text = "Capsulas: " + contador;
            Col.gameObject.SetActive(false);
            Destroy(Col.gameObject);
        }
    }
}
