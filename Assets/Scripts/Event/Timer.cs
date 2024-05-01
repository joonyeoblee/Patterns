using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Event
{
    public class Timer : MonoBehaviour
    {
        private float _currentTime;
        public float duration = 3.0f;

        void OnEnable()
        {
            GameEventBus.Subscribe(GameEventType.COUNTDOWN, StartTimer);
        }

        void OnDisable()
        {
            GameEventBus.Unsubscribe(GameEventType.COUNTDOWN, StartTimer);
        }

        void StartTimer()
        {
            StartCoroutine(Countdown());
        }

        IEnumerator Countdown()
        {
            _currentTime = duration;
            while (_currentTime > 0)
            {
                yield return new WaitForSeconds(1.0f);
                _currentTime--;
            }
            GameEventBus.publish(GameEventType.START);
        }

        void Update()
        {
            Debug.Log("COUNTDOWN: " + _currentTime);
        }
    }
}
