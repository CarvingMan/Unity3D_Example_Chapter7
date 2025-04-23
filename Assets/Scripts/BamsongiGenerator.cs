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
            // ���翡���� worldDir.nomalized �� �Ͽ� ���⺤�͸� ��������
            // �̹� ray.direction�� ����ȭ�� ���͸� return�ϱ⿡ ���ʿ��ϴ�.
            // �Ʒ�ó�� ���� ����� �ִ� ������ ������ ����
            bamsongi.GetComponent<BamsongiController>().Shoot(worldDir.normalized * 2000); 
        }
    }
}