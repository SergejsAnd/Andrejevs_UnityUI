using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NameScript : MonoBehaviour
{
    //izveido mainîgo
    private string text;
    
    // izveido masîvu ar tekstu
    private string[] sampleText = {"Hello", "Have a nice day", "Nive to see you",
    "Look what's here", "Goodbye"};
   
    // izveido mainîgo randomIx
    int randomIx;
   
    // izveido saites uz UI elementiem
    public GameObject inputField;
    public GameObject outputField;
    public GameObject reverseTextToggle;

    // izveido metodi/funkciju, kas tiek izsaukta, nospieþot pogu
    public void GetText() {
        randomIx = Random.Range(0, sampleText.Length);
        text = inputField.GetComponent<TMP_InputField>().text;
        outputField.GetComponent<TMP_Text>().text = sampleText[randomIx] + " " + text.ToUpper() +"!";

        // padara toggle interaktîvu
        reverseTextToggle.GetComponent<Toggle>().interactable = true;

        if(reverseTextToggle.GetComponent<Toggle>().isOn) {
            ReverseText();
        }
    }
    public void ReverseText() {
        char[] charArray = outputField.GetComponent<TMP_Text>().text.ToCharArray();
        System.Array.Reverse(charArray);
        outputField.GetComponent<TMP_Text>().text = new string(charArray);
    }
}
