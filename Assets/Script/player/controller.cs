using System.Collections;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 5f; // 移動速度
    private bool isMoving = false; // 紀錄是否正在移動
    private Vector2 input; // 玩家輸入
    private Animator animator;
    public LayerMask solidobjectLayer;
    public LayerMask grassLayer;
    public LayerMask interactableLayer;
    public LayerMask portalLayer;

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
        if (Input.GetKeyDown(KeyCode.E))
            interact();

    }

    void interact()
    {
        var facingdir = new Vector3(animator.GetFloat("moveX"), animator.GetFloat("moveY"));
        var interactPos = transform.position + facingdir;
        var collider = Physics2D.OverlapCircle(interactPos, 0.3f, interactableLayer);
        if(collider != null)
        {
            collider.GetComponent<interactable>()?.Interact();
        }
    }

    IEnumerator Move(Vector3 targetPos)
    {
        isMoving = true; // 設定為正在移動
        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null; // 等待下一幀
        }
        transform.position = targetPos; // 確保位置完全正確
        isMoving = false; // 移動結束
        checkencounter();
    }

    private bool walkable(Vector3 targetPos)
    {
        if (Physics2D.OverlapCircle(targetPos,0.3f,solidobjectLayer | interactableLayer) != null)
        {
            return false;
        }
        return true;
    }

    private void checkencounter()
    {
        // 檢測草地層級，觸發隨機遇怪
        if (Physics2D.OverlapCircle(transform.position, 0.5f, grassLayer) != null)
        {
            if (Random.Range(1, 101) < 10)
            {
                Debug.Log("Encountered monster");
            }
        }
        if (Physics2D.OverlapCircle(transform.position, 0.5f, portalLayer) != null)
        {
            Debug.Log("Encountered portal");
        }
    }

}
