using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject burgerObject;
    private float m_currentTime = 0;
    public float m_spawnDelay = 1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        m_currentTime += Time.deltaTime;
        if (m_currentTime > m_spawnDelay)
        {
            m_currentTime = 0;
            Instantiate(burgerObject, new Vector3(0.0f, 6.0f,0.0f), Quaternion.identity);
        }


	}
}
