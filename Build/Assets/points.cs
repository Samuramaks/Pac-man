using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class points : MonoBehaviour
{
    private int i = 0;
    public GameObject label1;
    public AudioSource audioSource1;
    public GameObject point;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(point);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Respawn")
        {
            other.gameObject.transform.position = new Vector3(Random.Range((float)-28.48, (float) -9.77), (float)-1.93, Random.Range((float)10.6, -8));
            Counter();
            Fruit();


        }
    }
    

    private void Counter()
    {
        i++;
        label1.GetComponent<Text>().text = "Score: " + i.ToString();
        Save.score = i;
    }
    
    private void Fruit()
    {
        audioSource1 = GetComponent<AudioSource>();
        audioSource1.Play();
    }
}
