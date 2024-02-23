using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cameras
{
    public class Camera
    {
        public string nome { get; set; }

        public Camera(string nome)
        {
            this.nome = nome;
        }

        public virtual void show(Funcionario funcionario)
        {
            Console.WriteLine($"Estou ligada ({funcionario.nome})");
        }


    }
}
