﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde1
{
   public class Produto
    {
        private int Id;
        private string Descricao;
        private decimal valor;
            
        public Produto(int id, string descricao, decimal valor)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;


        }
        public int getId()
        { return Id; }
        public string getDescricao()
        { return Descricao; }
        public decimal getValor() 
        {  return valor; }
    }
}
