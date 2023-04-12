using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AffichageFinal : MonoBehaviour
{   
    private GestionJeu _gestionJeu;
    [SerializeField] private TMP_Text _txtTempsTotal = default;
    [SerializeField] private TMP_Text _txtAccorchagesTotal = default;
    [SerializeField] private TMP_Text _txtPointageTotal = default;
    

    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();

        _txtTempsTotal.text = "Temps Total : " + _gestionJeu.GetTempsFinal().ToString("f2") + " sec.";

        _txtAccorchagesTotal.text = "Nombres d'accrochages : " + _gestionJeu.GetPointage().ToString();

        float pointageTotal = _gestionJeu.GetTempsFinal() + _gestionJeu.GetPointage();

        _txtPointageTotal.text = "Pointage Final : " + pointageTotal.ToString("f2") + " sec.";
    }
}
