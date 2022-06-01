using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject box;
    public Camera camera;
    public GameObject car;

    private float time = 0;

    void Update()
    {
        time += Time.deltaTime;
        if(Input.GetMouseButton(0))
        {
            RaycastHit hit;

            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit) && time > 1)
            {
                if(hit.transform.name == "Floor")
                {
                    Ray[] checks = new Ray[8];
                    RaycastHit temphit;
                    float[] dists = new float[8];

                    checks[0] = new Ray(hit.point, new Vector3(0, 0, 1));
                    checks[1] = new Ray(hit.point, new Vector3(1, 0, 1));
                    checks[2] = new Ray(hit.point, new Vector3(1, 0, 0));
                    checks[3] = new Ray(hit.point, new Vector3(1, 0, -1));
                    checks[4] = new Ray(hit.point, new Vector3(0, 0, -1));
                    checks[5] = new Ray(hit.point, new Vector3(-1, 0, -1));
                    checks[6] = new Ray(hit.point, new Vector3(-1, 0, 0));
                    checks[7] = new Ray(hit.point, new Vector3(-1, 0, 1));

                    for(int i=0; i<8; ++i)
                    {
                        Physics.Raycast(checks[i], out temphit);
                        if(temphit.distance != float.NaN)
                            dists[i] = temphit.distance;
                        else
                            dists[i] = 8;

                        Debug.Log("Куб-датчик " + i  + " = " + dists[i]);
                    }

                    float minDist = 3.5f;
                    for (int i = 0; i < 8; ++i)
                    {
                        if(dists[i] < minDist && dists[(i+3)%8] < minDist || dists[i] < minDist && dists[(i + 4) % 8] < minDist || dists[i] < minDist && dists[(i + 5) % 8] < minDist)
                        {
                            return;
                        }
                    }

                    if (Vector3.Distance(hit.point, car.transform.position) < 3)
                    {
                        Debug.Log("Dunger dist!");
                        return;
                    }

                    Instantiate(box, hit.point, Quaternion.identity);
                    time = 0;
                }
            }
        }
    }
}
