using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDrag : MonoBehaviour,IDragHandler,IEndDragHandler
{
  

    void Start()
    {
       
    }


    public void OnDrag(PointerEventData eventData)
    {
      
        transform.position = Input.mousePosition;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.localPosition = Vector3.zero;
     
        //transform.localPosition = PositionAtual;
    }


    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
