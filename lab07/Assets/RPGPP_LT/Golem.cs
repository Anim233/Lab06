using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : MonoBehaviour, IInteractable
{
   [SerializeField] private string _prompt; 

   [SerializeField] private Animator animate;
   
   public string InteractionPrompt => _prompt;
   
   
      

   public bool Interact(ButtonBehaviour interactor){
		  animate.SetBool("Rage",true);
		  Debug.Log(message:"raging a golem");
		  return true;
   }
}
