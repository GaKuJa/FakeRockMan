using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSpawnScript : MonoBehaviour
{
    //投擲物
    [SerializeField]
    private GameObject stone;
    //キャンバス
    [SerializeField]
    private GameObject canvas;
    //スポーンまでの時間
    [SerializeField]
    private float spawnWaitTime;
    // 空のオブジェクト
    private GameObject emptyObj;
    // スポーンポジション
    Vector3 SpawnPosition = new Vector3(1960f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StoneSpawn");
    }

    #region 投擲物スポーン
    IEnumerator StoneSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnWaitTime);

            emptyObj = (GameObject)Instantiate(stone, canvas.transform.position, Quaternion.identity);
            emptyObj.transform.SetParent(canvas.transform, false);
        }
    }
    #endregion
}
