using UnityEngine;

public class linerender : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Guide;
    public GameObject PickUp;
    private LineRenderer lineRenderer;

    void Start()
    {
        Guide = transform.Find("Guild").gameObject;
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0, Guide.transform.position);
        lineRenderer.SetPosition(1, PickUp.transform.position);
    }
}
