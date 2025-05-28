using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Projeto05
{
    class compromissos
    {
        private int id;
        private DateTime prazo;
        private TimeSpan horario;
        private string tarefa;

        public DateTime Prazo
        {
            get { return prazo; }
            set { prazo = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public TimeSpan Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        public string Tarefa
        {
            get { return tarefa; }
            set { tarefa = value; }
        }
    }
}
