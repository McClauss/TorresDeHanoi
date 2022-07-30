using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{

    void Update()
    {
        GameManager.Instance.GetScore();
    }
}
