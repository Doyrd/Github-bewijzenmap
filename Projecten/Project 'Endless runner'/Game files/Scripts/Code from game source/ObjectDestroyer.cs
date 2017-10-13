using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public GameObject TheDestructionPoint;

	void Start ()
    {
        TheDestructionPoint = GameObject.Find("Object destruction point");
	}

    void Update ()
    {
		if(transform.position.x < TheDestructionPoint.transform.position.x)
        {
            Destroy(gameObject);
        }
	}
}