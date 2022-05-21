using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSpawnScript : MonoBehaviour
{
    //石
    [SerializeField]
    private GameObject stone;
    //金玉
    [SerializeField]
    private GameObject gold;
    //キャンバス
    [SerializeField]
    private GameObject canvas;
    //石敵
    [SerializeField]
    private GameObject stoneEnemy;
    //金敵
    [SerializeField]
    private GameObject goldEnemy;
    //スポーンまでの時間
    [SerializeField]
    private float spawnWaitTime;
    // 空のオブジェクト1
    private GameObject emptyObj1;
    // 空のオブジェクト2
    private GameObject emptyObj2;
    // スポーンポジション
    Vector3 SpawnPosition = new Vector3(1960f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StoneSpawn");
        StartCoroutine("GoldSpawn");
    }

    #region 石
    IEnumerator StoneSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnWaitTime);

            emptyObj1 = (GameObject)Instantiate(stone, stoneEnemy.transform.position, Quaternion.identity);
            emptyObj1.transform.SetParent(canvas.transform, false);
        }
    }
    #endregion
    #region 金
    IEnumerator GoldSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnWaitTime);

            emptyObj2 = (GameObject)Instantiate(gold, goldEnemy.transform.position, Quaternion.identity);
            emptyObj2.transform.SetParent(canvas.transform, false);
        }
    }
    #endregion
}
