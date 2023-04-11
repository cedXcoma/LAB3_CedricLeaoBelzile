using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    //Attributs
    [SerializeField] private float _vitesse = 450;
    [SerializeField] private float _poid = 300;
    private bool jouer;
    private bool isGround;
    private bool isStair;
    private float push = -2.0f;
    [SerializeField] private float rotationSpeed;
    private Rigidbody _rb;

    // Méthodes privées
    private void Start()
    {
       
        jouer = true;
        //Position de départ du joueur
        this.transform.position = new Vector3(53f, 1.3f, -51f);
        _rb = GetComponent<Rigidbody>();
        //_rb.useGravity= true;
    }

    private void FixedUpdate()
    {
    
        if (jouer)
        {
            if (isGround) 
            { MovementsJoueur();}
        }

    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isGround= true;
        }
        if (collision.gameObject.tag == "stair")
        {
            isGround = true;
            isStair = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {     
            isGround = false; 
            isStair= false;
    }

    private void MovementsJoueur()
    {

        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        direction.Normalize();
        Vector3 pushed;
        if(isStair)
        {
            pushed = new Vector3(0f, push, 0f);
            _rb.AddForce(_poid * pushed, ForceMode.Force);
        }
        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;
        direction.Normalize();

        //_rb.AddForce(direction * Time.fixedDeltaTime * _vitesse); Fait comme un effet de glisse , car on utilise des forces pour se mouvoir donc pour arreter faut envoyer plus de force de l'autre coté
   
      if(direction != Vector3.zero) 
        {
            transform.forward = direction;
        }

    
    }
    
    public void Arret()
    {
        jouer = false;
        if (!jouer)
        {
            Debug.Log("Vous avez terminé");
            // OU faire this.gameobject.setActive(false)
        }
    }
}
