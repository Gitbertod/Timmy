using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject MenuPause;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CargaEscena() 
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
    }
    
    public void CargaMenu() 
    {
        SceneManager.LoadScene("Menu2");
        Time.timeScale = 1f;
    } 

    public void Continuar() 
    {
        MenuPause.SetActive(false);
        Time.timeScale = 1f;
        

    }
     public void CargaNivel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void salirJuego() 
    {
        Application.Quit();
    }
}

