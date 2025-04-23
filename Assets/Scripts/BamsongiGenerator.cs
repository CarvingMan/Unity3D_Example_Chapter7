using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bamsongi = Instantiate(bamsongiPrefab);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            // 교재에서는 worldDir.nomalized 를 하여 방향벡터를 구하지만
            // 이미 ray.direction은 정규화된 벡터를 return하기에 불필요하다.
            // 아래처럼 직접 상수를 넣는 버릇은 들이지 말자
            bamsongi.GetComponent<BamsongiController>().Shoot(worldDir.normalized * 2000); 
        }
    }
}