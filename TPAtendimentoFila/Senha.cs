using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAtendimentoFila
{
    class Senha
    {
        #region ATRIBUTOS
        private Int32 id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;
        #endregion

        #region PROPRIEDADES
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime DataGerac
        {
            get { return dataGerac; }
            set { dataGerac = value; }
        }

        public DateTime HoraGerac
        {
            get { return horaGerac; }
            set { horaGerac = value; }
        }

        public DateTime DataAtend
        {
            get { return dataAtend; }
            set { dataAtend = value; }
        }
        public DateTime HoraAtend
        {
            get { return horaAtend; }
            set { horaAtend = value; }
        }
        #endregion
        
        #region CONSTRUTORES
        //1 ARGUMENTO
        public Senha(Int32 id)
        {
            this.id = id;
            this.dataGerac = System.DateTime.Now;
            this.horaGerac = System.DateTime.Now;
            
        }
        //0 argumentos
        public Senha()
        {
            this.id = 0;
            this.dataGerac = DateTime.MinValue;
            this.horaGerac = DateTime.MinValue;
                    }
        #endregion

        #region SOBREESCRITAS
        public override bool Equals(object obj)
        {
            Senha p = (Senha)obj;
            return this.id.Equals(p.id);
        }
        #endregion

        #region METODOSFUNCIONAIS
        public String dadosParciais()
        {
            return "id: " + this.id + " - data geração: " + this.dataGerac.ToShortDateString() + " - hora geração: " + this.horaGerac.ToLongTimeString();
        }
        public String dadosCompletos()
        {
            return  this.dadosParciais() +
                " - hora geração: " + this.dataAtend.ToShortDateString() + " - hora atendimento: " + this.horaAtend.ToShortTimeString();
        }
        #endregion
    }//class
}//namespace
