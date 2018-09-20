using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAtendimentoFila
{
    class Guiche
    {
        #region ATRIBUTOS
        //ATRIBUTOS
        private Int32 id;
        private Queue<Senha> atendimentos;
        #endregion

        #region PROPRIEDADES
        //PROPRIEDADES
        public Queue<Senha> Atendimentos
        {
            get { return atendimentos; }
        }
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        #region CONSTRUTORES
        //CONSTRUTORES
        public Guiche(Int32 id)
        {
            this.id = id;
            this.atendimentos = new Queue<Senha>();
        }
        public Guiche()
        {
            this.id = 0;
            this.atendimentos = new Queue<Senha>();
        }
        #endregion

        #region METODOSFUNCIONAIS
        public Boolean chamar(Queue<Senha> FilaSenhas)
        {
            Boolean chamou = false;
            Senhas senhas = new Senhas();
            Senha senha = new Senha();

            atendimentos.Enqueue(new Senha(senhas.ProximoAtendimento, System.DateTime.Now));


            chamou = true;

            return chamou;
        }
        #endregion
    }//CLASS
}//NAMESPACE
