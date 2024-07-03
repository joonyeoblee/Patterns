using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EventSO", menuName = "EventSO")]
public class EventSO : ScriptableObject
{
    private List<GameEventListner> listners = new List<GameEventListner>();

    public void Raise()
    {
        for (int i = listners.Count - 1; i >= 0; i--)
        {
            listners[i].OnEventRaised();
        }
    }

    public void RegisterListner(GameEventListner listner)
    {
        listners.Add(listner);
    }

    public void UnregisterListner(GameEventListner listner)
    {
        listners.Remove(listner);
    }
}
