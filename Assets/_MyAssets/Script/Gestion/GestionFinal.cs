using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionFinal : MonoBehaviour
{
    private Joueur _gestionJoueur;
    private GestionJeu _gestionJeu;


    private void Start()
    {
        _gestionJoueur = FindObjectOfType<Joueur>();
        _gestionJeu = FindObjectOfType<GestionJeu>();
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            int indexScene = SceneManager.GetActiveScene().buildIndex;

            if (indexScene == 2)
            {
                int erreurs = _gestionJeu.GetPointage();
                int _accrochagesNiveau1 = _gestionJeu.GetAccrochageNiv1();

               float _tempsNiveau1 = _gestionJeu.GetTempsNiv1();             
               float _tempsNiveau2 = _gestionJeu.GetTempsNiv2();
               float _tempsNiveau3 = Time.time - _tempsNiveau2-_tempsNiveau1;

                int _accrochagesNiveau2 = _gestionJeu.GetAccrochageNiv2();
                int _accrochagesNiveau3 = erreurs - (_accrochagesNiveau2+_accrochagesNiveau1);

                float _tempsTotalNiv2 = _tempsNiveau2 + _accrochagesNiveau2;
                float _tempsTotalNiv3 = _tempsNiveau3 + _accrochagesNiveau3;
                float tempsTotalniv1 = _tempsNiveau1 + _accrochagesNiveau1;

                Debug.Log("Vous avez terminé!");

                Debug.Log("Le temps pour le niveau 1 est de : " + _tempsNiveau1.ToString("f2") + " secondes");
                Debug.Log("Obstacles accroché au niveau 1 : " + _accrochagesNiveau1);
                Debug.Log("Temps total pour niveau 1 : " + tempsTotalniv1.ToString("f2"));

                Debug.Log("Le temps pour le niveau 2 est de : " + _tempsNiveau2.ToString("f2") + "secondes");
                Debug.Log("Obstacles accroché au niveau 2 : " + _accrochagesNiveau2);
                Debug.Log("Temps total pour niveau 2 : " + _tempsTotalNiv2.ToString("f2"));

                Debug.Log("Le temps pour le niveau 3 est de : " + _tempsNiveau3.ToString("f2") + "secondes");
                Debug.Log("Obstacles accroché au niveau 3 : " + _accrochagesNiveau3);
                Debug.Log("Temps total pour niveau 3 : " + _tempsTotalNiv3.ToString("f2"));

                
                Debug.Log("Temps total pour les trois niveaux est de : " + (tempsTotalniv1 + _tempsTotalNiv2 + _tempsTotalNiv3).ToString("f2"));

                _gestionJoueur.Arret();
            }
            else if (indexScene==0)
            {
                //Charger la scene suivante
                _gestionJeu.SetNiveau1(_gestionJeu.GetPointage(), Time.time);
                SceneManager.LoadScene(indexScene + 1);
            }
            else if (indexScene==1)
            {
                //Charger la scene suivante
                _gestionJeu.SetNiveau2(_gestionJeu.GetPointage(), Time.time);
                SceneManager.LoadScene(indexScene + 1);
            }
    */

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")  
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;  
            int noScene = SceneManager.GetActiveScene().buildIndex; 
            if (noScene == (SceneManager.sceneCountInBuildSettings - 2)) 
            {
                _gestionJeu.SetTempsFinal(Time.time);
                SceneManager.LoadScene(noScene + 1);
            }
            else
            {
            
                SceneManager.LoadScene(noScene + 1);
            }
        }
    }

}

