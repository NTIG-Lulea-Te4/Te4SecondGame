using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EntityManager : MonoBehaviour
{
    private static Entity lastEntity;
    public static Entity firstEntity;
    static int counter;
    Moevment moevment = new Moevment();
    
    public EntityManager()
    {
        lastEntity = null;
        firstEntity = null;
        counter = 0;
       
    }
    public static void AddAtTheEnd(Entity addToEntity)
    {
        counter ++;
        addToEntity.uniquId = counter;
        if (firstEntity == null)
        {
            firstEntity = addToEntity;
        }
        else
        {
            lastEntity.nextEntity = addToEntity;
            addToEntity.previousEntity = lastEntity;
        }
        lastEntity = addToEntity;

    }

    public static void RemoveEntityRotation(Entity tempEntity)
    {
        Entity tem = firstEntity;
        while (tem != null)
        {
            if (tem.nextEntity.rotationData == tempEntity.rotationData)
            {
                tem.nextEntity = tem.nextEntity.nextEntity;
            }
            else if (tem.rotationData == tempEntity.rotationData)
            {
                tem = tem.nextEntity;
            }
            tem = tem.nextEntity;
        }
    }

    public static void Print()
    {
        Entity tempEntity = lastEntity;
        while (tempEntity != null)
        {
            Debug.Log(tempEntity.movementInformation);
            Debug.Log(tempEntity.forward);

            Debug.Log(tempEntity.rotateInformation);
            Debug.Log(tempEntity.rotationData);


            tempEntity = tempEntity.previousEntity;
        }
    }
    public static void Update()
    {
        Entity tempEntity = lastEntity;
        while (tempEntity != null)
        {
            if (tempEntity.movementInformation == "MovedForward")
            {
                
            }
        }
    }
}
