using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private GameManager gameManager;

    public static string language;

    public Button defaultLanguage;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GetComponent<GameManager>();
        defaultLanguage.Select();
    }

    public void SetLanguage(Button button)
    {
        language = button.name;
    }
}
