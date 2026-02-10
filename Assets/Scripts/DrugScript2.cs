using UnityEngine;
using UnityEngine.EventSystems;

public class DragScript2 : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    // These lines "introduce" the variables so the rest of the script knows what they are
    private RectTransform trans;
    private Canvas canvas;
    private SFXScript sfxScript;

    void Start()
    {
        trans = GetComponent<RectTransform>();
        sfxScript = FindFirstObjectByType<SFXScript>();

        // Automatically find the canvas in the parent hierarchy
        canvas = GetComponentInParent<Canvas>();
    }

    public void OnPointerDown(PointerEventData data)
    {
        if (sfxScript != null) sfxScript.PlaySFX(0);
        Debug.Log("Clicked on item");
    }

    public void OnBeginDrag(PointerEventData data)
    {
        // Bring the item to the front while dragging
        trans.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData data)
    {
        // delta is the movement of the mouse since the last frame.
        // We divide by canvas scale factor to match the UI movement speed.
        trans.anchoredPosition += data.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData data)
    {
        Debug.Log("Finished dragging");
    }
}