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

    //Kan hämta värdet från andra klasser
    //men kan bara ge den ett nytt värde inom denna klass
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
        Om det inte finns "Returnar" om det finns så hämtar vi namnet
        och placerar det i input fältet*/
        if (PlayerPrefs.HasKey(playerPrefsNameKey))
        {

            string tmpNameHolder = PlayerPrefs.GetString(playerPrefsNameKey);

            inputFieldForPlayerName.text = tmpNameHolder;

            
        }
    }

    //Kollar ifall namnet är "valid", om det är det så kan man
    //klicka på knappen som tar en vidare, är det inte valid så kan man ej gå vidare
    public void ActivateConfirmButton(string isNameValid)
    {

        confirmButton.interactable = !string.IsNullOrEmpty(isNameValid);

        confirmButton.interactable = isNameValid.Length <= maxNameLength;
    }

    //Sparar det nya namnet spelaren skrev in i player prefs
    //Så nästa gång man öppnar spelet så har sitt senaste namn i input fältet
    public void SavePlayerName()
    {
        playerName = inputFieldForPlayerName.text;

        PlayerPrefs.SetString(playerPrefsNameKey, playerName);
    }
}
