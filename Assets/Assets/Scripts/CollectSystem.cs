using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSystem : MonoBehaviour
{
    
     private void OnTriggerEnter(Collider other)
    {
        ScoreSystem.theScore += 1;
        Destroy(gameObject);
    }
}
