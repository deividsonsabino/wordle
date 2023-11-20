using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Menu : MonoBehaviour
{
    public static string language;
    public AudioClip sound;
    public AudioSource audioSource;

    public Button defaultLanguage;
    // Start is called before the first frame update
    void Start()
    {
        defaultLanguage.Select();
    }

    public void SetLanguage(Button button)
    {
        language = button.name;
    }

    public void MenuSoundeEffect()
    {
        audioSource.PlayOneShot(sound);
    }
}
