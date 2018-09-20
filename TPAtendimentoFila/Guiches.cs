using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAtendimentoFila
{
    class Guiches
    {
        #region ATRIBUTOS
        private List<Guiche> listaGuiches;
        #endregion

        #region PROPRIEDADES
        public List<Guiche> ListaGuiches
        {
            get { return listaGuiches; }
        }
        #endregion

        #region CONSTRUTORES
        public Guiches()
        {
            this.listaGuiches = new List<Guiche>();
        }
        #endregion

        #region METODOSFUNCIONAIS
        public void adicionar(Guiche guiche)
        {
            listaGuiches.Add(guiche);
        }
        #endregion
    }//class
}//namespace
