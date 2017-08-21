﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeInimigos : MonoBehaviour
{

  [SerializeField] private GameObject inimigo = null;
  private float momentoDaUltimaGeracao;

  [Range(0, 3)]
  [SerializeField] private float tempoDeCriacao = 2f;



  // Use this for initialization
  void Start()
  {
		
  }
	
  // Update is called once per frame
  void Update()
  {
		
    GeraInimigo();
  }

  private void GeraInimigo()
  {

    float tempoAtual = Time.time;
    if (tempoAtual > momentoDaUltimaGeracao + tempoDeCriacao)
      {
        momentoDaUltimaGeracao = tempoAtual;
        Vector3 posicaoDoGerador = this.transform.position;
        Instantiate(inimigo, posicaoDoGerador, Quaternion.identity);

      }       
      
  }
}
