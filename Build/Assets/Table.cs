using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Table : MonoBehaviour
{
    public GameObject label;
    // Start is called before the first frame update
    void Start()
    {
        label.GetComponent<Text>().text = "Score: " + Save.score.ToString();
    }

}
