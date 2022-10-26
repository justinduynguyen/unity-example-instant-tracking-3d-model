using UnityEngine;
using UnityEngine.UI;

public class StoryController : MonoBehaviour
{
    [SerializeField]
    private Settings _settings;
    private Animator _animator;
    // Start is called before the first frame update
    private void Start()
    {
        _animator = GetComponent<Animator>(); 
        _settings.Pose_1.onClick.AddListener(() =>
        {
            _animator.SetTrigger("Pose_1");
        });
        _settings.Pose_2.onClick.AddListener(() =>
        {
            _animator.SetTrigger("Pose_2");
        });
        _settings.Pose_3.onClick.AddListener(() =>
        {
            _animator.SetTrigger("Pose_3");
        });
        _settings.Pose_4.onClick.AddListener(() =>
        {
            _animator.SetTrigger("Pose_4");
        });
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            if (!_settings.ControlPosePanel.activeInHierarchy)
                _settings.ControlPosePanel.SetActive(true);
        }
    }


    [System.Serializable]
    public class Settings
    {
        public GameObject ControlPosePanel;
        public Button Pose_1, Pose_2, Pose_3, Pose_4;
        public GameObject Unicorn;
    }
}