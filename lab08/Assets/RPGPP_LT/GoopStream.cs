using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoopStream : MonoBehaviour, IInteractable
{
   [SerializeField] private string _prompt; 
   int j= 0;
   [SerializeField] private ParticleSystem particles;
   public string InteractionPrompt => _prompt;

   public bool Interact(ButtonBehaviour interactor){
		  if(j % 2 == 0 ){
				particles.Stop(true);
				Debug.Log(message:"stopped the stream");
				j+=1;
		  }
		  else
		  {
				particles.Play(true);
				Debug.Log(message:"on the Stream");
				j+=1;
		  }
		  return true;
   }
}
