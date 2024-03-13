using UnityEngine;
using UnityEngine.UI;

// クリックしたらボールを生成する
public class CreateBallButton : MonoBehaviour
{
  [SerializeField] private GameObject ballPrefab;
  private Button button;

  private void Start()
  {
    button = GetComponent<Button>();
    button.onClick.AddListener(OnClick);
  }

  private void OnClick()
  {
    GameObject ball = Instantiate(ballPrefab);
    // 位置を少しずらす
    ball.transform.position += new Vector3(Random.Range(-0.1f, 0.1f), 0f, Random.Range(-0.1f, 0.1f));
  }
}
