

using ControleDeElevador;

Pessoa jadson = new Pessoa("Jadson", 80.00f, 2, 8);
Pessoa waldyr = new Pessoa("Waldyr", 90.20f, 8, 0);

Elevador elevadorServico = new Elevador();

jadson.Chamar(elevadorServico);
jadson.Entrar(elevadorServico);
jadson.EscolheAndar(elevadorServico);
waldyr.Entrar(elevadorServico);
waldyr.EscolheAndar(elevadorServico);
jadson.Sair(elevadorServico);
waldyr.EscolheAndar(elevadorServico);
waldyr.Sair(elevadorServico);

