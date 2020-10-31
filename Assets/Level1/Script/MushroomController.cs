using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomController : MonoBehaviour
{
    public CounterManager counter;

    private void OnTriggerEnter2D(Collider2D other) {
         if(other.CompareTag("Player")){
            counter.addMushroom();
            Destroy(this.gameObject);
         }
    }
}