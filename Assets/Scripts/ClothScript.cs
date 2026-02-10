using UnityEngine.UI;
using TMPro;
using UnityEngine;


public class ClothScript : MonoBehaviour
{
    public Toggle ShoesToggle;
    public Toggle TrousersToggle;
    public Toggle ShirtsToggle;

    public GameObject Shoes1Image;
    public GameObject Shoes2Image;
    public GameObject Shoes3Image;

    public GameObject Trousers1Image;
    public GameObject Trousers2Image;
    public GameObject Trousers3Image;

    public GameObject Shirts1Image;
    public GameObject Shirts2Image;
    public GameObject Shirts3Image;

    void Start()
    {
        // Initial states
        ShoesToggleChanged(ShoesToggle.isOn);
        TrousersToggleChanged(TrousersToggle.isOn);
        ShirtsToggleChanged(ShirtsToggle.isOn);

        // Add listeners
        ShoesToggle.onValueChanged.AddListener(ShoesToggleChanged);
        TrousersToggle.onValueChanged.AddListener(TrousersToggleChanged);
        ShirtsToggle.onValueChanged.AddListener(ShirtsToggleChanged);
    }

    public void ShoesToggleChanged(bool isOn)
    {
        Shoes1Image.SetActive(isOn);
        Shoes2Image.SetActive(isOn);
        Shoes3Image.SetActive(isOn);
    }

    public void TrousersToggleChanged(bool isOn)
    {
        Trousers1Image.SetActive(isOn);
        Trousers2Image.SetActive(isOn);
        Trousers3Image.SetActive(isOn);
    }

    public void ShirtsToggleChanged(bool isOn)
    {
        Shirts1Image.SetActive(isOn);
        Shirts2Image.SetActive(isOn);
        Shirts3Image.SetActive(isOn);
    }
}
