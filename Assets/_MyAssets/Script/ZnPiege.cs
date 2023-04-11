using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ZnPiege : MonoBehaviour
{

    private bool _estActive = false;
    // [SerializeField]private GameObject _piege = default;
    [SerializeField] private List<GameObject> _listePieges = new List<GameObject>();
    private List<Rigidbody> _listeRb = new List<Rigidbody>();
    [SerializeField] private float _force = 500;
    // private Rigidbody _rb;
    private void Start()
    {
        foreach (var piege in _listePieges)
        {
            _listeRb.Add(piege.GetComponent<Rigidbody>());
        }

        //  _rb.useGravity = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !_estActive)
        {
            foreach (var rb in _listeRb)
            {
                rb.useGravity = true;
                rb.AddForce(Vector3.down * _force);
                //Vector3 direction = new Vector3(0f,-1f, 0f);
            }

            _estActive = true;
        }

    }
}
