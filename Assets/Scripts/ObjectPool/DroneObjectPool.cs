using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace ObjectPool
{

    public class DroneObjectPool : MonoBehaviour
    {
        public int maxPoolSize = 10;
        public int stackDefaultCapacity = 10;

        public IObjectPool<Drone> Pool
        {
            get
            {
                if (_pool == null)
                {
                    _pool = new ObjectPool<Drone>(CreatedPoolItem, OnTakeFromPool, OnReturnToPool, OnDestroyPoolObject, true, stackDefaultCapacity, maxPoolSize);

                    return _pool;
                }
                else
                {
                    return _pool;
                }
            }
        }

        private IObjectPool<Drone> _pool;

        private Drone CreatedPoolItem()
        {
            // var 변수로 큐브 게임오브젝트를 생성하고 Drone 컴포넌트를 추가한다.
            var go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Drone drone = go.AddComponent<Drone>();

            go.name = "Drone";
            drone.Pool = Pool;

            return drone;
        }

        private void OnReturnToPool(Drone drone)
        {
            drone.gameObject.SetActive(false);
        }

        private void OnTakeFromPool(Drone drone)
        {
            drone.gameObject.SetActive(true);
        }

        private void OnDestroyPoolObject(Drone drone)
        {
            Destroy(drone.gameObject);
        }

        public void Spawn()
        {
            var amount = Random.Range(1, 10);

            for (int i = 0; i < amount; ++i)
            {
                var drone = Pool.Get();
                //반경 10인 구 안에 랜덤한 위치에 생성
                drone.transform.position = Random.insideUnitSphere * 10;
            }
        }
    }
}