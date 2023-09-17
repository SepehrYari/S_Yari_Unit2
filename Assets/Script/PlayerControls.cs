using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float HorizontalMovement;
    public float Speed = 10.0f;
    public float Xrange = 20.0f;
    public GameObject ProjectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMovement = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalMovement * Time.deltaTime * Speed);

        if (transform.position.x > Xrange)
        {
            transform.position = new Vector3(Xrange, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x < -Xrange)
        {
            transform.position = new Vector3(-Xrange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space bar was pressed");
            Instantiate(ProjectilePrefab, transform.position, ProjectilePrefab.transform.rotation);
        }



    }
}
