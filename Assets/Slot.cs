using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        cleanSlot();

        DragHandler.itemBeingDragged.transform.SetParent(transform);
    }

    public void cleanSlot()
    {
        if (transform.childCount > 0)
        {
            GameObject token = transform.GetChild(0).gameObject;
            GameObject.Destroy(token);
        }
    }
}
