using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bite : MonoBehaviour
{
    public Text textHints;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        // Sprawd�, czy obiekt zderzaj�cy si� ma tag "Player" (lub u�yj innej metody identyfikacji gracza)
        if (other.CompareTag("Player"))
        {

            EndGame();
        }
    }
    void EndGame()
    {
        // Wypisz komunikat na konsoli (mo�esz tak�e u�y� UI, aby wy�wietli� komunikat na ekranie)
        Debug.Log("Wilk zjad� gracza!");
        //Komunikat
        textHints.SendMessage("ShowHint", "YOU DIED!");
        // Przywr�� do sceny "Menu" po pewnym op�nieniu (mo�esz dostosowa� czas)
        Invoke("LoadMenuScene", 2.0f);
    }

    // Metoda do za�adowania sceny "Menu"
    void LoadMenuScene()
    {

        SceneManager.LoadScene("Menu");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
