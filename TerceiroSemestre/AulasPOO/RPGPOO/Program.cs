// See https://aka.ms/new-console-template for more information
using RPGPOO;
using System.Runtime.InteropServices;

Guerreiro joel = new Guerreiro("Joel");
Dragao calipso = new Dragao("Calipso");
Goblin goblin = new Goblin("Goblin");
Aranha aranha = new Aranha("Aranha");
Arqueiro arqueiro = new Arqueiro(1, "Arqueiro");
Mago mago = new Mago(30, "Mago");

mago.Atacar(calipso);
mago.Atacar(calipso);
mago.Atacar(calipso);
mago.Atacar(calipso);
arqueiro.Atacar(calipso);
arqueiro.Atacar(calipso);
joel.Atacar(calipso);
calipso.Atacar(joel);
goblin.Atacar(joel);
aranha.Atacar(joel);

