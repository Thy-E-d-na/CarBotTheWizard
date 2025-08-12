using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    [SerializeField] private AudioSource _BGM;
    [SerializeField] private AudioSource _SFX;
    [SerializeField] private AudioClip[] bgm;
    [SerializeField] private AudioClip[] sfx;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void PlayBGM(int inde)
    {
        if(inde < bgm.Length)
        {
            _BGM.clip = bgm[inde];
            _BGM.Play();
        }
    }
    public void PlaySfx(int inde)
    {
        if (inde < sfx.Length)
        {
            _SFX.PlayOneShot(sfx[inde]);
        }
    }
}
