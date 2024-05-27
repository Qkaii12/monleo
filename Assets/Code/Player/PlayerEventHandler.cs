using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerEventHandler : MonoBehaviour
{
    public string characterName;
    public void OnPointerClick(BaseEventData eventData)
    {
        Debug.Log(characterName + "clicked: " + gameObject.name);
    }

    public void OnPointEnter(BaseEventData eventData)
    {
        Debug.Log("Pointer entered: " + characterName);
    }
    public void OnPointerExit(BaseEventData eventData)
    {
        Debug.Log("Pointer exited: " + characterName);  
    }

}
