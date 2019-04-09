using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pile : MonoBehaviour
{
    public GameObject tokenType;

    public void fill()
    {
        GameObject newToken = Instantiate(tokenType);
        newToken.transform.parent = transform;
    }
}
