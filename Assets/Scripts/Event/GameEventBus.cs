using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

namespace Event
{
    public class GameEventBus : MonoBehaviour
    {
        private static readonly IDictionary<GameEventType, UnityEvent> Events = new Dictionary<GameEventType, UnityEvent>();

        public static void Subscribe(GameEventType eventType, UnityAction listener)
        {
            UnityEvent thisEvent;

            if (Events.TryGetValue(eventType, out thisEvent))
            {
                thisEvent.AddListener(listener);
            }
            else
            {
                thisEvent = new UnityEvent();
                thisEvent.AddListener(listener);
                Events.Add(eventType, thisEvent);
            }
        }

        public static void Unsubscribe(GameEventType eventType, UnityAction listener)
        {
            UnityEvent thisEvent;

            if (Events.TryGetValue(eventType, out thisEvent))
            {
                thisEvent.RemoveListener(listener);
            }
        }

        public static void publish(GameEventType eventType)
        {
            UnityEvent thisEvent;

            if (Events.TryGetValue(eventType, out thisEvent))
            {
                thisEvent.Invoke();
            }
        }

    }
}

