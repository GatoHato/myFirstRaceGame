using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarReset : MonoBehaviour
{
    public Transform[] safePoints;
  

    void ResetCar()
    {
        // first, find the closest safe place
        Transform closestTransform;
        float closestDistance = 9999999999;
        Vector3 currentPos = transform.position;
        // This goes through every possible safe place and picks the best one
        foreach (Transform trans in safePoints)
        {
            float currentDistance = Vector3.Distance(currentPos, trans.position);
            if (currentDistance < closestDistance)
            {
                closestDistance = currentDistance;
                closestTransform = trans;
            }
            
          

        
        }
    

    }

}
