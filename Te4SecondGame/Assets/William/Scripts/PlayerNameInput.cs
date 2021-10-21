using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerNameInput : MonoBehaviour
{

    [Header("UI")]

    [SerializeField]
    private InputField inputFieldForPlayerName;

    [SerializeField]
    private Button confirmButton;

    //Kan h�mta v�rdet fr�n andra klasser
    //men kan bara ge den ett nytt v�rde inom denna klass
    public static string playerName { get; private set; }

    const string playerPrefsNameKey = "PlayerName";

    string nameCheck;
    int maxNameLength;

    private void Awake()
    {
        maxNameLength = 12;
        SetUp();
    }

    public void Update()
    {
        nameCheck = inputFieldForPlayerName.text;
        ActivateConfirmButton(nameCheck);
    }

    private void SetUp()
    {
        /*Kollar ifall det finns ett namn i PlayerPrefs
        Om det inte finns "Returnar" om det finns s� h�mtar vi namnet
        och placerar det i input f�ltet*/
        if (PlayerPrefs.HasKey(playerPrefsNameKey))
        {

            string tmpNameHolder = PlayerPrefs.GetString(playerPrefsNameKey);

            inputFieldForPlayerName.text = tmpNameHolder;

            
        }
    }

    //Kollar ifall namnet �r "valid", om det �r det s� kan man
    //klicka p� knappen som tar en vidare, �r det inte valid s� kan man ej g� vidare
    public void ActivateConfirmButton(string isNameValid)
    {

        confirmButton.interactable = !string.IsNullOrEmpty(isNameValid);

        confirmButton.interactable = isNameValid.Length <= maxNameLength;
    }

    //Sparar det nya namnet spelaren skrev in i player prefs
    //S� n�sta g�ng man �ppnar spelet s� har sitt senaste namn i input f�ltet
    public void SavePlayerName()
    {
        playerName = inputFieldForPlayerName.text;

        PlayerPrefs.SetString(playerPrefsNameKey, playerName);
    }
}
