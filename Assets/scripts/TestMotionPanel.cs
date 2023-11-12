using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestMotionPanel : MonoBehaviour
{
    [SerializeField] private GameObject bunny;
    [SerializeField] public RuntimeAnimatorController[] animatorControllers;

    void Start()
    {
        this.gameObject.SetActive(false);
    }

    public void OnButtonClicked(Button button)
    {
        ApplyAnimatorController applyAnimatorController = bunny.GetComponent<ApplyAnimatorController>();

        switch(button.name)
        {            
            case "MotionEarprickupButton":
                applyAnimatorController.UpdateAnimatorController(animatorControllers[0]);
                break;
            case "MotionScratchButton":
                applyAnimatorController.UpdateAnimatorController(animatorControllers[1]);
                break;
            case "MotionSleepButton":
                applyAnimatorController.UpdateAnimatorController(animatorControllers[2]);
                break;
            case "MotionStretchButton":
                applyAnimatorController.UpdateAnimatorController(animatorControllers[3]);
                break;
            case "MotionYawnButton":
                applyAnimatorController.UpdateAnimatorController(animatorControllers[4]);
                break;
            case "MotionEyeSparkleButton":
                applyAnimatorController.UpdateAnimatorController(animatorControllers[5]);
                break;
            case "MotionFlowerButton":
                applyAnimatorController.UpdateAnimatorController(animatorControllers[6]);
                break;
            case "MotionHungryButton":
                applyAnimatorController.UpdateAnimatorController(animatorControllers[7]);
                break;
            case "MotionPeacefulButton":
                applyAnimatorController.UpdateAnimatorController(animatorControllers[8]);
                break;
            case "MotionMoveForwardButton":
                applyAnimatorController.UpdateAnimatorController(animatorControllers[9]);
                break;
            case "MotionMoveSideButton":
                applyAnimatorController.UpdateAnimatorController(animatorControllers[10]);
                break;
            case "MotionMoveUpwardButton":
                applyAnimatorController.UpdateAnimatorController(animatorControllers[11]);
                break;
            case "OpenPanelButton":
                this.gameObject.SetActive(!this.gameObject.active);
                Text buttonText = button.GetComponentInChildren<Text>();
                if (this.gameObject.active)
                {
                    buttonText.text = "닫기";
                }
                else 
                {
                    buttonText.text = "모션 설정";
                }
                break;
            default:
                Debug.Log(button.name);
                break;
        }
    }
}
