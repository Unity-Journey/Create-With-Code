using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 30.0f;
    public float horizontalMovement;
    public GameObject foodPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * horizontalMovement * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodPrefab, transform.position, foodPrefab.transform.rotation);
        }
    }
}
