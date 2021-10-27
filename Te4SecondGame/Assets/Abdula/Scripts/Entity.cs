using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity
{
    public string rotateInformation;
    public string movementInformation;
    public float rotationData;
    public Vector3 forward;
    public Entity nextEntity;
    public Entity previousEntity;
    public int uniquId;
    public Entity(string data, float rotatetData)
    {
        rotateInformation = data;
        rotationData = rotatetData;
        nextEntity = null;
        previousEntity = null;
        uniquId = 0;
    }
    public Entity(string data, Vector3 movementData)
    {
        movementInformation = data;
        forward = movementData;
        nextEntity = null;
        previousEntity = null;
        uniquId = 0;
    }
}
