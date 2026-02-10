
using UnityEngine;
using UnityEngine.EventSystems;

public class DragScript : MonoBehaviour, 
    IPointerDownHandler, IBeginDragHandler, IDragHandler,  IEndDragHandler {

    private RectTransform trans;
    public Canvas canvas;
    SFXScript sfxScript;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sfxScript = FindFirstObjectByType<SFXScript>();
        trans = GetComponent<RectTransform>();
    }
    public void OnPointerDown(PointerEventData data) {
        Debug.Log("Uzklikðíinâts uz velkamâ objekta");
        sfxScript.PlaySFX(0);
    }
    public void OnBeginDrag(PointerEventData data) {
        Debug.Log("Sâkta objekta vilkðana!");
    }
    public void OnDrag(PointerEventData data) {
        Debug.Log("Notiek vilkðana!");
        Vector2 mousePosition = data.position;
        mousePosition.x = Mathf.Clamp(mousePosition.x, 
            0 + trans.rect.width / 2, 
            Screen.width - trans.rect.width / 2);
        mousePosition.y = Mathf.Clamp(mousePosition.y,
           0 + trans.rect.height / 2,
           Screen.height - trans.rect.height / 2);
        trans.position = mousePosition;
    }
    public void OnEndDrag(PointerEventData data) {
        Debug.Log("Beigusies objekta vilkðana!");
    }


}
