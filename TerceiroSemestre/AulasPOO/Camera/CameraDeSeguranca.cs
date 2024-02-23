using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cameras
{
    public class CameraDeSeguranca : Camera
    {
        public CameraDeSeguranca(string nome) : base(nome) { }
        public override void show(Funcionario funcionario)
        {
            Console.WriteLine("Você não tem acesso a essa camera!");
        }

        public void show(IAcesso acesso)
        {
            Console.WriteLine($"Você acessou a camera: {acesso.Nome()}");
        }

    }
}
