using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movements : MonoBehaviour
{
    public float speed = 3f;
    public float speedRotation = 60;
    public static float horizontal;
    public GameObject player;
    // Start is called before the first frame update

    void Start()
    {
        player = (GameObject)this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            player.transform.position += player.transform.forward * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            player.transform.position -= player.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            horizontal = Input.GetAxis("Horizontal") * speedRotation * Time.deltaTime;
            player.transform.Rotate(0, horizontal, 0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            horizontal = Input.GetAxis("Horizontal") * speedRotation * Time.deltaTime;
            player.transform.Rotate(0, horizontal, 0);
        }

    }
}
