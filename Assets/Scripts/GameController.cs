using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject cube;
    public GameObject cubeOut;
    public int numbers = 0;
    void Start()
    {
        for(int i = 0; i < numbers; i++)
        {
            //オブジェクトの座標
            float x = Random.Range(-9.0f, 9.0f);
            float z = Random.Range(-9.0f, 9.0f);
            while (x < 1.0f && x > -1.0f)
            {
                x = Random.Range(-9.0f, 9.0f);
            }
		    while (z < 1.0f && z > -1.0f)
            {
                z = Random.Range(-9.0f, 9.0f);
            }
		    float y = 0.5f;

            //オブジェクトを生産
		    Instantiate(cube, new Vector3(x, y, z), Quaternion.identity); 
        }
        for(int i = 0; i < 2; i++)
        {
            //オブジェクトの座標
            float x = Random.Range(-9.0f, 9.0f);
            float z = Random.Range(-9.0f, 9.0f);
            while (x < 1.0f && x > -1.0f)
            {
                x = Random.Range(-9.0f, 9.0f);
            }
		    while (z < 1.0f && z > -1.0f)
            {
                z = Random.Range(-9.0f, 9.0f);
            }
		    float y = 0.5f;

            //オブジェクトを生産
		    Instantiate(cubeOut, new Vector3(x, y, z), Quaternion.identity); 
        }
    }
}
