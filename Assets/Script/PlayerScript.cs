using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public Transform[] posicoes;
	public float velocidade;

	float direcao_x;
	float posicaoInicial_x;
	float posicaoFinal_x;
	int posicaoAtual = 1;
	
	// Update is called once per frame
	void Update () {

		//Cliquwe do mouse CTROL esquerdo ou touch na tela 
		if (Input.GetButtonDown ("Fire1")) {

			//Posicao do primeiro toque na tela/mouse
			posicaoInicial_x = Input.mousePosition.x;

		} else if (Input.GetButtonUp ("Fire1")) {
			//Posicao atual do toque na tela/mouse
			posicaoFinal_x = Input.mousePosition.x;


			//Define a direção
			direcao_x = posicaoFinal_x - posicaoInicial_x;

			if (direcao_x > 0 && posicaoAtual < 2) {
				posicaoAtual++;
			} else if (direcao_x < 0 && posicaoAtual > 0){
				posicaoAtual--;
			}
		}
		transform.position = Vector3.Lerp (transform.position, posicoes[posicaoAtual].position, velocidade * Time.deltaTime);
	}
}
