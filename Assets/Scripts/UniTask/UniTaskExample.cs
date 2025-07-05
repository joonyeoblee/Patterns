using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System;
using System.Threading;  // 스레딩 관련 네임스페이스

public class UniTaskExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 비동기 작업을 실행
        SomeHeavyTask().Forget();  // UniTaskVoid는 Forget()을 호출하여 실행합니다.
    }

    // 비동기 작업 정의
    async UniTaskVoid SomeHeavyTask()
    {
        Debug.Log("Heavy task started on background thread.");

        // 백그라운드 스레드에서 무거운 작업 수행
        await UniTask.RunOnThreadPool(() =>
        {
            // 현재 스레드가 메인 스레드인지 확인
            Debug.Log($"Is main thread: {Thread.CurrentThread.IsBackground}");

            // 백그라운드 스레드에서 실행될 무거운 작업
            DoHeavyCalculation();
        });

        // 메인 스레드로 돌아와 후속 작업 실행
        UpdateUI();
    }

    private void UpdateUI()
    {
        // 메인 스레드에서 UI 업데이트 로직
        Debug.Log("UI updated on main thread.");
    }

    private void DoHeavyCalculation()
    {
        // CPU 집약적인 계산 작업 시뮬레이션
        for (int i = 0; i < 100000000; i++)
        {
            // 무거운 계산 처리 중...
        }
        Debug.Log("Heavy calculation completed.");
    }
}
