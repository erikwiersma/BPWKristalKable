using UnityEngine;

public class KabelLinerender : MonoBehaviour
{
    public GameObject ItSelf;
    public GameObject DeLink;

    private LineRenderer lineRenderer;
    float Scrollx = 0.1f;
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(1, ItSelf.transform.position);
        lineRenderer.SetPosition(0, DeLink.transform.position);
        if (ItSelf.GetComponent<kabel>().State == 3)
        {
            lineRenderer.SetPosition(1, ItSelf.transform.position);
            lineRenderer.SetPosition(0, DeLink.transform.position);

            float offsetX = Time.time * Scrollx;
            GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offsetX, 0);
        }
        if (ItSelf.GetComponent<kabel>().State == 2)
        {
            lineRenderer.SetPosition(0, ItSelf.transform.position);
            lineRenderer.SetPosition(1, DeLink.transform.position);

            float offsetX = Time.time * Scrollx;
            GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offsetX, 0);
        }

    }
}
