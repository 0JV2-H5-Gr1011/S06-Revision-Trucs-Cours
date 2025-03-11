using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationMonnaiesBronze : MonoBehaviour
{

    [SerializeField] GameObject _prefabOriginal;

    void Start()
    {
        Vector3 _positionActuel = transform.position;
        Quaternion _rotation = transform.rotation;
        Instantiate(_prefabOriginal, _positionActuel, _rotation);
    }
}
