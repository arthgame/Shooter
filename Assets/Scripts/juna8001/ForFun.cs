using UnityEngine;
using System.Collections;

public class ForFun : MonoBehaviour {

    public GameObject go;

    public int x, y, z;

    public void put()
    {
        for (int i = 0; i < x; i++)
            for (int j = 0; j < y; j++)
                for (int k = 0; k < z; k++)
                    Instantiate(go, new Vector3(i, j, k), Quaternion.identity);
    }
}
