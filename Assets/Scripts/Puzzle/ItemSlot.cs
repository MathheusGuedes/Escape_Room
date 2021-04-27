using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    
    [SerializeField]
    private GameManager _gameManager;
    [SerializeField]
    private string Jewel;

    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {
            if(eventData.pointerDrag.tag == Jewel)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                _gameManager.pointsPuzzle2 ++;
                
                if(_gameManager.pointsPuzzle2 >= 3)
                {
                    _gameManager.AddPoint();
                    _gameManager.pointsPuzzle2 = 0;

                }
                eventData.pointerDrag.GetComponent<DragDrop>().enabled = false;
                eventData.pointerDrag.GetComponent<CanvasGroup>().alpha = 1f;
                
            }
            else{
                Vector3 pos = eventData.pointerDrag.GetComponent<DragDrop>().originalPos;
                eventData.pointerDrag.transform.position = new Vector3(pos.x, pos.y, pos.z);
            }
            
        }
    }


    
}
