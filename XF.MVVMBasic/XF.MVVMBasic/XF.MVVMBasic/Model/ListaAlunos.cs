using System;
using System.Collections.Generic;
using System.Text;

namespace XF.MVVMBasic.Model
{
    public class ListaAlunos
    {
        public static List<Aluno> Alunos { get; set; }

        public ListaAlunos()
        {
            Alunos = new List<Aluno>();
        }

        public static void AddAluno (Aluno aluno)
        {
            Alunos.Add(aluno);
        }
    }
}
