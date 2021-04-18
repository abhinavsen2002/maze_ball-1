using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinCondition : MonoBehaviour
{
    public int rightExtreme;
    public int downExtreme;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((gameObject.transform.position.x > rightExtreme) && (gameObject.transform.position.z > downExtreme))
            SceneManager.LoadScene(5);
    }
}