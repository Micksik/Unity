using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Start is called before the first frame update
public class Run : MonoBehaviour
{
    public int health = 5;
    public int lvl = 1;
    public float speed = 1.2f;

    void Start()
    {
        health += lvl;
        print("�������� " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}