using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starspawner : MonoBehaviour
{
    public Vector3 Min1;
    public Vector3 Max1;
    public Vector3 Min2;
    public Vector3 Max2;
    public Vector3 Min3;
    public Vector3 Max3;
    public Vector3 Min4;
    public Vector3 Max4;

    public float _xAxis1;
    public float _yAxis1;
    public float _zAxis1;
    public float _xAxis2;
    public float _yAxis2;
    public float _zAxis2;
    public float _xAxis3;
    public float _yAxis3;
    public float _zAxis3;
    public float _xAxis4;
    public float _yAxis4;
    public float _zAxis4;

    public Vector3 _randomPosition1;
    public Vector3 _randomPosition2;
    public Vector3 _randomPosition3;
    public Vector3 _randomPosition4;

    public bool _canInstantiate;

    public GameObject star1;
    public GameObject star2;

    //public GameObject star;

    void Start()
    {
        SetRanges();
       // InvokeRepeating("InstantiateRandomObjects", 1f, 2f);
    }
     void Update()
    {
        _xAxis1 = UnityEngine.Random.Range(Min1.x, Max1.x);
        _yAxis1 = UnityEngine.Random.Range(Min1.y, Max1.y);
        _zAxis1 = UnityEngine.Random.Range(Min1.z, Max1.z);
        _randomPosition1 = new Vector3(_xAxis1, _yAxis1, _zAxis1);


        _xAxis2 = UnityEngine.Random.Range(Min2.x, Max2.x);
        _yAxis2 = UnityEngine.Random.Range(Min2.y, Max2.y);
        _zAxis2 = UnityEngine.Random.Range(Min2.z, Max2.z);
        _randomPosition2 = new Vector3(_xAxis2, _yAxis2, _zAxis2);

        _xAxis3 = UnityEngine.Random.Range(Min3.x, Max3.x);
        _yAxis3 = UnityEngine.Random.Range(Min3.y, Max3.y);
        _zAxis3 = UnityEngine.Random.Range(Min3.z, Max3.z);
        _randomPosition3 = new Vector3(_xAxis3, _yAxis3, _zAxis3);

        _xAxis4 = UnityEngine.Random.Range(Min4.x, Max4.x);
        _yAxis4 = UnityEngine.Random.Range(Min4.y, Max4.y);
        _zAxis4 = UnityEngine.Random.Range(Min4.z, Max4.z);
        _randomPosition4 = new Vector3(_xAxis4, _yAxis4, _zAxis4);

    }
    //Here put the ranges where your object will appear, or put it in the inspector.
     void SetRanges()
    {
        Min1 = new Vector3(1000, 500, -500); //Random value.
        Max1 = new Vector3(1000, 1000, 500); 

        Min2 = new Vector3(-1000, 500, -500);
        Max2 = new Vector3(-1000, 1000, 500);

        Min3 = new Vector3(-500, 500, -1000);
        Max3 = new Vector3(500, 1000, -1000);

        Min4 = new Vector3(-500, 500, 1000);
        Max4 = new Vector3(500, 1000, 1000);
    }
     void InstantiateRandomObjects()
    {
        if (_canInstantiate)
        {
            Instantiate(star1, _randomPosition1, Quaternion.identity);
            Instantiate(star1, _randomPosition2, Quaternion.identity);
            Instantiate(star2, _randomPosition3, Quaternion.identity);
            Instantiate(star2, _randomPosition4, Quaternion.identity);
        }



    }

    public void startInvoke()
    {
        InvokeRepeating("InstantiateRandomObjects", 1f, 2f);
    }

    public void stopInvoke()
    {
        CancelInvoke();
    }
}

