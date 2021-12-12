using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public int enemyNum;
    public GameObject boss;
    public int bossNum;
    public GameObject youWon;
    private int bossTag;
    void Update()
    {
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("Enemy")) 
        {
            enemyNum++;
        }
        if (enemyNum == 0)
        {
            Instantiate(boss, boss.transform.position, transform.rotation);
            bossNum++;
            enemyNum++;
        }
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("Boss")) 
        {
            bossTag++;
        }
        if (bossNum == 0)
        {
            enemyNum = 0;
        }
        if (bossNum == 1)
        {
            if (bossTag == 0)
            {
                youWon.SetActive(true);
                Debug.Log("won");
            }
        }
        bossTag = 0;
    }
    
}
 