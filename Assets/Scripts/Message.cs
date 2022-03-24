using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Message : MonoBehaviour
{
    public GameObject msj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Player"))
        {
            msj.gameObject.SetActive(true);
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == ("Player"))
        {
            msj.gameObject.SetActive(false);
        }
    }
    
}
