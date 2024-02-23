
using Cameras;

Estagiario estagiario = new Estagiario("Igor");
Analista analista = new Analista("O Analista");
Diretor diretor = new Diretor("Neo");
Policial policial = new Policial("Peçanha");

Camera cameraSalaA107 = new Camera("A107");
CameraDeSeguranca cameraDoCIT = new CameraDeSeguranca("CIT");
cameraSalaA107.show(estagiario);
cameraSalaA107.show(analista);
cameraSalaA107.show(diretor);

cameraDoCIT.show(estagiario);
cameraDoCIT.show(analista);
cameraDoCIT.show(diretor);
cameraDoCIT.show(policial);



