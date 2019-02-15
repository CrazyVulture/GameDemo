﻿using System.Collections;
using UnityEngine;

public abstract class BaseSpawner : MonoBehaviour
{
    //Spawn target Obj
    public GameObject spawnObject;

    //Spawn target transform
    public Vector3 spawnValues;
    protected Vector3 spawnPosition;
    protected Quaternion spawnRotation;

    //Spawn target time interval
    public float spawnInterval;

}
