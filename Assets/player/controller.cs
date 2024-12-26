using System.Collections;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 5f; // ���ʳt��
    private bool isMoving = false; // �����O�_���b����
    private Vector2 input; // ���a��J
    private Animator animator;
    public LayerMask solidobjectLayer;
    public LayerMask grassLayer;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (!isMoving)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");
            if (input.x != 0) input.y = 0;
            if (input != Vector2.zero)
            {
                animator.SetFloat("moveX", input.x);
                animator.SetFloat("moveY", input.y);
                Vector3 targetPos = transform.position + new Vector3(input.x, input.y, 0f);
                if(walkable(targetPos))
                    StartCoroutine(Move(targetPos));
            }
        }
        animator.SetBool("isMoving", isMoving);
    }

    IEnumerator Move(Vector3 targetPos)
    {
        isMoving = true; // �]�w�����b����
        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null; // ���ݤU�@�V
        }
        transform.position = targetPos; // �T�O��m�������T
        isMoving = false; // ���ʵ���
        checkencounter();
    }

    private bool walkable(Vector3 targetPos)
    {
        if (Physics2D.OverlapCircle(targetPos,0.3f,solidobjectLayer) != null)
        {
            return false;
        }
        return true;
    }

    private void checkencounter()
    {
        if (Physics2D.OverlapCircle(transform.position, 0.2f, grassLayer) != null)
        {
            if(Random.Range(1, 101) < 10)
            {
                Debug.Log("Encountered monster");
            }
        }
    }

}
