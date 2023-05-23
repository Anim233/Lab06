using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonGas : MonoBehaviour, IInteractable
{
   [SerializeField] private string _prompt; 
   [SerializeField] private ParticleSystem particles;
   public string InteractionPrompt => _prompt;
   int i = 0;

   public bool Interact(ButtonBehaviour interactor){
		  if(i % 2 == 0 ){
				particles.Stop(true);
				Debug.Log(message:"fauled the gas");
				i+=1;
		  }
		  else
		  {
				particles.Play(true);
				Debug.Log(message:"fired the gas");
				i+=1;
		  }
		  return true;
   }
}
