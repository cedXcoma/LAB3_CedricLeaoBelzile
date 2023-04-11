using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionJeu : MonoBehaviour
{

    // Attributs
    private int _pointage;
    private float _tempsDepart = 0;
    private float _tempsFinal = 0;
    //private int _accrochageNiveau1 = 0;
    //private int _accrochageNiveau2 = 0;
    // private float _tempsNiveau1 = 0.0f;
    //private float _tempsNiveau2 = 0.0f;


    private void Awake()
    {
        int nbGestionJeu = FindObjectsOfType<GestionJeu>().Length;
        if (nbGestionJeu > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    private void Start()
    {

        _tempsDepart = Time.time;
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3 || SceneManager.GetActiveScene().buildIndex == 0)
        {
            Destroy(gameObject);
        }
    }
    // M�thodes publiques

    public void AugmenterPointage()
    {
        _pointage++;
        UIManager uiManager = FindObjectOfType<UIManager>();
        uiManager.ChangerPointage(_pointage);
    }
    public int GetPointage()
    {
        return _pointage;
    }

    public float GetTempsDepart()
    {
        return _tempsDepart;
    }

    public void SetTempsFinal(float p_tempFinal)
    {
        _tempsFinal = p_tempFinal - _tempsDepart;
    }

    public float GetTempsFinal()
    {
        return _tempsFinal;
    }

}
