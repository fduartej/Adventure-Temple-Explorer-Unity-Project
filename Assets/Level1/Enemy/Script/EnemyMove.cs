using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    

    void Start()
    {
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =
            new Vector3(
            transform.position.x - (10f * Time.deltaTime),
            transform.position.y, 
            transform.position.z);
    }



}
