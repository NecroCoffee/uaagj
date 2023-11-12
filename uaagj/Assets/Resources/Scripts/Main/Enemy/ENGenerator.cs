using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] Enemys = new GameObject[5];
    [SerializeField] private float generateDiff = 3f;

    [SerializeField] private float generateAreaMin = 11f;
    [SerializeField] private float generateAreaMax = 13f;

    [SerializeField] private GameObject[] generatePositionObjects=new GameObject[8];
    [SerializeField] private Vector3 generatePosition;

    private float currentTime;

    private Vector3 GetPlayerPosition()
    {
        Vector3 playerPos = (GameObject.FindWithTag("Player")).transform.position;
        return playerPos;
    }

    private void SetGeneratePosition()
    {
        int generatePointNum = Random.Range(0, 8);
        int generateEnemyNum = Random.Range(0, 3);
        Instantiate(Enemys[generateEnemyNum], generatePositionObjects[generatePointNum].transform.position, Quaternion.identity);
    }

    private void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= generateDiff)
        {
            SetGeneratePosition();
            /*
            for(int i = 0; i < 4; i++)
            {
                SetGeneratePosition();
            }
            */
            currentTime = 0;
        }
    }
}
