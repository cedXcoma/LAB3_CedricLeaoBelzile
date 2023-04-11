using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    private GestionJeu _gestionJeu;
    private bool _toucher;

    private void Start()
    {
       _gestionJeu = FindObjectOfType<GestionJeu>();
        _toucher = false;
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && !_toucher)
        {

            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            _gestionJeu.AugmenterPointage();
            _toucher = true;

        }
    }
}
