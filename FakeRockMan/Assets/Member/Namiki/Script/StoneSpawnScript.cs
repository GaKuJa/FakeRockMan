using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSpawnScript : MonoBehaviour
{
    //��
    [SerializeField]
    private GameObject stone;
    //����
    [SerializeField]
    private GameObject gold;
    //�L�����o�X
    [SerializeField]
    private GameObject canvas;
    //�ΓG
    [SerializeField]
    private GameObject stoneEnemy;
    //���G
    [SerializeField]
    private GameObject goldEnemy;
    //�X�|�[���܂ł̎���
    [SerializeField]
    private float spawnWaitTime;
    // ��̃I�u�W�F�N�g1
    private GameObject emptyObj1;
    // ��̃I�u�W�F�N�g2
    private GameObject emptyObj2;
    // �X�|�[���|�W�V����
    Vector3 SpawnPosition = new Vector3(1960f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StoneSpawn");
        StartCoroutine("GoldSpawn");
    }

    #region ��
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
    #region ��
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
