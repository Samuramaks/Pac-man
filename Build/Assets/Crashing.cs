using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Crashing : MonoBehaviour
{
    public AudioSource source;
    public Transform warrior;
    private int h = 3;
    public GameObject  label2;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            source = GetComponent<AudioSource>();
            source.Play();
            Health();
            other.gameObject.transform.position = new Vector3((float)-16.36, (float)-1.95, (float)-1.15);
            warrior.position = new Vector3((float)-27.09, (float)-1.25, (float)7.33);

        }
    }
    private void Health()
    {
        h--;
        label2.GetComponent<Text>().text = "Health: " + h.ToString();
        if (h == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
