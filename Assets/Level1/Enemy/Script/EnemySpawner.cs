using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTimer());
    }

    private IEnumerator SpawnTimer(){
        yield return new WaitForSeconds(2f);
        Instantiate(enemy, transform.position,
            Quaternion.Euler(new Vector3(0f, 0f, 0f)));
        StartCoroutine(SpawnTimer());
    }

}
