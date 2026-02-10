using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ActorChange : MonoBehaviour
{
    public GameObject imageField;
    public Sprite[] sprites;

    public void ChangeSprite(int val){
        imageField.GetComponent<Image>().sprite = sprites[val];
    }

  }
