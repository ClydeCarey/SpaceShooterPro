using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move down 4m/s
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        //respawn at the top if it hits bottom
        if(transform.position.y <-5.0f)
        {
            float randomX = Random.Range(-8.0f, 8.0f);
            transform.position = new Vector3(randomX, 7, 0);
        }
        //respan at top with noe wrandom position
    }
}
