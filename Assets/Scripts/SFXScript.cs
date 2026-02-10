using UnityEngine;

public class SFXScript : MonoBehaviour
{
    // tiek veidots logs, kurâ var pievienot skaòas efektus
    public AudioSource SFXSource;

    // tiek veidots masîvs kurâ var pievienot vairâkus skaòas efektus
    public AudioClip[] audioClip;

    // tiek veidota metode, kas atskaòo skaòas efektu, nospieþot pogu
    public void PlaySFX(int ix) {
        // ja skaòa tiek spçlçta
        if(SFXSource.isPlaying) {
            // apstâdinât skaòu
            SFXSource.Stop();
        }
        // atskaòot skaòas efektu no masîva, izvçloties to pçc indeksa
        SFXSource.PlayOneShot(audioClip[ix]);
    }
}
