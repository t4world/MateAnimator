using UnityEngine;
using System.Collections;

[AddComponentMenu("")]
public class AMAudioKey : AMKey {

    public AudioClip audioClip;
    public bool loop;

    public bool setAudioClip(AudioClip audioClip) {
        if(this.audioClip != audioClip) {
            this.audioClip = audioClip;
            return true;
        }
        return false;
    }

    public bool setLoop(bool loop) {
        if(this.loop != loop) {
            this.loop = loop;
            return true;
        }
        return false;
    }

    // copy properties from key
    public override AMKey CreateClone() {

        AMAudioKey a = gameObject.AddComponent<AMAudioKey>();
        a.enabled = false;
        a.frame = frame;
        a.audioClip = audioClip;
        a.loop = loop;

        return a;
    }
}
