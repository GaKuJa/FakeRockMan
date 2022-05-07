using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSpawnScript : MonoBehaviour
{
    //������
    [SerializeField]
    private GameObject stone;
    //�L�����o�X
    [SerializeField]
    private GameObject canvas;
    //�X�|�[���܂ł̎���
    [SerializeField]
    private float spawnWaitTime;
    // ��̃I�u�W�F�N�g
    private GameObject emptyObj;
    // �X�|�[���|�W�V����
    Vector3 SpawnPosition = new Vector3(1960f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StoneSpawn");
    }

    #region �������X�|�[��
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
