using UnityEngine;

public class VectorDirection : MonoBehaviour
{
    public Camera cam = null;
    public GameObject prefabHit = null;
    public GameObject prefabCenter = null;
    public GameObject prefabNeighbor = null;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) == true)
            {
                //where we hit with mouse click
                GameObject phit = Instantiate(prefabHit, hit.point, hit.transform.rotation, this.transform);

                //center of the cube we hit
                Vector3 pos = hit.point + (hit.normal * -0.1f);
                pos = quantizePoint(pos);
                GameObject pcenter = Instantiate(prefabCenter, pos, hit.transform.rotation, this.transform);

                //neighbor side of a cube hit
                Vector3 pos2 = hit.point + (hit.normal * 0.1f);
                pos2 = quantizePoint(pos2);
                GameObject pneighbor = Instantiate(prefabNeighbor, pos2, hit.transform.rotation, this.transform);
            }
        }
    }

    private Vector3 quantizePoint(Vector3 pos)
    {
        // IMPORTANT - cube is in whole number position (ie: yes= (1,3,2) no= (1.1,22.3,2.44) )
        Vector3 p;
        p.x = (float)System.Math.Round(pos.x, System.MidpointRounding.AwayFromZero);
        p.y = (float)System.Math.Round(pos.y, System.MidpointRounding.AwayFromZero);
        p.z = (float)System.Math.Round(pos.z, System.MidpointRounding.AwayFromZero);
        return p;
    }
}
