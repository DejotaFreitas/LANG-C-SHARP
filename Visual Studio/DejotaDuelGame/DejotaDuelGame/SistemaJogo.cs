using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DejotaGame
{
    class SistemaJogo
    {
        public SistemaJogo()
        {
            nomeJogador = "Noob";
            pontosVida = 90;
            ph = 14;
            ataque = 1;
            defesa = 1;
            vida = 1;
            velocidade = 1;
            critico = 1;
            esquiva = 1;
            precisao = 1;
    }

        public string nomeJogador;
        public int pontosVida;
        public int ph;
        public int ataque;
        public int defesa;
        public int vida;
        public int velocidade;
        public int critico;
        public int esquiva;
        public int precisao;

        public static Random r = new Random();
        public static int acertar (int pontosPrecisao)        
        {
            return (r.Next(0, 7) + pontosPrecisao);
        }

        public static int esquivar(int pontosEsquiva)
        {
            return (r.Next(0, 4) + pontosEsquiva);
        }    
            
        public static int criticar(int pontosCritico)
        {
            return r.Next(0, 3) + pontosCritico;
        }

        public static int defender(int PontosDefesa)
        {
            return (r.Next(0, 5) + PontosDefesa);
        }

        public static int dano(int pontosAtaque)
        {
            return (r.Next(5, 10) + pontosAtaque * (r.Next(1, 4)));
        }

        public static int AddVida(SistemaJogo jogador)
        {
             return (jogador.pontosVida+=(r.Next(3, 10)) + (jogador.vida));
        }

        public static int removerVida(SistemaJogo jogador)
        {
            return (jogador.pontosVida -= (r.Next(3, 10)) + (jogador.vida));
        }

        public static int velocidadeAtaque(int pontosVelocida)
        {
            return (2360 - (pontosVelocida * 110));
        }

        public static void resetar(SistemaJogo jogadorResetante)
        {
            jogadorResetante.nomeJogador = "Noob";
            jogadorResetante.pontosVida = 90;
            jogadorResetante.ph = 14;
            jogadorResetante.ataque = 1;
            jogadorResetante.defesa = 1;
            jogadorResetante.vida = 1;
            jogadorResetante.velocidade = 1;
            jogadorResetante.critico = 1;
            jogadorResetante.esquiva = 1;
            jogadorResetante.precisao = 1;

         }


     
    }
}
