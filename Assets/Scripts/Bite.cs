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
        // SprawdŸ, czy obiekt zderzaj¹cy siê ma tag "Player" (lub u¿yj innej metody identyfikacji gracza)
        if (other.CompareTag("Player"))
        {

            EndGame();
        }
    }
    void EndGame()
    {
        // Wypisz komunikat na konsoli (mo¿esz tak¿e u¿yæ UI, aby wyœwietliæ komunikat na ekranie)
        Debug.Log("Wilk zjad³ gracza!");
        //Komunikat
        textHints.SendMessage("ShowHint", "YOU DIED!");
        // Przywróæ do sceny "Menu" po pewnym opóŸnieniu (mo¿esz dostosowaæ czas)
        Invoke("LoadMenuScene", 2.0f);
    }

    // Metoda do za³adowania sceny "Menu"
    void LoadMenuScene()
    {

        SceneManager.LoadScene("Menu");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
