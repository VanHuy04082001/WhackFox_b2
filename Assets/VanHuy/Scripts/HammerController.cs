using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;
namespace VanHuy
{
    public class HammerController : MonoBehaviour
    {
        [SpineAnimation]
        public string smash;
        SkeletonAnimation skeletonAnimation;
        public Spine.AnimationState spineAnimationState;
        public Spine.Skeleton skeleton;
        // Start is called before the first frame update
        void Start()
        {
            int a = (PlayerPrefs.GetInt("IdUsingHammer") + 1);
            skeletonAnimation = GetComponent<SkeletonAnimation>();
            spineAnimationState = skeletonAnimation.AnimationState;
            skeleton = skeletonAnimation.Skeleton;
            skeleton.SetSkin("hammer" +a);
            DestroyHammer();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        void DestroyHammer()
        {
            Destroy(gameObject, 0.3f);
        }
    }
}
