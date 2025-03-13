using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChampignon : MonoBehaviour
{

    [SerializeField] private GameObject _positionChampignon;
    [SerializeField] private Vector3 _positionA;
        [SerializeField] private Vector3 _positionB;
    void Start()
    {

        float randomPosition = Random.value;

        if(randomPosition <= 0.5f)
        {
            _positionChampignon.transform.position = _positionA;
        }
        else
        {
            _positionChampignon.transform.position = _positionB;
        }
    }
}
