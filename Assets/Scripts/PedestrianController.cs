using System.Collections;
using UnityEngine;

public class PedestrianController : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 startLocation, endLocation;

    private Animator animator;
    private bool isRunning = false;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        startLocation = transform.position;
        isRunning = true;
    }

    void Update()
    {
        if (isRunning)
        {
            transform.position = Vector3.MoveTowards(transform.position, endLocation, speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, endLocation) < 0.7f)
            {
                animator.SetBool("StartRunning", false);
                isRunning = false;
                StartCoroutine(WaitAndStartRunning(Random.Range(3f, 6f)));
            }
        }
    }

    IEnumerator WaitAndStartRunning(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        animator.SetBool("StartRunning", true);
        isRunning = true;
        endLocation = startLocation;
        startLocation = transform.position;
        Vector3 newRotation = transform.rotation.eulerAngles;
        if (newRotation.y == 180)
        {
            newRotation = new Vector3(0, 0, 0);
        }
        else
        {
            newRotation = new Vector3(0, 180, 0);
        }
        transform.rotation = Quaternion.Euler(newRotation);
    }

}
