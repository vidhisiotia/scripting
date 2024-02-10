using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lessontwo : MonoBehaviour
{
    //NPC health
    public int health = 10;
    //NPC level
    public int level = 1;
    //NPC speed
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        // adding health and level
        level += health;
        // printing health
        print(level);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
