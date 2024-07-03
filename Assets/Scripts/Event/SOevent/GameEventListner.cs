using UnityEngine;
using UnityEngine.Events;
using Chapter.EventBus;

public class GameEventListner : MonoBehaviour
{
    public EventSO EventSO;
    public UnityEvent response;

    private void OnEnable()
    {
        EventSO.RegisterListner(this);
    }

    private void OnDisable()
    {
        EventSO.UnregisterListner(this);
    }

    public void OnEventRaised()
    {
        response.Invoke();
    }
}