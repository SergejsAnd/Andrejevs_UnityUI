using UnityEngine;
using TMPro; // Nepiecieðams TextMeshPro elementiem
using System; // Nepiecieðams, lai iegûtu paðreizçjo gadu (DateTime)

public class NameScript : MonoBehaviour
{
    
    public TMP_InputField inputFieldName;
    public TMP_InputField inputFieldYear;
    public TMP_Text outputField;

    public void GetText()
    {
        string name = inputFieldName.text;

        string yearString = inputFieldYear.text;

        if (int.TryParse(yearString, out int birthYear))
        {
            int currentYear = DateTime.Now.Year; 
            int age = currentYear - birthYear;

            outputField.text = "Tçla vârds: " + name.ToUpper() + "\nVecums: " + age + " gadi";
        }
        else
        {
            outputField.text = "Lûdzu, ievadiet derîgu dzimðanas gadu!";
        }
    }
}
