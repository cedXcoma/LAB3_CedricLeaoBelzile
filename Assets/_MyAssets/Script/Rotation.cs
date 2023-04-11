using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    [SerializeField] private float _vitesseRotationY = 0.5f;

    void Update()
    {
        this.transform.Rotate(0f, _vitesseRotationY, 0f);
    }
}
